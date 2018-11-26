namespace AutoBatchForProductionLine
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBodyType = new System.Windows.Forms.ComboBox();
            this.grbItem = new System.Windows.Forms.GroupBox();
            this.chkSetFormat = new System.Windows.Forms.CheckBox();
            this.chkSetSN = new System.Windows.Forms.CheckBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.chkSetPoweOff = new System.Windows.Forms.CheckBox();
            this.chkSetGPS = new System.Windows.Forms.CheckBox();
            this.chkSetAPN = new System.Windows.Forms.CheckBox();
            this.chkSetCheckNet = new System.Windows.Forms.CheckBox();
            this.chkSetGB28181 = new System.Windows.Forms.CheckBox();
            this.chkSetCMSV6 = new System.Windows.Forms.CheckBox();
            this.chkSetWiFi = new System.Windows.Forms.CheckBox();
            this.chkSyncTime = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearInfo = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnOnlyOnce = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.grbItem.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBodyType);
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 42);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "执法仪型号选择";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "执法仪型号";
            // 
            // comboBodyType
            // 
            this.comboBodyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBodyType.FormattingEnabled = true;
            this.comboBodyType.Items.AddRange(new object[] {
            "H6",
            "H8",
            "G5",
            "G9"});
            this.comboBodyType.Location = new System.Drawing.Point(76, 16);
            this.comboBodyType.Name = "comboBodyType";
            this.comboBodyType.Size = new System.Drawing.Size(57, 20);
            this.comboBodyType.TabIndex = 0;
            this.comboBodyType.SelectedIndexChanged += new System.EventHandler(this.cmboBodyType_SelectedIndexChanged);
            // 
            // grbItem
            // 
            this.grbItem.Controls.Add(this.chkSetFormat);
            this.grbItem.Controls.Add(this.chkSetSN);
            this.grbItem.Controls.Add(this.btnSetting);
            this.grbItem.Controls.Add(this.chkSetPoweOff);
            this.grbItem.Controls.Add(this.chkSetGPS);
            this.grbItem.Controls.Add(this.chkSetAPN);
            this.grbItem.Controls.Add(this.chkSetCheckNet);
            this.grbItem.Controls.Add(this.chkSetGB28181);
            this.grbItem.Controls.Add(this.chkSetCMSV6);
            this.grbItem.Controls.Add(this.chkSetWiFi);
            this.grbItem.Controls.Add(this.chkSyncTime);
            this.grbItem.Location = new System.Drawing.Point(12, 74);
            this.grbItem.Name = "grbItem";
            this.grbItem.Size = new System.Drawing.Size(145, 269);
            this.grbItem.TabIndex = 2;
            this.grbItem.TabStop = false;
            this.grbItem.Text = "项目设置";
            // 
            // chkSetFormat
            // 
            this.chkSetFormat.AutoSize = true;
            this.chkSetFormat.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetFormat.Enabled = false;
            this.chkSetFormat.ForeColor = System.Drawing.Color.Black;
            this.chkSetFormat.Location = new System.Drawing.Point(13, 187);
            this.chkSetFormat.Name = "chkSetFormat";
            this.chkSetFormat.Size = new System.Drawing.Size(84, 16);
            this.chkSetFormat.TabIndex = 9;
            this.chkSetFormat.Text = "自动格式化";
            this.chkSetFormat.UseVisualStyleBackColor = false;
            this.chkSetFormat.CheckedChanged += new System.EventHandler(this.chkSetFormat_CheckedChanged);
            this.chkSetFormat.EnabledChanged += new System.EventHandler(this.chkSetFormat_EnabledChanged);
            // 
            // chkSetSN
            // 
            this.chkSetSN.AutoSize = true;
            this.chkSetSN.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetSN.Enabled = false;
            this.chkSetSN.ForeColor = System.Drawing.Color.Black;
            this.chkSetSN.Location = new System.Drawing.Point(13, 38);
            this.chkSetSN.Name = "chkSetSN";
            this.chkSetSN.Size = new System.Drawing.Size(108, 16);
            this.chkSetSN.TabIndex = 2;
            this.chkSetSN.Text = "自动填写序列号";
            this.chkSetSN.UseVisualStyleBackColor = false;
            this.chkSetSN.CheckedChanged += new System.EventHandler(this.chkSetSN_CheckedChanged);
            this.chkSetSN.EnabledChanged += new System.EventHandler(this.chkSetSN_EnabledChanged);
            // 
            // btnSetting
            // 
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetting.Location = new System.Drawing.Point(13, 231);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(102, 30);
            this.btnSetting.TabIndex = 11;
            this.btnSetting.Text = "详细参数设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // chkSetPoweOff
            // 
            this.chkSetPoweOff.AutoSize = true;
            this.chkSetPoweOff.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetPoweOff.Enabled = false;
            this.chkSetPoweOff.ForeColor = System.Drawing.Color.Black;
            this.chkSetPoweOff.Location = new System.Drawing.Point(13, 209);
            this.chkSetPoweOff.Name = "chkSetPoweOff";
            this.chkSetPoweOff.Size = new System.Drawing.Size(120, 16);
            this.chkSetPoweOff.TabIndex = 10;
            this.chkSetPoweOff.Text = "设置完毕自动关机";
            this.chkSetPoweOff.UseVisualStyleBackColor = false;
            this.chkSetPoweOff.CheckedChanged += new System.EventHandler(this.chkSetPoweOff_CheckedChanged);
            this.chkSetPoweOff.EnabledChanged += new System.EventHandler(this.chkSetPoweOff_EnabledChanged);
            // 
            // chkSetGPS
            // 
            this.chkSetGPS.AutoSize = true;
            this.chkSetGPS.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetGPS.Enabled = false;
            this.chkSetGPS.ForeColor = System.Drawing.Color.Black;
            this.chkSetGPS.Location = new System.Drawing.Point(13, 166);
            this.chkSetGPS.Name = "chkSetGPS";
            this.chkSetGPS.Size = new System.Drawing.Size(90, 16);
            this.chkSetGPS.TabIndex = 8;
            this.chkSetGPS.Text = "自动打开GPS";
            this.chkSetGPS.UseVisualStyleBackColor = false;
            this.chkSetGPS.CheckedChanged += new System.EventHandler(this.chkSetGPS_CheckedChanged);
            this.chkSetGPS.EnabledChanged += new System.EventHandler(this.chkSetGPS_EnabledChanged);
            // 
            // chkSetAPN
            // 
            this.chkSetAPN.AutoSize = true;
            this.chkSetAPN.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetAPN.Enabled = false;
            this.chkSetAPN.ForeColor = System.Drawing.Color.Black;
            this.chkSetAPN.Location = new System.Drawing.Point(13, 100);
            this.chkSetAPN.Name = "chkSetAPN";
            this.chkSetAPN.Size = new System.Drawing.Size(90, 16);
            this.chkSetAPN.TabIndex = 5;
            this.chkSetAPN.Text = "自动设置APN";
            this.chkSetAPN.UseVisualStyleBackColor = false;
            this.chkSetAPN.CheckedChanged += new System.EventHandler(this.chkSetAPN_CheckedChanged);
            this.chkSetAPN.EnabledChanged += new System.EventHandler(this.chkSetAPN_EnabledChanged);
            // 
            // chkSetCheckNet
            // 
            this.chkSetCheckNet.AutoSize = true;
            this.chkSetCheckNet.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetCheckNet.Enabled = false;
            this.chkSetCheckNet.ForeColor = System.Drawing.Color.Black;
            this.chkSetCheckNet.Location = new System.Drawing.Point(13, 144);
            this.chkSetCheckNet.Name = "chkSetCheckNet";
            this.chkSetCheckNet.Size = new System.Drawing.Size(120, 16);
            this.chkSetCheckNet.TabIndex = 7;
            this.chkSetCheckNet.Text = "自动设置网络检查";
            this.chkSetCheckNet.UseVisualStyleBackColor = false;
            this.chkSetCheckNet.CheckedChanged += new System.EventHandler(this.chkSetCheckNet_CheckedChanged);
            this.chkSetCheckNet.EnabledChanged += new System.EventHandler(this.chkSetCheckNet_EnabledChanged);
            // 
            // chkSetGB28181
            // 
            this.chkSetGB28181.AutoSize = true;
            this.chkSetGB28181.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetGB28181.Enabled = false;
            this.chkSetGB28181.ForeColor = System.Drawing.Color.Black;
            this.chkSetGB28181.Location = new System.Drawing.Point(13, 121);
            this.chkSetGB28181.Name = "chkSetGB28181";
            this.chkSetGB28181.Size = new System.Drawing.Size(114, 16);
            this.chkSetGB28181.TabIndex = 6;
            this.chkSetGB28181.Text = "自动设置GB28181";
            this.chkSetGB28181.UseVisualStyleBackColor = false;
            this.chkSetGB28181.CheckedChanged += new System.EventHandler(this.chkSetGB28181_CheckedChanged);
            this.chkSetGB28181.EnabledChanged += new System.EventHandler(this.chkSetGB28181_EnabledChanged);
            // 
            // chkSetCMSV6
            // 
            this.chkSetCMSV6.AutoSize = true;
            this.chkSetCMSV6.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetCMSV6.Enabled = false;
            this.chkSetCMSV6.ForeColor = System.Drawing.Color.Black;
            this.chkSetCMSV6.Location = new System.Drawing.Point(13, 79);
            this.chkSetCMSV6.Name = "chkSetCMSV6";
            this.chkSetCMSV6.Size = new System.Drawing.Size(102, 16);
            this.chkSetCMSV6.TabIndex = 4;
            this.chkSetCMSV6.Text = "自动设置CMSV6";
            this.chkSetCMSV6.UseVisualStyleBackColor = false;
            this.chkSetCMSV6.CheckedChanged += new System.EventHandler(this.chkSetCMSV6_CheckedChanged);
            this.chkSetCMSV6.EnabledChanged += new System.EventHandler(this.chkSetCMSV6_EnabledChanged);
            // 
            // chkSetWiFi
            // 
            this.chkSetWiFi.AutoSize = true;
            this.chkSetWiFi.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetWiFi.Enabled = false;
            this.chkSetWiFi.ForeColor = System.Drawing.Color.Black;
            this.chkSetWiFi.Location = new System.Drawing.Point(13, 57);
            this.chkSetWiFi.Name = "chkSetWiFi";
            this.chkSetWiFi.Size = new System.Drawing.Size(96, 16);
            this.chkSetWiFi.TabIndex = 3;
            this.chkSetWiFi.Text = "自动设置WiFi";
            this.chkSetWiFi.UseVisualStyleBackColor = false;
            this.chkSetWiFi.CheckedChanged += new System.EventHandler(this.chkSetWiFi_CheckedChanged);
            this.chkSetWiFi.EnabledChanged += new System.EventHandler(this.chkSetWiFi_EnabledChanged);
            // 
            // chkSyncTime
            // 
            this.chkSyncTime.AutoSize = true;
            this.chkSyncTime.BackColor = System.Drawing.SystemColors.Control;
            this.chkSyncTime.Enabled = false;
            this.chkSyncTime.ForeColor = System.Drawing.Color.Black;
            this.chkSyncTime.Location = new System.Drawing.Point(13, 19);
            this.chkSyncTime.Name = "chkSyncTime";
            this.chkSyncTime.Size = new System.Drawing.Size(96, 16);
            this.chkSyncTime.TabIndex = 1;
            this.chkSyncTime.Text = "自动同步时间";
            this.chkSyncTime.UseVisualStyleBackColor = false;
            this.chkSyncTime.CheckedChanged += new System.EventHandler(this.chkSyncTime_CheckedChanged);
            this.chkSyncTime.EnabledChanged += new System.EventHandler(this.chkSyncTime_EnabledChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstMsg);
            this.groupBox3.Location = new System.Drawing.Point(163, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(682, 447);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信息列表";
            // 
            // lstMsg
            // 
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 12;
            this.lstMsg.Location = new System.Drawing.Point(15, 20);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(659, 412);
            this.lstMsg.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearInfo);
            this.groupBox4.Controls.Add(this.btnRestart);
            this.groupBox4.Controls.Add(this.btnOnlyOnce);
            this.groupBox4.Location = new System.Drawing.Point(12, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(145, 125);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // btnClearInfo
            // 
            this.btnClearInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearInfo.Location = new System.Drawing.Point(19, 87);
            this.btnClearInfo.Name = "btnClearInfo";
            this.btnClearInfo.Size = new System.Drawing.Size(102, 30);
            this.btnClearInfo.TabIndex = 14;
            this.btnClearInfo.Text = "清楚信息列表";
            this.btnClearInfo.UseVisualStyleBackColor = true;
            this.btnClearInfo.Click += new System.EventHandler(this.btnClearInfo_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Location = new System.Drawing.Point(19, 51);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(102, 30);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "重启软件";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnOnlyOnce
            // 
            this.btnOnlyOnce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnlyOnce.Location = new System.Drawing.Point(19, 16);
            this.btnOnlyOnce.Name = "btnOnlyOnce";
            this.btnOnlyOnce.Size = new System.Drawing.Size(102, 30);
            this.btnOnlyOnce.TabIndex = 12;
            this.btnOnlyOnce.Text = "手动单次运行";
            this.btnOnlyOnce.UseVisualStyleBackColor = true;
            this.btnOnlyOnce.Click += new System.EventHandler(this.btnOnlyOnce_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(851, 481);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbItem.ResumeLayout(false);
            this.grbItem.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBodyType;
        private System.Windows.Forms.GroupBox grbItem;
        private System.Windows.Forms.CheckBox chkSetPoweOff;
        private System.Windows.Forms.CheckBox chkSetGPS;
        private System.Windows.Forms.CheckBox chkSetCheckNet;
        private System.Windows.Forms.CheckBox chkSetGB28181;
        private System.Windows.Forms.CheckBox chkSetCMSV6;
        private System.Windows.Forms.CheckBox chkSetAPN;
        private System.Windows.Forms.CheckBox chkSetWiFi;
        private System.Windows.Forms.CheckBox chkSyncTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOnlyOnce;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClearInfo;
        private System.Windows.Forms.CheckBox chkSetFormat;
        private System.Windows.Forms.CheckBox chkSetSN;
    }
}

