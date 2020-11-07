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
            System.Windows.Forms.PictureBox pB_Logo;
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnAddPlayList = new System.Windows.Forms.Button();
            this.btnOnlineMusic = new System.Windows.Forms.Button();
            this.panelMusicOfYou = new System.Windows.Forms.Panel();
            this.btnPlayLists = new System.Windows.Forms.Button();
            this.btnArtists = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnMusicOfYou = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnLognOut = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lblTime_end = new System.Windows.Forms.Label();
            this.lblTime_start = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            pB_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pB_Logo)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panelMusicOfYou.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_Logo
            // 
            pB_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            pB_Logo.Image = global::MediaPlayerWindows.Properties.Resources.Lg;
            pB_Logo.Location = new System.Drawing.Point(0, 0);
            pB_Logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pB_Logo.Name = "pB_Logo";
            pB_Logo.Size = new System.Drawing.Size(352, 98);
            pB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pB_Logo.TabIndex = 3;
            pB_Logo.TabStop = false;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelControl.Controls.Add(this.btnAddPlayList);
            this.panelControl.Controls.Add(this.btnOnlineMusic);
            this.panelControl.Controls.Add(this.panelMusicOfYou);
            this.panelControl.Controls.Add(this.btnMusicOfYou);
            this.panelControl.Controls.Add(this.panelUser);
            this.panelControl.Controls.Add(this.btnUser);
            this.panelControl.Controls.Add(this.panelSearch);
            this.panelControl.Controls.Add(pB_Logo);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(352, 769);
            this.panelControl.TabIndex = 0;
            // 
            // btnAddPlayList
            // 
            this.btnAddPlayList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddPlayList.FlatAppearance.BorderSize = 0;
            this.btnAddPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlayList.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnAddPlayList.ForeColor = System.Drawing.Color.Silver;
            this.btnAddPlayList.Location = new System.Drawing.Point(0, 720);
            this.btnAddPlayList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPlayList.Name = "btnAddPlayList";
            this.btnAddPlayList.Size = new System.Drawing.Size(352, 49);
            this.btnAddPlayList.TabIndex = 9;
            this.btnAddPlayList.Text = "Tạo playList mới";
            this.btnAddPlayList.UseVisualStyleBackColor = true;
            // 
            // btnOnlineMusic
            // 
            this.btnOnlineMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOnlineMusic.FlatAppearance.BorderSize = 0;
            this.btnOnlineMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnlineMusic.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnOnlineMusic.ForeColor = System.Drawing.Color.Silver;
            this.btnOnlineMusic.Location = new System.Drawing.Point(0, 545);
            this.btnOnlineMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOnlineMusic.Name = "btnOnlineMusic";
            this.btnOnlineMusic.Size = new System.Drawing.Size(352, 49);
            this.btnOnlineMusic.TabIndex = 8;
            this.btnOnlineMusic.Text = "Nhạc online";
            this.btnOnlineMusic.UseVisualStyleBackColor = true;
            // 
            // panelMusicOfYou
            // 
            this.panelMusicOfYou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMusicOfYou.Controls.Add(this.btnPlayLists);
            this.panelMusicOfYou.Controls.Add(this.btnArtists);
            this.panelMusicOfYou.Controls.Add(this.btnAlbums);
            this.panelMusicOfYou.Controls.Add(this.btnMusic);
            this.panelMusicOfYou.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMusicOfYou.Location = new System.Drawing.Point(0, 367);
            this.panelMusicOfYou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMusicOfYou.Name = "panelMusicOfYou";
            this.panelMusicOfYou.Size = new System.Drawing.Size(352, 178);
            this.panelMusicOfYou.TabIndex = 7;
            // 
            // btnPlayLists
            // 
            this.btnPlayLists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayLists.FlatAppearance.BorderSize = 0;
            this.btnPlayLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayLists.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnPlayLists.ForeColor = System.Drawing.Color.Silver;
            this.btnPlayLists.Location = new System.Drawing.Point(0, 129);
            this.btnPlayLists.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayLists.Name = "btnPlayLists";
            this.btnPlayLists.Size = new System.Drawing.Size(352, 43);
            this.btnPlayLists.TabIndex = 6;
            this.btnPlayLists.Text = "PlayLists";
            this.btnPlayLists.UseVisualStyleBackColor = true;
            // 
            // btnArtists
            // 
            this.btnArtists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArtists.FlatAppearance.BorderSize = 0;
            this.btnArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtists.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnArtists.ForeColor = System.Drawing.Color.Silver;
            this.btnArtists.Location = new System.Drawing.Point(0, 86);
            this.btnArtists.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArtists.Name = "btnArtists";
            this.btnArtists.Size = new System.Drawing.Size(352, 43);
            this.btnArtists.TabIndex = 6;
            this.btnArtists.Text = "Ca sĩ";
            this.btnArtists.UseVisualStyleBackColor = true;
            // 
            // btnAlbums
            // 
            this.btnAlbums.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlbums.FlatAppearance.BorderSize = 0;
            this.btnAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbums.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnAlbums.ForeColor = System.Drawing.Color.Silver;
            this.btnAlbums.Location = new System.Drawing.Point(0, 43);
            this.btnAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(352, 43);
            this.btnAlbums.TabIndex = 6;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.UseVisualStyleBackColor = true;
            // 
            // btnMusic
            // 
            this.btnMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusic.FlatAppearance.BorderSize = 0;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnMusic.ForeColor = System.Drawing.Color.Silver;
            this.btnMusic.Location = new System.Drawing.Point(0, 0);
            this.btnMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(352, 43);
            this.btnMusic.TabIndex = 6;
            this.btnMusic.Text = "Nhạc";
            this.btnMusic.UseVisualStyleBackColor = true;
            // 
            // btnMusicOfYou
            // 
            this.btnMusicOfYou.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusicOfYou.FlatAppearance.BorderSize = 0;
            this.btnMusicOfYou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicOfYou.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnMusicOfYou.ForeColor = System.Drawing.Color.Silver;
            this.btnMusicOfYou.Location = new System.Drawing.Point(0, 318);
            this.btnMusicOfYou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMusicOfYou.Name = "btnMusicOfYou";
            this.btnMusicOfYou.Size = new System.Drawing.Size(352, 49);
            this.btnMusicOfYou.TabIndex = 6;
            this.btnMusicOfYou.Text = "Nhạc của bạn";
            this.btnMusicOfYou.UseVisualStyleBackColor = true;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelUser.Controls.Add(this.btnLognOut);
            this.panelUser.Controls.Add(this.btnSetting);
            this.panelUser.Controls.Add(this.btnUserInfo);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 183);
            this.panelUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(352, 135);
            this.panelUser.TabIndex = 5;
            // 
            // btnLognOut
            // 
            this.btnLognOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLognOut.FlatAppearance.BorderSize = 0;
            this.btnLognOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLognOut.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnLognOut.ForeColor = System.Drawing.Color.Silver;
            this.btnLognOut.Location = new System.Drawing.Point(0, 86);
            this.btnLognOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLognOut.Name = "btnLognOut";
            this.btnLognOut.Size = new System.Drawing.Size(352, 43);
            this.btnLognOut.TabIndex = 2;
            this.btnLognOut.Text = "Đăng xuất";
            this.btnLognOut.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnSetting.ForeColor = System.Drawing.Color.Silver;
            this.btnSetting.Location = new System.Drawing.Point(0, 43);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(352, 43);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserInfo.FlatAppearance.BorderSize = 0;
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnUserInfo.ForeColor = System.Drawing.Color.Silver;
            this.btnUserInfo.Location = new System.Drawing.Point(0, 0);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(352, 43);
            this.btnUserInfo.TabIndex = 0;
            this.btnUserInfo.Text = "Thông tin tài khoản";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnUser.ForeColor = System.Drawing.Color.Silver;
            this.btnUser.Location = new System.Drawing.Point(0, 134);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(352, 49);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "Tài khoản";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSearch.BackgroundImage = global::MediaPlayerWindows.Properties.Resources.简约搜索框放大镜矢量图;
            this.panelSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.textBox1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 98);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(352, 36);
            this.panelSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Silver;
            this.btnSearch.Location = new System.Drawing.Point(251, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 36);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 32);
            this.textBox1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(352, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 46);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Controls.Add(this.ProgressBar2);
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Controls.Add(this.lbArtist);
            this.panel4.Controls.Add(this.lblTime_end);
            this.panel4.Controls.Add(this.lblTime_start);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnOpen);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.btnPause);
            this.panel4.Controls.Add(this.btnPlay);
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(352, 619);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(961, 150);
            this.panel4.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Roboto", 10F);
            this.lbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbName.Location = new System.Drawing.Point(164, 68);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(101, 22);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "MusicName";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Roboto", 10F);
            this.lbArtist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbArtist.Location = new System.Drawing.Point(164, 105);
            this.lbArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(97, 22);
            this.lbArtist.TabIndex = 4;
            this.lbArtist.Text = "ArtistName";
            // 
            // lblTime_end
            // 
            this.lblTime_end.AutoSize = true;
            this.lblTime_end.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblTime_end.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime_end.Location = new System.Drawing.Point(899, 21);
            this.lblTime_end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime_end.Name = "lblTime_end";
            this.lblTime_end.Size = new System.Drawing.Size(43, 18);
            this.lblTime_end.TabIndex = 4;
            this.lblTime_end.Text = "00:00";
            // 
            // lblTime_start
            // 
            this.lblTime_start.AutoSize = true;
            this.lblTime_start.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblTime_start.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime_start.Location = new System.Drawing.Point(164, 21);
            this.lblTime_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime_start.Name = "lblTime_start";
            this.lblTime_start.Size = new System.Drawing.Size(43, 18);
            this.lblTime_start.TabIndex = 4;
            this.lblTime_start.Text = "00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MediaPlayerWindows.Properties.Resources.hinh_anh_nen_dep_cho_powerpoint_110314970;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 150);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::MediaPlayerWindows.Properties.Resources.end_26px;
            this.button2.Location = new System.Drawing.Point(561, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 62);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Image = global::MediaPlayerWindows.Properties.Resources.open_in_browser_26px;
            this.btnOpen.Location = new System.Drawing.Point(708, 62);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(67, 62);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = global::MediaPlayerWindows.Properties.Resources.cd_26px;
            this.button4.Location = new System.Drawing.Point(636, 62);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 62);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = global::MediaPlayerWindows.Properties.Resources.shuffle_26px;
            this.button5.Location = new System.Drawing.Point(349, 62);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 62);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = global::MediaPlayerWindows.Properties.Resources.skip_to_start_26px;
            this.button3.Location = new System.Drawing.Point(412, 62);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 62);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_26px;
            this.btnPause.Location = new System.Drawing.Point(487, 62);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(67, 62);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Image = global::MediaPlayerWindows.Properties.Resources.play_26px;
            this.btnPlay.Location = new System.Drawing.Point(487, 62);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(67, 62);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(783, 68);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(139, 56);
            this.trackBar1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(352, 46);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(961, 573);
            this.panel5.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar2.BorderRadius = 5;
            this.ProgressBar2.Location = new System.Drawing.Point(228, 21);
            this.ProgressBar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgressBar2.MaximumValue = 100;
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressBar2.Size = new System.Drawing.Size(652, 18);
            this.ProgressBar2.TabIndex = 0;
            this.ProgressBar2.Value = 0;
            // 
            // fMusicManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 769);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fMusicManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm nghe nhạc";
            ((System.ComponentModel.ISupportInitialize)(pB_Logo)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelMusicOfYou.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button btnLognOut;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panelMusicOfYou;
        private System.Windows.Forms.Button btnArtists;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnMusicOfYou;
        private System.Windows.Forms.Button btnOnlineMusic;
        private System.Windows.Forms.Button btnPlayLists;
        private System.Windows.Forms.Button btnAddPlayList;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lblTime_end;
        private System.Windows.Forms.Label lblTime_start;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar2;
    }
}