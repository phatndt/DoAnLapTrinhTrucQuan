namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcOnlineSong
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
            this.components = new System.ComponentModel.Container();
            this.PlayList_NameSong = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnSelect = new Guna.UI.WinForms.GunaCircleButton();
            this.lbTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbArtist = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.PlayList_NameSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayList_NameSong
            // 
            this.PlayList_NameSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(135)))));
            this.PlayList_NameSong.Controls.Add(this.gunaPictureBox1);
            this.PlayList_NameSong.Controls.Add(this.btnSelect);
            this.PlayList_NameSong.Controls.Add(this.lbTime);
            this.PlayList_NameSong.Controls.Add(this.lbArtist);
            this.PlayList_NameSong.Controls.Add(this.lbName);
            this.PlayList_NameSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayList_NameSong.Location = new System.Drawing.Point(0, 0);
            this.PlayList_NameSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayList_NameSong.Name = "PlayList_NameSong";
            this.PlayList_NameSong.Size = new System.Drawing.Size(1260, 62);
            this.PlayList_NameSong.TabIndex = 19;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(135)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(135)))));
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(67, 62);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 69;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Animated = true;
            this.btnSelect.AnimationHoverSpeed = 0.07F;
            this.btnSelect.AnimationSpeed = 0.03F;
            this.btnSelect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.btnSelect.BorderColor = System.Drawing.Color.Black;
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelect.FocusedColor = System.Drawing.Color.Empty;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
            this.btnSelect.ImageSize = new System.Drawing.Size(16, 16);
            this.btnSelect.Location = new System.Drawing.Point(105, 12);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSelect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSelect.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSelect.OnHoverImage = null;
            this.btnSelect.OnPressedColor = System.Drawing.Color.Black;
            this.btnSelect.Size = new System.Drawing.Size(40, 37);
            this.btnSelect.TabIndex = 68;
            // 
            // lbTime
            // 
            this.lbTime.AutoEllipsis = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(1165, 18);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(83, 25);
            this.lbTime.TabIndex = 67;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbArtist
            // 
            this.lbArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbArtist.ForeColor = System.Drawing.Color.White;
            this.lbArtist.Location = new System.Drawing.Point(809, 18);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(188, 25);
            this.lbArtist.TabIndex = 66;
            this.lbArtist.Text = "TÊN CA SĨ";
            this.lbArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(212, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(388, 37);
            this.lbName.TabIndex = 65;
            this.lbName.Text = "1.TÊN NHẠC";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 2;
            this.gunaElipse1.TargetControl = this;
            // 
            // UcOnlineSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlayList_NameSong);
            this.Name = "UcOnlineSong";
            this.Size = new System.Drawing.Size(1260, 62);
            this.PlayList_NameSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlayList_NameSong;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaCircleButton btnSelect;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTime;
        private Bunifu.Framework.UI.BunifuCustomLabel lbArtist;
        private Bunifu.Framework.UI.BunifuCustomLabel lbName;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
