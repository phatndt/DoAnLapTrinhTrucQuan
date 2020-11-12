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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMainButton = new System.Windows.Forms.Panel();
            this.lblTime_end = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.ProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lblTime_start = new System.Windows.Forms.Label();
            this.panelButtonExit = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelMedia = new System.Windows.Forms.Panel();
            this.panelPlayList = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlayList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMedia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureSong = new System.Windows.Forms.PictureBox();
            this.btnUnMute = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShuffle = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRepeat = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRepeat1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEnd = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMute = new Bunifu.Framework.UI.BunifuImageButton();
            this.ucPlaylist1 = new MediaPlayerWindows.UcPlaylist();
            this.ucSystemButton1 = new MediaPlayerWindows.ManagerUserControl.UcSystemButton();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelMainButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelButtonExit.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelMedia.SuspendLayout();
            this.panelPlayList.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelMainButton
            // 
            this.panelMainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMainButton.Controls.Add(this.lblTime_end);
            this.panelMainButton.Controls.Add(this.pictureSong);
            this.panelMainButton.Controls.Add(this.panel1);
            this.panelMainButton.Controls.Add(this.lbArtist);
            this.panelMainButton.Controls.Add(this.lbName);
            this.panelMainButton.Controls.Add(this.ProgressBar2);
            this.panelMainButton.Controls.Add(this.lblTime_start);
            this.panelMainButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainButton.Location = new System.Drawing.Point(0, 634);
            this.panelMainButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMainButton.Name = "panelMainButton";
            this.panelMainButton.Size = new System.Drawing.Size(1333, 135);
            this.panelMainButton.TabIndex = 2;
            // 
            // lblTime_end
            // 
            this.lblTime_end.AutoSize = true;
            this.lblTime_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTime_end.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime_end.Location = new System.Drawing.Point(1147, 18);
            this.lblTime_end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime_end.Name = "lblTime_end";
            this.lblTime_end.Size = new System.Drawing.Size(50, 20);
            this.lblTime_end.TabIndex = 37;
            this.lblTime_end.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUnMute);
            this.panel1.Controls.Add(this.btnShuffle);
            this.panel1.Controls.Add(this.btnRepeat);
            this.panel1.Controls.Add(this.btnRepeat1);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.btnMute);
            this.panel1.Controls.Add(this.bunifuSlider1);
            this.panel1.Location = new System.Drawing.Point(400, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 103);
            this.panel1.TabIndex = 35;
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider1.Location = new System.Drawing.Point(721, 6);
            this.bunifuSlider1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(159, 35);
            this.bunifuSlider1.TabIndex = 19;
            this.bunifuSlider1.Value = 0;
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbArtist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbArtist.Location = new System.Drawing.Point(175, 100);
            this.lbArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(108, 25);
            this.lbArtist.TabIndex = 34;
            this.lbArtist.Text = "ArtistName";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbName.Location = new System.Drawing.Point(175, 63);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(116, 25);
            this.lbName.TabIndex = 33;
            this.lbName.Text = "MusicName";
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar2.BorderRadius = 5;
            this.ProgressBar2.Location = new System.Drawing.Point(333, 22);
            this.ProgressBar2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProgressBar2.MaximumValue = 100;
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressBar2.Size = new System.Drawing.Size(805, 18);
            this.ProgressBar2.TabIndex = 31;
            this.ProgressBar2.Value = 0;
            // 
            // lblTime_start
            // 
            this.lblTime_start.AutoSize = true;
            this.lblTime_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTime_start.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime_start.Location = new System.Drawing.Point(267, 21);
            this.lblTime_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime_start.Name = "lblTime_start";
            this.lblTime_start.Size = new System.Drawing.Size(50, 20);
            this.lblTime_start.TabIndex = 32;
            this.lblTime_start.Text = "00:00";
            // 
            // panelButtonExit
            // 
            this.panelButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelButtonExit.Controls.Add(this.ucSystemButton1);
            this.panelButtonExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonExit.Location = new System.Drawing.Point(0, 0);
            this.panelButtonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtonExit.Name = "panelButtonExit";
            this.panelButtonExit.Size = new System.Drawing.Size(1333, 49);
            this.panelButtonExit.TabIndex = 3;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelControl.Controls.Add(this.panelMedia);
            this.panelControl.Controls.Add(this.panel4);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 49);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(333, 585);
            this.panelControl.TabIndex = 4;
            // 
            // panelMedia
            // 
            this.panelMedia.Controls.Add(this.panelPlayList);
            this.panelMedia.Controls.Add(this.btnPlayList);
            this.panelMedia.Controls.Add(this.bunifuFlatButton1);
            this.panelMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedia.Location = new System.Drawing.Point(0, 49);
            this.panelMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(333, 197);
            this.panelMedia.TabIndex = 1;
            // 
            // panelPlayList
            // 
            this.panelPlayList.Controls.Add(this.bunifuFlatButton4);
            this.panelPlayList.Controls.Add(this.bunifuFlatButton3);
            this.panelPlayList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlayList.Location = new System.Drawing.Point(0, 98);
            this.panelPlayList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPlayList.Name = "panelPlayList";
            this.panelPlayList.Size = new System.Drawing.Size(333, 98);
            this.panelPlayList.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMedia);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 49);
            this.panel4.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(333, 49);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1000, 585);
            this.panelMain.TabIndex = 5;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Create PlayList";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::MediaPlayerWindows.Properties.Resources.add_40px;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 30;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 49);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(333, 49);
            this.bunifuFlatButton4.TabIndex = 0;
            this.bunifuFlatButton4.Text = "Create PlayList";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Open PlayList";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::MediaPlayerWindows.Properties.Resources.opened_folder_40px;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 30;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(333, 49);
            this.bunifuFlatButton3.TabIndex = 0;
            this.bunifuFlatButton3.Text = "Open PlayList";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPlayList
            // 
            this.btnPlayList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayList.BorderRadius = 0;
            this.btnPlayList.ButtonText = "PlayList";
            this.btnPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayList.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayList.Iconimage = global::MediaPlayerWindows.Properties.Resources.playlist_40px;
            this.btnPlayList.Iconimage_right = null;
            this.btnPlayList.Iconimage_right_Selected = null;
            this.btnPlayList.Iconimage_Selected = null;
            this.btnPlayList.IconMarginLeft = 15;
            this.btnPlayList.IconMarginRight = 0;
            this.btnPlayList.IconRightVisible = true;
            this.btnPlayList.IconRightZoom = 0D;
            this.btnPlayList.IconVisible = true;
            this.btnPlayList.IconZoom = 90D;
            this.btnPlayList.IsTab = false;
            this.btnPlayList.Location = new System.Drawing.Point(0, 49);
            this.btnPlayList.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlayList.Name = "btnPlayList";
            this.btnPlayList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnPlayList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPlayList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlayList.selected = false;
            this.btnPlayList.Size = new System.Drawing.Size(333, 49);
            this.btnPlayList.TabIndex = 1;
            this.btnPlayList.Text = "PlayList";
            this.btnPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayList.Textcolor = System.Drawing.Color.White;
            this.btnPlayList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Playing";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::MediaPlayerWindows.Properties.Resources.circled_play_40px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 15;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(333, 49);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Playing";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMedia
            // 
            this.btnMedia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedia.BorderRadius = 0;
            this.btnMedia.ButtonText = "     Media";
            this.btnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedia.DisabledColor = System.Drawing.Color.Gray;
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMedia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMedia.Iconimage = global::MediaPlayerWindows.Properties.Resources.media_40px;
            this.btnMedia.Iconimage_right = null;
            this.btnMedia.Iconimage_right_Selected = null;
            this.btnMedia.Iconimage_Selected = null;
            this.btnMedia.IconMarginLeft = 0;
            this.btnMedia.IconMarginRight = 0;
            this.btnMedia.IconRightVisible = true;
            this.btnMedia.IconRightZoom = 0D;
            this.btnMedia.IconVisible = true;
            this.btnMedia.IconZoom = 90D;
            this.btnMedia.IsTab = false;
            this.btnMedia.Location = new System.Drawing.Point(0, 0);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(5);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnMedia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMedia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMedia.selected = false;
            this.btnMedia.Size = new System.Drawing.Size(333, 49);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "     Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.Textcolor = System.Drawing.Color.White;
            this.btnMedia.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // pictureSong
            // 
            this.pictureSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureSong.Location = new System.Drawing.Point(0, 0);
            this.pictureSong.Margin = new System.Windows.Forms.Padding(4);
            this.pictureSong.Name = "pictureSong";
            this.pictureSong.Size = new System.Drawing.Size(167, 135);
            this.pictureSong.TabIndex = 36;
            this.pictureSong.TabStop = false;
            // 
            // btnUnMute
            // 
            this.btnUnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUnMute.Image = global::MediaPlayerWindows.Properties.Resources.voice_40px;
            this.btnUnMute.ImageActive = null;
            this.btnUnMute.Location = new System.Drawing.Point(660, 0);
            this.btnUnMute.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnMute.Name = "btnUnMute";
            this.btnUnMute.Size = new System.Drawing.Size(53, 49);
            this.btnUnMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUnMute.TabIndex = 0;
            this.btnUnMute.TabStop = false;
            this.btnUnMute.Zoom = 10;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnShuffle.Image = global::MediaPlayerWindows.Properties.Resources.shuffle_40px;
            this.btnShuffle.ImageActive = null;
            this.btnShuffle.Location = new System.Drawing.Point(75, 0);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(53, 49);
            this.btnShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShuffle.TabIndex = 0;
            this.btnShuffle.TabStop = false;
            this.btnShuffle.Zoom = 10;
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_one_40px;
            this.btnRepeat.ImageActive = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
            this.btnRepeat.Location = new System.Drawing.Point(373, 0);
            this.btnRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(53, 49);
            this.btnRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRepeat.TabIndex = 0;
            this.btnRepeat.TabStop = false;
            this.btnRepeat.Zoom = 10;
            // 
            // btnRepeat1
            // 
            this.btnRepeat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRepeat1.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
            this.btnRepeat1.ImageActive = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
            this.btnRepeat1.Location = new System.Drawing.Point(373, 0);
            this.btnRepeat1.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepeat1.Name = "btnRepeat1";
            this.btnRepeat1.Size = new System.Drawing.Size(53, 49);
            this.btnRepeat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRepeat1.TabIndex = 0;
            this.btnRepeat1.TabStop = false;
            this.btnRepeat1.Zoom = 10;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNext.Image = global::MediaPlayerWindows.Properties.Resources.end_40px;
            this.btnNext.ImageActive = null;
            this.btnNext.Location = new System.Drawing.Point(299, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 49);
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
            this.btnPlay.Location = new System.Drawing.Point(224, 0);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(53, 49);
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
            this.btnPause.Location = new System.Drawing.Point(224, 0);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(53, 49);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 0;
            this.btnPause.TabStop = false;
            this.btnPause.Zoom = 10;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEnd.Image = global::MediaPlayerWindows.Properties.Resources.skip_to_start_40px;
            this.btnEnd.ImageActive = null;
            this.btnEnd.Location = new System.Drawing.Point(149, 0);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(53, 49);
            this.btnEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEnd.TabIndex = 0;
            this.btnEnd.TabStop = false;
            this.btnEnd.Zoom = 10;
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMute.Image = global::MediaPlayerWindows.Properties.Resources.mute_40px;
            this.btnMute.ImageActive = null;
            this.btnMute.Location = new System.Drawing.Point(660, 0);
            this.btnMute.Margin = new System.Windows.Forms.Padding(4);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(53, 49);
            this.btnMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMute.TabIndex = 0;
            this.btnMute.TabStop = false;
            this.btnMute.Zoom = 10;
            // 
            // ucPlaylist1
            // 
            this.ucPlaylist1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlaylist1.Location = new System.Drawing.Point(333, 49);
            this.ucPlaylist1.Margin = new System.Windows.Forms.Padding(5);
            this.ucPlaylist1.Name = "ucPlaylist1";
            this.ucPlaylist1.Size = new System.Drawing.Size(1000, 585);
            this.ucPlaylist1.TabIndex = 0;
            // 
            // ucSystemButton1
            // 
            this.ucSystemButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ucSystemButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSystemButton1.Location = new System.Drawing.Point(0, 0);
            this.ucSystemButton1.Margin = new System.Windows.Forms.Padding(5);
            this.ucSystemButton1.Name = "ucSystemButton1";
            this.ucSystemButton1.Size = new System.Drawing.Size(1333, 49);
            this.ucSystemButton1.TabIndex = 0;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.ucSystemButton1;
            this.DragControl.Vertical = true;
            // 
            // fMusicManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1333, 769);
            this.Controls.Add(this.ucPlaylist1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelButtonExit);
            this.Controls.Add(this.panelMainButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fMusicManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Phần mềm nghe nhạc";
            this.panelMainButton.ResumeLayout(false);
            this.panelMainButton.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelButtonExit.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelMedia.ResumeLayout(false);
            this.panelPlayList.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelMainButton;
        private System.Windows.Forms.Panel panelButtonExit;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelMedia;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnMedia;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelPlayList;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlayList;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private UcPlaylist ucPlaylist1;
        private ManagerUserControl.UcSystemButton ucSystemButton1;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.PictureBox pictureSong;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnUnMute;
        private Bunifu.Framework.UI.BunifuImageButton btnShuffle;
        private Bunifu.Framework.UI.BunifuImageButton btnRepeat;
        private Bunifu.Framework.UI.BunifuImageButton btnRepeat1;
        private Bunifu.Framework.UI.BunifuImageButton btnNext;
        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private Bunifu.Framework.UI.BunifuImageButton btnPause;
        private Bunifu.Framework.UI.BunifuImageButton btnEnd;
        private Bunifu.Framework.UI.BunifuImageButton btnMute;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbName;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar2;
        private System.Windows.Forms.Label lblTime_start;
        private System.Windows.Forms.Label lblTime_end;
    }
}