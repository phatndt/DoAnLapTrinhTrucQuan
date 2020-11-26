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
using NAudio.Wave;
using NAudio.Gui;
using NAudio.FileFormats;
using MediaPlayerWindows.ManagerUserControl;
using NAudio.Wave.SampleProviders;
using NAudio.MediaFoundation;

namespace MediaPlayerWindows
{
    public delegate void CreatPlayList();
    public delegate void ClickAddFavoriteSong();
    public partial class fMusicManager : Form
    {
        WindowsMediaPlayer w = new WindowsMediaPlayer();
        MediaPlayer M = new MediaPlayer();
        private int lastSoundValue = 0;
        private bool CheckFavoriteSong = true;
        private bool CheckShuffleSong = true;
        private int CheckRepeatSong = 0;
        private string BrowserPath;
        //private UcSongList FavoriteSongList = new UcSongList();
        private UcFavoriteSong FavoriteSongList = new UcFavoriteSong();

        public event ClickAddFavoriteSong Add;
        public fMusicManager()
        {
            MediaFoundationApi.Startup();
            InitializeComponent();
            HideSubMenu();
            btnMedia.Click += BtnMedia_Click;
            btnYourMusic.Click += BtnYourMusic_Click;
            btnPlayList.Click += BtnPlayList_Click;
            btnBrowser.Click += BtnBrowser_Click;

            btnMute.Click += BtnMute_Click;
            btnUnMute.Click += BtnUnMute_Click;
            btnRepeat.Click += BtnRepeat_Click;
            btnShuffle.Click += BtnShuffle_Click;

            btnPlay.Click += BtnPlay_Click;
            btnPause.Click += BtnPause_Click;
            this.FormClosing += FMusicManager_FormClosing;
            ucPlaylist1.Hide();

            
            btnPlaying.Click += BtnPlaying_Click;

            btnCreatPlayList.Click += BtnCreatPlayList_Click;

            btnTym.Click += BtnTym_Click;
            btnFavoriteSong.Click += BtnFavoriteSong_Click;
            FavoriteSongList.Hide();
        }


        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            if (CheckShuffleSong)
            {
                btnShuffle.Image = global::MediaPlayerWindows.Properties.Resources.shuffle_40px_green;
                CheckShuffleSong = false;
            }
            else
            {
                btnShuffle.Image = global::MediaPlayerWindows.Properties.Resources.shuffle_40px;
                CheckShuffleSong = true;
            }
        }
        #region FavoriteSong
        private void BtnFavoriteSong_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(FavoriteSongList);

        }

        private void BtnTym_Click(object sender, EventArgs e)
        {
            if (CheckFavoriteSong)
            {
                btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_outline_40px;
                CheckFavoriteSong = false;
                FavoriteSongList.Add();
            }    
            else
            {
                btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_40px;
                CheckFavoriteSong = true;
                FavoriteSongList.Remove();
                MessageBox.Show("a");
            }

        }

        #endregion
        private void openChildFormInPanel(UcFavoriteSong childForm)
        {
            panelMain.Controls.Clear();
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
            panelMain.Controls.Add(childForm);
        }
        private void BtnCreatPlayList_Click(object sender, EventArgs e)
        {
            ucPlaylist1.AddPlayList_Name();
        }

        private void BtnPlaying_Click(object sender, EventArgs e)
        {
            ucPlaylist1.Hide();
        }
        #region Browser
        private void BtnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            setnewsong(dlg);
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
                    btnTym.Enabled = true;
                    btnPlay.Hide();
                    btnPause.Show();
                    TrackbarVolumn.Value = 30;
                    this.lastSoundValue = TrackbarVolumn.Value;
                    setbtnMute();
                    var fileTag = TagLib.File.Create(dlg.FileName);
                    lbName.Text = fileTag.Tag.Title;
                    lbArtist.Text = fileTag.Tag.FirstPerformer;
                    textBox1.Text = fileTag.Tag.Subtitle;
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
                        pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound;
                    }
                    //var fileTag = 

                    timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }
        #endregion
        private void BtnPlayList_Click(object sender, EventArgs e)
        {
            ucPlaylist1.BringToFront();
            ucPlaylist1.Show();
        }
        private void BtnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMedia);
            ucPlaylist1.Visible = false;
            panelMain.Controls.Clear();
        }
        private void BtnYourMusic_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelYourMusic);
            ucPlaylist1.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelMedia.Visible == true)
                panelMedia.Visible = true;
            else
                panelMedia.Visible = false;
            if (panelYourMusic.Visible == true)
                panelYourMusic.Visible = true;
            else
            {
                panelYourMusic.Visible = false;
            }    
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

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            if (CheckRepeatSong == 0)
            {
                btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_one_40px_green;
                CheckRepeatSong = 1;
            }
            else
            {
                if (CheckRepeatSong == 1)
                {
                    btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px_green;
                    CheckRepeatSong = 2;
                }    
                else
                {
                    btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
                    CheckRepeatSong = 0;
                }    
            }
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
    }
}