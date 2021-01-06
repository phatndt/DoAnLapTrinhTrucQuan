namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcMusicControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMusicControl));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btnPreivous = new Guna.UI.WinForms.GunaCircleButton();
            this.btnShuffle = new Guna.UI.WinForms.GunaCircleButton();
            this.btnPlayPause = new Guna.UI.WinForms.GunaCircleButton();
            this.btnRepeat = new Guna.UI.WinForms.GunaCircleButton();
            this.btnNext = new Guna.UI.WinForms.GunaCircleButton();
            this.btnVolumn = new Guna.UI.WinForms.GunaCircleButton();
            this.btnAddPlaylist = new Guna.UI.WinForms.GunaCircleButton();
            this.btnTym = new Guna.UI.WinForms.GunaCircleButton();
            this.btnLyrics = new Guna.UI.WinForms.GunaCircleButton();
            this.TrackbarVolumn = new Guna.UI.WinForms.GunaTrackBar();
            this.lblTime_end = new Guna.UI.WinForms.GunaLabel();
            this.lblTime_start = new Guna.UI.WinForms.GunaLabel();
            this.lbArtist = new Guna.UI.WinForms.GunaLabel();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.pictureSong = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.TrackbarMusic = new Guna.UI.WinForms.GunaTrackBar();
            this.bunifuGradientPanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.gunaPanel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.Window;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1200, 80);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Controls.Add(this.btnVolumn);
            this.gunaPanel1.Controls.Add(this.btnAddPlaylist);
            this.gunaPanel1.Controls.Add(this.btnTym);
            this.gunaPanel1.Controls.Add(this.TrackbarVolumn);
            this.gunaPanel1.Controls.Add(this.lblTime_end);
            this.gunaPanel1.Controls.Add(this.lblTime_start);
            this.gunaPanel1.Controls.Add(this.lbArtist);
            this.gunaPanel1.Controls.Add(this.lbName);
            this.gunaPanel1.Controls.Add(this.pictureSong);
            this.gunaPanel1.Controls.Add(this.TrackbarMusic);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1200, 80);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.btnPreivous);
            this.gunaPanel2.Controls.Add(this.btnShuffle);
            this.gunaPanel2.Controls.Add(this.btnPlayPause);
            this.gunaPanel2.Controls.Add(this.btnRepeat);
            this.gunaPanel2.Controls.Add(this.btnLyrics);
            this.gunaPanel2.Controls.Add(this.btnNext);
            this.gunaPanel2.Location = new System.Drawing.Point(479, 10);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(290, 40);
            this.gunaPanel2.TabIndex = 60;
            // 
            // btnPreivous
            // 
            this.btnPreivous.Animated = true;
            this.btnPreivous.AnimationHoverSpeed = 0.07F;
            this.btnPreivous.AnimationSpeed = 0.03F;
            this.btnPreivous.BaseColor = System.Drawing.Color.White;
            this.btnPreivous.BorderColor = System.Drawing.Color.Black;
            this.btnPreivous.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPreivous.FocusedColor = System.Drawing.Color.Empty;
            this.btnPreivous.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreivous.ForeColor = System.Drawing.Color.White;
            this.btnPreivous.Image = global::MediaPlayerWindows.Properties.Resources.skip_to_start_40px;
            this.btnPreivous.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPreivous.Location = new System.Drawing.Point(62, 0);
            this.btnPreivous.Name = "btnPreivous";
            this.btnPreivous.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnPreivous.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.btnPreivous.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btnPreivous.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.skip_to_start_40px_green;
            this.btnPreivous.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPreivous.Size = new System.Drawing.Size(40, 40);
            this.btnPreivous.TabIndex = 59;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Animated = true;
            this.btnShuffle.AnimationHoverSpeed = 0.07F;
            this.btnShuffle.AnimationSpeed = 0.03F;
            this.btnShuffle.BaseColor = System.Drawing.Color.White;
            this.btnShuffle.BorderColor = System.Drawing.Color.Black;
            this.btnShuffle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShuffle.FocusedColor = System.Drawing.Color.Empty;
            this.btnShuffle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShuffle.ForeColor = System.Drawing.Color.White;
            this.btnShuffle.Image = global::MediaPlayerWindows.Properties.Resources.shuffle_40px;
            this.btnShuffle.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShuffle.Location = new System.Drawing.Point(0, 0);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnShuffle.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.btnShuffle.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btnShuffle.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.shuffle_40px_green;
            this.btnShuffle.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnShuffle.Size = new System.Drawing.Size(40, 40);
            this.btnShuffle.TabIndex = 59;
            this.btnShuffle.Visible = false;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Animated = true;
            this.btnPlayPause.AnimationHoverSpeed = 0.07F;
            this.btnPlayPause.AnimationSpeed = 0.03F;
            this.btnPlayPause.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.btnPlayPause.BorderColor = System.Drawing.Color.Black;
            this.btnPlayPause.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlayPause.FocusedColor = System.Drawing.Color.Empty;
            this.btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
            this.btnPlayPause.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPlayPause.Location = new System.Drawing.Point(120, 0);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPlayPause.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPlayPause.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPlayPause.OnHoverImage = null;
            this.btnPlayPause.OnPressedColor = System.Drawing.Color.Black;
            this.btnPlayPause.Size = new System.Drawing.Size(40, 40);
            this.btnPlayPause.TabIndex = 59;
            // 
            // btnRepeat
            // 
            this.btnRepeat.Animated = true;
            this.btnRepeat.AnimationHoverSpeed = 0.07F;
            this.btnRepeat.AnimationSpeed = 0.03F;
            this.btnRepeat.BaseColor = System.Drawing.Color.White;
            this.btnRepeat.BorderColor = System.Drawing.Color.Black;
            this.btnRepeat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRepeat.FocusedColor = System.Drawing.Color.Empty;
            this.btnRepeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRepeat.ForeColor = System.Drawing.Color.White;
            this.btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
            this.btnRepeat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRepeat.Location = new System.Drawing.Point(250, 0);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnRepeat.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.btnRepeat.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btnRepeat.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.repeat_one_40px_green;
            this.btnRepeat.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRepeat.Size = new System.Drawing.Size(40, 40);
            this.btnRepeat.TabIndex = 59;
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.AnimationHoverSpeed = 0.07F;
            this.btnNext.AnimationSpeed = 0.03F;
            this.btnNext.BaseColor = System.Drawing.Color.White;
            this.btnNext.BorderColor = System.Drawing.Color.Black;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::MediaPlayerWindows.Properties.Resources.end_40px;
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(190, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.btnNext.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btnNext.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.end_40px_greej;
            this.btnNext.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 59;
            // 
            // btnVolumn
            // 
            this.btnVolumn.Animated = true;
            this.btnVolumn.AnimationHoverSpeed = 0.07F;
            this.btnVolumn.AnimationSpeed = 0.03F;
            this.btnVolumn.BaseColor = System.Drawing.Color.White;
            this.btnVolumn.BorderColor = System.Drawing.Color.Black;
            this.btnVolumn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVolumn.FocusedColor = System.Drawing.Color.Empty;
            this.btnVolumn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolumn.ForeColor = System.Drawing.Color.White;
            this.btnVolumn.Image = global::MediaPlayerWindows.Properties.Resources.voice_40px;
            this.btnVolumn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVolumn.Location = new System.Drawing.Point(1037, 20);
            this.btnVolumn.Name = "btnVolumn";
            this.btnVolumn.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnVolumn.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.btnVolumn.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btnVolumn.OnHoverImage = null;
            this.btnVolumn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnVolumn.OnPressedDepth = 15;
            this.btnVolumn.Size = new System.Drawing.Size(40, 40);
            this.btnVolumn.TabIndex = 59;
            this.btnVolumn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit;
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.AnimationHoverSpeed = 0.07F;
            this.btnAddPlaylist.AnimationSpeed = 0.03F;
            this.btnAddPlaylist.BaseColor = System.Drawing.Color.White;
            this.btnAddPlaylist.BorderColor = System.Drawing.Color.White;
            this.btnAddPlaylist.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPlaylist.Enabled = false;
            this.btnAddPlaylist.FocusedColor = System.Drawing.Color.White;
            this.btnAddPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnAddPlaylist.Image = global::MediaPlayerWindows.Properties.Resources.plus_40pxx;
            this.btnAddPlaylist.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddPlaylist.Location = new System.Drawing.Point(137, 55);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddPlaylist.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnAddPlaylist.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddPlaylist.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.plus_40px_green;
            this.btnAddPlaylist.OnPressedColor = System.Drawing.Color.White;
            this.btnAddPlaylist.Size = new System.Drawing.Size(20, 20);
            this.btnAddPlaylist.TabIndex = 59;
            // 
            // btnTym
            // 
            this.btnTym.AnimationHoverSpeed = 0.07F;
            this.btnTym.AnimationSpeed = 0.03F;
            this.btnTym.BaseColor = System.Drawing.Color.White;
            this.btnTym.BorderColor = System.Drawing.Color.White;
            this.btnTym.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTym.Enabled = false;
            this.btnTym.FocusedColor = System.Drawing.Color.White;
            this.btnTym.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTym.ForeColor = System.Drawing.Color.White;
            this.btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_40px;
            this.btnTym.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTym.Location = new System.Drawing.Point(111, 55);
            this.btnTym.Name = "btnTym";
            this.btnTym.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnTym.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnTym.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTym.OnHoverImage = null;
            this.btnTym.OnPressedColor = System.Drawing.Color.White;
            this.btnTym.Size = new System.Drawing.Size(20, 20);
            this.btnTym.TabIndex = 59;
            // 
            // btnLyrics
            // 
            this.btnLyrics.Animated = true;
            this.btnLyrics.AnimationHoverSpeed = 0.07F;
            this.btnLyrics.AnimationSpeed = 0.03F;
            this.btnLyrics.BaseColor = System.Drawing.Color.White;
            this.btnLyrics.BorderColor = System.Drawing.Color.Black;
            this.btnLyrics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLyrics.FocusedColor = System.Drawing.Color.Empty;
            this.btnLyrics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLyrics.ForeColor = System.Drawing.Color.White;
            this.btnLyrics.Image = global::MediaPlayerWindows.Properties.Resources.explicit_30px;
            this.btnLyrics.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLyrics.Location = new System.Drawing.Point(0, 0);
            this.btnLyrics.Name = "btnLyrics";
            this.btnLyrics.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnLyrics.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.btnLyrics.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btnLyrics.OnHoverImage = null;
            this.btnLyrics.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLyrics.Size = new System.Drawing.Size(40, 40);
            this.btnLyrics.TabIndex = 59;
            // 
            // TrackbarVolumn
            // 
            this.TrackbarVolumn.Location = new System.Drawing.Point(1083, 30);
            this.TrackbarVolumn.Name = "TrackbarVolumn";
            this.TrackbarVolumn.Size = new System.Drawing.Size(100, 20);
            this.TrackbarVolumn.TabIndex = 58;
            this.TrackbarVolumn.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.TrackbarVolumn.TrackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.TrackbarVolumn.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.TrackbarVolumn.TrackPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            // 
            // lblTime_end
            // 
            this.lblTime_end.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTime_end.Location = new System.Drawing.Point(906, 55);
            this.lblTime_end.Name = "lblTime_end";
            this.lblTime_end.Size = new System.Drawing.Size(44, 20);
            this.lblTime_end.TabIndex = 56;
            this.lblTime_end.Text = "00:00";
            this.lblTime_end.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime_start
            // 
            this.lblTime_start.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTime_start.Location = new System.Drawing.Point(250, 55);
            this.lblTime_start.Name = "lblTime_start";
            this.lblTime_start.Size = new System.Drawing.Size(44, 20);
            this.lblTime_start.TabIndex = 56;
            this.lblTime_start.Text = "00:00";
            this.lblTime_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbArtist.Location = new System.Drawing.Point(107, 35);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(39, 19);
            this.lbArtist.TabIndex = 56;
            this.lbArtist.Text = "Keyp";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(106, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(164, 21);
            this.lbName.TabIndex = 57;
            this.lbName.Text = "Xin một lần ngoại lệ";
            // 
            // pictureSong
            // 
            this.pictureSong.BackColor = System.Drawing.Color.Transparent;
            this.pictureSong.BaseColor = System.Drawing.Color.White;
            this.pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.BackgroundLogin;
            this.pictureSong.Location = new System.Drawing.Point(28, 5);
            this.pictureSong.Name = "pictureSong";
            this.pictureSong.Size = new System.Drawing.Size(70, 70);
            this.pictureSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSong.TabIndex = 55;
            this.pictureSong.TabStop = false;
            this.pictureSong.UseTransfarantBackground = false;
            // 
            // TrackbarMusic
            // 
            this.TrackbarMusic.Location = new System.Drawing.Point(300, 55);
            this.TrackbarMusic.Name = "TrackbarMusic";
            this.TrackbarMusic.Size = new System.Drawing.Size(600, 20);
            this.TrackbarMusic.TabIndex = 54;
            this.TrackbarMusic.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.TrackbarMusic.TrackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.TrackbarMusic.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.TrackbarMusic.TrackPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.TrackbarMusic.Value = 0;
            // 
            // UcMusicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "UcMusicControl";
            this.Size = new System.Drawing.Size(1200, 80);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaCircleButton btnTym;
        private Guna.UI.WinForms.GunaTrackBar TrackbarVolumn;
        private Guna.UI.WinForms.GunaLabel lblTime_start;
        private Guna.UI.WinForms.GunaLabel lbArtist;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaCirclePictureBox pictureSong;
        private Guna.UI.WinForms.GunaTrackBar TrackbarMusic;
        private Guna.UI.WinForms.GunaCircleButton btnNext;
        private Guna.UI.WinForms.GunaCircleButton btnVolumn;
        private Guna.UI.WinForms.GunaCircleButton btnShuffle;
        private Guna.UI.WinForms.GunaCircleButton btnRepeat;
        private Guna.UI.WinForms.GunaCircleButton btnPreivous;
        private Guna.UI.WinForms.GunaCircleButton btnPlayPause;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaLabel lblTime_end;
        private System.Windows.Forms.Timer timer;
        private Guna.UI.WinForms.GunaCircleButton btnLyrics;
        private Guna.UI.WinForms.GunaCircleButton btnAddPlaylist;
    }
}
