﻿namespace AutoBatchForProductionLine
{
    partial class frmSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWiFiPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWiFiSSID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAPNUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPN = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCMSV6ReportTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCMSV6Port = new System.Windows.Forms.TextBox();
            this.txtCMSV6IP = new System.Windows.Forms.TextBox();
            this.txtAPNPwd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkEnableGB28181 = new System.Windows.Forms.CheckBox();
            this.txtGB2_ChnName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGB2_ChnNo = new System.Windows.Forms.TextBox();
            this.txtGB2_ServNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGB2_Passwd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGB2_DevNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGB2_Port = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGB2_IP = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkEnableCheckNet = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCheckNetPort = new System.Windows.Forms.TextBox();
            this.txtCheckNetIP = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radOpenGPS = new System.Windows.Forms.RadioButton();
            this.rabCloseGPS = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWiFiPwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWiFiSSID);
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WiFi设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "WiFi密码";
            // 
            // txtWiFiPwd
            // 
            this.txtWiFiPwd.Location = new System.Drawing.Point(65, 42);
            this.txtWiFiPwd.Name = "txtWiFiPwd";
            this.txtWiFiPwd.Size = new System.Drawing.Size(108, 21);
            this.txtWiFiPwd.TabIndex = 4;
            this.txtWiFiPwd.TextChanged += new System.EventHandler(this.txtWiFiPwd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "WiFi名称";
            // 
            // txtWiFiSSID
            // 
            this.txtWiFiSSID.Location = new System.Drawing.Point(65, 15);
            this.txtWiFiSSID.Name = "txtWiFiSSID";
            this.txtWiFiSSID.Size = new System.Drawing.Size(108, 21);
            this.txtWiFiSSID.TabIndex = 3;
            this.txtWiFiSSID.TextChanged += new System.EventHandler(this.txtWiFiSSID_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAPNUser);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAPN);
            this.groupBox2.Location = new System.Drawing.Point(221, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "APN设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "APN密码";
            // 
            // txtAPNUser
            // 
            this.txtAPNUser.Location = new System.Drawing.Point(61, 43);
            this.txtAPNUser.Name = "txtAPNUser";
            this.txtAPNUser.Size = new System.Drawing.Size(171, 21);
            this.txtAPNUser.TabIndex = 7;
            this.txtAPNUser.TextChanged += new System.EventHandler(this.txtAPNUser_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "APN账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "APN名称";
            // 
            // txtAPN
            // 
            this.txtAPN.Location = new System.Drawing.Point(61, 16);
            this.txtAPN.Name = "txtAPN";
            this.txtAPN.Size = new System.Drawing.Size(334, 21);
            this.txtAPN.TabIndex = 5;
            this.txtAPN.TextChanged += new System.EventHandler(this.txtAPN_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCMSV6ReportTime);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCMSV6Port);
            this.groupBox3.Controls.Add(this.txtCMSV6IP);
            this.groupBox3.Location = new System.Drawing.Point(27, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 101);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CMSV6服务器设置";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "秒";
            // 
            // txtCMSV6ReportTime
            // 
            this.txtCMSV6ReportTime.Location = new System.Drawing.Point(89, 74);
            this.txtCMSV6ReportTime.Name = "txtCMSV6ReportTime";
            this.txtCMSV6ReportTime.Size = new System.Drawing.Size(53, 21);
            this.txtCMSV6ReportTime.TabIndex = 8;
            this.txtCMSV6ReportTime.TextChanged += new System.EventHandler(this.txtCMSV6ReportTime_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "上报时间间隔";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "服务器端口";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "服务器IP";
            // 
            // txtCMSV6Port
            // 
            this.txtCMSV6Port.Location = new System.Drawing.Point(87, 45);
            this.txtCMSV6Port.Name = "txtCMSV6Port";
            this.txtCMSV6Port.Size = new System.Drawing.Size(53, 21);
            this.txtCMSV6Port.TabIndex = 5;
            this.txtCMSV6Port.TextChanged += new System.EventHandler(this.txtCMSV6Port_TextChanged);
            // 
            // txtCMSV6IP
            // 
            this.txtCMSV6IP.Location = new System.Drawing.Point(65, 20);
            this.txtCMSV6IP.Name = "txtCMSV6IP";
            this.txtCMSV6IP.Size = new System.Drawing.Size(108, 21);
            this.txtCMSV6IP.TabIndex = 5;
            this.txtCMSV6IP.TextChanged += new System.EventHandler(this.txtCMSV6IP_TextChanged);
            // 
            // txtAPNPwd
            // 
            this.txtAPNPwd.Location = new System.Drawing.Point(513, 65);
            this.txtAPNPwd.Name = "txtAPNPwd";
            this.txtAPNPwd.Size = new System.Drawing.Size(103, 21);
            this.txtAPNPwd.TabIndex = 9;
            this.txtAPNPwd.TextChanged += new System.EventHandler(this.txtAPNPwd_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkEnableGB28181);
            this.groupBox4.Controls.Add(this.txtGB2_ChnName);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtGB2_ChnNo);
            this.groupBox4.Controls.Add(this.txtGB2_ServNo);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtGB2_Passwd);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtGB2_DevNo);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtGB2_Port);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtGB2_IP);
            this.groupBox4.Location = new System.Drawing.Point(221, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 123);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GB28181服务器设置";
            // 
            // chkEnableGB28181
            // 
            this.chkEnableGB28181.AutoSize = true;
            this.chkEnableGB28181.Location = new System.Drawing.Point(270, 16);
            this.chkEnableGB28181.Name = "chkEnableGB28181";
            this.chkEnableGB28181.Size = new System.Drawing.Size(48, 16);
            this.chkEnableGB28181.TabIndex = 18;
            this.chkEnableGB28181.Text = "使能";
            this.chkEnableGB28181.UseVisualStyleBackColor = true;
            this.chkEnableGB28181.CheckedChanged += new System.EventHandler(this.chkEnableGB28181_CheckedChanged);
            // 
            // txtGB2_ChnName
            // 
            this.txtGB2_ChnName.Location = new System.Drawing.Point(306, 94);
            this.txtGB2_ChnName.Name = "txtGB2_ChnName";
            this.txtGB2_ChnName.Size = new System.Drawing.Size(89, 21);
            this.txtGB2_ChnName.TabIndex = 17;
            this.txtGB2_ChnName.TextChanged += new System.EventHandler(this.txtGB2_ChnName_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(251, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 16;
            this.label16.Text = "通道名称";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 15;
            this.label15.Text = "通道ID";
            // 
            // txtGB2_ChnNo
            // 
            this.txtGB2_ChnNo.Location = new System.Drawing.Point(61, 96);
            this.txtGB2_ChnNo.Name = "txtGB2_ChnNo";
            this.txtGB2_ChnNo.Size = new System.Drawing.Size(182, 21);
            this.txtGB2_ChnNo.TabIndex = 14;
            this.txtGB2_ChnNo.TextChanged += new System.EventHandler(this.txtGB2_ChnNo_TextChanged);
            // 
            // txtGB2_ServNo
            // 
            this.txtGB2_ServNo.Location = new System.Drawing.Point(61, 69);
            this.txtGB2_ServNo.Name = "txtGB2_ServNo";
            this.txtGB2_ServNo.Size = new System.Drawing.Size(182, 21);
            this.txtGB2_ServNo.TabIndex = 13;
            this.txtGB2_ServNo.TextChanged += new System.EventHandler(this.txtGB2_ServNo_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "服务器ID";
            // 
            // txtGB2_Passwd
            // 
            this.txtGB2_Passwd.Location = new System.Drawing.Point(306, 41);
            this.txtGB2_Passwd.Name = "txtGB2_Passwd";
            this.txtGB2_Passwd.Size = new System.Drawing.Size(89, 21);
            this.txtGB2_Passwd.TabIndex = 11;
            this.txtGB2_Passwd.TextChanged += new System.EventHandler(this.txtGB2_Passwd_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "密码";
            // 
            // txtGB2_DevNo
            // 
            this.txtGB2_DevNo.Location = new System.Drawing.Point(53, 42);
            this.txtGB2_DevNo.Name = "txtGB2_DevNo";
            this.txtGB2_DevNo.Size = new System.Drawing.Size(190, 21);
            this.txtGB2_DevNo.TabIndex = 9;
            this.txtGB2_DevNo.TextChanged += new System.EventHandler(this.txtGB2_DevNo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "设备ID";
            // 
            // txtGB2_Port
            // 
            this.txtGB2_Port.Location = new System.Drawing.Point(201, 16);
            this.txtGB2_Port.Name = "txtGB2_Port";
            this.txtGB2_Port.Size = new System.Drawing.Size(42, 21);
            this.txtGB2_Port.TabIndex = 7;
            this.txtGB2_Port.TextChanged += new System.EventHandler(this.txtGP2_Port_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "端口";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "IP地址";
            // 
            // txtGB2_IP
            // 
            this.txtGB2_IP.Location = new System.Drawing.Point(53, 16);
            this.txtGB2_IP.Name = "txtGB2_IP";
            this.txtGB2_IP.Size = new System.Drawing.Size(107, 21);
            this.txtGB2_IP.TabIndex = 5;
            this.txtGB2_IP.TextChanged += new System.EventHandler(this.txtGB2_IP_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkEnableCheckNet);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtCheckNetPort);
            this.groupBox5.Controls.Add(this.txtCheckNetIP);
            this.groupBox5.Location = new System.Drawing.Point(221, 230);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(412, 52);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "网络检查设置";
            // 
            // chkEnableCheckNet
            // 
            this.chkEnableCheckNet.AutoSize = true;
            this.chkEnableCheckNet.Location = new System.Drawing.Point(331, 22);
            this.chkEnableCheckNet.Name = "chkEnableCheckNet";
            this.chkEnableCheckNet.Size = new System.Drawing.Size(48, 16);
            this.chkEnableCheckNet.TabIndex = 19;
            this.chkEnableCheckNet.Text = "使能";
            this.chkEnableCheckNet.UseVisualStyleBackColor = true;
            this.chkEnableCheckNet.CheckedChanged += new System.EventHandler(this.chkEnableCheckNet_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(217, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 19;
            this.label18.Text = "端口";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 18;
            this.label17.Text = "IP地址";
            // 
            // txtCheckNetPort
            // 
            this.txtCheckNetPort.Location = new System.Drawing.Point(257, 20);
            this.txtCheckNetPort.Name = "txtCheckNetPort";
            this.txtCheckNetPort.Size = new System.Drawing.Size(47, 21);
            this.txtCheckNetPort.TabIndex = 18;
            this.txtCheckNetPort.TextChanged += new System.EventHandler(this.txtCheckNetPort_TextChanged);
            // 
            // txtCheckNetIP
            // 
            this.txtCheckNetIP.Location = new System.Drawing.Point(61, 20);
            this.txtCheckNetIP.Name = "txtCheckNetIP";
            this.txtCheckNetIP.Size = new System.Drawing.Size(137, 21);
            this.txtCheckNetIP.TabIndex = 18;
            this.txtCheckNetIP.TextChanged += new System.EventHandler(this.txtCheckNetIP_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radOpenGPS);
            this.groupBox6.Controls.Add(this.rabCloseGPS);
            this.groupBox6.Location = new System.Drawing.Point(26, 204);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(189, 42);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "GPS设置";
            // 
            // radOpenGPS
            // 
            this.radOpenGPS.AutoSize = true;
            this.radOpenGPS.Location = new System.Drawing.Point(18, 19);
            this.radOpenGPS.Name = "radOpenGPS";
            this.radOpenGPS.Size = new System.Drawing.Size(65, 16);
            this.radOpenGPS.TabIndex = 12;
            this.radOpenGPS.TabStop = true;
            this.radOpenGPS.Text = "打开GPS";
            this.radOpenGPS.UseVisualStyleBackColor = true;
            // 
            // rabCloseGPS
            // 
            this.rabCloseGPS.AutoSize = true;
            this.rabCloseGPS.Location = new System.Drawing.Point(109, 19);
            this.rabCloseGPS.Name = "rabCloseGPS";
            this.rabCloseGPS.Size = new System.Drawing.Size(65, 16);
            this.rabCloseGPS.TabIndex = 13;
            this.rabCloseGPS.TabStop = true;
            this.rabCloseGPS.Text = "关闭GPS";
            this.rabCloseGPS.UseVisualStyleBackColor = true;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 299);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtAPNPwd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWiFiPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWiFiSSID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAPNUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCMSV6ReportTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCMSV6Port;
        private System.Windows.Forms.TextBox txtCMSV6IP;
        private System.Windows.Forms.TextBox txtAPNPwd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGB2_Port;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGB2_IP;
        private System.Windows.Forms.TextBox txtGB2_ChnName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGB2_ChnNo;
        private System.Windows.Forms.TextBox txtGB2_ServNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGB2_Passwd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGB2_DevNo;
        private System.Windows.Forms.CheckBox chkEnableGB28181;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCheckNetPort;
        private System.Windows.Forms.TextBox txtCheckNetIP;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radOpenGPS;
        private System.Windows.Forms.RadioButton rabCloseGPS;
        private System.Windows.Forms.CheckBox chkEnableCheckNet;
    }
}