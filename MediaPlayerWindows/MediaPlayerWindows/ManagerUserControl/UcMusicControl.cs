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
using System.Net;
using xNet;
using System.Text.RegularExpressions;

namespace MediaPlayerWindows.ManagerUserControl
{
    public delegate void RemoveFS(string a, string b);
    public partial class UcMusicControl : UserControl
    {
        public delegate void Play(string s);


        public event RemoveFS Remove;

        public event Action ReLoad;

        WindowsMediaPlayer WindowsMediaPlayer = new WindowsMediaPlayer();


        private int LastSoundValue = 50;

        private bool CheckVolumnImage = true;

        private bool CheckPlayPauseImage = true;

        private bool CheckRepeat = false;

        private bool CheckTym  = false;

        private Song song = new Song();

        private FavoriteSong FavoriteSong = new FavoriteSong();

        private PlaylistSong PlaylistSong = new PlaylistSong();

        List<UcSong> ucSongs = new List<UcSong>();

        List<UcFavoriteSong> ucFavoriteSongLists = new List<UcFavoriteSong>();

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

            btnAddPlaylist.Click += BtnAddPlaylist_Click;

            TrackbarMusic.Scroll += TrackbarMusic_Scroll;

            btnRepeat.Click += BtnRepeat_Click;

            btnNext.Click += BtnNext_Click;

            btnPreivous.Click += BtnPreivous_Click;

            TrackbarMusic.MouseUp += TrackbarMusic_MouseUp;

            TrackbarMusic.MouseDown += TrackbarMusic_MouseDown;

            btnLyrics.Click += BtnLyrics_Click;
        }

        private void BtnLyrics_Click(object sender, EventArgs e)
        {
            try
            {
                HttpRequest http = new HttpRequest();
                string html = http.Get(@"https://www.nhaccuatui.com/tim-kiem/bai-hat?q=" + lbName.Text + " " + lbArtist.Text).ToString();
                var htmlFindLyrics = Regex.Matches(html, @"<li class=""sn_search_single_song"">(.*?)</li>", RegexOptions.Singleline);
                if (htmlFindLyrics.Count != 0)
                {
                    string ResultFind = htmlFindLyrics[0].ToString();
                    var LyricsURL = Regex.Matches(ResultFind, @"<a href=""(.*?)""", RegexOptions.Singleline);
                    string URL = LyricsURL[0].ToString().Replace("<a href=\"", "").Replace("\"", "");
                    HttpRequest http1 = new HttpRequest();
                    string htmlSong = http1.Get(@URL).ToString();

                    var lyrics = Regex.Matches(htmlSong, @"<p id(.*?)</p>", RegexOptions.Singleline);

                    string tempLiryc = "Chưa có lyric";
                    if (lyrics.Count > 0)
                    {
                        tempLiryc = lyrics[0].ToString();
                        string tempToCut = tempLiryc.Substring(0, tempLiryc.IndexOf('>') + 1);
                        tempLiryc = tempLiryc.Replace(tempToCut, "").Replace("<br />", "").Replace("</p>", "");
                        tempLiryc = WebUtility.HtmlDecode(tempLiryc);
                    }
                    MessageBox.Show(tempLiryc);
                }
                else
                    MessageBox.Show("Không có lời bài hát");
            }
            catch
            {
                MessageBox.Show("Không có kết nối Internet");
            }
            
        }

