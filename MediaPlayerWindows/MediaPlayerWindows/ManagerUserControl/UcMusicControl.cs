using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using static MediaPlayerWindows.ManagerUserControl.UcNameSong;

namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcMusicControl : UserControl
    {
        public delegate void PlaySong(string s);
        

        WindowsMediaPlayer WindowsMediaPlayer = new WindowsMediaPlayer();

        private int LastSoundValue = 0;

        private bool CheckVolumnImage = true;

        private bool CheckPlayPauseImage = true;
        public UcMusicControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            timer.Tick += Timer_Tick;

            btnVolumn.Click += BtnVolumn_Click;

            TrackbarVolumn.ValueChanged += TrackbarVolumn_ValueChanged;

            btnPlayPause.Click += BtnPlayPause_Click;
        }

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            if (CheckPlayPauseImage)
            {
                WindowsMediaPlayer.controls.pause();
                btnPlayPause.Image = global::MediaPlayerWindows.Properties.Resources.play_40px;
                btnPlayPause.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.pause_40px;
                CheckPlayPauseImage = false;
            }
            else
            {
                WindowsMediaPlayer.controls.play();
                btnPlayPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
                btnPlayPause.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.play_40px;
                CheckPlayPauseImage = true;
            }
        }

        private void TrackbarVolumn_ValueChanged(object sender, EventArgs e)
        {
            if (TrackbarVolumn.Value != this.LastSoundValue && TrackbarVolumn.Value != 0)
            {
                WindowsMediaPlayer.settings.volume = TrackbarVolumn.Value;
                this.LastSoundValue = TrackbarVolumn.Value;
            }
        }

        private void BtnVolumn_Click(object sender, EventArgs e)
        {
            if (CheckVolumnImage)
            {
                btnVolumn.Image = global::MediaPlayerWindows.Properties.Resources.mute_40px;
                btnVolumn.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.voice_40px;
                CheckVolumnImage = false;
            }
            else
            {
                btnVolumn.Image = global::MediaPlayerWindows.Properties.Resources.voice_40px;
                btnVolumn.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.mute_40px;
                CheckVolumnImage = true;
            }
            if (TrackbarVolumn.Value != 0)
            {
                TrackbarVolumn.Value = 0;
                WindowsMediaPlayer.settings.volume = TrackbarVolumn.Value;
            }
            else
            {
                TrackbarVolumn.Value = this.LastSoundValue;
                WindowsMediaPlayer.settings.volume = this.LastSoundValue;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                TrackbarMusic.Maximum = (int)WindowsMediaPlayer.currentMedia.duration;
                TrackbarMusic.Value = (int)WindowsMediaPlayer.controls.currentPosition;
            }
            lblTime_start.Text = WindowsMediaPlayer.controls.currentPositionString;
            lblTime_end.Text = WindowsMediaPlayer.controls.currentItem.durationString;
        }

        public void SetupPausePlayButton()
        {
            btnPlayPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
        }
        public void SetMuteButton()
        {
            if (TrackbarVolumn.Value == 0)
            {
                btnVolumn.Image = global::MediaPlayerWindows.Properties.Resources.mute_40px;
            }
            else
            {
                btnVolumn.Image = global::MediaPlayerWindows.Properties.Resources.voice_40px;
            }
        }
        public void Setup(OpenFileDialog dlg)
        {
            try
            {
                WindowsMediaPlayer.URL = dlg.FileName;
                btnTym.Enabled = true;
                SetupPausePlayButton();
                TrackbarVolumn.Value = 50;
                this.LastSoundValue = TrackbarVolumn.Value;
                SetMuteButton();
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
                    pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound;
                }
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void Setup(string s)
        {
            try
            {
                WindowsMediaPlayer.URL = s;
                btnTym.Enabled = true;
                SetupPausePlayButton();
                TrackbarVolumn.Value = 50;
                this.LastSoundValue = TrackbarVolumn.Value;
                SetMuteButton();
                var fileTag = TagLib.File.Create(s);
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
                    pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound;
                }
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

    }
}
