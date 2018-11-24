using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Edward;

namespace AutoBatchForProductionLine
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void txtWiFiSSID_TextChanged(object sender, EventArgs e)
        {
            p.WiFiSSID = txtWiFiSSID.Text.Trim();
            IniFile.IniWriteValue("WiFi", "WiFiSSID",p.WiFiSSID);
            
        }

        private void txtWiFiPwd_TextChanged(object sender, EventArgs e)
        {
            p.WiFiPwd = txtWiFiPwd.Text.Trim();
            IniFile.IniWriteValue("WiFi", "WiFiPwd", p.WiFiPwd);
        }

        private void txtCMSV6IP_TextChanged(object sender, EventArgs e)
        {
            p.CMSV6IP = txtCMSV6IP.Text.Trim();
            IniFile.IniWriteValue("CMSV6", "CMSV6IP", p.CMSV6IP);
        }

        private void txtCMSV6Port_TextChanged(object sender, EventArgs e)
        {
            p.CMSV6Port = txtCMSV6Port.Text.Trim();
            IniFile.IniWriteValue("CMSV6", "CMSV6Port", p.CMSV6Port);

        }

        private void txtCMSV6ReportTime_TextChanged(object sender, EventArgs e)
        {
            p.CMSV6ReportTime = txtCMSV6ReportTime.Text.Trim();
            IniFile.IniWriteValue("CMSV6", "CMSV6ReportTime", p.CMSV6ReportTime);
        }

        private void txtAPN_TextChanged(object sender, EventArgs e)
        {
            p.APN = txtAPN.Text.Trim();
            IniFile.IniWriteValue("APN", "APN",p. APN);
        }

        private void txtAPNUser_TextChanged(object sender, EventArgs e)
        {
            p.APNUser = txtAPNUser.Text.Trim();
            IniFile.IniWriteValue("APN", "APNUser", p.APNUser);
        }

        private void txtAPNPwd_TextChanged(object sender, EventArgs e)
        {
            p.APNPwd = txtAPNPwd.Text.Trim();
            IniFile.IniWriteValue("APN", "APNPwd",p. APNPwd);

        }

        private void chkEnableGB28181_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableGB28181.Checked)
                p.GB2_Enable = "1";
            else
                p.GB2_Enable = "0";
            IniFile.IniWriteValue("GB28181", "GB2_Enable",p.GB2_Enable);
        }

        private void txtGB2_IP_TextChanged(object sender, EventArgs e)
        {
            p.GB2_ServIP = txtGB2_IP.Text.Trim();
            IniFile.IniWriteValue("GB28181", "GB2_ServIP",p. GB2_ServIP);
        }

        private void txtGP2_Port_TextChanged(object sender, EventArgs e)
        {
            p.GB2_ServPort = txtGB2_Port.Text.Trim();
            IniFile.IniWriteValue("GB28181", "GB2_ServPort",p. GB2_ServPort);

        }

        private void txtGB2_DevNo_TextChanged(object sender, EventArgs e)
        {
            p.GB2_DevNo = txtGB2_DevNo.Text.Trim();
            IniFile.IniWriteValue("GB28181", "GB2_DevNo", p.GB2_DevNo);
        }

        private void txtGB2_Passwd_TextChanged(object sender, EventArgs e)
        {
            p.GB2_Passwd = txtGB2_Passwd.Text.Trim();
            IniFile.IniWriteValue("GB28181", "GB2_Passwd",p. GB2_Passwd);
        }

        private void txtGB2_ChnNo_TextChanged(object sender, EventArgs e)
        {
            p.GB2_ChnNo = txtGB2_ChnNo.Text.Trim();
            IniFile.IniWriteValue("GB28181", "GB2_ChnNo", p.GB2_ChnNo);
        }

        private void txtGB2_ServNo_TextChanged(object sender, EventArgs e)
        {
            p.GB2_ServNo = txtGB2_ServNo.Text.Trim();
            IniFile.IniWriteValue("GB28181", "GB2_ServNo", p.GB2_ServNo);

        }

        private void txtGB2_ChnName_TextChanged(object sender, EventArgs e)
        {
            p.GB2_ChnName  = txtGB2_ChnName.Text.Trim ();
            IniFile.IniWriteValue("GB28181", "GB2_ChnName", p.GB2_ChnName);
        }

        private void txtCheckNetIP_TextChanged(object sender, EventArgs e)
        {
            p.NetCheckIP = txtCheckNetIP.Text.Trim();
            IniFile.IniWriteValue("NetCheck", "NetCheckIP",p. NetCheckIP);
        }

        private void txtCheckNetPort_TextChanged(object sender, EventArgs e)
        {
            p.NetCheckPort = txtCheckNetPort.Text.Trim();
            IniFile.IniWriteValue("NetCheck", "NetCheckPort", p.NetCheckPort);
        }

        private void chkEnableCheckNet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableCheckNet.Checked)
                p.NetCheckEnable = "1";
            else
                p.NetCheckEnable = "0";

            IniFile.IniWriteValue("NetCheck", "NetCheckEnable", p.NetCheckEnable);
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            this.Text = "详细参数设置,Ver:" + Application.ProductVersion;
            //
            txtWiFiSSID.Text = p.WiFiSSID;
            txtWiFiPwd.Text = p.WiFiPwd;
            //
            txtGB2_IP.Text = p.GB2_ServIP;
            txtGB2_Passwd.Text = p.GB2_Passwd;
            txtGB2_ChnName.Text = p.GB2_ChnName;
            txtGB2_ChnNo.Text = p.GB2_ChnNo;
            txtGB2_DevNo.Text = p.GB2_DevNo;
            txtGB2_ServNo.Text = p.GB2_ServNo;
            txtGB2_Port.Text = p.GB2_ServPort;
            if (p.GB2_Enable == "1")
                chkEnableGB28181.Checked = true;
            else
                chkEnableGB28181.Checked  = false;
            //
            txtAPN.Text = p.APN;
            txtAPNUser.Text = p.APNUser;
            txtAPNPwd.Text = p.APNPwd;
            //
            txtCMSV6IP.Text = p.CMSV6IP;
            txtCMSV6Port.Text = p.CMSV6Port;
            txtCMSV6ReportTime .Text = p.CMSV6ReportTime;
            //
            txtCheckNetIP.Text = p.NetCheckIP;
            txtCheckNetPort.Text = p.NetCheckPort;
            if (p.NetCheckEnable == "1")
                chkEnableCheckNet.Checked = true;
            else
                chkEnableCheckNet.Checked = false;
            //
            if (p.GPS == "1")
                rabOpenGPS.Checked = true;
            else
                rabCloseGPS.Checked = true;

            switch (p.CheckParamErrorCode)
            {
                case p.SetErrorCode.OK:
                    break;
                case p.SetErrorCode.WIFISSID:
                    txtWiFiSSID.SelectAll();
                    txtWiFiSSID.Focus();
                    break;
                case p.SetErrorCode.WIFIPWD:
                    txtWiFiPwd.SelectAll();
                    txtWiFiPwd.Focus();
                    break;
                case p.SetErrorCode.CMSV6IP:
                    txtCMSV6IP.SelectAll();
                    txtCMSV6IP.Focus();
                    break;
                case p.SetErrorCode.CMSV6RerpotTime:
                    txtCMSV6ReportTime.SelectAll();
                    txtCMSV6ReportTime.Focus();
                    break;
                case p.SetErrorCode.APN:
                    txtAPN.SelectAll();
                    txtAPN.Focus();
                    break;
                case p.SetErrorCode.APNUser:
                    txtAPNUser.SelectAll();
                    txtAPNUser.Focus();
                    break;
                case p.SetErrorCode.APNPwd:
                    txtAPNPwd.SelectAll();
                    txtAPNPwd.Focus();
                    break;
                case p.SetErrorCode.CheckNetIP:
                    txtCheckNetIP.SelectAll();
                    txtCheckNetIP.Focus();
                    break;
                case p.SetErrorCode.CheckNetPort:
                    txtCheckNetPort.SelectAll();
                    txtCheckNetPort.Focus();
                    break;
                case p.SetErrorCode.GB2_IP:
                    txtGB2_IP.SelectAll();
                    txtGB2_IP.Focus();
                    break;
                case p.SetErrorCode.GB2_Port:
                    txtGB2_Port.SelectAll();
                    txtGB2_Port.Focus();
                    break;
                case p.SetErrorCode.GB2_DevNo:
                    txtGB2_DevNo.SelectAll();
                    txtGB2_DevNo.Focus();
                    break;
                case p.SetErrorCode.GB2_ChnNo:
                    txtGB2_ChnNo.SelectAll();
                    txtGB2_ChnNo.Focus();
                    break;
                case p.SetErrorCode.GB2_SerNo:
                    txtGB2_ServNo.SelectAll();
                    txtGB2_ServNo.Focus();
                    break;
                case p.SetErrorCode.GB2_Passwd:
                    txtGB2_Passwd.SelectAll();
                    txtGB2_Passwd.Focus();
                    break;
                default:
                    break;
            }



        }

        private void rabCloseGPS_CheckedChanged(object sender, EventArgs e)
        {
            if (rabCloseGPS.Checked)
                p.GPS = "0";
            IniFile.IniWriteValue("GPS", "GPS", p.GPS);

        }

        private void rabOpenGPS_CheckedChanged(object sender, EventArgs e)
        {
            if (rabOpenGPS.Checked )
                p.GPS = "1";
            IniFile.IniWriteValue("GPS", "GPS", p.GPS);
        }
    }
}
