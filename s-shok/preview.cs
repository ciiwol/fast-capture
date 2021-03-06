﻿using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace fast_capture
{
    public partial class preview : Form
    {
        Point xy; Size sz;
        Bitmap bmp;
        public preview(Point xy, Size sz, Bitmap bmp)
        {
            this.xy = xy;
            this.sz = sz;
            this.bmp = bmp;
            InitializeComponent();
        }

        private void preview_Load(object sender, EventArgs e)
        {
            if (frmSetting.defaultdirectory.Substring(frmSetting.defaultdirectory.Length - 1) != "\\")
                frmSetting.defaultdirectory += "\\";
            //설정 재저장
            frmSetting.setting_save();

            if (frmSetting.isSaveCB) Clipboard.SetImage(bmp);
            if (frmSetting.isSaveAuto) saveDef();
            if (frmSetting.isSaveOpen) saveOpen();

            init();
        }

        private void init()
        {
            int thisWidth, thisHeight;
            thisWidth = 380; /* this.Width; */ thisHeight = 230; /* this.Height; */ //왜 width랑 height가 이상하게나오지?
            switch (frmSetting.locationmode)
            {
                case 0 :    //왼쪽위고정
                    frmSetting.lastlocation.X = 0;
                    frmSetting.lastlocation.Y = 0;
                    break;
                case 1 : case 4 :   //캡처영역중앙
                    frmSetting.lastlocation.X = (xy.X + sz.Width / 2) - thisWidth/2;
                    frmSetting.lastlocation.Y = (xy.Y + sz.Height / 2) - thisHeight/2;
                    break;
                case 2 : case 5 :   //마지막마우스땐곳
                    Point p = MainCore.getCaptureFormStartPoint();
                    Size s = MainCore.getCaptureFormMaxSize();
                    frmSetting.lastlocation.X = Cursor.Position.X - thisWidth / 2;
                    frmSetting.lastlocation.Y = Cursor.Position.Y - thisHeight / 2;
                    if (frmSetting.lastlocation.X < p.X) frmSetting.lastlocation.X = p.X;
                    if (frmSetting.lastlocation.Y < p.Y) frmSetting.lastlocation.Y = p.Y;
                    if (frmSetting.lastlocation.X > (s.Width + p.X) - thisWidth) frmSetting.lastlocation.X = (s.Width + p.X) - thisWidth;
                    if (frmSetting.lastlocation.Y > (s.Height + p.Y) - thisHeight) frmSetting.lastlocation.Y = (s.Height + p.Y) - thisHeight;
                    break;
                case 3 :    //그냥자율
                    break;
            }
            
            this.Location = frmSetting.lastlocation;

            if (frmSetting.isAutoClose)
            {
                tim.Interval = frmSetting.autoclosetime * 1000;
                tim.Enabled = true;
            }
            pbox.Image = bmp;
            Opacity = frmSetting.opacity * 0.01;
        }

        private void preview_Click(object sender, EventArgs e)
        {
            pbox.Image = null;
            Close();
        }
   
       

        private void pbox_Click(object sender, EventArgs e)
        {
            if (frmSetting.locationmode < 3) Close();   
        }

        private void pbox_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void pbox_MouseLeave(object sender, EventArgs e)
        {
            if(!(this.IsDisposed || this.Disposing))
            this.Opacity = frmSetting.opacity * 0.01;
        }

        private void saveDef(bool tomspaint = false)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(frmSetting.defaultdirectory);
            sb.Append("cfc_");
            sb.Append(DateTime.Now.ToString("yyyyMMddHHmmss"));
            sb.Append(".png");
            try
            {
                pbox.Image.Save(sb.ToString());
                if (tomspaint)
                    System.Diagnostics.Process.Start("mspaint", sb.ToString());
            }
            catch(Exception e)
            {
                MessageBox.Show("저장 중 오류가 발생했습니다. 다른 위치에 저장해보세요.\n" +
                                "Some error has occured while saving image. You might try to save image in other directory.\n\n" +
                                "ErrorMessage : " + e.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveOpen()
        {
            string dir = frmSetting.defaultdirectory;
            sfd.ShowDialog();
            dir = sfd.FileName;
            try
            {
                pbox.Image.Save(dir);
            }
            catch (Exception e)
            {
                MessageBox.Show("저장 중 오류가 발생했습니다. 다른 위치에 저장해보세요.\n" +
                               "Some error has occured while saving image. You may try to save image in other directory.\n\n" +
                               "ErrorMessage : " + e.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btncb_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pbox.Image);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            saveOpen();
        }

        private void btndef_Click(object sender, EventArgs e)
        {
            saveDef();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            saveDef(true);
        }

        private void btnopendir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", frmSetting.defaultdirectory);
        }

        private void tim_Tick(object sender, EventArgs e)
        {
            tim.Enabled = false;
            if (frmSetting.isAutoClose) Close();
        }

        bool dragpreview = false;
        Point dragxy = new Point();
        private void pbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (frmSetting.locationmode >= 3)
            {
                dragpreview = true;
                dragxy = Cursor.Position;
            }
        }

        private void pbox_MouseUp(object sender, MouseEventArgs e)
        {
            dragpreview = false;
            frmSetting.lastlocation = this.Location;
        }

        private void pbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragpreview) return;
            this.Left = frmSetting.lastlocation.X + Cursor.Position.X - dragxy.X;
            this.Top = frmSetting.lastlocation.Y + Cursor.Position.Y - dragxy.Y;
        }

        private void pbox_DoubleClick(object sender, EventArgs e)
        {
            if (frmSetting.locationmode >= 3) Close();
        }

        private void btnre_Click(object sender, EventArgs e)
        {

        }
    }
}
