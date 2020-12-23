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
using static MediaPlayerWindows.ManagerUserControl.UcSong;
using MediaPlayerWindows.DTO;
using MediaPlayerWindows.DAO;

namespace MediaPlayerWindows.ManagerUserControl
{
    public delegate void RemoveFS(string a, string b);
    public partial class UcMusicControl : UserControl
    {
        public delegate void Play(string s);


        public event RemoveFS Remove;

        public event Action ReLoad;

        public event Action<UcSong> Next;

        WindowsMediaPlayer WindowsMediaPlayer = new WindowsMediaPlayer();


        private int LastSoundValue = 50;

        private bool CheckVolumnImage = true;

        private bool CheckPlayPauseImage = true;

        private bool CheckRepeat = false;

        private bool CheckTym  = false;

        private Song song = new Song();

        List<UcSong> ucSongs = new List<UcSong>();

        ListBox ListBox = new ListBox();
        public UcMusicControl()
        {
            this.DoubleBuffered = true;

            InitializeComponent();

            timer.Tick += Timer_Tick;

            btnVolumn.Click += BtnVolumn_Click;

            TrackbarVolumn.ValueChanged += TrackbarVolumn_ValueChanged;

            btnPlayPause.Click += BtnPlayPause_Click;

            this.SizeChanged += UcMusicControl_SizeChanged;

            btnTym.Click += BtnTym_Click;

            TrackbarMusic.Scroll += TrackbarMusic_Scroll;

            btnRepeat.Click += BtnRepeat_Click;

            btnNext.Click += BtnNext_Click;

            //WindowsMediaPlayer.PlayStateChange += WindowsMediaPlayer_PlayStateChange;

            TrackbarMusic.MouseUp += TrackbarMusic_MouseUp;

            TrackbarMusic.MouseDown += TrackbarMusic_MouseDown;

        }

        private void TrackbarMusic_MouseDown(object sender, MouseEventArgs e)
        {
            TrackbarMusic.ValueChanged -= TrackbarMusic_ValueChanged;
        }

        private void TrackbarMusic_MouseUp(object sender, MouseEventArgs e)
        {
            if (TrackbarMusic.Value == TrackbarMusic.Maximum)
            {
                BtnNext_Click(sender, e);
            }
            else
            {
                TrackbarMusic.ValueChanged += TrackbarMusic_ValueChanged;
            }    
        }

        private void TrackbarMusic_ValueChanged(object sender, EventArgs e)
        {
            if (TrackbarMusic.Value == TrackbarMusic.Maximum)
            {
                BtnNext_Click(sender, e);
            }
        }


