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
using xNet;
using System.Net;

namespace MediaPlayerWindows
{
    public delegate void CreatPlayList();

    public partial class fMusicManager : Form
    {

        UcFavoriteSongList ucFavoriteSongList = new UcFavoriteSongList();
        UcBrowseSongList ucBrowseSongList = null;
        UcSongList UcSongList = new UcSongList("LoadRecentlySongs");

        UcSongList UcSongListVN = new UcSongList("LoadTopVNSong", CheckForInternetConnection());
        UcSongList UcSongListEA = new UcSongList("LoadTopEASong", CheckForInternetConnection());
        UcSongList UcSongListKO = new UcSongList("LoadTopKOSong", (CheckForInternetConnection()));
        UcPlaylistSong UcPlaylistSong = new UcPlaylistSong();
        string[] Path;


        public fMusicManager()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            this.FormClosing += FMusicManager_FormClosing;

            btnHome.Click += BtnHome_Click;
            btnBrowse.Click += BtnBrowse_Click;
            btnRecently.Click += BtnRecently_Click;
            btnFavoriteSong.Click += BtnFavoriteSong_Click;
            btnPlaylist.Click += BtnPlaylist_Click;
            btnTopVN.Click += BtnTopVN_Click;
            btnTopEA.Click += BtnTopEA_Click;
            btnTopKO.Click += BtnTopKO_Click;
            btnDownload.Click += BtnDownload_Click;

            ucMusicControl.ReLoad += UcMusicControl_ReLoad;
            ucMusicControl.Remove += UcMusicControl_Remove;

        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            UcDownload uc = new UcDownload();
            panel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            uc.Show();
            panel2.Controls.Add(uc);
        }
        #region FormEvent
        private void FMusicManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region HomeButton
        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (Path != null)
            {

                OpenUserControlDockFill(ucBrowseSongList);
            }
            else
                panel2.Controls.Clear();
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
                ucMusicControl.CleanUcFavoriteSong();
                LoadEventUcSong();
                OpenUserControlDockFill(ucBrowseSongList);
                ucMusicControl.PlayFirstSong();
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
        #region RecentlySong
        private void BtnRecently_Click(object sender, EventArgs e)
        {
            UcSongList.LoadRecentlySongs();
            OpenUserControlDockFill(UcSongList);
            ucMusicControl.CleanUcSong();
            ucMusicControl.CleanUcFavoriteSong();
            LoadEventUcRecentlySong();
        }
        private void LoadEventUcRecentlySong()
        {
            foreach (UcSong ucSong in UcSongList.GetFlowLayoutPanel().Controls)
            {
                ucSong.PlaySong += UcSong_PlaySong1;
                ucMusicControl.AddUcSong(ucSong);
            }
        }

        private void UcSong_PlaySong1(UcSong ucSong)
        {
            ucMusicControl.Setup(ucSong);
        }
        #endregion
        #region FavoriteSong
        private void UcFavoriteSong_RemoveTym(UcFavoriteSong ucFavoriteSong)
        {
            ucMusicControl.SetTymImage(ucFavoriteSong);
        }

        private void BtnFavoriteSong_Click(object sender, EventArgs e)
        {
            ucFavoriteSongList.Load();
            ucMusicControl.CleanUcSong();
            ucMusicControl.CleanUcFavoriteSong();
            LoadEventUcFavoriteSong();
            OpenUserControlDockFill(ucFavoriteSongList);
        }
        private void LoadEventUcFavoriteSong()
        {
            foreach (UcFavoriteSong ucFavoriteSong in ucFavoriteSongList.FlowLayoutPanel().Controls)
            {
                ucFavoriteSong.Play += UcFavoriteSong_Play;
                ucFavoriteSong.RemoveTym += UcFavoriteSong_RemoveTym;
                ucMusicControl.AddUcFavoriteSong(ucFavoriteSong);
            }
        }
        private void UcFavoriteSong_Play(UcFavoriteSong ucFavoriteSong)
        {
            ucMusicControl.Setup(ucFavoriteSong);

        }
        #endregion
        #region Playlist
        private void BtnPlaylist_Click(object sender, EventArgs e)
        {
            UcPlaylistSong ucPlaylistSong = new UcPlaylistSong();
            //ucMusicControl.CleanUcSong();
            //ucMusicControl.CleanUcFavoriteSong();
            OpenUserControlDockFill(ucPlaylistSong);
            ucPlaylistSong.Play += UcPlaylistSong_Play;
            ucPlaylistSong.LoadList += UcPlaylistSong_LoadList;
            
        }

        private void UcPlaylistSong_LoadList(string s)
        {
            ucMusicControl.CleanUcSong();
            ucMusicControl.CleanUcFavoriteSong();
            List<PlaylistSong> PlaylistSongs = PlaylistSongDAO.Instance.LoadPlaylistSongFromDB(s);
            foreach (PlaylistSong playlistSong in PlaylistSongs)
            {
                UcSong ucSong = new UcSong(playlistSong.Name, playlistSong.Artist, playlistSong.IMage, playlistSong.Source, playlistSong.Length, "");
                ucMusicControl.AddUcSong(ucSong);
            }
        }

        private void UcPlaylistSong_Play(UcSong ucSong)
        {
            ucMusicControl.Setup(ucSong);
        }
        #endregion
        #region OnlineSong
        private void BtnTopKO_Click(object sender, EventArgs e)
        {
            OpenUserControlDockFill(UcSongListKO);
            LoadEventUcOnlineSongKO();
        }

        private void BtnTopEA_Click(object sender, EventArgs e)
        {
            OpenUserControlDockFill(UcSongListEA);
            LoadEventUcOnlineSongEA();
        }

        private void BtnTopVN_Click(object sender, EventArgs e)
        {
            OpenUserControlDockFill(UcSongListVN);
            LoadEventUcOnlineSongVN();
        }

        private void LoadEventUcOnlineSongVN()
        {
            foreach (UcOnlineSong ucOnlineSong in UcSongListVN.GetFlowLayoutPanel().Controls)
            {
                ucOnlineSong.PlayOnlineSong += UcOnlineSong_PlayOnlineSong;
            }
        }
        private void LoadEventUcOnlineSongEA()
        {
            foreach (UcOnlineSong ucOnlineSong in UcSongListEA.GetFlowLayoutPanel().Controls)
            {
                ucOnlineSong.PlayOnlineSong += UcOnlineSong_PlayOnlineSong;
            }
        }
        private void LoadEventUcOnlineSongKO()
        {
            foreach (UcOnlineSong ucOnlineSong in UcSongListKO.GetFlowLayoutPanel().Controls)
            {
                ucOnlineSong.PlayOnlineSong += UcOnlineSong_PlayOnlineSong;
            }
        }

        private void UcOnlineSong_PlayOnlineSong(UcOnlineSong ucOnlineSong)
        {

            ucMusicControl.SelectOnlineSong(ucOnlineSong);
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
            panel2.Controls.Clear();
            childForm.Dock = DockStyle.Bottom;
            childForm.BringToFront();
            childForm.Show();
            panel2.Controls.Add(childForm);
        }
        private void OpenUserControlDockFill(UserControl childForm)
        {
            panel2.Controls.Clear();
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
            panel2.Controls.Add(childForm);
        }
        #endregion
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}