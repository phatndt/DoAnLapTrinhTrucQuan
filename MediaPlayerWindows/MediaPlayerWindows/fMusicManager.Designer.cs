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
            this.panelButtonExit = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnTopEA = new Guna.UI.WinForms.GunaButton();
            this.btnTopKO = new Guna.UI.WinForms.GunaButton();
            this.btnTopVN = new Guna.UI.WinForms.GunaButton();
            this.btnPlaylist = new Guna.UI.WinForms.GunaButton();
            this.btnFavoriteSong = new Guna.UI.WinForms.GunaButton();
            this.btnRecently = new Guna.UI.WinForms.GunaButton();
            this.btnBrowse = new Guna.UI.WinForms.GunaButton();
            this.btnHome = new Guna.UI.WinForms.GunaButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.ucPlaylistList1 = new MediaPlayerWindows.UcPlaylistList();
            this.ucSystemButton = new MediaPlayerWindows.ManagerUserControl.UcSystemButton();
            this.ucMusicControl = new MediaPlayerWindows.ManagerUserControl.UcMusicControl();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelMainButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelButtonExit.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 35;
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
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.panelControl.Controls.Add(this.gunaLabel2);
            this.panelControl.Controls.Add(this.gunaLabel3);
            this.panelControl.Controls.Add(this.gunaLabel1);
            this.panelControl.Controls.Add(this.gunaButton1);
            this.panelControl.Controls.Add(this.btnTopEA);
            this.panelControl.Controls.Add(this.btnTopKO);
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
            this.gunaLabel2.Location = new System.Drawing.Point(22, 379);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(82, 25);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "ONLINE";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.gunaLabel3.Location = new System.Drawing.Point(51, 4);
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
            this.gunaLabel1.Location = new System.Drawing.Point(22, 161);
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
            this.btnTopEA.Location = new System.Drawing.Point(27, 536);
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
            // btnTopKO
            // 
            this.btnTopKO.AnimationHoverSpeed = 0.07F;
            this.btnTopKO.AnimationSpeed = 0.03F;
            this.btnTopKO.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnTopKO.BorderColor = System.Drawing.Color.Black;
            this.btnTopKO.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTopKO.FocusedColor = System.Drawing.Color.Empty;
            this.btnTopKO.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnTopKO.ForeColor = System.Drawing.Color.White;
            this.btnTopKO.Image = global::MediaPlayerWindows.Properties.Resources.playlist_40px;
            this.btnTopKO.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTopKO.Location = new System.Drawing.Point(27, 477);
            this.btnTopKO.Name = "btnTopKO";
            this.btnTopKO.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.btnTopKO.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(126)))), ((int)(((byte)(146)))));
            this.btnTopKO.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTopKO.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.playlist_green_40px;
            this.btnTopKO.OnPressedColor = System.Drawing.Color.Black;
            this.btnTopKO.Size = new System.Drawing.Size(225, 45);
            this.btnTopKO.TabIndex = 1;
            this.btnTopKO.Text = "BXH HÀN QUỐC";
            this.btnTopKO.TextOffsetX = 10;
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
            this.btnTopVN.Location = new System.Drawing.Point(27, 417);
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
            this.btnPlaylist.Location = new System.Drawing.Point(27, 319);
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
            this.btnFavoriteSong.Location = new System.Drawing.Point(27, 259);
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
            this.btnRecently.Location = new System.Drawing.Point(27, 201);
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
            this.btnBrowse.Location = new System.Drawing.Point(27, 101);
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
            this.btnHome.Location = new System.Drawing.Point(27, 46);
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
            this.panelMain.Controls.Add(this.ucPlaylistList1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(950, 640);
            this.panelMain.TabIndex = 5;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::MediaPlayerWindows.Properties.Resources.playlist_40px;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(28, 595);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(126)))), ((int)(((byte)(146)))));
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.gunaButton1.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.playlist_green_40px;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(224, 38);
            this.gunaButton1.TabIndex = 1;
            this.gunaButton1.Text = "DOWNLOAD MUSIC";
            this.gunaButton1.TextOffsetX = 10;
            // 
            // ucPlaylistList1
            // 
            this.ucPlaylistList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.ucPlaylistList1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPlaylistList1.Location = new System.Drawing.Point(0, 520);
            this.ucPlaylistList1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPlaylistList1.Name = "ucPlaylistList1";
            this.ucPlaylistList1.Size = new System.Drawing.Size(950, 120);
            this.ucPlaylistList1.TabIndex = 0;
            // 
            // ucSystemButton
            // 
            this.ucSystemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.ucSystemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSystemButton.Location = new System.Drawing.Point(0, 0);
            this.ucSystemButton.Margin = new System.Windows.Forms.Padding(4);
            this.ucSystemButton.Name = "ucSystemButton";
            this.ucSystemButton.Size = new System.Drawing.Size(1200, 30);
            this.ucSystemButton.TabIndex = 0;
            // 
            // ucMusicControl
            // 
            this.ucMusicControl.Location = new System.Drawing.Point(0, 0);
            this.ucMusicControl.Margin = new System.Windows.Forms.Padding(4);
            this.ucMusicControl.Name = "ucMusicControl";
            this.ucMusicControl.Size = new System.Drawing.Size(1200, 80);
            this.ucMusicControl.TabIndex = 41;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.ucSystemButton;
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fMusicManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Phần mềm nghe nhạc";
            this.panelMainButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private Guna.UI.WinForms.GunaButton btnHome;
        private ManagerUserControl.UcSystemButton ucSystemButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnBrowse;
        private Guna.UI.WinForms.GunaButton btnPlaylist;
        private Guna.UI.WinForms.GunaButton btnFavoriteSong;
        private Guna.UI.WinForms.GunaButton btnRecently;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnTopEA;
        private Guna.UI.WinForms.GunaButton btnTopKO;
        private Guna.UI.WinForms.GunaButton btnTopVN;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        public Guna.UI.WinForms.GunaResize gunaResize1;
        private ManagerUserControl.UcMusicControl ucMusicControl;
        private UcPlaylistList ucPlaylistList1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}