using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayerWindows;
using WMPLib;
using System.IO;
using MediaPlayerWindows.DTO;
using MediaPlayerWindows.DAO;
using xNet;
using System.Text.RegularExpressions;
using System.Net;

namespace MediaPlayerWindows.ManagerUserControl
{
    public delegate void PlaySong(UcSong ucSong);
    public delegate void PlayOnlineSong(UcOnlineSong ucOnlineSong);

    public partial class UcSongList : UserControl
    {

        List<Song> songs = null;
        public UcSongList( )
        {
            InitializeComponent();
        }
        public UcSongList(string s)
        {
            InitializeComponent();
            if (s == "LoadRecentlySongs")
                LoadRecentlySongs();
        }
        public UcSongList(string s,bool check)
        {
            InitializeComponent();
            if(check)
            {
                if (s == "LoadTopVNSong")
                    LoadTopVNSongs();
                if (s == "LoadTopEASong")
                    LoadTopEASongs();
                if (s == "LoadTopKOSong")
                    LoadTopKOSongs();
            }
            else
            {
                if (s == "LoadTopVNSong")
                {
                    MessageBox.Show("Không thể tải BXH VN");
                }   
                if (s == "LoadTopEASong")
                {
                    MessageBox.Show("Không thể tải BXH EA");
                }
                if (s == "LoadTopKOSong")
                {
                    MessageBox.Show("Không thể tải BXH KO");
                }
            }
           
        }
        public UcSongList(string[] pathSongs)
        {
            InitializeComponent();
            LoadBrowser(pathSongs);
        }
        public void LoadBrowser(string[] pathSongs)
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                foreach (string s in pathSongs)
                {
                    var fileTag = TagLib.File.Create(s);
                    byte[] pImageData = null;
                    byte[] pSourceData = null;
                    var mStream = new MemoryStream();
                    var firstPicture = fileTag.Tag.Pictures.FirstOrDefault();
                    if (firstPicture != null)
                    {
                        pImageData = firstPicture.Data.Data;
                        mStream.Write(pImageData, 0, Convert.ToInt32(pImageData.Length));
                        var bm = new Bitmap(mStream, false);
                        mStream.Dispose();
                    }
                    else
                    {
                        pImageData = ConvertClass.Instance.ConvertImageToByte(global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound);
                    }
                    pSourceData = ConvertClass.Instance.ConvertDataMusicToByte(s);
                    UcSong ucSong = new UcSong(fileTag.Tag.Title, fileTag.Tag.FirstPerformer, pImageData, pSourceData, fileTag.Properties.Duration.ToString(@"mm\:ss"));
                    flowLayoutPanel1.Controls.Add(ucSong);
                    songs.Add(new Song(fileTag.Tag.Title, fileTag.Tag.FirstPerformer, pImageData, pSourceData, fileTag.Properties.Duration.ToString(@"mm\:ss")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                //aloooooooo
            }
        }
        public void LoadRecentlySongs()
        {
            flowLayoutPanel1.Controls.Clear();
            List<RecentlySong> recentlySongs = RecentlySongDAO.Instance.LoadRencentlySongsFromDB();
            foreach (RecentlySong recently in recentlySongs)
            {
                UcSong ucSong = new UcSong(recently.Name, recently.Artist, recently.IMage, recently.Source, recently.Length);
                flowLayoutPanel1.Controls.Add(ucSong);
            }
        }
        public void Remove()
        {
            //flowLayoutPanel.Controls.Remove()
        }

        private void FlowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            //MessageBox.Show("b");
            //flowLayoutPanel.Controls.Add(new UcNameSong());
           
        }

        public FlowLayoutPanel GetFlowLayoutPanel()
        {
            return flowLayoutPanel1;
        }
        public void LoadTopVNSongs()
        {
            flowLayoutPanel1.Controls.Clear();
            List<OnlineSong> TopVNSongs = OnlineSongDAO.Instance.LoadOnlineSongVN();
            foreach (OnlineSong songVN in TopVNSongs)
            {
                UcOnlineSong ucOnlineSong = new UcOnlineSong(songVN.Name, songVN.Artist, songVN.ImageOnline, songVN.DownloadURL);
                flowLayoutPanel1.Controls.Add(ucOnlineSong);
            }
        }
        public void LoadTopEASongs()
        {
            flowLayoutPanel1.Controls.Clear();
            List<OnlineSong> TopEASongs = OnlineSongDAO.Instance.LoadOnlineSongEA();
            foreach (OnlineSong songVN in TopEASongs)
            {
                UcOnlineSong ucOnlineSong = new UcOnlineSong(songVN.Name, songVN.Artist, songVN.ImageOnline, songVN.DownloadURL);
                flowLayoutPanel1.Controls.Add(ucOnlineSong);
            }
        }
        public void LoadTopKOSongs()
        {
            flowLayoutPanel1.Controls.Clear();
            List<OnlineSong> TopKOSongs = OnlineSongDAO.Instance.LoadOnlineSongKO();
            foreach (OnlineSong songVN in TopKOSongs)
            {
                UcOnlineSong ucOnlineSong = new UcOnlineSong(songVN.Name, songVN.Artist, songVN.ImageOnline, songVN.DownloadURL);
                flowLayoutPanel1.Controls.Add(ucOnlineSong);
            }
        }
        public FlowLayoutPanel FlowLayoutPanel()
        {
            return flowLayoutPanel1;
        }
    }
}
