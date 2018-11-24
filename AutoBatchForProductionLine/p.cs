using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Edward;


namespace AutoBatchForProductionLine
{
    class p
    {


        public static string AppFolder = Application.StartupPath +@"\自动生产工具";
        public static string LogFolder = AppFolder  + @"\Log";
        public static string IniPath = AppFolder + @"\SysConfig.ini";
        
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
        public static string CMSV6ReportTime = "50";
        //GB28181
        public static string GB2_ServIP = string.Empty;
        public static string GB2_ServPort = string.Empty;
        public static string GB2_DevNo = string.Empty;    //设备ID
        public static string GB2_ChnNo = string.Empty;   //设备通道ID
        public static string GB2_ServNo = string.Empty; //服务器ID
        public static string GB2_Passwd = string.Empty;
        public static string GB2_ChnName = string.Empty;
        public static string GB2_Enable = "0";          //使能
        //NetCheck
        public static string NetCheckIP = "127.0.0.1";
        public static string NetCheckPort = "554";
        public static string NetCheckEnable = "0";
        //GPS
        public static string GPS = "0";
        //PowerOff
        public static string PowerOff = "0";

        public static SetErrorCode CheckParamErrorCode;

        public   enum SetErrorCode
        {
            OK = 0,
            WIFISSID,
            WIFIPWD,
            CMSV6IP,
            CMSV6RerpotTime,
            APN,
            APNUser,
            APNPwd,
            CheckNetIP,
            CheckNetPort,
            GB2_IP,
            GB2_Port,
            GB2_DevNo,
            GB2_ChnNo,
            GB2_SerNo,
            GB2_Passwd


        }


