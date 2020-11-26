namespace MediaPlayerWindows
{
    partial class UcPlaylist
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
            this.ucSongList1 = new MediaPlayerWindows.ManagerUserControl.UcSongList();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UcplayList_Name = new MediaPlayerWindows.ManagerUserControl.UcPlayList_Name();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucSongList1
            // 
            this.ucSongList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ucSongList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSongList1.Location = new System.Drawing.Point(0, 0);
            this.ucSongList1.Name = "ucSongList1";
            this.ucSongList1.Size = new System.Drawing.Size(750, 475);
            this.ucSongList1.TabIndex = 1;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.UcplayList_Name);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(202, 475);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // UcplayList_Name
            // 
            this.UcplayList_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.UcplayList_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.UcplayList_Name.Location = new System.Drawing.Point(2, 2);
            this.UcplayList_Name.Margin = new System.Windows.Forms.Padding(2);
            this.UcplayList_Name.Name = "UcplayList_Name";
            this.UcplayList_Name.Size = new System.Drawing.Size(200, 40);
            this.UcplayList_Name.TabIndex = 1;
            // 
            // UcPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.ucSongList1);
            this.Name = "UcPlaylist";
            this.Size = new System.Drawing.Size(750, 475);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ManagerUserControl.UcSongList ucSongList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private ManagerUserControl.UcPlayList_Name UcplayList_Name;
    }
}
