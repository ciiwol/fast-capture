namespace fast_capture
{
    partial class frmSetting
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.dbox_defcapture = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdirectory = new System.Windows.Forms.TextBox();
            this.btnsetdirectory = new System.Windows.Forms.Button();
            this.btnopendirectory = new System.Windows.Forms.Button();
            this.llbl = new System.Windows.Forms.LinkLabel();
            this.cboxStartup = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackopacity = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxCB = new System.Windows.Forms.CheckBox();
            this.cboxAuto = new System.Windows.Forms.CheckBox();
            this.cboxOpen = new System.Windows.Forms.CheckBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.dboxpreview = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxautoclose = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nautoclose = new System.Windows.Forms.NumericUpDown();
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.gbMultiMonitor = new System.Windows.Forms.GroupBox();
            this.chkCaptureWholeScreen = new System.Windows.Forms.CheckBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.llblEmail = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trackopacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nautoclose)).BeginInit();
            this.pnTitleBar.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.gbMultiMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "트레이아이콘 클릭하면 :\r\nWhen tray icon clicked :";
            // 
            // dbox_defcapture
            // 
            this.dbox_defcapture.BackColor = System.Drawing.Color.White;
            this.dbox_defcapture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbox_defcapture.FormattingEnabled = true;
            this.dbox_defcapture.Items.AddRange(new object[] {
            "사각형 갈무리(Rectangle capture)",
            "화면 갈무리(Screen capture)"});
            this.dbox_defcapture.Location = new System.Drawing.Point(159, 54);
            this.dbox_defcapture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dbox_defcapture.Name = "dbox_defcapture";
            this.dbox_defcapture.Size = new System.Drawing.Size(249, 23);
            this.dbox_defcapture.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(748, 256);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(104, 28);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "저장(Save)";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "기본 저장 폴더 :\r\nDefault save directory :";
            // 
            // txtdirectory
            // 
            this.txtdirectory.Location = new System.Drawing.Point(159, 113);
            this.txtdirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdirectory.Name = "txtdirectory";
            this.txtdirectory.ReadOnly = true;
            this.txtdirectory.Size = new System.Drawing.Size(168, 23);
            this.txtdirectory.TabIndex = 4;
            // 
            // btnsetdirectory
            // 
            this.btnsetdirectory.Location = new System.Drawing.Point(333, 113);
            this.btnsetdirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsetdirectory.Name = "btnsetdirectory";
            this.btnsetdirectory.Size = new System.Drawing.Size(32, 24);
            this.btnsetdirectory.TabIndex = 5;
            this.btnsetdirectory.Text = "...";
            this.btnsetdirectory.UseVisualStyleBackColor = true;
            this.btnsetdirectory.Click += new System.EventHandler(this.btnsetdirectory_Click);
            // 
            // btnopendirectory
            // 
            this.btnopendirectory.Location = new System.Drawing.Point(371, 113);
            this.btnopendirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnopendirectory.Name = "btnopendirectory";
            this.btnopendirectory.Size = new System.Drawing.Size(37, 24);
            this.btnopendirectory.TabIndex = 5;
            this.btnopendirectory.Text = "🗁";
            this.btnopendirectory.UseVisualStyleBackColor = true;
            this.btnopendirectory.Click += new System.EventHandler(this.btnopendirectory_Click);
            // 
            // llbl
            // 
            this.llbl.AutoSize = true;
            this.llbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llbl.LinkColor = System.Drawing.Color.Black;
            this.llbl.Location = new System.Drawing.Point(11, 264);
            this.llbl.Name = "llbl";
            this.llbl.Size = new System.Drawing.Size(71, 15);
            this.llbl.TabIndex = 6;
            this.llbl.TabStop = true;
            this.llbl.Text = "ciiwolstudio";
            this.llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_LinkClicked);
            // 
            // cboxStartup
            // 
            this.cboxStartup.AutoSize = true;
            this.cboxStartup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxStartup.Location = new System.Drawing.Point(430, 262);
            this.cboxStartup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxStartup.Name = "cboxStartup";
            this.cboxStartup.Size = new System.Drawing.Size(299, 19);
            this.cboxStartup.TabIndex = 8;
            this.cboxStartup.Text = "윈도우 시작할 때 실행 (Run when Windows startup)";
            this.cboxStartup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(449, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "미리보기 투명도 :\r\nPreview opacity :";
            // 
            // trackopacity
            // 
            this.trackopacity.Location = new System.Drawing.Point(567, 54);
            this.trackopacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackopacity.Maximum = 100;
            this.trackopacity.Minimum = 30;
            this.trackopacity.Name = "trackopacity";
            this.trackopacity.Size = new System.Drawing.Size(263, 45);
            this.trackopacity.TabIndex = 10;
            this.trackopacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackopacity.Value = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "30%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(797, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "100%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "찍은 후 행동 :\r\nAfter capture :";
            // 
            // cboxCB
            // 
            this.cboxCB.AutoSize = true;
            this.cboxCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxCB.Location = new System.Drawing.Point(159, 164);
            this.cboxCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCB.Name = "cboxCB";
            this.cboxCB.Size = new System.Drawing.Size(211, 19);
            this.cboxCB.TabIndex = 13;
            this.cboxCB.Text = "클립보드에 저장(Save in clipboard)";
            this.cboxCB.UseVisualStyleBackColor = true;
            // 
            // cboxAuto
            // 
            this.cboxAuto.AutoSize = true;
            this.cboxAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxAuto.Location = new System.Drawing.Point(159, 192);
            this.cboxAuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxAuto.Name = "cboxAuto";
            this.cboxAuto.Size = new System.Drawing.Size(249, 19);
            this.cboxAuto.TabIndex = 13;
            this.cboxAuto.Text = "기본폴더에 저장(Save in Default directory)";
            this.cboxAuto.UseVisualStyleBackColor = true;
            // 
            // cboxOpen
            // 
            this.cboxOpen.AutoSize = true;
            this.cboxOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxOpen.Location = new System.Drawing.Point(159, 219);
            this.cboxOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxOpen.Name = "cboxOpen";
            this.cboxOpen.Size = new System.Drawing.Size(225, 19);
            this.cboxOpen.TabIndex = 13;
            this.cboxOpen.Text = "저장 창 띄우기 (Open save file dialog)";
            this.cboxOpen.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(449, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "미리보기 위치 :\r\nPreview position :";
            // 
            // dboxpreview
            // 
            this.dboxpreview.BackColor = System.Drawing.Color.White;
            this.dboxpreview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dboxpreview.FormattingEnabled = true;
            this.dboxpreview.Items.AddRange(new object[] {
            "왼쪽 위 고정(Left-Top fixed)",
            "캡처영역 중앙(Center of capture area)",
            "마우스 땔 때 위치(Mouse released position)",
            "자율 이동(Free position)",
            "자율+캡처영역중앙(Free+Center of capture area)",
            "자율+마우스 땐 곳(Free+Released position)"});
            this.dboxpreview.Location = new System.Drawing.Point(570, 108);
            this.dboxpreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dboxpreview.Name = "dboxpreview";
            this.dboxpreview.Size = new System.Drawing.Size(260, 23);
            this.dboxpreview.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(449, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 30);
            this.label9.TabIndex = 14;
            this.label9.Text = "미리보기 자동닫기 :\r\nPreview auto closing :";
            // 
            // cboxautoclose
            // 
            this.cboxautoclose.AutoSize = true;
            this.cboxautoclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxautoclose.Location = new System.Drawing.Point(603, 149);
            this.cboxautoclose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxautoclose.Name = "cboxautoclose";
            this.cboxautoclose.Size = new System.Drawing.Size(113, 34);
            this.cboxautoclose.TabIndex = 13;
            this.cboxautoclose.Text = "자동으로 닫는다\r\n(Close auto)";
            this.cboxautoclose.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(776, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 30);
            this.label10.TabIndex = 16;
            this.label10.Text = "초 후\r\nseconds";
            // 
            // nautoclose
            // 
            this.nautoclose.Location = new System.Drawing.Point(732, 151);
            this.nautoclose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nautoclose.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nautoclose.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nautoclose.Name = "nautoclose";
            this.nautoclose.Size = new System.Drawing.Size(38, 23);
            this.nautoclose.TabIndex = 17;
            this.nautoclose.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.Controls.Add(this.lblTitleBar);
            this.pnTitleBar.Controls.Add(this.lblClose);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(859, 30);
            this.pnTitleBar.TabIndex = 18;
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleBar.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F);
            this.lblTitleBar.ForeColor = System.Drawing.Color.Black;
            this.lblTitleBar.Location = new System.Drawing.Point(0, 0);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(824, 30);
            this.lblTitleBar.TabIndex = 0;
            this.lblTitleBar.Text = "설정";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitleBar_MouseDown);
            // 
            // lblClose
            // 
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F);
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClose.Location = new System.Drawing.Point(824, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(35, 30);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblClose_MouseDown);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // pnSettings
            // 
            this.pnSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSettings.Controls.Add(this.gbMultiMonitor);
            this.pnSettings.Controls.Add(this.nautoclose);
            this.pnSettings.Controls.Add(this.label1);
            this.pnSettings.Controls.Add(this.label10);
            this.pnSettings.Controls.Add(this.dbox_defcapture);
            this.pnSettings.Controls.Add(this.label9);
            this.pnSettings.Controls.Add(this.dboxpreview);
            this.pnSettings.Controls.Add(this.label8);
            this.pnSettings.Controls.Add(this.btnsave);
            this.pnSettings.Controls.Add(this.cboxOpen);
            this.pnSettings.Controls.Add(this.label2);
            this.pnSettings.Controls.Add(this.cboxAuto);
            this.pnSettings.Controls.Add(this.txtdirectory);
            this.pnSettings.Controls.Add(this.cboxautoclose);
            this.pnSettings.Controls.Add(this.btnsetdirectory);
            this.pnSettings.Controls.Add(this.cboxCB);
            this.pnSettings.Controls.Add(this.btnopendirectory);
            this.pnSettings.Controls.Add(this.label7);
            this.pnSettings.Controls.Add(this.llblEmail);
            this.pnSettings.Controls.Add(this.llbl);
            this.pnSettings.Controls.Add(this.label6);
            this.pnSettings.Controls.Add(this.lblVersion);
            this.pnSettings.Controls.Add(this.label5);
            this.pnSettings.Controls.Add(this.cboxStartup);
            this.pnSettings.Controls.Add(this.trackopacity);
            this.pnSettings.Controls.Add(this.label4);
            this.pnSettings.Controls.Add(this.pnTitleBar);
            this.pnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSettings.Location = new System.Drawing.Point(0, 0);
            this.pnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(861, 290);
            this.pnSettings.TabIndex = 19;
            this.pnSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSettings_Paint);
            // 
            // gbMultiMonitor
            // 
            this.gbMultiMonitor.Controls.Add(this.chkCaptureWholeScreen);
            this.gbMultiMonitor.Location = new System.Drawing.Point(441, 202);
            this.gbMultiMonitor.Name = "gbMultiMonitor";
            this.gbMultiMonitor.Size = new System.Drawing.Size(407, 39);
            this.gbMultiMonitor.TabIndex = 19;
            this.gbMultiMonitor.TabStop = false;
            this.gbMultiMonitor.Text = "멀티모니터 설정 Multi-monitor fullscreen capture setting";
            // 
            // chkCaptureWholeScreen
            // 
            this.chkCaptureWholeScreen.AutoSize = true;
            this.chkCaptureWholeScreen.Location = new System.Drawing.Point(11, 16);
            this.chkCaptureWholeScreen.Name = "chkCaptureWholeScreen";
            this.chkCaptureWholeScreen.Size = new System.Drawing.Size(325, 19);
            this.chkCaptureWholeScreen.TabIndex = 0;
            this.chkCaptureWholeScreen.Text = "전체화면 캡쳐시 모든 모니터를 캡쳐(Capture all screens)";
            this.chkCaptureWholeScreen.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVersion.Location = new System.Drawing.Point(225, 264);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(74, 15);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "Fast capture";
            // 
            // llblEmail
            // 
            this.llblEmail.AutoSize = true;
            this.llblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llblEmail.LinkColor = System.Drawing.Color.Black;
            this.llblEmail.Location = new System.Drawing.Point(104, 264);
            this.llblEmail.Name = "llblEmail";
            this.llblEmail.Size = new System.Drawing.Size(98, 15);
            this.llblEmail.TabIndex = 6;
            this.llblEmail.TabStop = true;
            this.llblEmail.Text = "김주진(Jujin Kim)";
            this.llblEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEmail_LinkClicked);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 290);
            this.Controls.Add(this.pnSettings);
            this.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmSetting";
            this.Text = "Fast capture setting";
            this.Load += new System.EventHandler(this.setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackopacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nautoclose)).EndInit();
            this.pnTitleBar.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.gbMultiMonitor.ResumeLayout(false);
            this.gbMultiMonitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dbox_defcapture;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdirectory;
        private System.Windows.Forms.Button btnsetdirectory;
        private System.Windows.Forms.Button btnopendirectory;
        private System.Windows.Forms.LinkLabel llbl;
        private System.Windows.Forms.CheckBox cboxStartup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackopacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cboxCB;
        private System.Windows.Forms.CheckBox cboxAuto;
        private System.Windows.Forms.CheckBox cboxOpen;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dboxpreview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cboxautoclose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nautoclose;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.GroupBox gbMultiMonitor;
        private System.Windows.Forms.CheckBox chkCaptureWholeScreen;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel llblEmail;
    }
}

