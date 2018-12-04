using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Edward;
using SDK;
using System.Data.SQLite;


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
        public static string SetSN = "0";
        public static string SetWiFi = "0";
        public static string SetAPN = "0";
        public static string SetCMSV6 = "0";
        public static string SetGB28181 = "0";
        public static string SetCheckNet = "0";
        public static string SetGPS = "0";
        public static string SetFormat = "0";
        public static string SetUpdate = "0";
        public static string SetPowerOff = "0";



        //SN
        public static string StartSN = "0000000";
        public static string EndSN = "0000000";
        public static string SN_userNo = "000000";
        public static string SN_userName = string.Empty;
        public static string SN_unitNo = string.Empty;
        public static string SN_unitName = string.Empty;

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
        public static string NetCheckEnable = "1";
        //SetFormat
        public static string Format = "exFAT";
        //
        public static string BinFile = string.Empty;
        //GPS
        public static string GPS = "0";
        //PowerOff
        public static string PowerOff = "0";

        public static BODYCAMDLL_API_YZ.FSTYPE_E FsType = BODYCAMDLL_API_YZ.FSTYPE_E.FS_EXFAT;

        //DB

        public static string dbFile = AppFolder + @"\sn.sqlite";
        public static string dbConnectionString = "Data Source=" + @dbFile;
        

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
            StartSNEmpty,
            EndSNEmpty,
            StartSNStartNotMatch,
            EndSNStartNotMacth,
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

            checkDB(dbFile);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        public static void WriteLog(string log)
        {
            string logfile = LogFolder + @"\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            try
            {
                StreamWriter sw = new StreamWriter(logfile, true);
                log = DateTime.Now.ToString("HH:mm:ss") + "->" + log;
                sw.WriteLine(log);
                sw.Close();
            }
            catch (Exception)
            {
                
                //throw;
            }


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
                IniFile.IniWriteValue("SysConfig", "SetSN", p.SetSN);
                IniFile.IniWriteValue("SysConfig", "SetWiFi", SetWiFi);
                IniFile.IniWriteValue("SysConfig", "SetAPN", SetAPN);
                IniFile.IniWriteValue("SysConfig", "SetCMSV6", SetCMSV6);
                IniFile.IniWriteValue("SysConfig", "SetGB28181", SetGB28181);
                IniFile.IniWriteValue("SysConfig", "SetCheckNet",SetCheckNet);
                IniFile.IniWriteValue("SysConfig", "SetGPS", SetGPS);
                IniFile.IniWriteValue("SysConfig", "SetFormat", p.SetFormat);
                IniFile.IniWriteValue("SysConfig", "SetUpdate", p.SetUpdate);
                IniFile.IniWriteValue("SysConfig", "SetPowerOff", SetPowerOff);
                //
                IniFile.IniWriteValue("SN", "StartSN", StartSN);
                IniFile.IniWriteValue("SN", "EndSN", EndSN);
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
                IniFile.IniWriteValue("Format", "Format", Format);
                //
                IniFile.IniWriteValue("Update", "BinFile", BinFile);
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
                SetSN = IniFile.IniReadValue("SysConfig", "SetSN");
                SetWiFi = IniFile.IniReadValue("SysConfig", "SetWiFi");
                SetAPN = IniFile.IniReadValue("SysConfig", "SetAPN");
                SetCMSV6 = IniFile.IniReadValue("SysConfig", "SetCMSV6");
                SetGB28181 = IniFile.IniReadValue("SysConfig", "SetGB28181");
                SetCheckNet = IniFile.IniReadValue("SysConfig", "SetCheckNet");
                SetGPS = IniFile.IniReadValue("SysConfig", "SetGPS");
                SetFormat = IniFile.IniReadValue("SysConfig", "SetFormat");
                SetUpdate = IniFile.IniReadValue("SysConfig", "SetUpdate");
                SetPowerOff = IniFile.IniReadValue("SysConfig", "SetPowerOff");
                //
                StartSN = IniFile.IniReadValue("SN", "StartSN");
                EndSN = IniFile.IniReadValue("SN", "EndSN");
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
               Format = IniFile.IniReadValue("Format", "Format");
                //
               BinFile = IniFile.IniReadValue("Update", "BinFile");
               //
               PowerOff = IniFile.IniReadValue("PowerOff", "PowerOff");
           
            }

        }



        /// <summary>
        /// check db file ,if not exits,create it
        /// </summary>
        /// <param name="_dbfile">db file path</param>
        /// <returns></returns>
        public static bool checkDB(string _dbfile)
        {
            if (!File.Exists(_dbfile))
            {
                try
                {
                    SQLiteConnection.CreateFile(_dbfile);

                    if (!p.createAllTable())
                        Environment.Exit(0);
                  //  p.writeDefaultData();


                    return true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Create DB Fail." + ex.Message, "Create DB Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    WriteLog("Create DB Fail." + ex.Message);
                    return false;
                }


            }
            return true;
        }




        /// <summary>
        /// create all defaul tables
        /// </summary>
        public static bool createAllTable()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS h6sn(
sn varchar(7) PRIMARY KEY NOT NULL,
usedtime varchar(14) NOT NULL,
remark varchar(255) NULL)";
            if (!p.createTable(sql))
                return false;

