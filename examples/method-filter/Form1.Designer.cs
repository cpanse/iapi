﻿namespace Thermo.IAPI.Examples
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMethodPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIsConnected = new System.Windows.Forms.Label();
            this.btnISA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInstrument = new System.Windows.Forms.Label();
            this.btnInstrument = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblScanNumber = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.precursorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(23, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Method";
            // 
            // txtMethodPath
            // 
            this.txtMethodPath.Enabled = false;
            this.txtMethodPath.Location = new System.Drawing.Point(132, 169);
            this.txtMethodPath.Name = "txtMethodPath";
            this.txtMethodPath.Size = new System.Drawing.Size(472, 20);
            this.txtMethodPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(610, 168);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(40, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(610, 204);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(40, 23);
            this.btnDatabase.TabIndex = 5;
            this.btnDatabase.Text = "...";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(132, 205);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(472, 20);
            this.txtDB.TabIndex = 4;
            this.txtDB.Text = "C:\\Users\\Thermo\\Desktop\\iapi\\examples\\method-filter\\bin\\Debug\\methoddb.db";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Database";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.precursorDataGridViewTextBoxColumn});
            this.dataGridView1.Location = new System.Drawing.Point(26, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(156, 194);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(524, 231);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 35);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start MS3";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Server ";
            // 
            // lblIsConnected
            // 
            this.lblIsConnected.AutoSize = true;
            this.lblIsConnected.Location = new System.Drawing.Point(66, 6);
            this.lblIsConnected.Name = "lblIsConnected";
            this.lblIsConnected.Size = new System.Drawing.Size(0, 13);
            this.lblIsConnected.TabIndex = 11;
            // 
            // btnISA
            // 
            this.btnISA.Location = new System.Drawing.Point(164, 1);
            this.btnISA.Name = "btnISA";
            this.btnISA.Size = new System.Drawing.Size(106, 23);
            this.btnISA.TabIndex = 12;
            this.btnISA.Text = "Connect to Server";
            this.btnISA.UseVisualStyleBackColor = true;
            this.btnISA.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(575, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnScan
            // 
            this.btnScan.Enabled = false;
            this.btnScan.Location = new System.Drawing.Point(164, 63);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(80, 23);
            this.btnScan.TabIndex = 14;
            this.btnScan.Text = "Start Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Instrument";
            // 
            // lblInstrument
            // 
            this.lblInstrument.AutoSize = true;
            this.lblInstrument.Location = new System.Drawing.Point(76, 39);
            this.lblInstrument.Name = "lblInstrument";
            this.lblInstrument.Size = new System.Drawing.Size(0, 13);
            this.lblInstrument.TabIndex = 16;
            // 
            // btnInstrument
            // 
            this.btnInstrument.Enabled = false;
            this.btnInstrument.Location = new System.Drawing.Point(164, 34);
            this.btnInstrument.Name = "btnInstrument";
            this.btnInstrument.Size = new System.Drawing.Size(122, 23);
            this.btnInstrument.TabIndex = 17;
            this.btnInstrument.Text = "Connect to Instrument";
            this.btnInstrument.UseVisualStyleBackColor = true;
            this.btnInstrument.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Current Scan #";
            // 
            // lblScanNumber
            // 
            this.lblScanNumber.AutoSize = true;
            this.lblScanNumber.Location = new System.Drawing.Point(97, 73);
            this.lblScanNumber.Name = "lblScanNumber";
            this.lblScanNumber.Size = new System.Drawing.Size(13, 13);
            this.lblScanNumber.TabIndex = 19;
            this.lblScanNumber.Text = "0";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(18, 503);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(691, 268);
            this.txtMessage.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Output";
            // 
            // precursorDataGridViewTextBoxColumn
            // 
            this.precursorDataGridViewTextBoxColumn.DataPropertyName = "Precursor";
            dataGridViewCellStyle4.Format = "N2";
            this.precursorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.precursorDataGridViewTextBoxColumn.HeaderText = "Precursor";
            this.precursorDataGridViewTextBoxColumn.Name = "precursorDataGridViewTextBoxColumn";
            this.precursorDataGridViewTextBoxColumn.ToolTipText = "Unique Precursors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(314, 255);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(153, 170);
            this.dataGridView2.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mz";
            dataGridViewCellStyle5.Format = "N2";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Product";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Target Product";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 783);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblScanNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInstrument);
            this.Controls.Add(this.lblInstrument);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnISA);
            this.Controls.Add(this.lblIsConnected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtMethodPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fusion - Method Filter Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMethodPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIsConnected;
        private System.Windows.Forms.Button btnISA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInstrument;
        private System.Windows.Forms.Button btnInstrument;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblScanNumber;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn precursorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
    }
}

