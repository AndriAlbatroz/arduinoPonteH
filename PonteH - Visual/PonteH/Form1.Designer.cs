namespace PonteH
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
            this.components = new System.ComponentModel.Container();
            this.portName = new System.Windows.Forms.ComboBox();
            this.connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baudeRate = new System.Windows.Forms.ComboBox();
            this.logBox = new System.Windows.Forms.GroupBox();
            this.logList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.settingsBox.SuspendLayout();
            this.logBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portName
            // 
            this.portName.FormattingEnabled = true;
            this.portName.Location = new System.Drawing.Point(70, 14);
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(121, 21);
            this.portName.TabIndex = 0;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(116, 67);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 1;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.baudeRate);
            this.settingsBox.Controls.Add(this.connect);
            this.settingsBox.Controls.Add(this.label2);
            this.settingsBox.Controls.Add(this.label1);
            this.settingsBox.Controls.Add(this.portName);
            this.settingsBox.Location = new System.Drawing.Point(12, 12);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(206, 100);
            this.settingsBox.TabIndex = 4;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baude rate:";
            // 
            // baudeRate
            // 
            this.baudeRate.FormattingEnabled = true;
            this.baudeRate.Location = new System.Drawing.Point(70, 40);
            this.baudeRate.Name = "baudeRate";
            this.baudeRate.Size = new System.Drawing.Size(121, 21);
            this.baudeRate.TabIndex = 4;
            // 
            // logBox
            // 
            this.logBox.Controls.Add(this.logList);
            this.logBox.Location = new System.Drawing.Point(224, 12);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(177, 100);
            this.logBox.TabIndex = 5;
            this.logBox.TabStop = false;
            this.logBox.Text = "Log";
            // 
            // logList
            // 
            this.logList.FormattingEnabled = true;
            this.logList.Location = new System.Drawing.Point(6, 19);
            this.logList.Name = "logList";
            this.logList.Size = new System.Drawing.Size(165, 69);
            this.logList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOff);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 223);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(9, 19);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(182, 106);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(197, 19);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(182, 106);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(9, 131);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(370, 86);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.settingsBox);
            this.Name = "Form1";
            this.Text = "Arduno ponte H";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.logBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox portName;
        private System.Windows.Forms.Button connect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.ComboBox baudeRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox logBox;
        private System.Windows.Forms.ListBox logList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnOff;
    }
}

