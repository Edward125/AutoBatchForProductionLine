﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Reflection;

namespace Edward
{
    public delegate void DelegateCloseSplash();


    //
    // SplashForm.StartSplash(@".\splash.bmp", Color.FromArgb(128, 128, 128)); 
    //// simulating operations at startup
    //System.Threading.Thread.Sleep(1000);
    //// close the splash screen
    //SplashForm.CloseSplash();


    public class SplashForm : Form
    {
        #region Constructor
        public SplashForm(String imageFile, Color col)
        {
            Debug.Assert(imageFile != null && imageFile.Length > 0,
                "A valid file path has to be given");
            // ====================================================================================
            // Setup the form
            // ==================================================================================== 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.TopMost = true;

            // make form transparent
            this.TransparencyKey = this.BackColor;

            // tie up the events
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SplashForm_KeyUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SplashForm_Paint);
            this.MouseDown += new MouseEventHandler(SplashForm_MouseClick);

            // load and make the bitmap transparent
            m_bmp = new Bitmap(imageFile);

            if (m_bmp == null)
                throw new Exception("Failed to load the bitmap file " + imageFile);
            m_bmp.MakeTransparent(col);

            // resize the form to the size of the iamge
            this.Width = m_bmp.Width;
            this.Height = m_bmp.Height;

            // center the form
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // thread handling
            m_delegateClose = new DelegateCloseSplash(InternalCloseSplash);
        }
        #endregion // Constructor

        #region Public methods
        // this can be used for About dialogs
        public static void ShowModal(String imageFile, Color col)
        {
            m_imageFile = imageFile;
            m_transColor = col;
            MySplashThreadFunc();
        }


        // Call this method with the image file path and the color 
        // in the image to be rendered transparent
        public static void StartSplash(String imageFile, Color col)
        {
            m_imageFile = imageFile;
            m_transColor = col;
            // Create and Start the splash thread
            Thread InstanceCaller = new Thread(new ThreadStart(MySplashThreadFunc));
            InstanceCaller.Start();
        }


        // Call this at the end of your apps initialization to close the splash screen
        public static void CloseSplash()
        {
            if (m_instance != null)
                m_instance.Invoke(m_instance.m_delegateClose);

        }
        #endregion // Public methods

        #region Dispose
        protected override void Dispose(bool disposing)
        {
            m_bmp.Dispose();
            base.Dispose(disposing);
            m_instance = null;
        }
        #endregion // Dispose

        #region Threading code
        // ultimately this is called for closing the splash window
        void InternalCloseSplash()
        {
            this.Close();
            this.Dispose();
        }
        // this is called by the new thread to show the splash screen
        private static void MySplashThreadFunc()
        {
            m_instance = new SplashForm(m_imageFile, m_transColor);
            m_instance.TopMost = false;
            m_instance.ShowDialog();
        }
        #endregion // Multithreading code

        #region Event Handlers

        void SplashForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.InternalCloseSplash();
        }

        private void SplashForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.DrawImage(m_bmp, 0, 0);
        }

        private void SplashForm_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.InternalCloseSplash();
        }
        #endregion // Event Handlers

        #region Private variables
        private static SplashForm m_instance;
        private static String m_imageFile;
        private static Color m_transColor;
        private Bitmap m_bmp;
        private DelegateCloseSplash m_delegateClose;
        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SplashForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(535, 283);
            this.Name = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 定义一个资源文件名 资源文件名 = 工程的默认命名空间+文件名(不带扩展名)
        /// </summary>
        private string PublicResourceFileName = "AutoBatchForProductionLine.Resources";

        /// <summary>
        /// 从资源文件中读取一个资源
        /// </summary>
        /// <param name="resFile">资源文件名称 命名空间+文件名称</param>
        /// <param name="resName">要读取的资源名称</param>
        /// <returns>返回一个资源 读取失败返回NULL</returns>
        public System.Object ReadFromResourceFile(String resName)
        {

            try
            {
                Assembly myAssembly;
                myAssembly = Assembly.GetExecutingAssembly();
                System.Resources.ResourceManager rm = new
                System.Resources.ResourceManager(PublicResourceFileName, myAssembly);
                return rm.GetObject(resName);
            }
            catch (Exception)
            {
                return null;
            }

        }


        /// <summary>
        /// 获取资源图片
        /// </summary>
        /// <param name="name">文件名</param>
        /// <returns>资源图片</returns>
        public Bitmap GetResourceImage(String name)
        {
            Object tempbitmap = null;
            tempbitmap = ReadFromResourceFile(name);
            if (tempbitmap.GetType().Equals(typeof(Bitmap)))
            {
                return (Bitmap)tempbitmap;
            }
            return null;
        }
        //调用GetResourceImage方法即可。name为文件的名称不带有后缀.

    }
}
