namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcSong
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
            this.btnRemove = new Guna.UI.WinForms.GunaButton();
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
            this.PlayList_NameSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.PlayList_NameSong.Controls.Add(this.btnRemove);
            this.PlayList_NameSong.Controls.Add(this.gunaPictureBox1);
            this.PlayList_NameSong.Controls.Add(this.btnSelect);
            this.PlayList_NameSong.Controls.Add(this.lbTime);
            this.PlayList_NameSong.Controls.Add(this.lbArtist);
            this.PlayList_NameSong.Controls.Add(this.lbName);
            this.PlayList_NameSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayList_NameSong.Location = new System.Drawing.Point(0, 0);
            this.PlayList_NameSong.Margin = new System.Windows.Forms.Padding(2);
            this.PlayList_NameSong.Name = "PlayList_NameSong";
            this.PlayList_NameSong.Size = new System.Drawing.Size(924, 60);
            this.PlayList_NameSong.TabIndex = 18;
            // 
            // btnRemove
            // 
            this.btnRemove.AnimationHoverSpeed = 0.07F;
            this.btnRemove.AnimationSpeed = 0.03F;
            this.btnRemove.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnRemove.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = global::MediaPlayerWindows.Properties.Resources.minus_40px_white;
            this.btnRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRemove.Location = new System.Drawing.Point(862, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.btnRemove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemove.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemove.OnHoverImage = null;
            this.btnRemove.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemove.Size = new System.Drawing.Size(62, 60);
            this.btnRemove.TabIndex = 70;
            this.btnRemove.Visible = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(135)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(135)))));
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(60, 60);
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
            this.btnSelect.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSelect.Location = new System.Drawing.Point(100, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSelect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSelect.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSelect.OnHoverImage = null;
            this.btnSelect.OnPressedColor = System.Drawing.Color.Black;
            this.btnSelect.Size = new System.Drawing.Size(40, 40);
            this.btnSelect.TabIndex = 68;
            // 
            // lbTime
            // 
            this.lbTime.AutoEllipsis = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(790, 10);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(62, 40);
            this.lbTime.TabIndex = 67;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbArtist
            // 
            this.lbArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbArtist.ForeColor = System.Drawing.Color.White;
            this.lbArtist.Location = new System.Drawing.Point(600, 10);
            this.lbArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(141, 40);
            this.lbArtist.TabIndex = 66;
            this.lbArtist.Text = "TÊN CA SĨ";
            this.lbArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(185, 10);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(405, 40);
            this.lbName.TabIndex = 65;
            this.lbName.Text = "1.TÊN NHẠC";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // UcSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PlayList_NameSong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcSong";
            this.Size = new System.Drawing.Size(924, 60);
            this.PlayList_NameSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlayList_NameSong;
        private Guna.UI.WinForms.GunaCircleButton btnSelect;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTime;
        private Bunifu.Framework.UI.BunifuCustomLabel lbArtist;
        private Bunifu.Framework.UI.BunifuCustomLabel lbName;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton btnRemove;
    }
}
