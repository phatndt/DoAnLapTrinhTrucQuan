namespace MediaPlayerWindows
{
    partial class fMusicManager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMusicManager));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMainButton = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucMusicControl = new MediaPlayerWindows.ManagerUserControl.UcMusicControl();
            this.btnTym = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTime_end = new System.Windows.Forms.Label();
            this.lblTime_start = new System.Windows.Forms.Label();
            this.ProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.btnUnMute = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureSong = new System.Windows.Forms.PictureBox();
            this.btnShuffle = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbArtist = new System.Windows.Forms.Label();
            this.btnRepeat = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbName = new System.Windows.Forms.Label();
            this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMute = new Bunifu.Framework.UI.BunifuImageButton();
            this.TrackbarVolumn = new Bunifu.Framework.UI.BunifuSlider();
            this.panelButtonExit = new System.Windows.Forms.Panel();
            this.ucSystemButton = new MediaPlayerWindows.ManagerUserControl.UcSystemButton();
            this.panelControl = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnTopEA = new Guna.UI.WinForms.GunaButton();
            this.btnTopKorea = new Guna.UI.WinForms.GunaButton();
            this.btnTopVN = new Guna.UI.WinForms.GunaButton();
            this.btnPlaylist = new Guna.UI.WinForms.GunaButton();
            this.btnFavoriteSong = new Guna.UI.WinForms.GunaButton();
            this.btnRecently = new Guna.UI.WinForms.GunaButton();
            this.btnBrowse = new Guna.UI.WinForms.GunaButton();
            this.btnHome = new Guna.UI.WinForms.GunaButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.ucNameSong1 = new MediaPlayerWindows.ManagerUserControl.UcNameSong();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.panelMainButton.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).BeginInit();
            this.panelButtonExit.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelMainButton
            // 
            this.panelMainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMainButton.Controls.Add(this.panel1);
            this.panelMainButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainButton.Location = new System.Drawing.Point(0, 670);
            this.panelMainButton.Name = "panelMainButton";
            this.panelMainButton.Size = new System.Drawing.Size(1200, 80);
            this.panelMainButton.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucMusicControl);
            this.panel1.Controls.Add(this.btnTym);
            this.panel1.Controls.Add(this.lblTime_end);
            this.panel1.Controls.Add(this.lblTime_start);
            this.panel1.Controls.Add(this.ProgressBar2);
            this.panel1.Controls.Add(this.btnUnMute);
            this.panel1.Controls.Add(this.pictureSong);
            this.panel1.Controls.Add(this.btnShuffle);
            this.panel1.Controls.Add(this.lbArtist);
            this.panel1.Controls.Add(this.btnRepeat);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnMute);
            this.panel1.Controls.Add(this.TrackbarVolumn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 35;
            // 
            // ucMusicControl
            // 
            this.ucMusicControl.Location = new System.Drawing.Point(0, 0);
            this.ucMusicControl.Name = "ucMusicControl";
            this.ucMusicControl.Size = new System.Drawing.Size(1200, 80);
            this.ucMusicControl.TabIndex = 41;
            // 
            // btnTym
            // 
            this.btnTym.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_40px;
            this.btnTym.ImageActive = null;
            this.btnTym.Location = new System.Drawing.Point(103, 56);
            this.btnTym.Name = "btnTym";
            this.btnTym.Size = new System.Drawing.Size(34, 21);
            this.btnTym.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTym.TabIndex = 3;
            this.btnTym.TabStop = false;
            this.btnTym.Zoom = 10;
            // 
            // lblTime_end
            // 
            this.lblTime_end.AutoSize = true;
            this.lblTime_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTime_end.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime_end.Location = new System.Drawing.Point(755, 49);
            this.lblTime_end.Name = "lblTime_end";
            this.lblTime_end.Size = new System.Drawing.Size(44, 17);
            this.lblTime_end.TabIndex = 40;
            this.lblTime_end.Text = "00:00";
            // 
            // lblTime_start
            // 
            this.lblTime_start.AutoSize = true;
            this.lblTime_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTime_start.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime_start.Location = new System.Drawing.Point(247, 49);
            this.lblTime_start.Name = "lblTime_start";
            this.lblTime_start.Size = new System.Drawing.Size(44, 17);
            this.lblTime_start.TabIndex = 39;
            this.lblTime_start.Text = "00:00";
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar2.BorderRadius = 5;
            this.ProgressBar2.Location = new System.Drawing.Point(298, 50);
            this.ProgressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar2.MaximumValue = 100;
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressBar2.Size = new System.Drawing.Size(450, 15);
            this.ProgressBar2.TabIndex = 38;
            this.ProgressBar2.Value = 0;
            // 
            // btnUnMute
            // 
            this.btnUnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUnMute.Image = global::MediaPlayerWindows.Properties.Resources.voice_40px;
            this.btnUnMute.ImageActive = null;
            this.btnUnMute.Location = new System.Drawing.Point(840, 39);
            this.btnUnMute.Name = "btnUnMute";
            this.btnUnMute.Size = new System.Drawing.Size(35, 35);
            this.btnUnMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUnMute.TabIndex = 0;
            this.btnUnMute.TabStop = false;
            this.btnUnMute.Zoom = 10;
            // 
            // pictureSong
            // 
            this.pictureSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureSong.Location = new System.Drawing.Point(0, 0);
            this.pictureSong.Name = "pictureSong";
            this.pictureSong.Size = new System.Drawing.Size(91, 80);
            this.pictureSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSong.TabIndex = 36;
            this.pictureSong.TabStop = false;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnShuffle.Image = global::MediaPlayerWindows.Properties.Resources.shuffle_40px;
            this.btnShuffle.ImageActive = null;
            this.btnShuffle.Location = new System.Drawing.Point(399, 13);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(25, 25);
            this.btnShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShuffle.TabIndex = 0;
            this.btnShuffle.TabStop = false;
            this.btnShuffle.Zoom = 10;
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Roboto", 10F);
            this.lbArtist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbArtist.Location = new System.Drawing.Point(100, 35);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(81, 18);
            this.lbArtist.TabIndex = 34;
            this.lbArtist.Text = "ArtistName";
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
            this.btnRepeat.ImageActive = null;
            this.btnRepeat.InitialImage = null;
            this.btnRepeat.Location = new System.Drawing.Point(599, 13);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(25, 25);
            this.btnRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRepeat.TabIndex = 0;
            this.btnRepeat.TabStop = false;
            this.btnRepeat.Zoom = 10;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbName.Location = new System.Drawing.Point(99, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(95, 20);
            this.lbName.TabIndex = 33;
            this.lbName.Text = "MusicName";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNext.Image = global::MediaPlayerWindows.Properties.Resources.end_40px;
            this.btnNext.ImageActive = null;
            this.btnNext.Location = new System.Drawing.Point(549, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 25);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            this.btnNext.Zoom = 10;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPlay.Image = global::MediaPlayerWindows.Properties.Resources.play_40px;
            this.btnPlay.ImageActive = null;
            this.btnPlay.Location = new System.Drawing.Point(499, 8);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(35, 35);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Zoom = 10;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
            this.btnPause.ImageActive = null;
            this.btnPause.Location = new System.Drawing.Point(499, 8);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(35, 35);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 0;
            this.btnPause.TabStop = false;
            this.btnPause.Zoom = 10;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPrevious.Image = global::MediaPlayerWindows.Properties.Resources.skip_to_start_40px;
            this.btnPrevious.ImageActive = null;
            this.btnPrevious.Location = new System.Drawing.Point(449, 13);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 25);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Zoom = 10;
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMute.Image = global::MediaPlayerWindows.Properties.Resources.mute_40px;
            this.btnMute.ImageActive = null;
            this.btnMute.Location = new System.Drawing.Point(840, 39);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(35, 35);
            this.btnMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMute.TabIndex = 0;
            this.btnMute.TabStop = false;
            this.btnMute.Zoom = 10;
            // 
            // TrackbarVolumn
            // 
            this.TrackbarVolumn.BackColor = System.Drawing.Color.Transparent;
            this.TrackbarVolumn.BackgroudColor = System.Drawing.Color.DarkGray;
            this.TrackbarVolumn.BorderRadius = 0;
            this.TrackbarVolumn.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.TrackbarVolumn.Location = new System.Drawing.Point(882, 45);
            this.TrackbarVolumn.Margin = new System.Windows.Forms.Padding(4);
            this.TrackbarVolumn.MaximumValue = 100;
            this.TrackbarVolumn.Name = "TrackbarVolumn";
            this.TrackbarVolumn.Size = new System.Drawing.Size(105, 30);
            this.TrackbarVolumn.TabIndex = 19;
            this.TrackbarVolumn.Value = 0;
            this.TrackbarVolumn.ValueChanged += new System.EventHandler(this.TrackbarVolumn_ValueChanged);
            // 
            // panelButtonExit
            // 
            this.panelButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelButtonExit.Controls.Add(this.ucSystemButton);
            this.panelButtonExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonExit.Location = new System.Drawing.Point(0, 0);
            this.panelButtonExit.Name = "panelButtonExit";
            this.panelButtonExit.Size = new System.Drawing.Size(1200, 30);
            this.panelButtonExit.TabIndex = 3;
            // 
            // ucSystemButton
            // 
            this.ucSystemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.ucSystemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSystemButton.Location = new System.Drawing.Point(0, 0);
            this.ucSystemButton.Name = "ucSystemButton";
            this.ucSystemButton.Size = new System.Drawing.Size(1200, 30);
            this.ucSystemButton.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.panelControl.Controls.Add(this.gunaLabel2);
            this.panelControl.Controls.Add(this.gunaLabel3);
            this.panelControl.Controls.Add(this.gunaLabel1);
            this.panelControl.Controls.Add(this.btnTopEA);
            this.panelControl.Controls.Add(this.btnTopKorea);
            this.panelControl.Controls.Add(this.btnTopVN);
            this.panelControl.Controls.Add(this.btnPlaylist);
            this.panelControl.Controls.Add(this.btnFavoriteSong);
            this.panelControl.Controls.Add(this.btnRecently);
            this.panelControl.Controls.Add(this.btnBrowse);
            this.panelControl.Controls.Add(this.btnHome);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 30);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(250, 640);
            this.panelControl.TabIndex = 4;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.gunaLabel2.Location = new System.Drawing.Point(20, 420);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(82, 25);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "ONLINE";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.gunaLabel3.Location = new System.Drawing.Point(50, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(150, 50);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "MUSICLY";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(58)))), ((int)(((byte)(93)))));
            this.gunaLabel1.Location = new System.Drawing.Point(20, 190);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(124, 25);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "MY LIBRARY";
            // 
            // btnTopEA
            // 
            this.btnTopEA.AnimationHoverSpeed = 0.07F;
            this.btnTopEA.AnimationSpeed = 0.03F;
            this.btnTopEA.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnTopEA.BorderColor = System.Drawing.Color.Black;
            this.btnTopEA.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTopEA.FocusedColor = System.Drawing.Color.Empty;
            this.btnTopEA.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnTopEA.ForeColor = System.Drawing.Color.White;
            this.btnTopEA.Image = global::MediaPlayerWindows.Properties.Resources.playlist_40px;
            this.btnTopEA.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTopEA.Location = new System.Drawing.Point(25, 579);
            this.btnTopEA.Name = "btnTopEA";
            this.btnTopEA.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnTopEA.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(126)))), ((int)(((byte)(146)))));
            this.btnTopEA.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTopEA.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.playlist_green_40px;
            this.btnTopEA.OnPressedColor = System.Drawing.Color.Black;
            this.btnTopEA.Size = new System.Drawing.Size(225, 45);
            this.btnTopEA.TabIndex = 1;
            this.btnTopEA.Text = "BXH ÂU MĨ";
            this.btnTopEA.TextOffsetX = 10;
            // 
            // btnTopKorea
            // 
            this.btnTopKorea.AnimationHoverSpeed = 0.07F;
            this.btnTopKorea.AnimationSpeed = 0.03F;
            this.btnTopKorea.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnTopKorea.BorderColor = System.Drawing.Color.Black;
            this.btnTopKorea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTopKorea.FocusedColor = System.Drawing.Color.Empty;
            this.btnTopKorea.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnTopKorea.ForeColor = System.Drawing.Color.White;
            this.btnTopKorea.Image = global::MediaPlayerWindows.Properties.Resources.playlist_40px;
            this.btnTopKorea.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTopKorea.Location = new System.Drawing.Point(25, 520);
            this.btnTopKorea.Name = "btnTopKorea";
            this.btnTopKorea.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnTopKorea.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(126)))), ((int)(((byte)(146)))));
            this.btnTopKorea.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTopKorea.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.playlist_green_40px;
            this.btnTopKorea.OnPressedColor = System.Drawing.Color.Black;
            this.btnTopKorea.Size = new System.Drawing.Size(225, 45);
            this.btnTopKorea.TabIndex = 1;
            this.btnTopKorea.Text = "BXH HÀN QUỐC";
            this.btnTopKorea.TextOffsetX = 10;
            // 
            // btnTopVN
            // 
            this.btnTopVN.AnimationHoverSpeed = 0.07F;
            this.btnTopVN.AnimationSpeed = 0.03F;
            this.btnTopVN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnTopVN.BorderColor = System.Drawing.Color.Black;
            this.btnTopVN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTopVN.FocusedColor = System.Drawing.Color.Empty;
            this.btnTopVN.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnTopVN.ForeColor = System.Drawing.Color.White;
            this.btnTopVN.Image = global::MediaPlayerWindows.Properties.Resources.playlist_40px;
            this.btnTopVN.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTopVN.Location = new System.Drawing.Point(25, 460);
            this.btnTopVN.Name = "btnTopVN";
            this.btnTopVN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnTopVN.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(126)))), ((int)(((byte)(146)))));
            this.btnTopVN.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTopVN.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.playlist_green_40px;
            this.btnTopVN.OnPressedColor = System.Drawing.Color.Black;
            this.btnTopVN.Size = new System.Drawing.Size(225, 45);
            this.btnTopVN.TabIndex = 1;
            this.btnTopVN.Text = "BXH VIỆT NAM";
            this.btnTopVN.TextOffsetX = 10;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.AnimationHoverSpeed = 0.07F;
            this.btnPlaylist.AnimationSpeed = 0.03F;
            this.btnPlaylist.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnPlaylist.BorderColor = System.Drawing.Color.Black;
            this.btnPlaylist.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaylist.FocusedColor = System.Drawing.Color.Empty;
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnPlaylist.Image = global::MediaPlayerWindows.Properties.Resources.playlist_40px;
            this.btnPlaylist.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPlaylist.Location = new System.Drawing.Point(25, 360);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnPlaylist.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(126)))), ((int)(((byte)(146)))));
            this.btnPlaylist.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPlaylist.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.playlist_green_40px;
            this.btnPlaylist.OnPressedColor = System.Drawing.Color.Black;
            this.btnPlaylist.Size = new System.Drawing.Size(150, 45);
            this.btnPlaylist.TabIndex = 1;
            this.btnPlaylist.Text = "PLAYLIST";
            this.btnPlaylist.TextOffsetX = 10;
            // 
            // btnFavoriteSong
            // 
            this.btnFavoriteSong.AnimationHoverSpeed = 0.07F;
            this.btnFavoriteSong.AnimationSpeed = 0.03F;
            this.btnFavoriteSong.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnFavoriteSong.BorderColor = System.Drawing.Color.Black;
            this.btnFavoriteSong.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFavoriteSong.FocusedColor = System.Drawing.Color.Empty;
            this.btnFavoriteSong.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnFavoriteSong.ForeColor = System.Drawing.Color.White;
            this.btnFavoriteSong.Image = global::MediaPlayerWindows.Properties.Resources.heart_white_40px;
            this.btnFavoriteSong.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFavoriteSong.Location = new System.Drawing.Point(25, 295);
            this.btnFavoriteSong.Name = "btnFavoriteSong";
            this.btnFavoriteSong.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnFavoriteSong.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(126)))), ((int)(((byte)(146)))));
            this.btnFavoriteSong.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFavoriteSong.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.heart_outline_40px;
            this.btnFavoriteSong.OnPressedColor = System.Drawing.Color.Black;
            this.btnFavoriteSong.Size = new System.Drawing.Size(225, 45);
            this.btnFavoriteSong.TabIndex = 1;
            this.btnFavoriteSong.Text = "FAVORITE SONG";
            this.btnFavoriteSong.TextOffsetX = 10;
            // 
            // btnRecently
            // 
            this.btnRecently.AnimationHoverSpeed = 0.07F;
            this.btnRecently.AnimationSpeed = 0.03F;
            this.btnRecently.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnRecently.BorderColor = System.Drawing.Color.Black;
            this.btnRecently.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRecently.FocusedColor = System.Drawing.Color.Empty;
            this.btnRecently.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnRecently.ForeColor = System.Drawing.Color.White;
            this.btnRecently.Image = global::MediaPlayerWindows.Properties.Resources.time_machine_40px;
            this.btnRecently.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRecently.Location = new System.Drawing.Point(25, 230);
            this.btnRecently.Name = "btnRecently";
            this.btnRecently.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnRecently.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(126)))), ((int)(((byte)(146)))));
            this.btnRecently.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRecently.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.time_machine_green_40px;
            this.btnRecently.OnPressedColor = System.Drawing.Color.Black;
            this.btnRecently.Size = new System.Drawing.Size(225, 45);
            this.btnRecently.TabIndex = 1;
            this.btnRecently.Text = "RECENTLY PLAYER";
            this.btnRecently.TextOffsetX = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AnimationHoverSpeed = 0.07F;
            this.btnBrowse.AnimationSpeed = 0.03F;
            this.btnBrowse.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnBrowse.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = global::MediaPlayerWindows.Properties.Resources.search_40px;
            this.btnBrowse.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBrowse.Location = new System.Drawing.Point(25, 130);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnBrowse.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(126)))), ((int)(((byte)(146)))));
            this.btnBrowse.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBrowse.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.search_green_40px;
            this.btnBrowse.OnPressedColor = System.Drawing.Color.Black;
            this.btnBrowse.Size = new System.Drawing.Size(150, 45);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.TextOffsetX = 10;
            // 
            // btnHome
            // 
            this.btnHome.AnimationHoverSpeed = 0.07F;
            this.btnHome.AnimationSpeed = 0.03F;
            this.btnHome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnHome.BorderColor = System.Drawing.Color.Black;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.FocusedColor = System.Drawing.Color.Empty;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::MediaPlayerWindows.Properties.Resources.home_40px;
            this.btnHome.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHome.Location = new System.Drawing.Point(25, 75);
            this.btnHome.Name = "btnHome";
            this.btnHome.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnHome.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(126)))), ((int)(((byte)(146)))));
            this.btnHome.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHome.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.home_green_40px;
            this.btnHome.OnPressedColor = System.Drawing.Color.Black;
            this.btnHome.Size = new System.Drawing.Size(150, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.TextOffsetX = 10;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMain.Controls.Add(this.ucNameSong1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(950, 640);
            this.panelMain.TabIndex = 5;
            // 
            // ucNameSong1
            // 
            this.ucNameSong1.BackColor = System.Drawing.Color.White;
            this.ucNameSong1.Location = new System.Drawing.Point(2, 5);
            this.ucNameSong1.Margin = new System.Windows.Forms.Padding(2);
            this.ucNameSong1.Name = "ucNameSong1";
            this.ucNameSong1.Size = new System.Drawing.Size(543, 41);
            this.ucNameSong1.TabIndex = 1;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.ucSystemButton;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // fMusicManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelButtonExit);
            this.Controls.Add(this.panelMainButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMusicManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Phần mềm nghe nhạc";
            this.panelMainButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).EndInit();
            this.panelButtonExit.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelMainButton;
        private System.Windows.Forms.Panel panelButtonExit;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelControl;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnTym;
        private System.Windows.Forms.Label lblTime_end;
        private System.Windows.Forms.Label lblTime_start;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar2;
        private Bunifu.Framework.UI.BunifuImageButton btnUnMute;
        private System.Windows.Forms.PictureBox pictureSong;
        private Bunifu.Framework.UI.BunifuImageButton btnShuffle;
        private System.Windows.Forms.Label lbArtist;
        private Bunifu.Framework.UI.BunifuImageButton btnRepeat;
        private System.Windows.Forms.Label lbName;
        private Bunifu.Framework.UI.BunifuImageButton btnNext;
        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private Bunifu.Framework.UI.BunifuImageButton btnPause;
        private Bunifu.Framework.UI.BunifuImageButton btnPrevious;
        private Bunifu.Framework.UI.BunifuImageButton btnMute;
        private Bunifu.Framework.UI.BunifuSlider TrackbarVolumn;
        private Guna.UI.WinForms.GunaButton btnHome;
        private ManagerUserControl.UcSystemButton ucSystemButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnBrowse;
        private Guna.UI.WinForms.GunaButton btnPlaylist;
        private Guna.UI.WinForms.GunaButton btnFavoriteSong;
        private Guna.UI.WinForms.GunaButton btnRecently;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnTopEA;
        private Guna.UI.WinForms.GunaButton btnTopKorea;
        private Guna.UI.WinForms.GunaButton btnTopVN;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        public Guna.UI.WinForms.GunaResize gunaResize1;
        private ManagerUserControl.UcMusicControl ucMusicControl;
        private ManagerUserControl.UcNameSong ucNameSong1;
    }
}