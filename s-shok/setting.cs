using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace fast_capture
{

    public partial class frmSetting : Form
    {
        static public short tray;
        static public string defaultdirectory;
        static public short opacity;
        static public short locationmode;
        static public Point lastlocation;
        static public short autoclosetime;
        static public bool isAutoClose;
        static public bool isSaveCB;
        static public bool isSaveAuto;
        static public bool isSaveOpen;
        static public bool isRunStartup;
        static public bool isCaptureWholeScreen;

        public frmSetting()
        {
           
            InitializeComponent();
        }

        static public void setting_save()
        {
            StreamWriter sw = new StreamWriter(Path.Combine(Application.StartupPath, "setting.cfc"));
            StringBuilder sb = new StringBuilder();
            sb.Append("ClickTrayIcon*");
            sb.Append(tray); sb.AppendLine();
            sb.Append("DefaultDirectory*");
            sb.Append(defaultdirectory); sb.AppendLine();
            sb.Append("Opacity*");
            sb.Append(opacity); sb.AppendLine();
            sb.Append("LocationMode*");
            sb.Append(locationmode); sb.AppendLine();
            sb.Append("LastLocation*");
            sb.Append(lastlocation.X); sb.Append(","); sb.Append(lastlocation.Y); sb.AppendLine();
            sb.Append("isAutoClose*");
            sb.Append(isAutoClose); sb.AppendLine();
            sb.Append("AutoCloseTime*");
            sb.Append(autoclosetime); sb.AppendLine();
            sb.Append("isSaveCB*");
            sb.Append(isSaveCB); sb.AppendLine();
            sb.Append("isSaveAuto*");
            sb.Append(isSaveAuto); sb.AppendLine();
            sb.Append("isSaveOpen*");
            sb.Append(isSaveOpen); sb.AppendLine();
            sb.Append("isRunStartup*");
            sb.Append(isRunStartup); sb.AppendLine();
            sb.Append("isCaptureWholeScreen*");
            sb.Append(isCaptureWholeScreen); sb.AppendLine();

            sw.Write(sb);
            sw.Close();
            sw.Dispose();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            tray = Convert.ToInt16(dbox_defcapture.SelectedIndex);
            defaultdirectory = txtdirectory.Text;
            opacity = Convert.ToInt16(trackopacity.Value);
            locationmode = Convert.ToInt16(dboxpreview.SelectedIndex);
            isAutoClose = cboxautoclose.Checked;
            autoclosetime = Convert.ToInt16(nautoclose.Value);
            isSaveCB = cboxCB.Checked;
            isSaveAuto = cboxAuto.Checked;
            isSaveOpen = cboxOpen.Checked;
            isRunStartup = cboxStartup.Checked;
            isCaptureWholeScreen = chkCaptureWholeScreen.Checked;
            setting_save();

            //시작프로그램 등록
            Microsoft.Win32.RegistryKey rkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isRunStartup)
               rkey.SetValue("ciiwolfastcapture", Application.ExecutablePath);
             else
                rkey.DeleteValue("ciiwolfastcapture", false);

            this.Close();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            dbox_defcapture.SelectedIndex = tray;
            txtdirectory.Text = defaultdirectory;
            trackopacity.Value = opacity;
            dboxpreview.SelectedIndex = locationmode;
            cboxautoclose.Checked = isAutoClose;
            nautoclose.Value = autoclosetime;
            cboxCB.Checked = isSaveCB;
            cboxAuto.Checked = isSaveAuto;
            cboxOpen.Checked = isSaveOpen;
            cboxStartup.Checked = isRunStartup;
            chkCaptureWholeScreen.Checked = isCaptureWholeScreen;

            if (Screen.AllScreens.Length > 1) gbMultiMonitor.Visible = true;
            else gbMultiMonitor.Visible = false;

            lblVersion.Text = "Fast capture " + Application.ProductVersion;
        }

        private void llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ciiwolstudio.com");
        }


        private void llblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("jk012345@gmail.com\n\n개발자 이메일주소를 복사하시겠습니까?\nCopy to clipboard the developer's e-mail?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Clipboard.SetText("jk012345@gmail.com");
        }

        private void btnopendirectory_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", txtdirectory.Text);
        }

        private void btnsetdirectory_Click(object sender, EventArgs e)
        {
            fbd.SelectedPath = txtdirectory.Text;
            fbd.ShowDialog();
            if(fbd.SelectedPath != "")
            txtdirectory.Text = fbd.SelectedPath;
        }

        private void pnSettings_Paint(object sender, PaintEventArgs e)
        {
            using (Pen linePen = new Pen(Color.LightGray))
            {

                using (Graphics frmGraphic = e.Graphics)
                {
                    frmGraphic.DrawLine(linePen, 0, 30, 860, 30);
                    frmGraphic.DrawLine(linePen, 430, 35, 430, 245);
                    frmGraphic.DrawLine(linePen, 10, 250, 850, 250);
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void lblTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.IndianRed;
            lblClose.ForeColor = Color.White;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.White;
            lblClose.ForeColor = Color.Gray;
        }

        private void lblClose_MouseDown(object sender, MouseEventArgs e)
        {
            lblClose.BackColor = Color.DarkRed;
        }
    }
}
