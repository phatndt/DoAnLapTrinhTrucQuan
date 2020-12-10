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
using System.Data.SqlClient;
using MediaPlayerWindows.DAO;
using System.Collections;
using Bunifu.Framework;
using MediaPlayerWindows.DTO;
using Guna.UI.WinForms;

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
        private UserControl active;
        SaveFileDialog sv = new SaveFileDialog();
        private byte[] bytes;
        public fMusicManager()
        {
            InitializeComponent();
            LoadAccountList();
            btnBrowse.Click += BtnBrowse_Click;
            btnMute.Click += BtnMute_Click;
            btnUnMute.Click += BtnUnMute_Click;
            btnShuffle.Click += BtnShuffle_Click;

            btnPlay.Click += BtnPlay_Click;
            btnPause.Click += BtnPause_Click;
            this.FormClosing += FMusicManager_FormClosing;

            btnTym.Click += BtnTym_Click;
            btnFavoriteSong.Click += BtnFavoriteSong_Click;

            btnHome.Click += BtnHome_Click;
            this.DoubleBuffered = true;
            LoadOneMusic();
            ucNameSong1.PlayUcSong += UcNameSong1_PlayUcSong;
        }

        private void UcNameSong1_PlayUcSong(string s)
        {
            ucMusicControl.Setup(s);
        }

        public void LoadOneMusic()
        {
            string s = @"C:\Users\THANHPHAT219\Downloads\MusicTest\Tình Sầu Thiên Thu Muôn Lối ( Htrol Remix ) Doãn Hiếu Nhạc Tiktok Gây Nghiện 2020.mp3";
            TagLib.File fileTag = TagLib.File.Create(s, "audio/mp3", TagLib.ReadStyle.None);
            string Name = fileTag.Tag.Title;
            string Artist = fileTag.Tag.FirstPerformer;
            Image image = null;
            var mStream = new MemoryStream();
            var firstPicture = fileTag.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                image = bm;
            }
            else
            {
                pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound;
            }
            ucNameSong1.Set(s, Name, Artist, image);
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new UcMusicControl());
        }

        void LoadAccountList()
        {

            string query = "SELECT * FROM ACCOUNT";
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
            openChildForm(new UcFavoriteSong());

        }

        private void BtnTym_Click(object sender, EventArgs e)
        {
            if (CheckFavoriteSong)
            {
                btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_outline_40px;
                CheckFavoriteSong = false;
                
            }    
            else
            {
                btnTym.Image = global::MediaPlayerWindows.Properties.Resources.heart_40px;
                CheckFavoriteSong = true;
                
                MessageBox.Show("a");
            }

        }

        #endregion
        private void openChildForm(UserControl childForm)
        {
            panelMainButton.Controls.Clear();
            panelMain.Controls.Clear();
            childForm.Dock = DockStyle.Top;
            childForm.BringToFront();
            childForm.Show();
            //panelMain.Controls.Add(childForm);
            panelMainButton.Controls.Add(childForm);
        }

        //private void BtnPlaying_Click(object sender, EventArgs e)
        //{
        //    insert();
        //}
        //private void insert()
        //{
        //    bytes = File.ReadAllBytes(sv.FileName);
        //    var bit = new BitArray(bytes);
        //    DataProvider.Instance.ExecuteNonQuery("exec USE_INSERT &SV", new object[] { bit });
        //    DataProvider.Instance.ExecuteNonQuery("insert into datamusic values( '" + bytes + "'))");
        //    FavoriteSong favoriteSong = new FavoriteSong(w.URL);
        //    FavoriteSongDAO.Instance.AddFavoriteSong(favoriteSong);

        //    FavoriteSongDAO.Instance.PlayfavoriteSongFromDB(favoriteSong);
        //    string cs = "Data Source=MSI;Initial Catalog=TP219;Integrated Security=True";
        //    try
        //    {
        //        SqlConnection connection;
        //        connection = new SqlConnection(cs);
        //        SqlCommand selectcom = new SqlCommand("insert into datamusic values( '" + bytes + "'))", connection);
        //        SqlDataReader myread;

        //        connection.Open();
        //        myread = selectcom.ExecuteReader();
        //        while (myread.Read())
        //        {

        //        }

        //        connection.Close();
        //        MessageBox.Show("Data saved successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
        #region Browser
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter =
                "Audio Files (*.mp3,*.m4a,*.wav,*.aac)|*.mp3|Video Files(*.mp4,*.wmv,*.3gp,*.mkv)|*.mp4|All Files(*.*)|*.*";
            dlg.FilterIndex = 1;
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                ucMusicControl.Setup(dlg) ;
            }
            //setnewsong(dlg);
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
                    MessageBox.Show(dlg.FileName);
                    btnTym.Enabled = true;
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
                        pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound;
                    }
                    timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            sv.FileName = dlg.FileName;
        }
        #endregion
        private void FMusicManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            w.controls.stop();
        }

        //private void BtnRepeat_Click(object sender, EventArgs e)
        //{
        //    if (CheckRepeatSong == 0)
        //    {
        //        btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_one_40px_green;
        //        CheckRepeatSong = 1;
        //    }
        //    else
        //    {
        //        if (CheckRepeatSong == 1)
        //        {
        //            btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px_green;
        //            CheckRepeatSong = 2;
        //        }    
        //        else
        //        {
        //            btnRepeat.Image = global::MediaPlayerWindows.Properties.Resources.repeat_40px;
        //            CheckRepeatSong = 0;
        //        }    
        //    }
        //}
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