//            sql = @"CREATE TABLE IF NOT EXISTS h8sn(
//sn varchar(7) PRIMARY KEY NOT NULL,
//usedtime varchar(14) NOT NULL,
//remark varchar(255) NULL,
//)";
//            if (!p.createTable(sql))
//                return false;

//            sql = @"CREATE TABLE IF NOT EXISTS g5sn(
//sn varchar(7) PRIMARY KEY NOT NULL,
//usedtime varchar(14) NOT NULL,
//remark varchar(255) NULL,
//)";
//            if (!p.createTable(sql))
//                return false;

            sql = @"CREATE TABLE IF NOT EXISTS g9sn(
sn varchar(7) PRIMARY KEY NOT NULL,
usedtime varchar(14) NOT NULL,
remark varchar(255) NULL
)";
            if (!p.createTable(sql))
                return false;


            return true;


        }

        // string sql = "create table highscores (name varchar(20), score int)";
        /// <summary>
        /// create table 
        /// </summary>
        /// <param name="sql">sql</param>
        /// <returns>create ok,return true;create ng,return false</returns>
        public static bool createTable(string sql)
        {
            SQLiteConnection conn = new SQLiteConnection(dbConnectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Connect to database fail," + ex.Message);
                WriteLog("Connect to database fail," + ex.Message);
                return false;
            }

            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Create TABLE fail," + ex.Message);
                WriteLog("Create TABLE fail," + ex.Message);
                conn.Close();
                return false;

            }

            return true;
        }


        /// <summary>
        /// update data to sqlite
        /// </summary>
        /// <param name="sql">sql</param>
        /// <returns>success,return true;fail,return false</returns>
        public static bool updateData2DB(string sql)
        {
            SQLiteConnection conn = new SQLiteConnection(dbConnectionString);

            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                //cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Execute sql: " + sql + " fail," + ex.Message);
                WriteLog("Execute sql: " + sql + " fail," + ex.Message);
                return false;
            }
            return true;
        }



        /// <summary>
        /// update data to sqlite
        /// </summary>
        /// <param name="sql">sql</param>
        /// <returns>success,return true;fail,return false</returns>
        public static bool queryDatafromDB(string sql,string key,out string result)
        {
            result = string.Empty;
            SQLiteConnection conn = new SQLiteConnection(dbConnectionString);

            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result = reader[key].ToString();
                    }
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Execute sql: " + sql + " fail," + ex.Message);
                WriteLog("Execute sql: " + sql + " fail," + ex.Message);
                return false;
            }
            return true;
        }


    }
}