        /// <summary>
        /// 
        /// </summary>
        public static void CreateFolder()
        {
            if (!Directory.Exists(AppFolder))
                Directory.CreateDirectory(AppFolder);
            if (!Directory.Exists(LogFolder))
                Directory.CreateDirectory(LogFolder);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        public static void WriteLog(string log)
        {
            string logfile = LogFolder + @"\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            StreamWriter sw = new StreamWriter(logfile, true);
            log = DateTime .Now.ToString ("hh:mm:ss") +"->" +log;
            sw.WriteLine(log);
            sw.Close();

        }



        public static void CreateIni()
        {
            IniFile.iniFilePathValue = IniPath;
            if (!File.Exists(IniPath))
            {
                IniFile.CreateIniFile(IniPath);
                //SysConfig
                IniFile.IniWriteValue("SysConfig", "Version", Application.ProductVersion);
                IniFile.IniWriteValue("SysConfig", "CurrentDevice", CurrentDevice);
                IniFile.IniWriteValue("SysConfig", "SyncTime", SyncTime);
                IniFile.IniWriteValue("SysConfig", "SetWiFi", SetWiFi);
                IniFile.IniWriteValue("SysConfig", "SetAPN", SetAPN);
                IniFile.IniWriteValue("SysConfig", "SetCMSV6", SetCMSV6);
                IniFile.IniWriteValue("SysConfig", "SetGB28181", SetGB28181);
                IniFile.IniWriteValue("SysConfig", "SetCheckNet",SetCheckNet);
                IniFile.IniWriteValue("SysConfig", "SetGPS", SetGPS);
                IniFile.IniWriteValue("SysConfig", "SetPowerOff", SetPowerOff);
                //
                IniFile.IniWriteValue("WiFi", "WiFiSSID", WiFiSSID);
                IniFile.IniWriteValue("WiFi", "WiFiSSID", WiFiPwd);
                //
                IniFile.IniWriteValue("APN", "APN", APN);
                IniFile.IniWriteValue("APN", "APNUser", APNUser);
                IniFile.IniWriteValue("APN", "APNPwd", APNPwd);
                //
                IniFile.IniWriteValue("CMSV6", "CMSV6IP", CMSV6IP);
                IniFile.IniWriteValue("CMSV6", "CMSV6Port", CMSV6Port);
                IniFile.IniWriteValue("CMSV6", "CMSV6ReportTime", CMSV6ReportTime);
                //
                IniFile.IniWriteValue("GB28181", "GB2_ServIP", GB2_ServIP);
                IniFile.IniWriteValue("GB28181", "GB2_ServPort", GB2_ServPort);
                IniFile.IniWriteValue("GB28181", "GB2_DevNo", GB2_DevNo);
                IniFile.IniWriteValue("GB28181", "GB2_ChnNo", GB2_ChnNo);
                IniFile.IniWriteValue("GB28181", "GB2_ServNo", GB2_ServNo);
                IniFile.IniWriteValue("GB28181", "GB2_Passwd", GB2_Passwd);
                IniFile.IniWriteValue("GB28181", "GB2_ChnName", GB2_ChnName);
                IniFile.IniWriteValue("GB28181", "GB2_Enable", GB2_Enable);
                //
                IniFile.IniWriteValue("NetCheck", "NetCheckIP", NetCheckIP);
                IniFile.IniWriteValue("NetCheck", "NetCheckPort", NetCheckPort);
                IniFile.IniWriteValue("NetCheck", "NetCheckEnable", NetCheckEnable);
                //
                IniFile.IniWriteValue("GPS", "GPS", GPS);
                //
                IniFile.IniWriteValue("PowerOff", "PowerOff", PowerOff);


            }

        }

        public static void ReadIni()
        {
            IniFile.iniFilePathValue = IniPath;
            if (File.Exists(IniPath))
            {
                CurrentDevice = IniFile.IniReadValue("SysConfig", "CurrentDevice");
                SyncTime = IniFile.IniReadValue("SysConfig", "SyncTime");
                SetWiFi = IniFile.IniReadValue("SysConfig", "SetWiFi");
                SetAPN = IniFile.IniReadValue("SysConfig", "SetAPN");
                SetCMSV6 = IniFile.IniReadValue("SysConfig", "SetCMSV6");
                SetGB28181 = IniFile.IniReadValue("SysConfig", "SetGB28181");
                SetCheckNet = IniFile.IniReadValue("SysConfig", "SetCheckNet");
                SetGPS = IniFile.IniReadValue("SysConfig", "SetGPS");
                SetPowerOff = IniFile.IniReadValue("SysConfig", "SetPowerOff");
                //
                WiFiSSID = IniFile.IniReadValue("WiFi", "WiFiSSID");
                WiFiPwd = IniFile.IniReadValue("WiFi", "WiFiPwd");
                //
                APN = IniFile.IniReadValue("APN", "APN");
                APNUser = IniFile.IniReadValue("APN", "APNUser");
                APNPwd = IniFile.IniReadValue("APN", "APNPwd");
                //
               CMSV6IP = IniFile.IniReadValue("CMSV6", "CMSV6IP");
               CMSV6Port = IniFile.IniReadValue("CMSV6", "CMSV6Port" );
               CMSV6ReportTime = IniFile.IniReadValue("CMSV6", "CMSV6ReportTime");
                //
               GB2_ServIP = IniFile.IniReadValue("GB28181", "GB2_ServIP");
               GB2_ServPort = IniFile.IniReadValue("GB28181", "GB2_ServPort");
               GB2_DevNo = IniFile.IniReadValue("GB28181", "GB2_DevNo");
               GB2_ChnNo = IniFile.IniReadValue("GB28181", "GB2_ChnNo");
               GB2_ServNo = IniFile.IniReadValue("GB28181", "GB2_ServNo");
               GB2_Passwd = IniFile.IniReadValue("GB28181", "GB2_Passwd");
               GB2_ChnName = IniFile.IniReadValue("GB28181", "GB2_ChnName");
               GB2_Enable = IniFile.IniReadValue("GB28181", "GB2_Enable");
                //
               NetCheckIP = IniFile.IniReadValue("NetCheck", "NetCheckIP");
               NetCheckPort = IniFile.IniReadValue("NetCheck", "NetCheckPort");
               NetCheckEnable = IniFile.IniReadValue("NetCheck", "NetCheckEnable");
               //
               GPS = IniFile.IniReadValue("GPS", "GPS");
               //
               PowerOff = IniFile.IniReadValue("PowerOff", "PowerOff");
            
            
            
            
            
            }

        }


    }
}
