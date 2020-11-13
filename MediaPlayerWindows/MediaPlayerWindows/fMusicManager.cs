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
        private int lastSoundValue = 0;
        public fMusicManager()
        {
            InitializeComponent();
            
            HideSubMenu();
            btnMedia.Click += BtnMedia_Click;
            btnPlayList.Click += BtnPlayList_Click;
            btnBrowser.Click += BtnBrowser_Click;

            btnMute.Click += BtnMute_Click;
            btnUnMute.Click += BtnUnMute_Click;
            btnRepeat1.Click += BtnRepeat_Click;
            btnRepeat.Click += BtnRepeat1_Click;

            btnPlay.Click += BtnPlay_Click;
            btnPause.Click += BtnPause_Click;
            this.FormClosing += FMusicManager_FormClosing;
            //ucPlaylist1.Hide();
            
        }
        private void setnewsong(OpenFileDialog dlg)
        {
            dlg.Filter =
                "Audio Files (*.mp3,*.m4a,*.wav,*.aac)|*.mp3|Video Files(*.mp4,*.wmv,*.3gp,*.mkv)|*.mp4|All Files(*.*)|*.*";
            dlg.FilterIndex = 1;
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                try
                {
                    w.URL = dlg.FileName;
                    btnPlay.Hide();
                    btnPause.Show();
                    TrackbarVolumn.Value = 30;
                    this.lastSoundValue = TrackbarVolumn.Value;
                    setbtnMute();
                    var fileTag = TagLib.File.Create(dlg.FileName);
                    lbName.Text = fileTag.Tag.Title;
                    lbArtist.Text = fileTag.Tag.FirstPerformer;
                    var mStream = new MemoryStream();
                    var firstPicture = fileTag.Tag.Pictures.FirstOrDefault();
                    if (firstPicture != null)
                    {
                        byte[] pData = firstPicture.Data.Data;
                        mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                        var bm = new Bitmap(mStream, false);
                        mStream.Dispose();
                        pictureSong.Image = bm;
                    }
                    else
                    {
                        pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.hinh_anh_nen_dep_cho_powerpoint_110314970;
                    }
                    timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }
        private void BtnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            setnewsong(dlg);
        }
        private void BtnPlayList_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPlayList);
            //ucPlaylist1.Show();
        }
        private void BtnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMedia);
        }
        private void HideSubMenu()
        {
            if (panelMedia.Visible == true)
                panelMedia.Visible = true;
            else
                panelMedia.Visible = false;
            panelPlayList.Visible = false;
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
        private void FMusicManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            w.controls.stop();
        }
        private void BtnRepeat1_Click(object sender, EventArgs e)
        {
            btnRepeat.Hide();
            btnRepeat1.Show();
        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            btnRepeat1.Hide();
            btnRepeat.Show();
        }
        private void BtnUnMute_Click(object sender, EventArgs e)
        {
            btnUnMute.Enabled = false;
            btnUnMute.Visible = false;
            btnMute.Enabled = true;
            btnMute.Visible = true;
            int temp = TrackbarVolumn.Value;
            TrackbarVolumn.Value = 0;
            this.lastSoundValue = temp;
            w.settings.volume = TrackbarVolumn.Value;
        }

        private void BtnMute_Click(object sender, EventArgs e)
        {
            TrackbarVolumn.Value = 0;
            btnUnMute.Enabled = true;
            btnUnMute.Visible = true;
            btnMute.Enabled = false;
            btnMute.Visible = false;
            if (this.lastSoundValue != 0)
                TrackbarVolumn.Value = this.lastSoundValue;
            else
                TrackbarVolumn.Value = 30;
            w.settings.volume = TrackbarVolumn.Value;
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
        public void setbtnMute()
        {
            if (TrackbarVolumn.Value == 0)
            {
                btnMute.Show();
                btnUnMute.Hide();
            }
            else
            {
                btnUnMute.Show();
                btnMute.Hide();
            }
        }
        private void TrackbarVolumn_ValueChanged(object sender, EventArgs e)
        {
            w.settings.volume = TrackbarVolumn.Value;
            if (TrackbarVolumn.Value == 0 && btnUnMute.Enabled == true)
            {
                BtnUnMute_Click(sender, e);
            }
            else if (TrackbarVolumn.Value > 0 && btnUnMute.Enabled == false)
            {
                BtnMute_Click(sender, e);
            }
            setbtnMute();
        }
        public String getCurTime(int time)
        {
            String rs = "";
            int mins = Convert.ToInt32(time) / 60;
            int second = Convert.ToInt32(time) % 60;
            string minStr, sedStr;
            if (mins < 10)
            {
                minStr = "0" + mins.ToString();
            }
            else
            {
                minStr = mins.ToString();
            }

            if (second < 10)
            {
                sedStr = "0" + second.ToString();
            }
            else
            {
                sedStr = second.ToString();
            }
            rs = minStr + ":" + sedStr;
            return rs;

        }
        private void ProgressBar2_progressChanged(object sender, EventArgs e)
        {
            
        }
    }
}