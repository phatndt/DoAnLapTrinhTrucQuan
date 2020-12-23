namespace MediaPlayerWindows
{
    partial class UcPlaylistList
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
            this.ucPlayList_Name1 = new MediaPlayerWindows.ManagerUserControl.UcPlayList_Name();
            this.ucPlayList_Name2 = new MediaPlayerWindows.ManagerUserControl.UcPlayList_Name();
            this.SuspendLayout();
            // 
            // ucPlayList_Name1
            // 
            this.ucPlayList_Name1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ucPlayList_Name1.Location = new System.Drawing.Point(2, 2);
            this.ucPlayList_Name1.Margin = new System.Windows.Forms.Padding(2);
            this.ucPlayList_Name1.Name = "ucPlayList_Name1";
            this.ucPlayList_Name1.Size = new System.Drawing.Size(100, 120);
            this.ucPlayList_Name1.TabIndex = 0;
            // 
            // ucPlayList_Name2
            // 
            this.ucPlayList_Name2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ucPlayList_Name2.Location = new System.Drawing.Point(106, 2);
            this.ucPlayList_Name2.Margin = new System.Windows.Forms.Padding(2);
            this.ucPlayList_Name2.Name = "ucPlayList_Name2";
            this.ucPlayList_Name2.Size = new System.Drawing.Size(100, 120);
            this.ucPlayList_Name2.TabIndex = 0;
            // 
            // UcPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.ucPlayList_Name2);
            this.Controls.Add(this.ucPlayList_Name1);
            this.Name = "UcPlaylist";
            this.Size = new System.Drawing.Size(950, 120);
            this.ResumeLayout(false);

        }

        #endregion

        private ManagerUserControl.UcPlayList_Name ucPlayList_Name1;
        private ManagerUserControl.UcPlayList_Name ucPlayList_Name2;
    }
}
