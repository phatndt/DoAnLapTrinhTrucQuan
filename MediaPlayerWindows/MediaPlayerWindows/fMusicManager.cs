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
        private void setNewSong(OpenFileDialog dlg, Label name, Label singer)
        {
            byte[] b = new byte[128];
            FileStream fs = new FileStream(dlg.FileName, FileMode.Open);
            fs.Seek(-128, SeekOrigin.End);
            fs.Read(b, 0, 128);
            bool isSet = false;
            String sFlag = System.Text.Encoding.Default.GetString(b, 0, 3);
            if (sFlag.CompareTo("TAG") == 0)
            {
                System.Console.WriteLine("Tag   is   setted! ");
                isSet = true;
            }

            if (isSet)
            {
                name.Text = (string)System.Text.Encoding.Default.GetString(b, 3, 30);
                singer.Text = (string)System.Text.Encoding.Default.GetString(b, 33, 30);
            }

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
                    setNewSong(dlg, lbName, lbArtist);
                    timer.Start();
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
        private void timer_Tick(object sender, EventArgs e)
        {

            if (w.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                ProgressBar2.MaximumValue = (int)w.currentMedia.duration;
                ProgressBar2.Value = (int)w.controls.currentPosition;
            }
            lblTime_start.Text = w.controls.currentPositionString;
            lblTime_end.Text = w.controls.currentItem.durationString;
        }
    }
}
