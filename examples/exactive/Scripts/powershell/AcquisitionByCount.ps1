<#
 # Copyright(c) 2011 - 2018 Thermo Fisher Scientific - LSMS
 # 
 # Permission is hereby granted, free of charge, to any person obtaining a copy
 # of this software and associated documentation files (the "Software"), to deal
 # in the Software without restriction, including without limitation the rights
 # to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 # copies of the Software, and to permit persons to whom the Software is
 # furnished to do so, subject to the following conditions:
 # 
 # The above copyright notice and this permission notice shall be included in all
 # copies or substantial portions of the Software.
 # 
 # THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 # IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 # FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 # AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 # LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 # OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 # SOFTWARE.
 #>

<#
Sample script to demonstrate how to run an acquisition limited by count and get all MsScan data.

When subscribing to the event handler MsScanArrived of MsScanContainer with Register-ObjectEvent,
you should keep in mind, that the registered action is called in another thread. If another MsScan
is arrived before the event is handled the MsScan object is disposed / overwritten with the next
MsScan data. To prevent the MsScan data from getting disposed you must get a reference to the 
MsScan data by calling GetScan on the MsScanEventArgs. Note the reference must be released by 
calling the Dispose methode. You should as fast as possible otherwise the system performance decrease.

This example shows how to get a reference of the MsScan data put the MsScan data in a queue and
process the MsScan data in the powershell event handler.

The .Net class MsScanBridgeTo is used to get the reference of MsScan data by subscribing to the event
MsScanArrived of IMsScanContainer. In the eventhandler the MsScan reference count is incremented by
GetScan of MsScanEventArgs. The MsScan data are put into a queue and the event MsScanQueued is raised.
The powershell action MsScanQueued is registered to the MsScanqueued event of the class MsScanBridge. 
#>

# is this type already defined?    
if (-not ("MsScanBridge" -as [type])) 
{
    $assemblies = [System.Reflection.Assembly]::LoadWithPartialName("API-1.0")
    Add-Type  -TypeDefinition @"
        using System;
        using Thermo.Interfaces.InstrumentAccess_V1.MsScanContainer;

        /// <summary>
        /// Helper class to get a reference of MsScan data synchronously to the event MsScanArrived of IMsScanContainer.
        /// The MsScan data are put in a queue. The get notified about MsScan data are put into the queue subscribe
        /// to the event MsScanQueued.
        /// </summary>
        public class MsScanBridge
        {
            /// <summary>
            /// Singleton for this class
            /// </summary>
            private static MsScanBridge m_msScanBridge = null;

            /// <summary>
            /// Add to get notified when a <see cref="IMsScan"/> is put into the queue.
            /// </summary>
            public event System.EventHandler MsScanQueued;

            /// <summary>
            /// Queue to store received MsScans.
            /// </summary>
            private System.Collections.Queue m_msScanQueue = new System.Collections.Queue();

            /// <summary>
            /// Creates a new <see cref="MsScanBridge"/>
            /// </summary>
            private MsScanBridge()
            {
            }

            /// <summary>
            /// Eventhandler for arrived MsScan of the instrument
            /// </summary>
            /// <param name="sender"><see cref="IMsScanContainer"/> which generated the event</param>
            /// <param name="e">Scan arguments</param>
            public void MsScanArrived(object sender, MsScanEventArgs e)
            {
                // only if a eventhandler is attached store the event in the queue
                if (MsScanQueued != null)
                {
                    lock (m_msScanQueue)
                    {
                        m_msScanQueue.Enqueue(e.GetScan());
                        // if the number of elements in the queue increase the processing function
                        // is to slow
                        System.Diagnostics.Debug.WriteLine(String.Format("MsScanBridge queue count {0}", m_msScanQueue.Count));
                    }
                    MsScanQueued(sender, EventArgs.Empty);
                }
            }

            /// <summary>
            /// Gets the one and only instance of <see cref="MsScanBridge"/>
            /// </summary>
            public static MsScanBridge Get()
            {
                if (m_msScanBridge == null)
                {
                    m_msScanBridge = new MsScanBridge();
                }
                return m_msScanBridge;
            }

            /// <summary>
            /// Registers the eventhandler <see cref="MsScanArrived"/> to the MsScanArrived event of the given
            /// instance of <see cref="IMsScanContainer"/>
            /// </summary>
            /// <param name="sc">The <see cref="IMsScanContainer"/> where the eventhandler <see cref="MsScanArrived"/> is added.</param>
            public void Register(IMsScanContainer sc)
            {
                sc.MsScanArrived -= MsScanArrived;
                sc.MsScanArrived += MsScanArrived;
            }

            /// <summary>
            /// Gets the first <see cref="IMsScan"/> of the internal queue
            /// </summary>
            /// <returns>The first <see cref="IMsScan"/>of the queue. You must call Dispose() on this object</returns>
            public IMsScan Dequeue()
            {
                IMsScan scan = null;
                lock (m_msScanQueue)
                {
                    scan = (IMsScan) m_msScanQueue.Dequeue();
                }
                return scan;
            }
        }
"@ -ReferencedAssemblies $assemblies
}

