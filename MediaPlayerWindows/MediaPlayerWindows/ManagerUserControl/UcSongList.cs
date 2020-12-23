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

namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcSongList : UserControl
    {
        public delegate void PlaySong(UcSong ucSong);

        List<Song> songs = null;
        public UcSongList(string s)
        {
            InitializeComponent();
            if (s == "LoadRecentlySongs")
                LoadRecentlySongs();
        }
        public UcSongList(string[] pathSongs)
        {
            InitializeComponent();
            LoadBrowser(pathSongs);
        }
        public void LoadBrowser(string[] pathSongs)
        {
            flowLayoutPanel.Controls.Clear();
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
                    flowLayoutPanel.Controls.Add(ucSong);
                    songs.Add(new Song(fileTag.Tag.Title, fileTag.Tag.FirstPerformer, pImageData, pSourceData, fileTag.Properties.Duration.ToString(@"mm\:ss")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void LoadRecentlySongs()
        {
            flowLayoutPanel.Controls.Clear();
            List<RecentlySong> recentlySongs = RecentlySongDAO.Instance.LoadRencentlySongsFromDB();
            foreach (RecentlySong recently in recentlySongs)
            {
                UcSong ucSong = new UcSong(recently.Name, recently.Artist, recently.IMage, recently.Source, recently.Length);
                flowLayoutPanel.Controls.Add(ucSong);
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
            return flowLayoutPanel;
        }
    }
}
