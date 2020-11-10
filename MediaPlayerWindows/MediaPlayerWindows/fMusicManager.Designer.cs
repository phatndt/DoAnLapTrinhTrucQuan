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
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.ProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lblTime_end = new System.Windows.Forms.Label();
            this.lblTime_start = new System.Windows.Forms.Label();
            this.panelButtonExit = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelMedia = new System.Windows.Forms.Panel();
            this.panelPlayList = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMedia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlayList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelMainButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelButtonExit.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelMedia.SuspendLayout();
            this.panelPlayList.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelMainButton
            // 
            this.panelMainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMainButton.Controls.Add(this.panel1);
            this.panelMainButton.Controls.Add(this.button4);
            this.panelMainButton.Controls.Add(this.button3);
            this.panelMainButton.Controls.Add(this.lbArtist);
            this.panelMainButton.Controls.Add(this.lbName);
            this.panelMainButton.Controls.Add(this.bunifuSlider1);
            this.panelMainButton.Controls.Add(this.ProgressBar2);
            this.panelMainButton.Controls.Add(this.lblTime_end);
            this.panelMainButton.Controls.Add(this.lblTime_start);
            this.panelMainButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainButton.Location = new System.Drawing.Point(0, 475);
            this.panelMainButton.Name = "panelMainButton";
            this.panelMainButton.Size = new System.Drawing.Size(1000, 150);
            this.panelMainButton.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Location = new System.Drawing.Point(309, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 55);
            this.panel1.TabIndex = 23;
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbArtist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbArtist.Location = new System.Drawing.Point(16, 89);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(91, 20);
            this.lbArtist.TabIndex = 21;
            this.lbArtist.Text = "ArtistName";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbName.Location = new System.Drawing.Point(12, 46);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(95, 20);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "MusicName";
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider1.Location = new System.Drawing.Point(869, 66);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(119, 30);
            this.bunifuSlider1.TabIndex = 19;
            this.bunifuSlider1.Value = 0;
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar2.BorderRadius = 5;
            this.ProgressBar2.Location = new System.Drawing.Point(225, 20);
            this.ProgressBar2.MaximumValue = 100;
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressBar2.Size = new System.Drawing.Size(604, 15);
            this.ProgressBar2.TabIndex = 9;
            this.ProgressBar2.Value = 0;
            // 
            // lblTime_end
            // 
            this.lblTime_end.AutoSize = true;
            this.lblTime_end.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblTime_end.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime_end.Location = new System.Drawing.Point(848, 21);
            this.lblTime_end.Name = "lblTime_end";
            this.lblTime_end.Size = new System.Drawing.Size(34, 14);
            this.lblTime_end.TabIndex = 17;
            this.lblTime_end.Text = "00:00";
            // 
            // lblTime_start
            // 
            this.lblTime_start.AutoSize = true;
            this.lblTime_start.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblTime_start.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime_start.Location = new System.Drawing.Point(161, 21);
            this.lblTime_start.Name = "lblTime_start";
            this.lblTime_start.Size = new System.Drawing.Size(34, 14);
            this.lblTime_start.TabIndex = 18;
            this.lblTime_start.Text = "00:00";
            // 
            // panelButtonExit
            // 
            this.panelButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelButtonExit.Controls.Add(this.btnExit);
            this.panelButtonExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonExit.Location = new System.Drawing.Point(0, 0);
            this.panelButtonExit.Name = "panelButtonExit";
            this.panelButtonExit.Size = new System.Drawing.Size(1000, 40);
            this.panelButtonExit.TabIndex = 3;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelControl.Controls.Add(this.panelMedia);
            this.panelControl.Controls.Add(this.panel4);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 40);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(249, 435);
            this.panelControl.TabIndex = 4;
            // 
            // panelMedia
            // 
            this.panelMedia.Controls.Add(this.panelPlayList);
            this.panelMedia.Controls.Add(this.btnPlayList);
            this.panelMedia.Controls.Add(this.bunifuFlatButton1);
            this.panelMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedia.Location = new System.Drawing.Point(0, 40);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(249, 160);
            this.panelMedia.TabIndex = 1;
            // 
            // panelPlayList
            // 
            this.panelPlayList.Controls.Add(this.bunifuFlatButton4);
            this.panelPlayList.Controls.Add(this.bunifuFlatButton3);
            this.panelPlayList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlayList.Location = new System.Drawing.Point(0, 80);
            this.panelPlayList.Name = "panelPlayList";
            this.panelPlayList.Size = new System.Drawing.Size(249, 80);
            this.panelPlayList.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMedia);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 40);
            this.panel4.TabIndex = 0;
            // 
            // btnMedia
            // 
            this.btnMedia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedia.BorderRadius = 0;
            this.btnMedia.ButtonText = "     Media";
            this.btnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedia.DisabledColor = System.Drawing.Color.Gray;
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMedia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMedia.Iconimage = null;
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
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnMedia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMedia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMedia.selected = false;
            this.btnMedia.Size = new System.Drawing.Size(249, 40);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "     Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.Textcolor = System.Drawing.Color.White;
            this.btnMedia.TextFont = new System.Drawing.Font("Roboto", 12F);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(249, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(751, 435);
            this.panelMain.TabIndex = 5;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Create PlayList";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 40);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(249, 40);
            this.bunifuFlatButton4.TabIndex = 0;
            this.bunifuFlatButton4.Text = "Create PlayList";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Open PlayList";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(249, 40);
            this.bunifuFlatButton3.TabIndex = 0;
            this.bunifuFlatButton3.Text = "Open PlayList";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPlayList
            // 
            this.btnPlayList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayList.BorderRadius = 0;
            this.btnPlayList.ButtonText = "PlayList";
            this.btnPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayList.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlayList.Iconimage")));
            this.btnPlayList.Iconimage_right = null;
            this.btnPlayList.Iconimage_right_Selected = null;
            this.btnPlayList.Iconimage_Selected = null;
            this.btnPlayList.IconMarginLeft = 0;
            this.btnPlayList.IconMarginRight = 0;
            this.btnPlayList.IconRightVisible = true;
            this.btnPlayList.IconRightZoom = 0D;
            this.btnPlayList.IconVisible = true;
            this.btnPlayList.IconZoom = 90D;
            this.btnPlayList.IsTab = false;
            this.btnPlayList.Location = new System.Drawing.Point(0, 40);
            this.btnPlayList.Name = "btnPlayList";
            this.btnPlayList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnPlayList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPlayList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlayList.selected = false;
            this.btnPlayList.Size = new System.Drawing.Size(249, 40);
            this.btnPlayList.TabIndex = 1;
            this.btnPlayList.Text = "PlayList";
            this.btnPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayList.Textcolor = System.Drawing.Color.White;
            this.btnPlayList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Playing";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(249, 40);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Playing";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::MediaPlayerWindows.Properties.Resources.close_window_40px;
            this.btnExit.Location = new System.Drawing.Point(966, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 40);
            this.btnExit.TabIndex = 22;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::MediaPlayerWindows.Properties.Resources.skip_to_start_40px;
            this.button7.Location = new System.Drawing.Point(110, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 23;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::MediaPlayerWindows.Properties.Resources.shuffle_40px;
            this.button2.Location = new System.Drawing.Point(54, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::MediaPlayerWindows.Properties.Resources.end_40px1;
            this.btnNext.Location = new System.Drawing.Point(222, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 25;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
            this.button6.Location = new System.Drawing.Point(278, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 22;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MediaPlayerWindows.Properties.Resources.repeat_one_40px;
            this.button1.Location = new System.Drawing.Point(278, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::MediaPlayerWindows.Properties.Resources.play_40px;
            this.btnPlay.Location = new System.Drawing.Point(166, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 26;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
            this.btnPause.Location = new System.Drawing.Point(166, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 50);
            this.btnPause.TabIndex = 22;
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::MediaPlayerWindows.Properties.Resources.voice_40px;
            this.button4.Location = new System.Drawing.Point(795, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::MediaPlayerWindows.Properties.Resources.mute_40px;
            this.button3.Location = new System.Drawing.Point(795, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fMusicManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelButtonExit);
            this.Controls.Add(this.panelMainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelMainButton;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbName;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar2;
        private System.Windows.Forms.Label lblTime_end;
        private System.Windows.Forms.Label lblTime_start;
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
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
    }
}