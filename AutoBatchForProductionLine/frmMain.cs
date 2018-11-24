﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Edward;
using SDK;

namespace AutoBatchForProductionLine
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        #region 参数定义



        private static Vendor LoginDevice;  //当前设备的方案商
        private static Model LoginModel;//当前设备的型号

        private static IntPtr BCHandle = IntPtr.Zero;
        private static string DevicePwd = "000000";
        public static string IDCode = string.Empty;
        public static bool bRestart = false;

        public enum Model
        {
            H6,
            H8,
            G5,
            G9
        }

        public enum Vendor
        {
            Cammpro,
            EasyStorage
        }


        /// <summary>
        /// APN
        /// </summary>
        public class APN
        {
            public string ApnName { set; get; }
            public string ApnUser { set; get; }
            public string ApnPwd { set; get; }
        }


        /// <summary>
        /// Only Wifi
        /// </summary>
        public class WiFi
        {
           // public WiFiModeType WiFiMode { set; get; }
            public string WiFiSSID { set; get; }
            public string WiFiPassword { set; get; }

        }



        /// <summary>
        ///  CMCSV6 Server
        /// </summary>
        public class CMCSV6Server
        {
            public string ServerIP { set; get; }
            public string ServerPort { set; get; }
            public int ReportTime { set; get; }
            public string DevNo { set; get; }
            public int Enable { set; get; }
        }

        /// <summary>
        /// GB28181
        /// </summary>
        public class GB28181Server
        {
            public string ServerIP { set; get; }
            public string ServerPort { set; get; }
            public int Enable { set; get; }
            public string DeviceID { set; get; }
            public string ServerPassword { set; get; }
            public string ChannelName { set; get; }
            public string ServerID { set; get; }
            public string ChannelID { set; get; }
            public string GPSIP { set; get; }
            public string GPSPort { set; get; }
        }


        /// <summary>
        /// NetCheckServer
        /// </summary>
        public class NetCheckServer
        {
            public int Enable { set; get; }
            public string IP { set; get; }
            public string Port { set; get; }
        }


        /// <summary>
        /// 设备的信息(序列号等等)
        /// </summary>
        public class DeviceInfo
        {
            public string cSerial { get; set; }
            public string userNo { get; set; }
            public string userName { get; set; }
            public string unitNo { get; set; }
            public string unitName { get; set; }

        }


        #endregion


        private void frmMain_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Snow;
            LoadUI();

        }


        private void LoadUI()
        {
            p.CreateFolder();
            p.CreateIni();
            p.ReadIni();
            LoadData();
        }


        private void LoadData()
        {
            this.Text = "自动设置执法仪信息工具,Ver:" + Application.ProductVersion;
            bRestart = false;
            if (!string.IsNullOrEmpty(p.CurrentDevice))
                comboBodyType.Text = p.CurrentDevice;
            switch (p.CurrentDevice)
            {
                case "H6":
                    LoginDevice = Vendor.Cammpro;
                    LoginModel = Model.H6;
                    break;
                case "H8":
                    LoginDevice = Vendor.EasyStorage;
                    LoginModel = Model.H8;
                    break;
                case "G5":
                    LoginDevice = Vendor.EasyStorage;
                    LoginModel = Model.G5;
                    break;
                case "G9":
                    LoginDevice = Vendor.Cammpro;
                    LoginModel = Model.G9;
                    break;
                default:
                    break;

            }



        }

        #region combobox


        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;  //当前的ComboBox控件
            SolidBrush myBrush = new SolidBrush(cmb.ForeColor);  //字体颜色
            Font ft = cmb.Font;    //获取在属性中设置的字体

            //选项的文本
            string itemText = cmb.GetItemText(cmb.Items[e.Index]);//cmb.Items[e.Index].ToString(); 
            // 计算字符串尺寸（以像素为单位）
            SizeF ss = e.Graphics.MeasureString(itemText, cmb.Font);

            // 水平居中
            float left = 0;
            left = (float)(e.Bounds.Width - ss.Width) / 2;  //如果需要水平居中取消注释
            if (left < 0) left = 0f;

            // 垂直居中
            float top = (float)(e.Bounds.Height - ss.Height) / 2;
            if (top <= 0) top = 0f;

            // 输出
            e.DrawBackground();
            e.Graphics.DrawString(itemText, ft, myBrush, new RectangleF(
                e.Bounds.X + left,    //设置X坐标偏移量
                e.Bounds.Y + top,     //设置Y坐标偏移量
                e.Bounds.Width, e.Bounds.Height), StringFormat.GenericDefault);

            //e.Graphics.DrawString(cmb.GetItemText(cmb.Items[e.Index]), ft, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        #endregion

        private void cmboBodyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            IniFile.IniWriteValue("SysConfig", "CurrentDevice", comboBodyType.Text);
            switch (comboBodyType.Text)
            {

                case "H6":
                    LoginDevice = Vendor.Cammpro;
                    LoginModel = Model.H6;
                    LoadUIByModel(LoginModel);
                    LoadConfigByModel(LoginModel);
                    break;
                case "H8":
                    LoginDevice = Vendor.EasyStorage;
                    LoginModel = Model.H8;
                    LoadUIByModel(LoginModel);
                    LoadConfigByModel(LoginModel);
                    break;
                case "G5":
                    LoginDevice = Vendor.EasyStorage;
                    LoginModel = Model.G5;
                    LoadUIByModel(LoginModel);
                    LoadConfigByModel(LoginModel);
                    break;
                case "G9":
                    LoginDevice = Vendor.Cammpro;
                    LoginModel = Model.G9;
                    LoadUIByModel(LoginModel);
                    LoadConfigByModel(LoginModel);
                    break;
                default:
                    break;
            }




        }





        #region LoadUIByModel

        private void LoadUIByModel(Model _model)
        {
            switch (_model)
            {
                case Model.H6:
                    chkSyncTime.Enabled = true;
                    chkSetAPN.Enabled = false;
                    chkSetCMSV6.Enabled = false;
                    chkSetGB28181.Enabled = false;
                    chkSetWiFi.Enabled = false;
                    chkSetGPS.Enabled = false;
                    chkSetCheckNet.Enabled = false;
                    chkSetPoweOff.Enabled = false;
                    break;
                case Model.H8:
                    chkSyncTime.Enabled = true;
                    chkSetAPN.Enabled = false;
                    chkSetCMSV6.Enabled = false;
                    chkSetGB28181.Enabled = false;
                    chkSetWiFi.Enabled = false;
                    chkSetGPS.Enabled = false;
                    chkSetCheckNet.Enabled = false;
                    chkSetPoweOff.Enabled = false;
                    break;
                case Model.G5:
                    chkSyncTime.Enabled = true;
                    chkSetAPN.Enabled = true;
                    chkSetCMSV6.Enabled = true;
                    chkSetGB28181.Enabled = true;
                    chkSetWiFi.Enabled = true;
                    chkSetGPS.Enabled = true;
                    chkSetCheckNet.Enabled = true;
                    chkSetPoweOff.Enabled = true;
                    break;
                case Model.G9:
                    chkSyncTime.Enabled = true;
                    chkSetAPN.Enabled = false;
                    chkSetCMSV6.Enabled = true;
                    chkSetGB28181.Enabled = false;
                    chkSetWiFi.Enabled = true;
                    chkSetGPS.Enabled = false;
                    chkSetCheckNet.Enabled = false;
                    chkSetPoweOff.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        #endregion




        private void LoadConfigByModel(Model _model)
        {
            p.SyncTime = IniFile.IniReadValue(_model.ToString(), "SyncTime");
            p.SetWiFi = IniFile.IniReadValue(_model.ToString(), "SetWiFi");
            p.SetAPN = IniFile.IniReadValue(_model.ToString(), "SetAPN");
            p.SetCMSV6 = IniFile.IniReadValue(_model.ToString(), "SetCMSV6");
            p.SetGB28181 = IniFile.IniReadValue(_model.ToString(), "SetGB28181");
            p.SetCheckNet = IniFile.IniReadValue(_model.ToString(), "SetCheckNet");
            p.SetGPS = IniFile.IniReadValue(_model.ToString(), "SetGPS");
            p.SetPowerOff = IniFile.IniReadValue(_model.ToString(), "SetPowerOff");

            CheckConfigValueAndCheckbox(p.SyncTime, chkSyncTime);
            CheckConfigValueAndCheckbox(p.SetWiFi, chkSetWiFi);
            CheckConfigValueAndCheckbox(p.SetAPN, chkSetAPN);
            CheckConfigValueAndCheckbox(p.SetCMSV6, chkSetCMSV6);
            CheckConfigValueAndCheckbox(p.SetGB28181, chkSetGB28181);
            CheckConfigValueAndCheckbox(p.SetCheckNet, chkSetCheckNet);
            CheckConfigValueAndCheckbox(p.SetGPS, chkSetGPS);
            CheckConfigValueAndCheckbox(p.SetPowerOff, chkSetPoweOff);


        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="checkbox"></param>
        private void CheckConfigValueAndCheckbox(string param, CheckBox checkbox)
        {
            if (param == "1")
                checkbox.Checked = true;
            if (param == "0")
                checkbox.Checked = false;
        }




        private void CheckCheckboxCheckState(CheckBox checkbox)
        {

            if (!checkbox.Enabled)
            {
                checkbox.BackColor = SystemColors.Control;
                checkbox.Checked = false;
            }
            else
            {
                if (checkbox.Checked)
                {
                    checkbox.BackColor = Color.Green;
                    checkbox.ForeColor = Color.White;
                }
                else
                {
                    checkbox.BackColor = Color.Red;
                    checkbox.ForeColor = Color.White;
                }
            }





        }

        private void chkSyncTime_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSyncTime);
            string State = string.Empty;
            if (chkSyncTime.Checked)
                State = "1";
            else
                State = "0";
            p.SyncTime = State;
            IniFile.IniWriteValue(LoginModel.ToString(), "SyncTime", State);

        }

        private void chkSetWiFi_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetWiFi);
            string State = string.Empty;
            if (chkSetWiFi.Checked)
                State = "1";
            else
                State = "0";
            p.SetWiFi = State;
            IniFile.IniWriteValue(LoginModel.ToString(), "SetWiFi", State);
        }

        private void chkSetCMSV6_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetCMSV6);
            string State = string.Empty;
            if (chkSetCMSV6.Checked)
                State = "1";
            else
                State = "0";
            p.SetCMSV6 = State;
            IniFile.IniWriteValue(LoginModel.ToString(), "SetCMSV6", State);
        }

        private void chkSetAPN_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetAPN);
            string State = string.Empty;
            if (chkSetAPN.Checked)
                State = "1";
            else
                State = "0";
            p.SetAPN = State;
            IniFile.IniWriteValue(LoginModel.ToString(), "SetAPN", State);
        }

        private void chkSetGB28181_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetGB28181);
            string State = string.Empty;
            if (chkSetGB28181.Checked)
                State = "1";
            else
                State = "0";
            p.SetGB28181 = State;
            IniFile.IniWriteValue(LoginModel.ToString(), "SetGB28181", State);
        }

        private void chkSetCheckNet_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetCheckNet);
            string State = string.Empty;
            if (chkSetCheckNet.Checked)
                State = "1";
            else
                State = "0";
            p.SetCheckNet = State;
            IniFile.IniWriteValue(LoginModel.ToString(), "SetCheckNet", State);
        }

        private void chkSetGPS_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetGPS);
            string State = string.Empty;
            if (chkSetGPS.Checked)
                State = "1";
            else
                State = "0";
            p.SetGPS = State;
            IniFile.IniWriteValue(LoginModel.ToString(), "SetGPS", State);
        }

        private void chkSetPoweOff_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetPoweOff);
            string State = string.Empty;
            if (chkSetPoweOff.Checked)
                State = "1";
            else
                State = "0";
            p.SetPowerOff = State;
            IniFile.IniWriteValue(LoginModel.ToString(), "SetPowerOff", State);
        }

        private void chkSyncTime_EnabledChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSyncTime);
        }

        private void chkSetWiFi_EnabledChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetWiFi);
        }

        private void chkSetCMSV6_EnabledChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetCMSV6);
        }

        private void chkSetAPN_EnabledChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetAPN);
        }

        private void chkSetGB28181_EnabledChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetGB28181);
        }

        private void chkSetCheckNet_EnabledChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetCheckNet);
        }

        private void chkSetGPS_EnabledChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetGPS);
        }

        private void chkSetPoweOff_EnabledChanged(object sender, EventArgs e)
        {
            CheckCheckboxCheckState(chkSetPoweOff);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form f = new frmSetting();
            f.ShowDialog();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private p.SetErrorCode CheckSetting()
        {

            switch (LoginDevice)
            {
                case Vendor.Cammpro:
                    switch (LoginModel)
	                        {
                                case Model.H6:
                                    break;
                                case Model.H8:
                                    break;
                                case Model.G5:
                                    break;
                                case Model.G9:
                                     if (p.SetWiFi == "1")
                                        {
                                            if (string.IsNullOrEmpty(p.WiFiSSID))
                                                return p.SetErrorCode.WIFISSID;
                                            if (string.IsNullOrEmpty(p.WiFiPwd))
                                                return p.SetErrorCode.WIFIPWD;
                                         }
                                     if (p.SetCMSV6 == "1")
                                         {
                                            if (string.IsNullOrEmpty(p.CMSV6IP))
                                                return p.SetErrorCode.CMSV6IP;
                                         }
                                    break;
                                default:
                                    break;
	                        } 
                    break;

                case Vendor.EasyStorage:
                    switch (LoginModel)
	                        {
                                case Model.H6:
                                    break;
                                case Model.H8:
                                    break;
                                case Model.G5:
                                     if (p.SetWiFi == "1")
                                          {
                                             if (string.IsNullOrEmpty(p.WiFiSSID))
                                                   return p.SetErrorCode.WIFISSID ;
  
                                             if (string.IsNullOrEmpty(p.WiFiPwd))
                                                   return p.SetErrorCode.WIFIPWD;

                                            }
                                            if (p.SetCMSV6 == "1")
                                            {
                                                if (string.IsNullOrEmpty(p.CMSV6IP))
                                                    return p.SetErrorCode.CMSV6IP;
              
                                                if (string.IsNullOrEmpty(p.CMSV6ReportTime))
                                                    return p.SetErrorCode.CMSV6RerpotTime;
     
                                            }
                                            //if (p.SetAPN == "1")                   //允许为空
                                            //{
                                            //    if (string.IsNullOrEmpty (p.APN ))
                                            //        return p.SetErrorCode.APN;
                                            //}
                                            if (p.SetCheckNet == "1")
                                            {
                                                if (string.IsNullOrEmpty(p.NetCheckIP))
                                                    return p.SetErrorCode.CheckNetIP;
                                                if (string.IsNullOrEmpty(p.NetCheckPort))
                                                    return p.SetErrorCode.CheckNetPort;
                                            }

                                            if (p.SetGB28181 == "1")
                                            {
                                                if (string.IsNullOrEmpty (p.GB2_ServIP))
                                                    return p.SetErrorCode.GB2_IP;
                                                if (string.IsNullOrEmpty(p.GB2_ServPort))
                                                    return p.SetErrorCode.GB2_Port;
                                                if (string.IsNullOrEmpty(p.GB2_DevNo))
                                                    return p.SetErrorCode.GB2_DevNo;
                                                if (string.IsNullOrEmpty(p.GB2_ChnNo))
                                                    return p.SetErrorCode.GB2_ChnNo;
                                                if (string.IsNullOrEmpty(p.GB2_Passwd))
                                                    return p.SetErrorCode.GB2_Passwd;
                                            }
                                           
                                    break;
                                case Model.G9:
                                    break;
                                default:
                                    break;
	                        }
                    break;
                default:
                    break;
            }

            return p.SetErrorCode.OK;
        }

        private void btnOnlyOnce_Click(object sender, EventArgs e)
        {
           

            int Init_Device_iRet = -1;
            byte[] _IDCode = new byte[5];
             DeviceInfo DI = new DeviceInfo();
            p.CheckParamErrorCode = CheckSetting();
         

            if (p.CheckParamErrorCode == p.SetErrorCode.OK)
            {

                if (LoginDevice == Vendor.Cammpro)
                {
                    DevicePwd = "000000";
                }

                else
                {
                    Init_Device_iRet = BODYCAMDLL_API_YZ.BC_ProbeDevEx(out _IDCode[0]);
                    DevicePwd = "888888";
                    BCHandle = BODYCAMDLL_API_YZ.BC_InitDevEx(_IDCode);
                    IDCode = System.Text.Encoding.Default.GetString(_IDCode, 0, _IDCode.Length);
                    if (BCHandle != IntPtr.Zero)
                    {
                       
                        GetDeviceInfo(LoginDevice, DevicePwd, out DI);
                        updateMessage(lstMsg, "检测到设备" + IDCode + ",SN:" + DI.cSerial);
                        p.WriteLog ("检测到设备" + IDCode + ",SN:" + DI.cSerial);   
                    }
                    else
                        return;
                }

                //
                if (p.SyncTime == "1")
                {
                    updateMessage(lstMsg,DI.cSerial + ":准备开始同步时间");
                    p.WriteLog(DI.cSerial + ":准备开始同步时间");
                    if (SyncDeviceTime(LoginDevice, DevicePwd))
                    {
                        updateMessage(lstMsg, DI.cSerial + ":同步设备时间成功.（" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ")");
                        p.WriteLog(DI.cSerial + ":同步设备时间成功.（" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ")");
                    }
                    else
                    {
                        updateMessage(lstMsg, DI.cSerial + ":同步设备时间失败.");
                        p.WriteLog(DI.cSerial + ":同步设备时间失败.");
                    }
                }
                //WiFi
                if (p.SetWiFi == "1")
                {
                    updateMessage(lstMsg,DI.cSerial + ":准备开始设置WiFi信息");
                    p.WriteLog(DI.cSerial + ":准备开始设置WiFi信息");
                    WiFi _wifi = new WiFi();
                    _wifi.WiFiSSID = p.WiFiSSID;
                    _wifi.WiFiPassword = p.WiFiPwd;
                    if (SetWiFiInfo(LoginDevice, DevicePwd, _wifi))
                    {
                        updateMessage(lstMsg, DI.cSerial + ":设置执法仪WiFi信息成功，SSID:" + p.WiFiSSID + ",Pwd:" + p.WiFiPwd);
                        p.WriteLog(DI.cSerial + ":设置执法仪WiFi信息成功，SSID:" + p.WiFiSSID + ",Pwd:" + p.WiFiPwd);
                    }
                    else
                    {
                        updateMessage(lstMsg,DI.cSerial + ":设置执法仪WiFi信息失败.");
                        p.WriteLog(DI.cSerial + ":设置执法仪WiFi信息失败.");
                    }
                }
                // CMSV6
                if (p.SetCMSV6 == "1")
                {
                    updateMessage(lstMsg, DI.cSerial +":准备开始设置CMSV6服务器信息");
                    p.WriteLog(DI.cSerial + ":准备开始设置CMSV6服务器信息");
                    CMCSV6Server cs6 = new CMCSV6Server();
                    cs6.ServerIP = p.CMSV6IP;
                    cs6.ServerPort = p.CMSV6Port;
                    cs6.ReportTime = Convert.ToInt16(p.CMSV6ReportTime);
                    if (SetCMSV6Info(LoginDevice, DevicePwd, cs6))
                    {
                        updateMessage(lstMsg,DI.cSerial + ":设置CMSV6类型服务器信息成功,IP:" + p.CMSV6IP + ",Port:" + p.CMSV6Port);
                        p.WriteLog(DI.cSerial + ":设置CMSV6类型服务器信息成功,IP:" + p.CMSV6IP + ",Port:" + p.CMSV6Port);
                    }
                }


                //APN
                if (p.SetAPN == "1")
                {
                    updateMessage(lstMsg, DI.cSerial +":准备开始设置APN信息");
                    p.WriteLog(DI.cSerial + ":准备开始设置APN信息");
                    APN apn = new APN();
                    apn.ApnName = p.APN;
                    apn.ApnUser = p.APNUser;
                    apn.ApnPwd = p.APNPwd;
                    if (SetAPNInfo(LoginDevice, DevicePwd, apn))
                    {
                        updateMessage(lstMsg,DI.cSerial + ":设置执法仪APN信息成功.");
                        p.WriteLog(DI.cSerial + ":设置执法仪APN信息成功.");
                    }
                }





                //GB28181
                if (p.SetGB28181 == "1")
                {
                    updateMessage(lstMsg, DI.cSerial +":准备开始设置GB28181服务器信息");
                    p.WriteLog(DI.cSerial + ":准备开始设置GB28181服务器信息");
                    GB28181Server gb2 = new GB28181Server();
                    gb2.ChannelID = p.GB2_ChnNo;
                    gb2.ChannelName = p.GB2_ChnName;
                    gb2.ServerIP = p.GB2_ServIP;
                    gb2.ServerPort = p.GB2_ServPort;
                    gb2.ServerPassword = p.GB2_Passwd;
                    gb2.DeviceID = p.GB2_DevNo;
                    gb2.ServerID = p.GB2_ServNo;
                    gb2.Enable = Convert.ToInt16(p.GB2_Enable);
                    if (SetGB28181Info(LoginDevice, DevicePwd, gb2))
                    {
                        updateMessage(lstMsg,DI.cSerial+ ":设置GB28181类型服务器信息成功.");
                        p.WriteLog(DI.cSerial + ":设置GB28181类型服务器信息成功.");
                    }
                }


                //CheckNet
                if (p.SetCheckNet == "1")
                {
                    updateMessage(lstMsg, DI.cSerial +":准备开始设置网络检查服务器信息");
                    p.WriteLog(DI.cSerial + ":准备开始设置网络检查服务器信息");
                    NetCheckServer nc = new NetCheckServer();
                    nc.IP = p.NetCheckIP;
                    nc.Port = p.NetCheckPort;
                    nc.Enable = Convert.ToInt16(p.NetCheckEnable);
                    if (SetNetCheckServerInfo(LoginDevice, DevicePwd, nc))
                    {
                        updateMessage(lstMsg, DI.cSerial +":设置NetCheck Server类型服务器信息成功.");
                        p.WriteLog(DI.cSerial + ":设置NetCheck Server类型服务器信息成功.");
                    }
                }


                //SetGPS
                if (p.SetGPS == "1")
                {
                    if (SetGPSInfo(LoginDevice, DevicePwd, p.GPS))
                    {
                        if (p.GPS == "1")
                        {
                            updateMessage(lstMsg,DI.cSerial + ":设置GPS状态(打开)成功.");
                            p.WriteLog(DI.cSerial + ":设置GPS状态(打开)成功.");
                        }
                        if (p.GPS == "0")
                        {
                            updateMessage(lstMsg, DI.cSerial +":设置GPS状态(关闭)成功.");
                            p.WriteLog(DI.cSerial + ":设置GPS状态(关闭)成功.");
                        }
                    }
                }

                //shutdown
                if (p.SetPowerOff == "1")
                {
                   if ( BODYCAMDLL_API_YZ.BC_CtrlPowerOff(BCHandle, DevicePwd) ==1)
                   {
                       updateMessage(lstMsg, DI.cSerial + ":设备已关机");
                       p.WriteLog(DI.cSerial + ":设备已关机");
                   };
                }


                if (LoginDevice ==Vendor .EasyStorage)
                    BODYCAMDLL_API_YZ.BC_UnInitDevEx(BCHandle);
                updateMessage(lstMsg,DI.cSerial + ":已完成配置,请拔出设备");
                p.WriteLog(DI.cSerial + ":已完成配置,请拔出设备");
                


            }
            else
            {
                MessageBox.Show("参数设置不能为空,请重新设置.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Form f = new frmSetting();
                f.ShowDialog();
            }

        }




        #region 更新信息
        /// <summary>
        /// 更新信息到listbox中
        /// </summary>
        /// <param name="listbox">listbox name</param>
        /// <param name="message">message</param>
        public static void updateMessage(ListBox listbox, string message)
        {
            if (listbox.Items.Count > 1000)
                listbox.Items.RemoveAt(0);

            string item = string.Empty;
            //listbox.Items.Add("");
            item = DateTime.Now.ToString("HH:mm:ss") + " " + @message;
            listbox.Items.Add(item);
            if (listbox.Items.Count > 1)
            {
                listbox.TopIndex = listbox.Items.Count - 1;
                listbox.SetSelected(listbox.Items.Count - 1, true);
            }
        }
        #endregion



        #region Item

        /// <summary>
        /// 同步时间
        /// </summary>
        /// <param name="devicetype"></param>
        /// <param name="password"></param>
        /// <returns>true 成功,false 失败</returns>
        private bool SyncDeviceTime(Vendor logindevice, string password)
        {
            int SyncDevTime_iRet = -1;
            if (LoginDevice == Vendor.Cammpro)
            {
                ZFYDLL_API_MC.SyncDevTime(password, ref SyncDevTime_iRet);
                if (SyncDevTime_iRet == 5)
                    return true;
            }

            if (LoginDevice == Vendor.EasyStorage)
            {
                SyncDevTime_iRet = BODYCAMDLL_API_YZ.BC_SetDevTime(BCHandle, password);
                if (SyncDevTime_iRet == 1)
                    return true;
            }


            return false;
        }




        /// <summary>
        /// 设置WiFi信息
        /// </summary>
        /// <param name="logindevice"></param>
        /// <param name="password"></param>
        /// <param name="_wifi"></param>
        /// <returns></returns>
        private bool SetWiFiInfo(Vendor  logindevice, string password, WiFi _wifi)
        {
            if (logindevice == Vendor.EasyStorage)
            {
                //设置WiFi,WiFi是存储在一个wifi list中，故设置时，先删除所有wifi，在添加wifi，再设置wifi
                int DelApResult = BODYCAMDLL_API_YZ.BC_DelAllAp(BCHandle, password);
                if (DelApResult == 1)
                {
                    byte[] WifiSSID = new byte[32];
                    WifiSSID = Encoding.Default.GetBytes(_wifi.WiFiSSID.PadRight(32, '\0').ToArray());
                    byte[] WifiPSW = new byte[32];
                    WifiPSW = Encoding.Default.GetBytes(_wifi.WiFiPassword.PadRight(32, '\0').ToArray());
                    int AddApResult = BODYCAMDLL_API_YZ.BC_AddAp(BCHandle, password, WifiSSID, WifiPSW);
                    if (AddApResult == 1)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }

            if (logindevice == Vendor.Cammpro)
            {
                byte[] WifiSSID = new byte[50];
                int iRet_SetWifiSSID = -1;
                WifiSSID = Encoding.Default.GetBytes(_wifi.WiFiSSID.PadRight(50, '\0').ToArray());
                ZFYDLL_API_MC.SetWifiSSID(WifiSSID, password, ref iRet_SetWifiSSID);

                byte[] WifiPSW = new byte[50];
                int iRet_SetWifiPSW = -1;
                WifiPSW = Encoding.Default.GetBytes(_wifi.WiFiPassword.PadRight(50, '\0').ToArray());
                ZFYDLL_API_MC.SetWifiPSW(WifiPSW, password, ref iRet_SetWifiPSW);
                return true;
            }

            return false;
        }



        /// <summary>
        /// 设置APN信息
        /// </summary>
        /// <param name="logindevice"></param>
        /// <param name="password"></param>
        /// <param name="apn"></param>
        /// <returns></returns>
        private bool SetAPNInfo(Vendor logindevice, string password, APN apn)
        {
            if (logindevice == Vendor.EasyStorage)
            {
                int result = -1;
                byte[] Apn = new byte[64];
                byte[] ApnUser = new byte[64];
                byte[] ApnPwd = new byte[64];
                Apn = System.Text.Encoding.Default.GetBytes(apn.ApnName.PadRight(64, '\0').ToArray());
                ApnUser = System.Text.Encoding.Default.GetBytes(apn.ApnUser.PadRight(64, '\0').ToArray());
                ApnPwd = System.Text.Encoding.Default.GetBytes(apn.ApnPwd.PadRight(64, '\0').ToArray());

                result = BODYCAMDLL_API_YZ.BC_SetVpn(BCHandle, password, Apn, ApnUser, ApnPwd);
                if (result == 1)
                    return true;
            }

            //if (logindevice == DeviceType.Cammpro)
            //{
            //    byte[] APN = new byte[32];
            //    int iRet_SetAPN = -1;
            //    APN = Encoding.Default.GetBytes(apn.ApnName.PadRight(32, '\0').ToArray());
            //    ZFYDLL_API_MC.Set4GAPN(APN, password, ref iRet_SetAPN);

            //    byte[] PIN = new byte[32];
            //    int iRet_SetPIN = -1;
            //    PIN = Encoding.Default.GetBytes(apn.ApnPin.PadRight(32, '\0').ToArray());
            //    ZFYDLL_API_MC.Set4GPIN(PIN, password, ref iRet_SetPIN);

            //    //if (iRet_SetAPN == 7 && iRet_SetPIN == 7)
            //    return true;

            //}

            return false;
        }




        /// <summary>
        /// 设置CMSV6信息
        /// </summary>
        /// <param name="logindevice"></param>
        /// <param name="password"></param>
        /// <param name="cs6"></param>
        /// <returns></returns>
        private bool SetCMSV6Info(Vendor logindevice, string password, CMCSV6Server cs6)
        {

            if (logindevice == Vendor.Cammpro)
            {
                byte[] IP = new byte[50];
                int iRet_ReadServerIP = -1;
                IP = Encoding.Default.GetBytes(cs6.ServerIP.PadRight(50, '\0').ToArray());
                ZFYDLL_API_MC.SetServerIP(IP, password, ref iRet_ReadServerIP);

                byte[] Port = new byte[50];
                int iRet_SetServerPort = -1;
                Port = Encoding.Default.GetBytes(cs6.ServerPort.PadRight(50, '\0').ToArray());
                ZFYDLL_API_MC.SetServerPort(Port, password, ref iRet_SetServerPort);
                return true;
            }

            if (logindevice == Vendor.EasyStorage)
            {
                int result = -1;
                byte[] IP = new byte[50];
                IP = Encoding.Default.GetBytes(cs6.ServerIP.PadRight(50, '\0').ToArray());
                byte[] Port = new byte[50];
                Port = Encoding.Default.GetBytes(cs6.ServerPort.PadRight(50, '\0').ToArray());
                byte[] DevID = new byte[32];
                DevID = System.Text.Encoding.Default.GetBytes(cs6.DevNo.PadRight(32, '\0').ToArray());
                result = BODYCAMDLL_API_YZ.BC_SetCmsv6Cfg(BCHandle, password, cs6.Enable, IP, Port, DevID, cs6.ReportTime);
                if (result == 1)
                    return true;
            }

            return false;
        }


        /// <summary>
        /// 设置GB28181信息
        /// </summary>
        /// <param name="logindevice"></param>
        /// <param name="password"></param>
        /// <param name="gb2"></param>
        /// <returns></returns>
        private bool SetGB28181Info(Vendor  logindevice, string password, GB28181Server gb2)
        {

            if (logindevice == Vendor.EasyStorage)
            {
                int result = -1;
                byte[] ServIP = new byte[16];
                ServIP = Encoding.Default.GetBytes(gb2.ServerIP.PadRight(16, '\0').ToArray());
                byte[] ServPort = new byte[16];
                ServPort = Encoding.Default.GetBytes(gb2.ServerPort.PadRight(16, '\0').ToArray());
                byte[] DevID = new byte[32];
                DevID = Encoding.Default.GetBytes(gb2.DeviceID.PadRight(32, '\0').ToArray());
                byte[] ChnNo = new byte[32];
                ChnNo = Encoding.Default.GetBytes(gb2.ChannelID.PadRight(32, '\0').ToArray());
                byte[] ChnName = new byte[32];
                ChnName = Encoding.Default.GetBytes(gb2.ChannelName.PadRight(32, '\0').ToArray());
                byte[] ServNo = new byte[32];
                ServNo = Encoding.Default.GetBytes(gb2.ServerID.PadRight(32, '\0').ToArray());
                byte[] ServPwd = new byte[32];
                ServPwd = Encoding.Default.GetBytes(gb2.ServerPassword.PadRight(32, '\0').ToArray());

                result = BODYCAMDLL_API_YZ.BC_SetGb28181Cfg(BCHandle, password, gb2.Enable, ServIP,
                    ServPort, DevID, ChnNo, ChnName, ServNo, ServPwd);
                if (result == 1)
                    return true;
            }

            //cammpro 不支持

            return false;
        }



        /// <summary>
        /// 设置检查网络
        /// </summary>
        /// <param name="logindevice"></param>
        /// <param name="password"></param>
        /// <param name="nc"></param>
        /// <returns></returns>
        private bool SetNetCheckServerInfo(Vendor logindevice, string password, NetCheckServer nc)
        {
            if (logindevice == Vendor.EasyStorage)
            {
                int result = -1;
                byte[] ServIP = new byte[16];
                ServIP = Encoding.Default.GetBytes(nc.IP.PadRight(16, '\0').ToArray());
                byte[] ServPort = new byte[16];
                ServPort = Encoding.Default.GetBytes(nc.Port.PadRight(16, '\0').ToArray());
                result = BODYCAMDLL_API_YZ.BC_SetNetCheckServCfg(BCHandle, password, nc.Enable, ServIP, ServPort);
                if (result == 1)
                    return true;

            }

            // cammpro 不支持

            return false;
        }



        /// <summary>
        /// 设置GPS开关
        /// </summary>
        /// <param name="logindevice"></param>
        /// <param name="password"></param>
        /// <param name="gpsstate"></param>
        /// <returns></returns>
        private bool SetGPSInfo(Vendor logindevice, string password, string gpsstate)
        {
            if (logindevice == Vendor.EasyStorage)
            {
                int result = -1;
                result = BODYCAMDLL_API_YZ.BC_SetDevGpsEn(BCHandle, password, Convert.ToInt16(gpsstate));
                if (result == 1)
                    return true;
            }

            return false;
        }



        /// <summary>
        /// 获取设备硬件信息,序列号等
        /// </summary>
        /// <param name="devicetype"></param>
        /// <param name="password"></param>
        /// <param name="deviceinfo"></param>
        /// <returns>true 成功,false 不成功</returns>
        private bool GetDeviceInfo(Vendor devicetype, string password, out DeviceInfo deviceinfo)
        {

            deviceinfo = new DeviceInfo();
            int GetZFYInfo_iRet = -1;
            if (LoginDevice == Vendor.Cammpro)
            {
                ZFYDLL_API_MC.ZFY_INFO uuDevice = new ZFYDLL_API_MC.ZFY_INFO();//执法仪结构信息定义
                ZFYDLL_API_MC.GetZFYInfo(ref uuDevice, password, ref GetZFYInfo_iRet);
                if (GetZFYInfo_iRet == 1)
                {

                    deviceinfo.cSerial = System.Text.Encoding.Default.GetString(uuDevice.cSerial);
                    deviceinfo.userNo = System.Text.Encoding.Default.GetString(uuDevice.userNo);
                    deviceinfo.userName = System.Text.Encoding.Default.GetString(uuDevice.userName);
                    deviceinfo.unitNo = System.Text.Encoding.Default.GetString(uuDevice.unitNo);
                    deviceinfo.unitName = System.Text.Encoding.Default.GetString(uuDevice.unitName);
                    return true;
                }
                else
                    return false;
            }
            if (LoginDevice == Vendor .EasyStorage)
            {
                //BODYCAMDLL_API_YZ.ZFY_INFO uuDevice = new BODYCAMDLL_API_YZ.ZFY_INFO();//执法仪结构信息定义
                BODYCAMDLL_API_YZ.ZFY_INFO_N uuDevice = new BODYCAMDLL_API_YZ.ZFY_INFO_N();
                GetZFYInfo_iRet = BODYCAMDLL_API_YZ.BC_GetDevInfo(BCHandle, password, out uuDevice);
                // BODYCAMDLL_API_YZ.GetZFYInfo(ref uuDevice, password, ref GetZFYInfo_iRet);
                if (GetZFYInfo_iRet == 1)
                {

                    deviceinfo.cSerial = uuDevice.cSerial;
                    deviceinfo.userNo = uuDevice.userNo;
                    deviceinfo.userName = uuDevice.userName;
                    deviceinfo.unitNo = uuDevice.unitNo;
                    deviceinfo.unitName = uuDevice.unitName;
                    return true;
                }
                else
                    return false;
            }
            return false;

        }



        #endregion

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bRestart)
            {
                //ezUSB.RemoveUSBEventWatcher();
                //Environment.Exit(0);
            }
            else
            {
                DialogResult dr = MessageBox.Show("是否确认退出软件,退出点击是(Y),不退出点击否(N)?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                   // ezUSB.RemoveUSBEventWatcher();
                    Environment.Exit(0);
                }
                else
                    e.Cancel = true;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否确认重启软件,退出点击是(Y),不退出点击否(N)?", "Restart?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bRestart = true;
               // ezUSB.RemoveUSBEventWatcher();
                Application.Restart();

            }
        }
    }
}
