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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        #region 参数定义


        private static Vendor LoginDevice;  //当前设备的方案商
        private static Model LoginModel;//当前设备的型号

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
            if (!string.IsNullOrEmpty(p.CurrentDevice))
                comboBodyType.Text = p.CurrentDevice;
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
                                            if (p.SetAPN == "1")
                                            {
                                                if (string.IsNullOrEmpty (p.APN ))
                                                    return p.SetErrorCode.APN;
                                            }
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
            p.CheckParamErrorCode = CheckSetting();
            if (p.CheckParamErrorCode == p.SetErrorCode.OK)
            {
            }
            else
            {
                MessageBox.Show("参数设置不能为空,请重新设置.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Form f = new frmSetting();
                f.ShowDialog();
            }



        }
    }
}