# event handler is invoked when the connection state of the instrument has changed
$ConnectionChanged =
{
    #prints the connection state
    if ($Event.Sender.Connected -eq $True)
    {
        Write-Host $Event.Sender.InstrumentName " connected" -fore green
    }
    else
    {
        Write-Host $Event.Sender.InstrumentName " not connected" -fore red
    }
}

# event handler is invoked when a MS scan has queued
$MsScanQueued =
{
    $global:scanCount = $global:scanCount + 1
    try
    {
        # Gets one scan from the queue
        $scan = $global:bridge.Dequeue();
        # prints the centriod count
        if ($scan.HasCentroidInformation)
        {
            $maxInt = 0;
            $maxIntMz = 0;
            foreach ($centroid in $scan.Centroids)
            {
                if ($maxInt -lt $centroid.Intensity)
                {
                    $maxInt = $centroid.Intensity
                    $maxIntMz = $centroid.Mz
                }
            }
            Write-Host $global:scanCount`t $scan.CentroidCount`t$maxIntMz`t$maxInt
        }
        else
        {
            Write-Host $global:scanCount "No centroid information"
        }
        # releases the MsScan data
        $scan.Dispose()
    }
    catch
    {
        Write-Host "Failed to access scan" $global:scanCount -fore red
    }
}

# removes all events and event subscribers
Function Remove-EventAndSubscriber
{
    Get-EventSubscriber | Unregister-Event
    Get-Event | Remove-Event
}

# because the script might stop with ctrl+c the event subscribers maystill active
# so remove all events and event subscribers
Remove-EventAndSubscriber

# instantiate instrument API for the first instrument
$ia = New-Object -ComObject "Thermo Exactive.API_Clr2_32_V1"
# get the first instrument
$ie = $ia.Get(1)
# get the MsScanContainer
$sc = $ie.GetMsScanContainer(0)
# print the instrument name and id
$ie.InstrumentName + $ie.InstrumentId

$AcquisitionContinuation = [Thermo.Interfaces.ExactiveAccess_V1.Control.Acquisition.Workflow.AcquisitionContinuation]
$AcquisitionSystemNode = [Thermo.Interfaces.InstrumentAccess_V1.Control.Acquisition.SystemMode]

# get notified when the instrument connection has been changed
$null = Register-ObjectEvent $ie ConnectionChanged -SourceIdentifier Instrument.ConnectionChanged -Action $ConnectionChanged

# create a 200 scan acquisition with setting the instrument to standby afterwards
$acq = $ie.Control.Acquisition.CreateAcquisitionLimitedByCount(200)
$acq.Continuation = $AcquisitionContinuation::Standby

# get notified when the instrument state has been changed
$null = Register-ObjectEvent $ie.Control.Acquisition StateChanged -SourceIdentifier Instrument.StateChanged

#check if instrument is on
if ($acq.SystemMode -ne $AcquisitionSystemNode::On)
{
    # switch the instrument on and wait until state has been changed
    $ie.Control.Acquisition.SetMode($ie.Control.Acquisition.CreateOnMode())
    Wait-Event -SourceIdentifier Instrument.StateChanged
}
# subscribe the MsScanBridge to the MsScanArrived event
$global:bridge = [MsScanBridge]::Get()
$global:bridge.Register($sc)

# get notified when a MsScan is queued in MsScanBridge ($global:bridge)
$null = Register-ObjectEvent $global:bridge MsScanQueued -SourceIdentifier Instrument.MsScanQueued -Action $MsScanQueued

#start the acquistion
$global:scanCount = 0
$ie.Control.Acquisition.StartAcquisition($acq)

#just keep the script running, stop with ctrl+c
Wait-Event -SourceIdentifier Dummy