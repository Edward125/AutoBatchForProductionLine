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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBodyType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSetPoweOff = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkSetGB28181 = new System.Windows.Forms.CheckBox();
            this.chkSetCMSV6 = new System.Windows.Forms.CheckBox();
            this.chkSetAPN = new System.Windows.Forms.CheckBox();
            this.chkSetWiFi = new System.Windows.Forms.CheckBox();
            this.chkSyncTime = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmboBodyType);
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 51);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "执法仪型号选择";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "型号:";
            // 
            // cmboBodyType
            // 
            this.cmboBodyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBodyType.FormattingEnabled = true;
            this.cmboBodyType.Items.AddRange(new object[] {
            "H6",
            "H8",
            "G5",
            "G9"});
            this.cmboBodyType.Location = new System.Drawing.Point(50, 20);
            this.cmboBodyType.Name = "cmboBodyType";
            this.cmboBodyType.Size = new System.Drawing.Size(83, 20);
            this.cmboBodyType.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSetPoweOff);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.chkSetGB28181);
            this.groupBox1.Controls.Add(this.chkSetCMSV6);
            this.groupBox1.Controls.Add(this.chkSetAPN);
            this.groupBox1.Controls.Add(this.chkSetWiFi);
            this.groupBox1.Controls.Add(this.chkSyncTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目设置";
            // 
            // chkSetPoweOff
            // 
            this.chkSetPoweOff.AutoSize = true;
            this.chkSetPoweOff.Location = new System.Drawing.Point(19, 182);
            this.chkSetPoweOff.Name = "chkSetPoweOff";
            this.chkSetPoweOff.Size = new System.Drawing.Size(96, 16);
            this.chkSetPoweOff.TabIndex = 8;
            this.chkSetPoweOff.Text = "设置完毕关机";
            this.chkSetPoweOff.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 160);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 16);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "自动打开GPS";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "自动设置网络检查";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkSetGB28181
            // 
            this.chkSetGB28181.AutoSize = true;
            this.chkSetGB28181.Location = new System.Drawing.Point(19, 116);
            this.chkSetGB28181.Name = "chkSetGB28181";
            this.chkSetGB28181.Size = new System.Drawing.Size(114, 16);
            this.chkSetGB28181.TabIndex = 5;
            this.chkSetGB28181.Text = "自动设置GB28181";
            this.chkSetGB28181.UseVisualStyleBackColor = true;
            // 
            // chkSetCMSV6
            // 
            this.chkSetCMSV6.AutoSize = true;
            this.chkSetCMSV6.Location = new System.Drawing.Point(19, 94);
            this.chkSetCMSV6.Name = "chkSetCMSV6";
            this.chkSetCMSV6.Size = new System.Drawing.Size(102, 16);
            this.chkSetCMSV6.TabIndex = 4;
            this.chkSetCMSV6.Text = "自动设置CMSV6";
            this.chkSetCMSV6.UseVisualStyleBackColor = true;
            // 
            // chkSetAPN
            // 
            this.chkSetAPN.AutoSize = true;
            this.chkSetAPN.Location = new System.Drawing.Point(19, 72);
            this.chkSetAPN.Name = "chkSetAPN";
            this.chkSetAPN.Size = new System.Drawing.Size(90, 16);
            this.chkSetAPN.TabIndex = 3;
            this.chkSetAPN.Text = "自动设置APN";
            this.chkSetAPN.UseVisualStyleBackColor = true;
            // 
            // chkSetWiFi
            // 
            this.chkSetWiFi.AutoSize = true;
            this.chkSetWiFi.Location = new System.Drawing.Point(19, 50);
            this.chkSetWiFi.Name = "chkSetWiFi";
            this.chkSetWiFi.Size = new System.Drawing.Size(96, 16);
            this.chkSetWiFi.TabIndex = 2;
            this.chkSetWiFi.Text = "自动设置WiFi";
            this.chkSetWiFi.UseVisualStyleBackColor = true;
            // 
            // chkSyncTime
            // 
            this.chkSyncTime.AutoSize = true;
            this.chkSyncTime.Location = new System.Drawing.Point(19, 28);
            this.chkSyncTime.Name = "chkSyncTime";
            this.chkSyncTime.Size = new System.Drawing.Size(96, 16);
            this.chkSyncTime.TabIndex = 1;
            this.chkSyncTime.Text = "自动同步时间";
            this.chkSyncTime.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBodyType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSetPoweOff;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkSetGB28181;
        private System.Windows.Forms.CheckBox chkSetCMSV6;
        private System.Windows.Forms.CheckBox chkSetAPN;
        private System.Windows.Forms.CheckBox chkSetWiFi;
        private System.Windows.Forms.CheckBox chkSyncTime;
    }
}

