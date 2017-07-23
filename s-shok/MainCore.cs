using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace fast_capture
{
    class MainCore
    {
        NotifyIcon tray;
        ContextMenuStrip mnu;

        preview frmPreview;
        frmSetting frmsetting;

        static public Size sz;
        static public Point xy;

        public MainCore()
        {
            tray = new NotifyIcon();
            tray.BalloonTipText = "Fast Capture";
            tray.Icon = res.ico;
            tray.Text = "Fast Captrue";

            mnu = new ContextMenuStrip();
            ToolStripMenuItem mnucapture = new ToolStripMenuItem();
            ToolStripMenuItem mnuCap1 = new ToolStripMenuItem();
            ToolStripMenuItem mnuCap2 = new ToolStripMenuItem();
            ToolStripMenuItem mnusetting = new ToolStripMenuItem();
            ToolStripMenuItem mnuexit = new ToolStripMenuItem();
            // mnucapture
            mnucapture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuCap1,
            mnuCap2});
            mnucapture.Name = "mnucapture";
            mnucapture.Size = new System.Drawing.Size(149, 22);
            mnucapture.Text = "찍기(Capture)";
            // mnuCap1
            mnuCap1.Name = "mnuCap1";
            mnuCap1.Size = new System.Drawing.Size(232, 22);
            mnuCap1.Text = "영역 찍기(Rectangle Capture)";
            mnuCap1.Click += new System.EventHandler(this.mnuCap1_Click);
            // mnuCap2
            mnuCap2.Name = "mnuCap2";
            mnuCap2.Size = new System.Drawing.Size(232, 22);
            mnuCap2.Text = "화면 찍기(Screen Capture)";
            mnuCap2.Click += new System.EventHandler(this.mnuCap2_Click);
            // mnusetting
            mnusetting.Name = "mnusetting";
            mnusetting.Size = new System.Drawing.Size(149, 22);
            mnusetting.Text = "설정(Settings)";
            mnusetting.Click += new System.EventHandler(this.mnusetting_Click);
            // mnuexit
            mnuexit.Name = "mnuexit";
            mnuexit.Size = new System.Drawing.Size(149, 22);
            mnuexit.Text = "종료(Exit)";
            mnuexit.Click += new System.EventHandler(delegate (object o, EventArgs a) { Application.Exit(); });
            mnu.Items.Add(mnucapture);
            mnu.Items.Add(mnuCap1);
            mnu.Items.Add(mnuCap2);
            mnu.Items.Add(mnusetting);
            mnu.Items.Add(mnuexit);
            tray.ContextMenuStrip = mnu;

            tray.MouseClick += new MouseEventHandler(delegate (object o, MouseEventArgs e)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    RecCapture();
            });

            tray.Visible = true;
            sz = new Size();
            xy = new Point();

            init();
        }

        void init()
        {
            //frmPreview
            frmPreview = null;
            frmsetting = null;

            //설정 불러오기
            if (File.Exists(Path.Combine(Application.StartupPath, "setting.cfc")))
            {
                StreamReader sr = new StreamReader(Path.Combine(Application.StartupPath, "setting.cfc"), Encoding.UTF8, true);
                string rr;
                string[] rr2;
                char[] param = new char[] { '*' };
                while (sr.Peek() >= 0)
                {
                    rr = sr.ReadLine();
                    rr2 = rr.Split(param);
                    switch (rr2[0])
                    {
                        case "ClickTrayIcon":
                            frmSetting.tray = Convert.ToInt16(rr2[1]);
                            break;
                        case "DefaultDirectory":
                            frmSetting.defaultdirectory = rr2[1];
                            break;
                        case "Opacity":
                            frmSetting.opacity = Convert.ToInt16(rr2[1]);
                            break;
                        case "LocationMode":
                            frmSetting.locationmode = Convert.ToInt16(rr2[1]);
                            break;
                        case "LastLocation":
                            string[] rr3 = rr2[1].Split(new string[] { "," }, StringSplitOptions.None);
                            frmSetting.lastlocation.X = Convert.ToInt16(rr3[0]);
                            frmSetting.lastlocation.Y = Convert.ToInt16(rr3[1]);
                            break;
                        case "isAutoClose":
                            if (rr2[1] == "True") frmSetting.isAutoClose = true;
                            else frmSetting.isAutoClose = false;
                            break;
                        case "AutoCloseTime":
                            frmSetting.autoclosetime = Convert.ToInt16(rr2[1]);
                            if (frmSetting.autoclosetime == 0) frmSetting.autoclosetime = 1;
                            break;
                        case "isSaveCB":
                            if (rr2[1] == "True") frmSetting.isSaveCB = true;
                            else frmSetting.isSaveCB = false;
                            break;
                        case "isSaveAuto":
                            if (rr2[1] == "True") frmSetting.isSaveAuto = true;
                            else frmSetting.isSaveAuto = false;
                            break;
                        case "isSaveOpen":
                            if (rr2[1] == "True") frmSetting.isSaveOpen = true;
                            else frmSetting.isSaveOpen = false;
                            break;
                        case "isRunStartup":
                            if (rr2[1] == "True") frmSetting.isRunStartup = true;
                            else frmSetting.isRunStartup = false;
                            break;
                        case "isCaptureWholeScreen":
                            if (rr2[1] == "True") frmSetting.isCaptureWholeScreen = true;
                            else frmSetting.isCaptureWholeScreen = false;
                            break;
                    }
                }
                sr.Close();
                sr.Dispose();
            }
            else
            {
                frmSetting.tray = 0;
                frmSetting.defaultdirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                frmSetting.opacity = 70;
                frmSetting.lastlocation.X = 0; frmSetting.lastlocation.Y = 0;
                frmSetting.locationmode = 0;
                frmSetting.autoclosetime = 3;
                frmSetting.isAutoClose = false;
                frmSetting.isSaveCB = true;
                frmSetting.isSaveAuto = false;
                frmSetting.isSaveOpen = false;
                frmSetting.isRunStartup = false;
                frmSetting.isCaptureWholeScreen = false;
            }
        }


        //오른클릭으로 부분 찍었을 경우
        private void mnuCap1_Click(object sender, EventArgs e)
        {
            capture.captureDelegate captrueDel = new capture.captureDelegate(Capture);
            Form captureform = new capture(captrueDel);

            if (frmPreview != null)
            {
                frmPreview.Close();
                frmPreview.Dispose();
            }

            captureform.Show();
        }

        //오른클릭으로 전체화면 찍었을 경우
        private void mnuCap2_Click(object sender, EventArgs e)
        {
            if (frmSetting.isCaptureWholeScreen)
            {
                xy = getCaptureFormStartPoint();
                sz = getCaptureFormMaxSize();
            }
            else
            {
                xy.X = 0;
                xy.Y = 0;
                sz.Width = Screen.FromPoint(Cursor.Position).Bounds.Width;
                sz.Height = Screen.FromPoint(Cursor.Position).Bounds.Height;
            }

            if (frmPreview != null)
            {
                frmPreview.Close();
                frmPreview.Dispose();
            }

            Capture();
        }
    
        public void Capture()
        {
            GC.Collect();
        
            Bitmap bmp = new Bitmap(sz.Width, sz.Height);

            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(xy, Point.Empty, sz);

            frmPreview = new preview(xy,sz,bmp);

            frmPreview.Show();
            frmPreview.WindowState = FormWindowState.Normal;
       
        }

        //멀티모니터 지원. 모든 모니터를 감쌀 수 있도록 캡쳐폼의 위치를 가져온다.
        public static Point getCaptureFormStartPoint()
        {
            int left = 0, top = 0;
            foreach (Screen s in Screen.AllScreens)
            {
                if (s.Bounds.Left < left) left = s.Bounds.Left;
                if (s.Bounds.Top < top) top = s.Bounds.Top;
            }
            return new Point(left, top);
        }
        //멀티모니터 지원. 캡쳐폼 크기 설정
        public static Size getCaptureFormMaxSize()
        {
            int right = 0, bottom = 0;
            foreach (Screen s in Screen.AllScreens)
            {
                if (s.Bounds.Right > right) right = s.Bounds.Right;
                if (s.Bounds.Bottom > bottom) bottom = s.Bounds.Bottom;
            }

            Point p = getCaptureFormStartPoint();
            int width = right - p.X;
            int height = bottom - p.Y;
            return new Size(width, height);
        }

        //찍기
        private void RecCapture()
        {
            if (frmPreview != null)
            {
                frmPreview.Close();
                frmPreview.Dispose();
            }

            if (frmSetting.tray == 0)   //부분찍기
            {
                capture.captureDelegate captrueDel = new capture.captureDelegate(Capture);
                Form captureform = new capture(captrueDel);
                captureform.Show();
            }
            else    //전체화면 찍기
            {
                if (frmSetting.isCaptureWholeScreen)
                {
                    xy = getCaptureFormStartPoint();
                    sz = getCaptureFormMaxSize();
                }
                else
                {
                    xy.X = 0;
                    xy.Y = 0;
                    sz.Width = Screen.FromPoint(Cursor.Position).Bounds.Width;
                    sz.Height = Screen.FromPoint(Cursor.Position).Bounds.Height;
                }
                Capture();
            }

        }

        private void mnusetting_Click(object sender, EventArgs e)
        {
            if(frmsetting == null || frmsetting.IsDisposed)
                frmsetting = new frmSetting();
            frmsetting.Show();
            frmsetting.Activate();
        }
    }
}
