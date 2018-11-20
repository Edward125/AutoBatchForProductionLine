using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Edward;

namespace AutoBatchForProductionLine
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());

            SplashForm.StartSplash(@".\splash.bmp", Color.FromArgb(128, 128, 128));
            // simulating operations at startup
            System.Threading.Thread.Sleep(1000);
            // close the splash screen
            SplashForm.CloseSplash();

        }
    }
}
