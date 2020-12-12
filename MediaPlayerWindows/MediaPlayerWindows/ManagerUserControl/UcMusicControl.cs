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
using MediaPlayerWindows.DTO;
using MediaPlayerWindows.DAO;

namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcMusicControl : UserControl
    {
        public delegate void PlaySong(string s);
        
        WindowsMediaPlayer WindowsMediaPlayer = new WindowsMediaPlayer();

        FavoriteSong favoriteSong = null;

        private int LastSoundValue = 0;

        private bool CheckVolumnImage = true;

        private bool CheckPlayPauseImage = true;

        private bool CheckRepeat = false;

        private string path;
        private string name;
        private string artist;
        private byte[] image;
        private string length;
        private byte[] source;
        public UcMusicControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            timer.Tick += Timer_Tick;

            btnVolumn.Click += BtnVolumn_Click;

            TrackbarVolumn.ValueChanged += TrackbarVolumn_ValueChanged;

            btnPlayPause.Click += BtnPlayPause_Click;

            this.SizeChanged += UcMusicControl_SizeChanged;

            btnTym.Click += BtnTym_Click;

            TrackbarMusic.Scroll += TrackbarMusic_Scroll;

            btnRepeat.Click += BtnRepeat_Click;
        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            if (CheckRepeat)
            {
                btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
                CheckRepeat = false;
            }
            else
            {
                btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px_green;
                CheckRepeat = true;
            }
        }

        private void TrackbarMusic_Scroll(object sender, ScrollEventArgs e)
        {
            WindowsMediaPlayer.controls.currentPosition = TrackbarMusic.Value;
        }

        private void BtnTym_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM FAVORITESONGS WHERE NAMESONG = " + this.name + " AND ARTISTSONG = " + this.artist + "";
            if (DataProvider.Instance.ExecuteNonQuery(query) == 0)
            {
                favoriteSong = new FavoriteSong(path, name, artist, image, source, length, 1);
                FavoriteSongDAO.Instance.AddFavoriteSong(favoriteSong);
            }    
            

        }

        private void UcMusicControl_SizeChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Size.Width.ToString());
            //TrackbarVolumn.Location = new Point(this.Location.X * 361 / 400, this.Size.Height );
            //MessageBox.Show(TrackbarVolumn.Location.X.ToString() + TrackbarVolumn.Location.Y.ToString());
        }

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            if (CheckPlayPauseImage)
            {
                WindowsMediaPlayer.controls.pause();
                btnPlayPause.Image = global::MediaPlayerWindows.Properties.Resources.play_40px;
                //btnPlayPause.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.pause_40px;
                CheckPlayPauseImage = false;
            }
            else
            {
                WindowsMediaPlayer.controls.play();
                btnPlayPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
                //btnPlayPause.OnHoverImage = global::MediaPlayerWindows.Properties.Resources.play_40px;
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
            this.length = WindowsMediaPlayer.controls.currentItem.durationString;

            if (((int)WindowsMediaPlayer.controls.currentPosition == (int)WindowsMediaPlayer.currentMedia.duration) && (CheckRepeat == true))
            {
                WindowsMediaPlayer.controls.currentPosition = 0;
            }
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
                    this.image = pData;
                }
                else
                {
                    pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound;
                    this.image = ConvertClass.Instance.ConvertImageToByte(global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound);
                }
                timer.Start();
                this.path = dlg.FileName;
                this.name = fileTag.Tag.Title;
                this.artist = fileTag.Tag.FirstPerformer;
                this.source = ConvertClass.Instance.ConvertDataMusicToByte(dlg.FileName);
                //favoriteSong = new FavoriteSong(dlg.FileName, fileTag.Tag.Title, fileTag.Tag.FirstPerformer, firstPicture.Data.Data, ConvertClass.Instance.ConvertDataMusicToByte(dlg.FileName), WindowsMediaPlayer.controls.currentItem.durationString, 1);
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
