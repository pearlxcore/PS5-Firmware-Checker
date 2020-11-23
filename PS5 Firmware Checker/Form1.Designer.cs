namespace PS5_Firmware_Checker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.tbLinkRec = new DarkUI.Controls.DarkTextBox();
            this.darkLabel13 = new DarkUI.Controls.DarkLabel();
            this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.cbRegionRecovery = new DarkUI.Controls.DarkComboBox();
            this.tbMandatoryRec = new DarkUI.Controls.DarkTextBox();
            this.tbFwSizeRec = new DarkUI.Controls.DarkTextBox();
            this.tbFwVersionRec = new DarkUI.Controls.DarkTextBox();
            this.tbSdkVersionRec = new DarkUI.Controls.DarkTextBox();
            this.tbLabelRec = new DarkUI.Controls.DarkTextBox();
            this.darkLabel8 = new DarkUI.Controls.DarkLabel();
            this.darkLabel9 = new DarkUI.Controls.DarkLabel();
            this.darkLabel10 = new DarkUI.Controls.DarkLabel();
            this.darkLabel11 = new DarkUI.Controls.DarkLabel();
            this.darkLabel12 = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.btnDownloadRecovery = new DarkUI.Controls.DarkButton();
            this.cbRegionSystem = new DarkUI.Controls.DarkComboBox();
            this.tbFwSize = new DarkUI.Controls.DarkTextBox();
            this.tbFwVersion = new DarkUI.Controls.DarkTextBox();
            this.tbSdkVersion = new DarkUI.Controls.DarkTextBox();
            this.tbLabel = new DarkUI.Controls.DarkTextBox();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkDockPanel1 = new DarkUI.Docking.DarkDockPanel();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.btnDownloadSystem = new DarkUI.Controls.DarkButton();
            this.tbSha256 = new DarkUI.Controls.DarkTextBox();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel1.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.tbLinkRec);
            this.darkSectionPanel1.Controls.Add(this.darkLabel13);
            this.darkSectionPanel1.Controls.Add(this.darkGroupBox2);
            this.darkSectionPanel1.Controls.Add(this.tbMandatoryRec);
            this.darkSectionPanel1.Controls.Add(this.tbFwSizeRec);
            this.darkSectionPanel1.Controls.Add(this.tbFwVersionRec);
            this.darkSectionPanel1.Controls.Add(this.tbSdkVersionRec);
            this.darkSectionPanel1.Controls.Add(this.tbLabelRec);
            this.darkSectionPanel1.Controls.Add(this.darkLabel8);
            this.darkSectionPanel1.Controls.Add(this.darkLabel9);
            this.darkSectionPanel1.Controls.Add(this.darkLabel10);
            this.darkSectionPanel1.Controls.Add(this.darkLabel11);
            this.darkSectionPanel1.Controls.Add(this.darkLabel12);
            this.darkSectionPanel1.Location = new System.Drawing.Point(523, 189);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Recovery Firmware Info";
            this.darkSectionPanel1.Size = new System.Drawing.Size(179, 169);
            this.darkSectionPanel1.TabIndex = 0;
            // 
            // tbLinkRec
            // 
            this.tbLinkRec.Location = new System.Drawing.Point(182, 203);
            this.tbLinkRec.Name = "tbLinkRec";
            this.tbLinkRec.Size = new System.Drawing.Size(154, 23);
            this.tbLinkRec.TabIndex = 26;
            // 
            // darkLabel13
            // 
            this.darkLabel13.AutoSize = true;
            this.darkLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel13.Location = new System.Drawing.Point(33, 209);
            this.darkLabel13.Name = "darkLabel13";
            this.darkLabel13.Size = new System.Drawing.Size(29, 15);
            this.darkLabel13.TabIndex = 25;
            this.darkLabel13.Text = "Link";
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.Controls.Add(this.cbRegionRecovery);
            this.darkGroupBox2.Location = new System.Drawing.Point(36, 242);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(300, 118);
            this.darkGroupBox2.TabIndex = 24;
            this.darkGroupBox2.TabStop = false;
            this.darkGroupBox2.Text = "Download Recovery Firmware";
            // 
            // cbRegionRecovery
            // 
            this.cbRegionRecovery.FormattingEnabled = true;
            this.cbRegionRecovery.Items.AddRange(new object[] {
            "Australia",
            "Brazil",
            "China",
            "European Union",
            "Japan",
            "Korea",
            "Latin/Central America",
            "United States",
            "Russia",
            "Southeast Asia",
            "Taiwan",
            "United Kingdom"});
            this.cbRegionRecovery.Location = new System.Drawing.Point(71, 32);
            this.cbRegionRecovery.Name = "cbRegionRecovery";
            this.cbRegionRecovery.Size = new System.Drawing.Size(159, 24);
            this.cbRegionRecovery.TabIndex = 0;
            // 
            // tbMandatoryRec
            // 
            this.tbMandatoryRec.Location = new System.Drawing.Point(182, 172);
            this.tbMandatoryRec.Name = "tbMandatoryRec";
            this.tbMandatoryRec.Size = new System.Drawing.Size(154, 23);
            this.tbMandatoryRec.TabIndex = 22;
            // 
            // tbFwSizeRec
            // 
            this.tbFwSizeRec.Location = new System.Drawing.Point(182, 142);
            this.tbFwSizeRec.Name = "tbFwSizeRec";
            this.tbFwSizeRec.Size = new System.Drawing.Size(154, 23);
            this.tbFwSizeRec.TabIndex = 21;
            // 
            // tbFwVersionRec
            // 
            this.tbFwVersionRec.Location = new System.Drawing.Point(182, 112);
            this.tbFwVersionRec.Name = "tbFwVersionRec";
            this.tbFwVersionRec.Size = new System.Drawing.Size(154, 23);
            this.tbFwVersionRec.TabIndex = 20;
            // 
            // tbSdkVersionRec
            // 
            this.tbSdkVersionRec.Location = new System.Drawing.Point(182, 82);
            this.tbSdkVersionRec.Name = "tbSdkVersionRec";
            this.tbSdkVersionRec.Size = new System.Drawing.Size(154, 23);
            this.tbSdkVersionRec.TabIndex = 19;
            // 
            // tbLabelRec
            // 
            this.tbLabelRec.Location = new System.Drawing.Point(182, 52);
            this.tbLabelRec.Name = "tbLabelRec";
            this.tbLabelRec.Size = new System.Drawing.Size(154, 23);
            this.tbLabelRec.TabIndex = 18;
            // 
            // darkLabel8
            // 
            this.darkLabel8.AutoSize = true;
            this.darkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel8.Location = new System.Drawing.Point(33, 176);
            this.darkLabel8.Name = "darkLabel8";
            this.darkLabel8.Size = new System.Drawing.Size(111, 15);
            this.darkLabel8.TabIndex = 16;
            this.darkLabel8.Text = "Mandatory update :";
            // 
            // darkLabel9
            // 
            this.darkLabel9.AutoSize = true;
            this.darkLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel9.Location = new System.Drawing.Point(33, 146);
            this.darkLabel9.Name = "darkLabel9";
            this.darkLabel9.Size = new System.Drawing.Size(84, 15);
            this.darkLabel9.TabIndex = 15;
            this.darkLabel9.Text = "Firmware size :";
            // 
            // darkLabel10
            // 
            this.darkLabel10.AutoSize = true;
            this.darkLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel10.Location = new System.Drawing.Point(33, 116);
            this.darkLabel10.Name = "darkLabel10";
            this.darkLabel10.Size = new System.Drawing.Size(103, 15);
            this.darkLabel10.TabIndex = 14;
            this.darkLabel10.Text = "Firmware version :";
            // 
            // darkLabel11
            // 
            this.darkLabel11.AutoSize = true;
            this.darkLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel11.Location = new System.Drawing.Point(33, 86);
            this.darkLabel11.Name = "darkLabel11";
            this.darkLabel11.Size = new System.Drawing.Size(75, 15);
            this.darkLabel11.TabIndex = 13;
            this.darkLabel11.Text = "SDK version :";
            // 
            // darkLabel12
            // 
            this.darkLabel12.AutoSize = true;
            this.darkLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel12.Location = new System.Drawing.Point(33, 56);
            this.darkLabel12.Name = "darkLabel12";
            this.darkLabel12.Size = new System.Drawing.Size(90, 15);
            this.darkLabel12.TabIndex = 12;
            this.darkLabel12.Text = "Firmware label :";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.tbSha256);
            this.darkSectionPanel2.Controls.Add(this.darkLabel5);
            this.darkSectionPanel2.Controls.Add(this.darkGroupBox1);
            this.darkSectionPanel2.Controls.Add(this.tbFwSize);
            this.darkSectionPanel2.Controls.Add(this.tbFwVersion);
            this.darkSectionPanel2.Controls.Add(this.tbSdkVersion);
            this.darkSectionPanel2.Controls.Add(this.tbLabel);
            this.darkSectionPanel2.Controls.Add(this.darkLabel4);
            this.darkSectionPanel2.Controls.Add(this.darkLabel3);
            this.darkSectionPanel2.Controls.Add(this.darkLabel2);
            this.darkSectionPanel2.Controls.Add(this.darkLabel1);
            this.darkSectionPanel2.Location = new System.Drawing.Point(24, 21);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "System Firmware Info";
            this.darkSectionPanel2.Size = new System.Drawing.Size(399, 337);
            this.darkSectionPanel2.TabIndex = 1;
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.Controls.Add(this.btnDownloadSystem);
            this.darkGroupBox1.Controls.Add(this.darkLabel6);
            this.darkGroupBox1.Controls.Add(this.cbRegionSystem);
            this.darkGroupBox1.Location = new System.Drawing.Point(38, 197);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(326, 118);
            this.darkGroupBox1.TabIndex = 12;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "Download System Firmware";
            // 
            // btnDownloadRecovery
            // 
            this.btnDownloadRecovery.Location = new System.Drawing.Point(110, 334);
            this.btnDownloadRecovery.Name = "btnDownloadRecovery";
            this.btnDownloadRecovery.Size = new System.Drawing.Size(231, 23);
            this.btnDownloadRecovery.TabIndex = 1;
            this.btnDownloadRecovery.Text = "Download";
            this.btnDownloadRecovery.Visible = false;
            this.btnDownloadRecovery.Click += new System.EventHandler(this.btnDownloadRecovery_Click);
            // 
            // cbRegionSystem
            // 
            this.cbRegionSystem.FormattingEnabled = true;
            this.cbRegionSystem.Items.AddRange(new object[] {
            "Australia",
            "Brazil",
            "China",
            "European Union",
            "Japan",
            "Korea",
            "Latin/Central America",
            "United States",
            "Russia",
            "Southeast Asia",
            "Taiwan",
            "United Kingdom"});
            this.cbRegionSystem.Location = new System.Drawing.Point(144, 32);
            this.cbRegionSystem.Name = "cbRegionSystem";
            this.cbRegionSystem.Size = new System.Drawing.Size(131, 24);
            this.cbRegionSystem.TabIndex = 0;
            // 
            // tbFwSize
            // 
            this.tbFwSize.Location = new System.Drawing.Point(184, 133);
            this.tbFwSize.Name = "tbFwSize";
            this.tbFwSize.Size = new System.Drawing.Size(180, 23);
            this.tbFwSize.TabIndex = 9;
            // 
            // tbFwVersion
            // 
            this.tbFwVersion.Location = new System.Drawing.Point(184, 46);
            this.tbFwVersion.Name = "tbFwVersion";
            this.tbFwVersion.Size = new System.Drawing.Size(180, 23);
            this.tbFwVersion.TabIndex = 8;
            // 
            // tbSdkVersion
            // 
            this.tbSdkVersion.Location = new System.Drawing.Point(184, 104);
            this.tbSdkVersion.Name = "tbSdkVersion";
            this.tbSdkVersion.Size = new System.Drawing.Size(180, 23);
            this.tbSdkVersion.TabIndex = 7;
            // 
            // tbLabel
            // 
            this.tbLabel.Location = new System.Drawing.Point(184, 75);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(180, 23);
            this.tbLabel.TabIndex = 6;
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(35, 137);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(84, 15);
            this.darkLabel4.TabIndex = 3;
            this.darkLabel4.Text = "Firmware size :";
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(35, 50);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(103, 15);
            this.darkLabel3.TabIndex = 2;
            this.darkLabel3.Text = "Firmware version :";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(35, 108);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(75, 15);
            this.darkLabel2.TabIndex = 1;
            this.darkLabel2.Text = "SDK version :";
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(35, 79);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(90, 15);
            this.darkLabel1.TabIndex = 0;
            this.darkLabel1.Text = "Firmware label :";
            // 
            // darkDockPanel1
            // 
            this.darkDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkDockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.darkDockPanel1.Name = "darkDockPanel1";
            this.darkDockPanel1.Size = new System.Drawing.Size(447, 379);
            this.darkDockPanel1.TabIndex = 2;
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(46, 35);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(78, 15);
            this.darkLabel6.TabIndex = 28;
            this.darkLabel6.Text = "Select server :";
            // 
            // btnDownloadSystem
            // 
            this.btnDownloadSystem.Location = new System.Drawing.Point(48, 74);
            this.btnDownloadSystem.Name = "btnDownloadSystem";
            this.btnDownloadSystem.Size = new System.Drawing.Size(231, 23);
            this.btnDownloadSystem.TabIndex = 29;
            this.btnDownloadSystem.Text = "Download";
            this.btnDownloadSystem.Click += new System.EventHandler(this.btnDownloadSystem_Click_1);
            // 
            // tbSha256
            // 
            this.tbSha256.Location = new System.Drawing.Point(184, 162);
            this.tbSha256.Name = "tbSha256";
            this.tbSha256.Size = new System.Drawing.Size(180, 23);
            this.tbSha256.TabIndex = 14;
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(35, 166);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(111, 15);
            this.darkLabel5.TabIndex = 13;
            this.darkLabel5.Text = "SHA256 checksum :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 379);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkDockPanel1);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.btnDownloadRecovery);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS5 Firmware Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.darkGroupBox2.ResumeLayout(false);
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkGroupBox darkGroupBox2;
        private DarkUI.Controls.DarkComboBox cbRegionRecovery;
        private DarkUI.Controls.DarkTextBox tbMandatoryRec;
        private DarkUI.Controls.DarkTextBox tbFwSizeRec;
        private DarkUI.Controls.DarkTextBox tbFwVersionRec;
        private DarkUI.Controls.DarkTextBox tbSdkVersionRec;
        private DarkUI.Controls.DarkTextBox tbLabelRec;
        private DarkUI.Controls.DarkLabel darkLabel8;
        private DarkUI.Controls.DarkLabel darkLabel9;
        private DarkUI.Controls.DarkLabel darkLabel10;
        private DarkUI.Controls.DarkLabel darkLabel11;
        private DarkUI.Controls.DarkLabel darkLabel12;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private DarkUI.Controls.DarkButton btnDownloadRecovery;
        private DarkUI.Controls.DarkComboBox cbRegionSystem;
        private DarkUI.Controls.DarkTextBox tbFwSize;
        private DarkUI.Controls.DarkTextBox tbFwVersion;
        private DarkUI.Controls.DarkTextBox tbSdkVersion;
        private DarkUI.Controls.DarkTextBox tbLabel;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox tbLinkRec;
        private DarkUI.Controls.DarkLabel darkLabel13;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Docking.DarkDockPanel darkDockPanel1;
        private DarkUI.Controls.DarkButton btnDownloadSystem;
        private DarkUI.Controls.DarkTextBox tbSha256;
        private DarkUI.Controls.DarkLabel darkLabel5;
    }
}