        private void WindowsMediaPlayer_PlayStateChange(int NewState)
        {
            if (NewState == 1)
            {
                foreach (UcSong ucSong in ucSongs)
                {
                    if (ucSong.Song.Name == song.Name && ucSong.Song.Artist == song.Artist)
                    {
                        int i = ucSongs.IndexOf(ucSong);
                        //MessageBox.Show(i.ToString(), ucSongs.Count.ToString());
                        if (i == ucSongs.Count - 1)
                        {
                            Setup(ucSongs[0]);
                        }
                        else
                            Setup(ucSongs[i + 1]);
                        break;
                    }
                }
            }    
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            foreach (UcSong ucSong in ucSongs)
            {
                if (ucSong.Song.Name == song.Name && ucSong.Song.Artist == song.Artist)
                {
                    int i = ucSongs.IndexOf(ucSong);
                    //MessageBox.Show(i.ToString(), ucSongs.Count.ToString());
                    if (i == ucSongs.Count - 1)
                    {
                        Setup(ucSongs[0]);
                    }    
                    else
                        Setup(ucSongs[i+1]);
                    break;
                }    
            }    
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
            FavoriteSong favoriteSong = new FavoriteSong(song.Name, song.Artist, song.IMage, song.Source, song.Length, 1);
            MessageBox.Show(CheckTym.ToString());
            if (CheckTym)
            {
                btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_40px;
                CheckTym = false;
                FavoriteSongDAO.Instance.RemoveFavoriteSong(favoriteSong);
                Remove(favoriteSong.Name, favoriteSong.Artist);
                MessageBox.Show("Qua day xoa ra");
                ReLoad();
            }
            else
            {
                btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_outline_40px;
                CheckTym = true;
                if (ExecuteQuerySearchFavoriteSong(favoriteSong.Name,favoriteSong.Artist) == false)
                {
                    btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_outline_40px;
                    CheckTym = true;
                    FavoriteSongDAO.Instance.AddFavoriteSong(favoriteSong);
                    MessageBox.Show("Qua day them vao");
                    ReLoad();
                }    
                
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
                CheckPlayPauseImage = false;
            }
            else
            {
                WindowsMediaPlayer.controls.play();
                btnPlayPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
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
                CheckVolumnImage = false;
                TrackbarVolumn.Value = 0;
                WindowsMediaPlayer.settings.volume = TrackbarVolumn.Value;
            }
            else
            {
                btnVolumn.Image = global::MediaPlayerWindows.Properties.Resources.voice_40px;
                CheckVolumnImage = true;
                TrackbarVolumn.Value = this.LastSoundValue;
                WindowsMediaPlayer.settings.volume = this.LastSoundValue;
            }
            if (TrackbarVolumn.Value != 0)
            {
            }
            else
            {
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
            if (CheckRepeat)
            {
                if ((int)WindowsMediaPlayer.controls.currentPosition == (int)WindowsMediaPlayer.currentMedia.duration)
                    WindowsMediaPlayer.controls.currentPosition = 0;

            }    
            else
            {
                if (WindowsMediaPlayer.controls.currentPositionString == song.Length)
                {
                    //WindowsMediaPlayer.controls.stop();
                    //BtnNext_Click(sender, e);
                    //TrackbarMusic.Value = 0;
                }
            }
            //if (((int)WindowsMediaPlayer.controls.currentPosition == (int)WindowsMediaPlayer.currentMedia.duration) && (CheckRepeat == true))
            //{

            //    WindowsMediaPlayer.controls.currentPosition = 0;
            //}
        }

        public void SetupPausePlayButton()
        {
            btnPlayPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
            btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_40px;
            CheckTym = false;
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
        //public void Setup(OpenFileDialog dlg, string[] pathSong)
        //{
        //    try
        //    {
        //        WindowsMediaPlayer.URL = dlg.FileName;
        //        btnTym.Enabled = true;
        //        SetupPausePlayButton();
        //        TrackbarVolumn.Value = 50;
        //        this.LastSoundValue = TrackbarVolumn.Value;
        //        SetMuteButton();
        //        var fileTag = TagLib.File.Create(dlg.FileName);
        //        lbName.Text = fileTag.Tag.Title;
        //        lbArtist.Text = fileTag.Tag.FirstPerformer;
        //        if (ExecuteQuerySearchFavoriteSong(fileTag.Tag.Title, fileTag.Tag.FirstPerformer))
        //        {
        //            btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_outline_40px;
        //            CheckTym = true;
        //        }
        //        var mStream = new MemoryStream();
        //        var firstPicture = fileTag.Tag.Pictures.FirstOrDefault();
        //        if (firstPicture != null)
        //        {
        //            byte[] pData = firstPicture.Data.Data;
        //            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
        //            var bm = new Bitmap(mStream, false);
        //            mStream.Dispose();
        //            pictureSong.Image = bm;
        //            this.song.IMage = pData;
        //        }
        //        else
        //        {
        //            pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound;
        //            this.song.IMage = ConvertClass.Instance.ConvertImageToByte(global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound);
        //        }
        //        timer.Start();
        //        this.song.Path = dlg.FileName;
        //        this.song.Name= fileTag.Tag.Title;
        //        this.song.Artist = fileTag.Tag.FirstPerformer;
        //        this.song.Source = ConvertClass.Instance.ConvertDataMusicToByte(dlg.FileName);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error" + ex.Message);
        //    }
        //}
        #region Song
        public void Setup(UcSong ucSong)
        {
            try
            {
                song = new Song(ucSong.Song.Name,ucSong.Song.Artist,ucSong.Song.IMage,ucSong.Song.Source,ucSong.Song.Length);
                RecentlySongDAO.Instance.AddRecentlyToDB(new RecentlySong(ucSong.Song.Name, ucSong.Song.Artist, ucSong.Song.IMage, ucSong.Song.Source, ucSong.Song.Length));
                string name = Path.ChangeExtension(Path.GetRandomFileName(), ".wav"); // tạo random 1 cái tên đẻ l luuw
                string path = Path.Combine(Path.GetTempPath(), name); // tạo 1 cái đường dẫn
                File.WriteAllBytes(path, ucSong.Song.Source); // ghi cái data từ Vs vào cái đường dẫn
                WindowsMediaPlayer.URL = path;
                SetupPausePlayButton();
                TrackbarVolumn.Value = 50;
                TrackbarMusic.Value = TrackbarMusic.Minimum;
                this.LastSoundValue = TrackbarVolumn.Value;
                SetMuteButton();
                lbName.Text = ucSong.Song.Name;
                lbArtist.Text = ucSong.Song.Artist;
                pictureSong.Image = ConvertClass.Instance.ConvertByteToBitmap(ucSong.Song.IMage);
                lblTime_end.Text = ucSong.Song.Length;
                if (ExecuteQuerySearchFavoriteSong(ucSong.Song.Name, ucSong.Song.Artist))
                {
                    btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_outline_40px;
                    CheckTym = true;
                }
                else
                {
                    btnTym.Enabled = true;
                }
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void AddUcSong(UcSong ucSong)
        {
            ListBox.Items.Add(ucSong);
            ucSongs.Add(ucSong);
        }
        public void CleanUcSong()
        {
            ucSongs.Clear();
        }
        #endregion
        #region FavoriteSong
        public void Setup(UcFavoriteSong ucFavoriteSong)
        {
            try
            {
                MessageBox.Show("aaa0");
                string name = Path.ChangeExtension(Path.GetRandomFileName(), ".wav"); // tạo random 1 cái tên đẻ l luuw
                string path = Path.Combine(Path.GetTempPath(), name); // tạo 1 cái đường dẫn
                File.WriteAllBytes(path, ucFavoriteSong.FavoriteSong.Source); // ghi cái data từ Vs vào cái đường dẫn
                WindowsMediaPlayer.URL = path;
                SetupPausePlayButton();
                btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_outline_40px;
                btnTym.Enabled = false;
                TrackbarVolumn.Value = 50;
                this.LastSoundValue = TrackbarVolumn.Value;
                SetMuteButton();
                lbName.Text = ucFavoriteSong.FavoriteSong.Name;
                lbArtist.Text = ucFavoriteSong.FavoriteSong.Artist;
                pictureSong.Image = ConvertClass.Instance.ConvertByteToBitmap(ucFavoriteSong.FavoriteSong.IMage);
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void SetTymImage()
        {
            btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_40px;
            CheckTym = false;
        }
        private bool ExecuteQuerySearchFavoriteSong(string name, string artist)
        {
            string query = "SELECT * FROM FAVORITESONGS WHERE NAMESONG = N'" + name + "' AND ARTISTSONG = N'" + artist + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        #endregion
    }
}
