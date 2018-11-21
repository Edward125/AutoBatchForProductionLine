﻿using System;
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
        //GB28181
        public static string GB2_ServIP = string.Empty;
        public static string GB2_ServPort = string.Empty;
        public static string GB2_DevNo = string.Empty;    //设备ID
        public static string GB2_ChnNo = string.Empty;   //设备通道ID
        public static string GB2_ServNo = string.Empty; //服务器ID
        public static string GB2_Passwd = string.Empty;
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
            if (!Directory.Exists(AppFolder))
                Directory.CreateDirectory(AppFolder);

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
                //
                IniFile.IniWriteValue("NetCheck", "NetCheckIP", NetCheckIP);
                IniFile.IniWriteValue("NetCheck", "NetCheckPort", NetCheckPort);
                //
                IniFile.IniWriteValue("GPS", "GPS", GPS);
                //
                IniFile.IniWriteValue("PowerOff", "PowerOff", PowerOff);


            }

        }




    }
}
