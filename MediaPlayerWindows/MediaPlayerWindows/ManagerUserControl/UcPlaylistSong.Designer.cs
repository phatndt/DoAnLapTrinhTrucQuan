namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcPlaylistSong
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
            this.ucSongList2 = new MediaPlayerWindows.ManagerUserControl.UcSongList();
            this.SuspendLayout();
            // 
            // ucSongList2
            // 
            this.ucSongList2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ucSongList2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucSongList2.Location = new System.Drawing.Point(0, 0);
            this.ucSongList2.Name = "ucSongList2";
            this.ucSongList2.Size = new System.Drawing.Size(950, 334);
            this.ucSongList2.TabIndex = 0;
            // 
            // UcPlaylistSong
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.ucSongList2);
            this.Name = "UcPlaylistSong";
            this.Size = new System.Drawing.Size(950, 454);
            this.ResumeLayout(false);

        }

        #endregion
        private UcSongList ucSongList2;
    }
}