        private void BtnPreivous_Click(object sender, EventArgs e)
        {
            if (ucSongs.Count > 0)
            {
                foreach (UcSong ucSong in ucSongs)
                {
                    if (ucSong.Song.Name == song.Name && ucSong.Song.Artist == song.Artist)
                    {
                        int i = ucSongs.IndexOf(ucSong);
                        if (i == 0)
                        {
                            Setup(ucSongs[ucSongs.Count - 1]);
                        }
                        else
                        {
                            i = i - 1;
                            Setup(ucSongs[i]);
                        }    
                        break;
                    }
                }
            }
            else
            {
                foreach (UcFavoriteSong ucFavoriteSong in ucFavoriteSongLists)
                {
                    if (ucFavoriteSong.FavoriteSong.Name == FavoriteSong.Name && ucFavoriteSong.FavoriteSong.Artist == FavoriteSong.Artist)
                    {
                        int i = ucFavoriteSongLists.IndexOf(ucFavoriteSong);
                        if (i == 0)
                        {
                            Setup(ucFavoriteSongLists[ucFavoriteSongLists.Count - 1]);
                        }
                        else
                        {
                            i = i - 1;
                            Setup(ucFavoriteSongLists[i]);
                        }    
                        break;
                    }
                }
            }
        }

        private void BtnAddPlaylist_Click(object sender, EventArgs e)
        {
            fAddMusicToPlaylist fAddMusicToPlaylist = new fAddMusicToPlaylist(PlaylistSong.Name, PlaylistSong.Artist, PlaylistSong.IMage, PlaylistSong.Source, PlaylistSong.Length);
            fAddMusicToPlaylist.Show();
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

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (ucSongs.Count > 0)
            {
                foreach (UcSong ucSong in ucSongs)
                {
                    if (ucSong.Song.Name == song.Name && ucSong.Song.Artist == song.Artist)
                    {
                        int i = ucSongs.IndexOf(ucSong);
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
            else
            {
                foreach (UcFavoriteSong ucFavoriteSong in ucFavoriteSongLists)
                {
                    if (ucFavoriteSong.FavoriteSong.Name == FavoriteSong.Name && ucFavoriteSong.FavoriteSong.Artist == FavoriteSong.Artist)
                    {
                        int i = ucFavoriteSongLists.IndexOf(ucFavoriteSong);
                        if (i == ucFavoriteSongLists.Count - 1)
                        {
                            Setup(ucFavoriteSongLists[0]);
                        }
                        else
                            Setup(ucFavoriteSongLists[i + 1]);
                        break;
                    }
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
                btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_one_40px_green;
                CheckRepeat = true;
            }

        }

        private void TrackbarMusic_Scroll(object sender, ScrollEventArgs e)
        {
            WindowsMediaPlayer.controls.currentPosition = TrackbarMusic.Value;               
        }
        private void BtnTym_Click(object sender, EventArgs e)
        {
            FavoriteSong favoriteSong = new FavoriteSong(song.Name, song.Artist, song.IMage, song.Source, song.Length);
            if (CheckTym)
            {
                btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_40px;
                CheckTym = false;
                FavoriteSongDAO.Instance.RemoveFavoriteSong(favoriteSong);
                Remove(favoriteSong.Name, favoriteSong.Artist);
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
                    ReLoad();
                }    
                
            }
        }
        public void SelectOnlineSong(UcOnlineSong ucOnlineSong)
        {

            string Filename = AppDomain.CurrentDomain.BaseDirectory + "Song\\" + ucOnlineSong.NameSong + ".mp3";
            if (!File.Exists(Filename))
            {
                WebClient wb = new WebClient();
                wb.DownloadFile(ucOnlineSong.DownloadURL, Filename);
            }

            Setup(Filename);
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
            TrackbarMusic.ValueChanged -= TrackbarMusic_ValueChanged;
            TrackbarMusic.MouseUp -= TrackbarMusic_MouseUp;

            if (CheckRepeat)
            {
                //if ((int)WindowsMediaPlayer.controls.currentPosition == (int)WindowsMediaPlayer.currentMedia.duration)
                //    WindowsMediaPlayer.controls.currentPosition = 0;
                if (TrackbarMusic.Value == TrackbarMusic.Maximum)
                    WindowsMediaPlayer.controls.currentPosition = 0;

            }    
            else
            {
                TrackbarMusic.ValueChanged += TrackbarMusic_ValueChanged;
                TrackbarMusic.MouseUp += TrackbarMusic_MouseUp;
            }
        }

        public void SetupPausePlayButton()
        {
            btnPlayPause.Image = global::MediaPlayerWindows.Properties.Resources.pause_40px;
            btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_40px;
            CheckTym = false;
            btnAddPlaylist.Enabled = true;
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

        public void Setup(UcSong ucSong)
        {
            try
            {
                song = new Song(ucSong.Song.Name,ucSong.Song.Artist,ucSong.Song.IMage,ucSong.Song.Source,ucSong.Song.Length);
                PlaylistSong = new PlaylistSong(ucSong.Song.Name, ucSong.Song.Artist, ucSong.Song.IMage, ucSong.Song.Source, ucSong.Song.Length, "");
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
            ucSongs.Add(ucSong);
        }
        public void CleanUcSong()
        {
            ucSongs.Clear();
        }
        public void AddUcFavoriteSong(UcFavoriteSong ucFavoriteSong)
        {
            ucFavoriteSongLists.Add(ucFavoriteSong);
        }
        public void CleanUcFavoriteSong()
        {
            ucFavoriteSongLists.Clear();
        }
        public void PlayFirstSong()
        {
            this.Setup(ucSongs.First());
        }
        #endregion
        #region FavoriteSong
        public void Setup(UcFavoriteSong ucFavoriteSong)
        {
            try
            {
                FavoriteSong = new FavoriteSong(ucFavoriteSong.FavoriteSong.Name, ucFavoriteSong.FavoriteSong.Artist, ucFavoriteSong.FavoriteSong.IMage, ucFavoriteSong.FavoriteSong.Source, ucFavoriteSong.FavoriteSong.Length);
                PlaylistSong = new PlaylistSong(ucFavoriteSong.FavoriteSong.Name, ucFavoriteSong.FavoriteSong.Artist, ucFavoriteSong.FavoriteSong.IMage, ucFavoriteSong.FavoriteSong.Source, ucFavoriteSong.FavoriteSong.Length, "");
                RecentlySongDAO.Instance.AddRecentlyToDB(new RecentlySong(ucFavoriteSong.FavoriteSong.Name, ucFavoriteSong.FavoriteSong.Artist, ucFavoriteSong.FavoriteSong.IMage, ucFavoriteSong.FavoriteSong.Source, ucFavoriteSong.FavoriteSong.Length));
                string name = Path.ChangeExtension(Path.GetRandomFileName(), ".wav"); // tạo random 1 cái tên đẻ l luuw
                string path = Path.Combine(Path.GetTempPath(), name); // tạo 1 cái đường dẫn
                File.WriteAllBytes(path, ucFavoriteSong.FavoriteSong.Source); // ghi cái data từ Vs vào cái đường dẫn
                WindowsMediaPlayer.URL = path;
                SetupPausePlayButton();
                btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_outline_40px;
                btnTym.Enabled = false;
                TrackbarVolumn.Value = 50;
                TrackbarMusic.Value = TrackbarMusic.Minimum;
                this.LastSoundValue = TrackbarVolumn.Value;
                SetMuteButton();
                lbName.Text = ucFavoriteSong.FavoriteSong.Name;
                lbArtist.Text = ucFavoriteSong.FavoriteSong.Artist;
                pictureSong.Image = ConvertClass.Instance.ConvertByteToBitmap(ucFavoriteSong.FavoriteSong.IMage);
                lblTime_end.Text = ucFavoriteSong.FavoriteSong.Length;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void SetTymImage(UcFavoriteSong ucFavoriteSong)
        {
            if ( ucFavoriteSong.FavoriteSong.Name == FavoriteSong.Name && ucFavoriteSong.FavoriteSong.Artist == FavoriteSong.Artist)
            {
                btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_40px;
                CheckTym = false;
            }    
        }
        private bool ExecuteQuerySearchFavoriteSong(string name, string artist)
        {
            string query = "SELECT * FROM FAVORITESONGS WHERE ( NAMESONG = '" + name + "') AND ARTISTSONG = ('" + artist + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        #endregion
    }
}
