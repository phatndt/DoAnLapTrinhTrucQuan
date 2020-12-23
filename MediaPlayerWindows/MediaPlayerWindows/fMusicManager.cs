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


    public partial class fMusicManager : Form
    {
        UcFavoriteSongList ucFavoriteSongList = new UcFavoriteSongList();
        UcBrowseSongList ucBrowseSongList = null;
        UcSongList UcSongList = new UcSongList("LoadRecentlySongs");
        string[] Path;
        public fMusicManager()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            LoadAccountList();
            LoadOneMusic();

            this.FormClosing += FMusicManager_FormClosing;
            this.SizeChanged += FMusicManager_SizeChanged;

            btnHome.Click += BtnHome_Click;
            btnBrowse.Click += BtnBrowse_Click;
            btnRecently.Click += BtnRecently_Click;
            btnFavoriteSong.Click += BtnFavoriteSong_Click;
            btnPlaylist.Click += BtnPlaylist_Click;


            ucMusicControl.ReLoad += UcMusicControl_ReLoad;
            ucMusicControl.Remove += UcMusicControl_Remove;

        }

        #region FormEvent
        private void FMusicManager_SizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.Size.Height.ToString());
            //panelMainButton.Size = new Size(panelMainButton.Size.Width + 20, panelMainButton.Size.Height + 20); 
            ucMusicControl.Size = new Size(this.Size.Width * 25 / 4, this.Size.Height);
        }
        private void FMusicManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void BtnPlaylist_Click(object sender, EventArgs e)
        {
            OpenUserControlDockBottom(new UcPlaylistList());
        }
        public void LoadOneMusic()
        {
            //string s = @"C:\Users\PC\Downloads\BongHoaDepNhat-QuanAP-6607955.mp3";
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
                //pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound;
            }
            //ucNameSong1.Set(s, Name, Artist, image);
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (Path != null)
            {
                panelMain.Controls.Clear();
                OpenUserControlDockFill(ucBrowseSongList);
            }    

        }
        #region RecentlySong
        private void BtnRecently_Click(object sender, EventArgs e)
        {
            
            OpenUserControlDockFill(UcSongList);
            LoadEventUcRecentlySong();
        }
        private void LoadEventUcRecentlySong()
        {
            foreach (UcSong ucSong in UcSongList.GetFlowLayoutPanel().Controls)
            {
                ucSong.PlaySong += UcSong_PlaySong1;
            }
        }

        private void UcSong_PlaySong1(UcSong ucSong)
        {
            ucMusicControl.Setup(ucSong);
        }
        #endregion
        void LoadAccountList()
        {

            string query = "SELECT * FROM ACCOUNT";
        }
        #region FavoriteSong
        private void LoadEventUcFavoriteSong()
        {
            foreach (UcFavoriteSong ucFavoriteSong in ucFavoriteSongList.FlowLayoutPanel().Controls)
            {
                ucFavoriteSong.Play += UcFavoriteSong_Play;
                ucFavoriteSong.RemoveTym += UcFavoriteSong_RemoveTym;
            }
        }

        private void UcFavoriteSong_RemoveTym(UcFavoriteSong ucFavoriteSong)
        {
            ucMusicControl.SetTymImage();
        }

        private void BtnFavoriteSong_Click(object sender, EventArgs e)
        {
            ucFavoriteSongList.Load();
            LoadEventUcFavoriteSong();
            OpenUserControlDockFill(ucFavoriteSongList);
        }

        private void UcFavoriteSong_Play(UcFavoriteSong ucFavoriteSong)
        {
            ucMusicControl.Setup(ucFavoriteSong);
            
        }
        #endregion
        #region UcMusicControl
        private void UcMusicControl_ReLoad()
        {
            ucFavoriteSongList.Load();
            LoadEventUcFavoriteSong();
        }

        private void UcMusicControl_Remove(string a, string b)
        {
            foreach (UcFavoriteSong ucFavoriteSong in ucFavoriteSongList.FlowLayoutPanel().Controls)
            {
                if (ucFavoriteSong.FavoriteSong.Name == a && ucFavoriteSong.FavoriteSong.Artist == b)
                    ucFavoriteSongList.FlowLayoutPanel().Controls.Remove(ucFavoriteSong);
            }
            LoadEventUcFavoriteSong();
        }
        #endregion
        #region OpenUserControl
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
        private void OpenUserControlDockBottom(UserControl childForm)
        {
            //panelMain.Controls.Clear();
            childForm.Dock = DockStyle.Bottom;
            childForm.BringToFront();
            childForm.Show();
            //panelMain.Controls.Add(childForm);
            panelMain.Controls.Add(childForm);
        }
        private void OpenUserControlDockFill(UserControl childForm)
        {
            panelMain.Controls.Clear();
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
            panelMain.Controls.Add(childForm);
        }
        #endregion
        
        #region Browser
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter =
                "Audio Files (*.mp3,*.m4a,*.wav,*.aac)|*.mp3|Video Files(*.mp4,*.wmv,*.3gp,*.mkv)|*.mp4|All Files(*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.Multiselect = true;
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                Path = dlg.FileNames;
                ucBrowseSongList = new UcBrowseSongList(Path);
                ucMusicControl.CleanUcSong();
                LoadEventUcSong();
                OpenUserControlDockFill(ucBrowseSongList);
            }
        }
        private void LoadEventUcSong()
        {
            foreach (UcSong ucSong in ucBrowseSongList.FlowLayoutPanel().Controls)
            {
                ucSong.PlaySong += UcSong_PlaySong;
                ucMusicControl.AddUcSong(ucSong);
            }
        }

        private void UcSong_PlaySong(UcSong ucSong)
        {
            ucMusicControl.Setup(ucSong);
        }
        #endregion
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