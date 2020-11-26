namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcPlayList_Name
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
            this.PlayList_Name = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // PlayList_Name
            // 
            this.PlayList_Name.Activecolor = System.Drawing.SystemColors.GrayText;
            this.PlayList_Name.BackColor = System.Drawing.Color.Gray;
            this.PlayList_Name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayList_Name.BorderRadius = 0;
            this.PlayList_Name.ButtonText = "Nhạc trong máy";
            this.PlayList_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayList_Name.DisabledColor = System.Drawing.Color.Gray;
            this.PlayList_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayList_Name.Iconcolor = System.Drawing.Color.Transparent;
            this.PlayList_Name.Iconimage = null;
            this.PlayList_Name.Iconimage_right = null;
            this.PlayList_Name.Iconimage_right_Selected = null;
            this.PlayList_Name.Iconimage_Selected = null;
            this.PlayList_Name.IconMarginLeft = 0;
            this.PlayList_Name.IconMarginRight = 0;
            this.PlayList_Name.IconRightVisible = true;
            this.PlayList_Name.IconRightZoom = 0D;
            this.PlayList_Name.IconVisible = true;
            this.PlayList_Name.IconZoom = 90D;
            this.PlayList_Name.IsTab = false;
            this.PlayList_Name.Location = new System.Drawing.Point(0, 0);
            this.PlayList_Name.Name = "PlayList_Name";
            this.PlayList_Name.Normalcolor = System.Drawing.Color.Gray;
            this.PlayList_Name.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.PlayList_Name.OnHoverTextColor = System.Drawing.Color.White;
            this.PlayList_Name.selected = false;
            this.PlayList_Name.Size = new System.Drawing.Size(200, 40);
            this.PlayList_Name.TabIndex = 0;
            this.PlayList_Name.Text = "Nhạc trong máy";
            this.PlayList_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayList_Name.Textcolor = System.Drawing.Color.White;
            this.PlayList_Name.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UcPlayList_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.PlayList_Name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcPlayList_Name";
            this.Size = new System.Drawing.Size(200, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton PlayList_Name;
    }
}
