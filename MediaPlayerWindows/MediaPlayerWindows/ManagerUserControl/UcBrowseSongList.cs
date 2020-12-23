using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayerWindows.DTO;
using System.IO;
using MediaPlayerWindows.DAO;

namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcBrowseSongList : UserControl
    {
        public delegate void PlaySong(UcSong ucSong);

        public UcBrowseSongList(string[] pathSongs)
        {
            InitializeComponent();
            LoadBrowse(pathSongs);
        }
        //public void LoadBrowser(string[] pathSongs)
        //{
        //    flowLayoutPanel.Controls.Clear();
        //    try
        //    {
        //        foreach (string s in pathSongs)
        //        {
        //            var fileTag = TagLib.File.Create(s);
        //            byte[] pImageData = null;
        //            byte[] pSourceData = null;
        //            var mStream = new MemoryStream();
        //            var firstPicture = fileTag.Tag.Pictures.FirstOrDefault();
        //            if (firstPicture != null)
        //            {
        //                pImageData = firstPicture.Data.Data;
        //                mStream.Write(pImageData, 0, Convert.ToInt32(pImageData.Length));
        //                var bm = new Bitmap(mStream, false);
        //                mStream.Dispose();
        //            }
        //            else
        //            {
        //                pImageData = ConvertClass.Instance.ConvertImageToByte(global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound);
        //            }
        //            pSourceData = ConvertClass.Instance.ConvertDataMusicToByte(s);
        //            UcSong ucSong = new UcSong(s, fileTag.Tag.Title, fileTag.Tag.FirstPerformer, pImageData, pSourceData, fileTag.Properties.Duration.ToString(@"mm\:ss"));
        //            flowLayoutPanel.Controls.Add(ucSong);
        //            Songs.Add(new Song(s, fileTag.Tag.Title, fileTag.Tag.FirstPerformer, pImageData, pSourceData, fileTag.Properties.Duration.ToString(@"mm\:ss")));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error" + ex.Message);
        //    }
        //}
        public void LoadBrowse(string[] pathSongs)
        {
            flowLayoutPanel.Controls.Clear();
            List<Song> songs = SongDAO.Instance.LoadBrowser(pathSongs);
            foreach (Song song in songs)
            {
                UcSong ucSong = new UcSong(song.Name, song.Artist, song.IMage, song.Source, song.Length);
                flowLayoutPanel.Controls.Add(ucSong);
            }
        }
        public FlowLayoutPanel FlowLayoutPanel()
        {
            return flowLayoutPanel;
        }
    }
}
