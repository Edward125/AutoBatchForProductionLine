using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Edward;
using System.Drawing;
using System.IO;
using System.Reflection;

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

            if (!File.Exists(@".\logo1.png"))
            {
                //Assembly assem = this.GetType().Assembly;
                Assembly assem = System.Reflection.Assembly.GetEntryAssembly();
                Stream stream = assem.GetManifestResourceStream("AutoBatchForProductionLine.Resources.logo1.png");
                System.Drawing.Image.FromStream(stream).Save("logo1.png");
            }


            SplashForm.StartSplash(@".\logo1.png", Color.FromArgb(128, 128, 128));
            // simulating operations at startup
            System.Threading.Thread.Sleep(1000);
            // close the splash screen
            SplashForm.CloseSplash();

        }
    }
}
