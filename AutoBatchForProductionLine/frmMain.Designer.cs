﻿namespace AutoBatchForProductionLine
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBodyType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.lstInfo = new System.Windows.Forms.ListView();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnOnlyOnce = new System.Windows.Forms.Button();
            this.btnAutoRun = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.comboBodyType.TabIndex = 2;
            this.comboBodyType.SelectedIndexChanged += new System.EventHandler(this.cmboBodyType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetting);
            this.groupBox1.Controls.Add(this.chkSetPoweOff);
            this.groupBox1.Controls.Add(this.chkSetGPS);
            this.groupBox1.Controls.Add(this.chkSetAPN);
            this.groupBox1.Controls.Add(this.chkSetCheckNet);
            this.groupBox1.Controls.Add(this.chkSetGB28181);
            this.groupBox1.Controls.Add(this.chkSetCMSV6);
            this.groupBox1.Controls.Add(this.chkSetWiFi);
            this.groupBox1.Controls.Add(this.chkSyncTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目设置";
            // 
            // btnSetting
            // 
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetting.Location = new System.Drawing.Point(19, 192);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(102, 30);
            this.btnSetting.TabIndex = 3;
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
            this.chkSetPoweOff.Location = new System.Drawing.Point(19, 170);
            this.chkSetPoweOff.Name = "chkSetPoweOff";
            this.chkSetPoweOff.Size = new System.Drawing.Size(120, 16);
            this.chkSetPoweOff.TabIndex = 8;
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
            this.chkSetGPS.Location = new System.Drawing.Point(19, 148);
            this.chkSetGPS.Name = "chkSetGPS";
            this.chkSetGPS.Size = new System.Drawing.Size(90, 16);
            this.chkSetGPS.TabIndex = 7;
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
            this.chkSetAPN.Location = new System.Drawing.Point(19, 82);
            this.chkSetAPN.Name = "chkSetAPN";
            this.chkSetAPN.Size = new System.Drawing.Size(90, 16);
            this.chkSetAPN.TabIndex = 3;
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
            this.chkSetCheckNet.Location = new System.Drawing.Point(19, 126);
            this.chkSetCheckNet.Name = "chkSetCheckNet";
            this.chkSetCheckNet.Size = new System.Drawing.Size(120, 16);
            this.chkSetCheckNet.TabIndex = 6;
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
            this.chkSetGB28181.Location = new System.Drawing.Point(19, 104);
            this.chkSetGB28181.Name = "chkSetGB28181";
            this.chkSetGB28181.Size = new System.Drawing.Size(114, 16);
            this.chkSetGB28181.TabIndex = 5;
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
            this.chkSetCMSV6.Location = new System.Drawing.Point(19, 60);
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
            this.chkSetWiFi.Location = new System.Drawing.Point(19, 38);
            this.chkSetWiFi.Name = "chkSetWiFi";
            this.chkSetWiFi.Size = new System.Drawing.Size(96, 16);
            this.chkSetWiFi.TabIndex = 2;
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
            this.chkSyncTime.Location = new System.Drawing.Point(19, 16);
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
            this.groupBox3.Controls.Add(this.lstInfo);
            this.groupBox3.Controls.Add(this.lstMsg);
            this.groupBox3.Location = new System.Drawing.Point(163, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 408);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信息列表";
            // 
            // lstInfo
            // 
            this.lstInfo.Location = new System.Drawing.Point(483, 19);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(315, 377);
            this.lstInfo.TabIndex = 1;
            this.lstInfo.UseCompatibleStateImageBehavior = false;
            this.lstInfo.View = System.Windows.Forms.View.Details;
            // 
            // lstMsg
            // 
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 12;
            this.lstMsg.Location = new System.Drawing.Point(15, 20);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(462, 376);
            this.lstMsg.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRestart);
            this.groupBox4.Controls.Add(this.btnOnlyOnce);
            this.groupBox4.Controls.Add(this.btnAutoRun);
            this.groupBox4.Location = new System.Drawing.Point(12, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(145, 125);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Location = new System.Drawing.Point(19, 85);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(102, 30);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "重启软件";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnOnlyOnce
            // 
            this.btnOnlyOnce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnlyOnce.Location = new System.Drawing.Point(19, 50);
            this.btnOnlyOnce.Name = "btnOnlyOnce";
            this.btnOnlyOnce.Size = new System.Drawing.Size(102, 30);
            this.btnOnlyOnce.TabIndex = 1;
            this.btnOnlyOnce.Text = "手动单次运行";
            this.btnOnlyOnce.UseVisualStyleBackColor = true;
            // 
            // btnAutoRun
            // 
            this.btnAutoRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutoRun.Location = new System.Drawing.Point(19, 15);
            this.btnAutoRun.Name = "btnAutoRun";
            this.btnAutoRun.Size = new System.Drawing.Size(102, 30);
            this.btnAutoRun.TabIndex = 0;
            this.btnAutoRun.Text = "自动侦测运行";
            this.btnAutoRun.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(983, 454);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBodyType;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button btnAutoRun;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ListView lstInfo;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.Button btnSetting;
    }
}

