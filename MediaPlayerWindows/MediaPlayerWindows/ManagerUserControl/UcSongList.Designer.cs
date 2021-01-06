namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcSongList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucTitleInfomationSong1 = new MediaPlayerWindows.ManagerUserControl.UcTitleInfomationSong();
            this.ucNameSong = new MediaPlayerWindows.ManagerUserControl.UcSong();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 404);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ucTitleInfomationSong1
            // 
            this.ucTitleInfomationSong1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucTitleInfomationSong1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTitleInfomationSong1.Location = new System.Drawing.Point(0, 0);
            this.ucTitleInfomationSong1.Name = "ucTitleInfomationSong1";
            this.ucTitleInfomationSong1.Size = new System.Drawing.Size(950, 50);
            this.ucTitleInfomationSong1.TabIndex = 0;
            // 
            // ucNameSong
            // 
            this.ucNameSong.BackColor = System.Drawing.Color.White;
            this.ucNameSong.Location = new System.Drawing.Point(0, 0);
            this.ucNameSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucNameSong.Name = "ucNameSong";
            this.ucNameSong.Size = new System.Drawing.Size(1260, 62);
            this.ucNameSong.TabIndex = 0;
            // 
            // UcSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ucTitleInfomationSong1);
            this.Name = "UcSongList";
            this.Size = new System.Drawing.Size(950, 454);
            this.ResumeLayout(false);

        }

        #endregion
        private UcSong ucNameSong;
        private UcTitleInfomationSong ucTitleInfomationSong1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
