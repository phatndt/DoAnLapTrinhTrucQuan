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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ucNameSong = new MediaPlayerWindows.ManagerUserControl.UcNameSong();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.ucNameSong);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(600, 378);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // ucNameSong
            // 
            this.ucNameSong.BackColor = System.Drawing.Color.White;
            this.ucNameSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucNameSong.Location = new System.Drawing.Point(2, 2);
            this.ucNameSong.Margin = new System.Windows.Forms.Padding(2);
            this.ucNameSong.Name = "ucNameSong";
            this.ucNameSong.Size = new System.Drawing.Size(596, 41);
            this.ucNameSong.TabIndex = 0;
            // 
            // UcSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "UcSongList";
            this.Size = new System.Drawing.Size(600, 378);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private UcNameSong ucNameSong;
    }
}
