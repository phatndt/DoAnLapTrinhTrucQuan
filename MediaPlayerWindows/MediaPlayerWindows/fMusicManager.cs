using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;
using WMPLib;
using MediaPlayerWindows;
using System.Windows.Controls.Primitives;
using System.Runtime.CompilerServices;
using System.IO;

namespace MediaPlayerWindows
{
    public partial class fMusicManager : Form
    {

        WindowsMediaPlayer w = new WindowsMediaPlayer();
        MediaPlayer M = new MediaPlayer();
        public fMusicManager()
        {
            InitializeComponent();
            HideSubMenu();
            btnUser.Click += BtnUser_Click;
            btnMusicOfYou.Click += BtnMusicOfYou_Click;
            btnOpen.Click += BtnOpen_Click;
            btnPlay.Click += BtnPlay_Click;
            btnPause.Click += BtnPause_Click;
            btnOpen.Click += BtnOpen_Click1;
            this.FormClosing += FMusicManager_FormClosing;
            pictureBox1.BackgroundImageChanged += PictureBox1_BackgroundImageChanged;
        }

        private void PictureBox1_BackgroundImageChanged(object sender, EventArgs e)
        {
            Bitmap m = new Bitmap(w.URL);
            
            
            
        }

        private void FMusicManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            w.controls.stop();
        }

        private void BtnOpen_Click1(object sender, EventArgs e)
        {
            lbName.Text = w.currentMedia.getItemInfo("Title");
            lbArtist.Text = w.currentMedia.getItemInfo("Album artist");
            MessageBox.Show(lbArtist.Text);
        }
        private void BtnPause_Click(object sender, EventArgs e)
        {
            //Bitmap m = new Bitmap(w.URL);
           
            w.controls.pause();
            btnPause.Hide();
            btnPlay.Show();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            w.controls.play();
            btnPlay.Hide();
            btnPause.Show();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter =
                "Audio Files (*.mp3,*.m4a,*.wav,*.aac)|*.mp3|Video Files(*.mp4,*.wmv,*.3gp,*.mkv)|*.mp4|All Files(*.*)|*.*";
            dlg.FilterIndex = 1;
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                try
                {
                    w.URL = dlg.FileName;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }
        private void BtnMusicOfYou_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMusicOfYou);
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelUser);
        }

        private void HideSubMenu()
        {
            panelUser.Visible = false;
            panelMusicOfYou.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        

    }
}
