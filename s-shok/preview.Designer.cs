namespace fast_capture
{
    partial class preview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preview));
            this.btncb = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndef = new System.Windows.Forms.Button();
            this.mnucapture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCap1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCap2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuexit = new System.Windows.Forms.ToolStripMenuItem();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbox = new System.Windows.Forms.PictureBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnre = new System.Windows.Forms.Button();
            this.btnopendir = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.btnPaint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btncb
            // 
            this.btncb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncb.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F);
            this.btncb.ForeColor = System.Drawing.Color.SteelBlue;
            this.btncb.Location = new System.Drawing.Point(0, 0);
            this.btncb.Margin = new System.Windows.Forms.Padding(0);
            this.btncb.Name = "btncb";
            this.btncb.Size = new System.Drawing.Size(135, 30);
            this.btncb.TabIndex = 0;
            this.btncb.Text = "클립보드(Clipboard)";
            this.btncb.UseVisualStyleBackColor = true;
            this.btncb.Click += new System.EventHandler(this.btncb_Click);
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F);
            this.btnsave.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnsave.Location = new System.Drawing.Point(134, 0);
            this.btnsave.Margin = new System.Windows.Forms.Padding(0);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 30);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "저장(Save)..";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndef
            // 
            this.btndef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndef.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F);
            this.btndef.ForeColor = System.Drawing.Color.SteelBlue;
            this.btndef.Location = new System.Drawing.Point(0, 29);
            this.btndef.Margin = new System.Windows.Forms.Padding(0);
            this.btndef.Name = "btndef";
            this.btndef.Size = new System.Drawing.Size(286, 28);
            this.btndef.TabIndex = 0;
            this.btndef.Text = "기본폴더에 저장(Save in default directory)";
            this.btndef.UseVisualStyleBackColor = true;
            this.btndef.Click += new System.EventHandler(this.btndef_Click);
            // 
            // mnucapture
            // 
            this.mnucapture.Name = "mnucapture";
            this.mnucapture.Size = new System.Drawing.Size(32, 19);
            // 
            // mnuCap1
            // 
            this.mnuCap1.Name = "mnuCap1";
            this.mnuCap1.Size = new System.Drawing.Size(32, 19);
            // 
            // mnuCap2
            // 
            this.mnuCap2.Name = "mnuCap2";
            this.mnuCap2.Size = new System.Drawing.Size(32, 19);
            // 
            // mnusetting
            // 
            this.mnusetting.Name = "mnusetting";
            this.mnusetting.Size = new System.Drawing.Size(32, 19);
            // 
            // mnuexit
            // 
            this.mnuexit.Name = "mnuexit";
            this.mnuexit.Size = new System.Drawing.Size(32, 19);
            // 
            // pbox
            // 
            this.pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox.Location = new System.Drawing.Point(0, 57);
            this.pbox.Margin = new System.Windows.Forms.Padding(0);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(380, 173);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox.TabIndex = 1;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            this.pbox.DoubleClick += new System.EventHandler(this.pbox_DoubleClick);
            this.pbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbox_MouseDown);
            this.pbox.MouseEnter += new System.EventHandler(this.pbox_MouseEnter);
            this.pbox.MouseLeave += new System.EventHandler(this.pbox_MouseLeave);
            this.pbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbox_MouseMove);
            this.pbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbox_MouseUp);
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "png";
            this.sfd.FileName = "sshok.png";
            this.sfd.Filter = "png파일|*.png|모든 파일|*.*";
            this.sfd.InitialDirectory = "C:\\Users\\주진\\Pictures";
            // 
            // btnre
            // 
            this.btnre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnre.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F);
            this.btnre.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnre.Location = new System.Drawing.Point(322, 0);
            this.btnre.Margin = new System.Windows.Forms.Padding(0);
            this.btnre.Name = "btnre";
            this.btnre.Size = new System.Drawing.Size(58, 57);
            this.btnre.TabIndex = 2;
            this.btnre.Text = "다시(Again)";
            this.btnre.UseVisualStyleBackColor = true;
            this.btnre.Click += new System.EventHandler(this.btnre_Click);
            // 
            // btnopendir
            // 
            this.btnopendir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopendir.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F);
            this.btnopendir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnopendir.Location = new System.Drawing.Point(285, 29);
            this.btnopendir.Margin = new System.Windows.Forms.Padding(0);
            this.btnopendir.Name = "btnopendir";
            this.btnopendir.Size = new System.Drawing.Size(38, 28);
            this.btnopendir.TabIndex = 3;
            this.btnopendir.Text = "🗁";
            this.btnopendir.UseVisualStyleBackColor = true;
            this.btnopendir.Click += new System.EventHandler(this.btnopendir_Click);
            // 
            // tim
            // 
            this.tim.Tick += new System.EventHandler(this.tim_Tick);
            // 
            // btnPaint
            // 
            this.btnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaint.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F);
            this.btnPaint.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPaint.Location = new System.Drawing.Point(218, 0);
            this.btnPaint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(105, 30);
            this.btnPaint.TabIndex = 0;
            this.btnPaint.Text = "그림판(MsPaint)";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 230);
            this.ControlBox = false;
            this.Controls.Add(this.btnopendir);
            this.Controls.Add(this.btnre);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.btndef);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "preview";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "preview";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.preview_Load);
            this.Click += new System.EventHandler(this.preview_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncb;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndef;
        private System.Windows.Forms.ToolStripMenuItem mnusetting;
        private System.Windows.Forms.ToolStripMenuItem mnuexit;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ToolStripMenuItem mnucapture;
        private System.Windows.Forms.ToolStripMenuItem mnuCap1;
        private System.Windows.Forms.ToolStripMenuItem mnuCap2;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnre;
        private System.Windows.Forms.Button btnopendir;
        private System.Windows.Forms.Timer tim;
        private System.Windows.Forms.Button btnPaint;
    }
}