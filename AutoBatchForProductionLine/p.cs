using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoBatchForProductionLine
{
    class p
    {


        public static string AppFolder = Application.StartupPath +"自动生产工具";
        public static string IniPath = AppFolder + @"\SysConfig";
        //SysConfig
        public static string CurrentDevice = string.Empty ; //当前选择的执法仪
        public static string SyncTime = "0";
        public static string SetWiFi = "0";
        public static string SetAPN = "0";
        public static string SetCMSV6 = "0";
        public static string SetGB28181 = "0";
        public static string SetCheckNet = "0";
        public static string SetGPS = "0";
        public static string SetPowerOff = "0";
        //WiFi
        public static string WiFiSSID = string.Empty;
        public static string WiFiPwd = string.Empty;
        //APN
        public static string APN = string.Empty;
        public static string APNUser = string.Empty;
        public static string APNPwd = string.Empty;
        //CMSV6
        public static string CMSV6IP = string.Empty;
        public static string CMSV6Port = string.Empty;
        public static string CMSV6ReportTime = string.Empty;
        //NetCheck
        public static string NetCheckIP = "127.0.0.1";
        public static string NetCheckPort = "554";
        //GPS
        public static string GPS = "0";
        //PowerOff
        public static string PowerOff = "0";



        /// <summary>
        /// 
        /// </summary>
        public static void CreateFolder()
        {

        }




    }
}
