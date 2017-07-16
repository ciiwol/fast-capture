using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fast_capture
{
    public partial class capture : Form
    {
        bool isDrag = false;
        public delegate void captureDelegate();
        captureDelegate captureMethod;
        Point p;
        public capture(Delegate capture)
        {
            this.captureMethod = (captureDelegate)capture;
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            p = MainCore.getCaptureFormStartPoint();
        }

        
        private void capture_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            pncapture.Left = Cursor.Position.X - p.X;
            pncapture.Top = Cursor.Position.Y - p.Y;
            MainCore.xy.X = Cursor.Position.X - p.X;
            MainCore.xy.Y = Cursor.Position.Y - p.Y;
            pncapture.Visible = true;
        }

        private void capture_MouseUp(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainCore.sz.Width = pncapture.Width;
            MainCore.sz.Height = pncapture.Height;
            MainCore.xy.X = pncapture.Left + p.X;
            MainCore.xy.Y = pncapture.Top + p.Y;
            captureMethod();
            this.Close();
        }

        private void capture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrag) return;
            if ((Cursor.Position.X - p.X) - MainCore.xy.X > 0) { pncapture.Width = (Cursor.Position.X - p.X) - MainCore.xy.X; pncapture.Left = MainCore.xy.X; }
            if ((Cursor.Position.Y - p.Y) - MainCore.xy.Y > 0) { pncapture.Height = (Cursor.Position.Y - p.Y) - MainCore.xy.Y; pncapture.Top = MainCore.xy.Y; }
            if ((Cursor.Position.X - p.X) - MainCore.xy.X < 0) { pncapture.Width = MainCore.xy.X - (Cursor.Position.X -p.X); pncapture.Left = Cursor.Position.X - p.X; }
            if ((Cursor.Position.Y - p.Y) - MainCore.xy.Y < 0) { pncapture.Height = MainCore.xy.Y - (Cursor.Position.Y - p.Y); pncapture.Top = Cursor.Position.Y - p.Y; }
        }

        private void capture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Hide(); this.Close(); }
        }

        //모든 모니터를 감싸게 설정
        private void capture_Shown(object sender, EventArgs e)
        {
            Location = MainCore.getCaptureFormStartPoint();
            Size = MainCore.getCaptureFormMaxSize();
        }
    }
}
