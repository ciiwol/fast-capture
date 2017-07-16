namespace fast_capture
{
    partial class capture
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
            this.pncapture = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pncapture
            // 
            this.pncapture.BackColor = System.Drawing.Color.Magenta;
            this.pncapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pncapture.Location = new System.Drawing.Point(12, 12);
            this.pncapture.Name = "pncapture";
            this.pncapture.Size = new System.Drawing.Size(17, 21);
            this.pncapture.TabIndex = 0;
            this.pncapture.Visible = false;
            // 
            // capture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 402);
            this.ControlBox = false;
            this.Controls.Add(this.pncapture);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "capture";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "capture";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Shown += new System.EventHandler(this.capture_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.capture_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.capture_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.capture_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.capture_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pncapture;
    }
}