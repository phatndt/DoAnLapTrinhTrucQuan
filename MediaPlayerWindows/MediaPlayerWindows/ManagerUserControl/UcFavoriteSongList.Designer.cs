namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcFavoriteSongList
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
            this.ucTitleInfomationSong1 = new MediaPlayerWindows.ManagerUserControl.UcTitleInfomationSong();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 590);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // UcFavoriteSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ucTitleInfomationSong1);
            this.Name = "UcFavoriteSongList";
            this.Size = new System.Drawing.Size(950, 640);
            this.ResumeLayout(false);

        }

        #endregion

        private UcTitleInfomationSong ucTitleInfomationSong1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
