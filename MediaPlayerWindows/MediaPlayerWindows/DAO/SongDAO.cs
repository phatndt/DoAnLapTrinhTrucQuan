using MediaPlayerWindows.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MediaPlayerWindows.DAO
{
    class SongDAO : DataProvider
    {
        private static SongDAO instance;

        internal static SongDAO Instance
        {
            get { if (instance == null) instance = new SongDAO(); return SongDAO.instance; }
            private set { SongDAO.instance = value; }
        }
        private SongDAO()
        {

        }
        public List<Song> LoadSongFromDB()
        {
            List<Song> SongList = new List<Song>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM FAVORITESONGS");

            foreach (DataRow row in data.Rows)
            {
                Song song = new Song(row);
                SongList.Add(song);
            }
            return SongList;
        }
        public List<Song> LoadBrowser(string[] pathSongs)
        {
            List<Song> songs = new List<Song>();
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
                    Song song = new Song(fileTag.Tag.Title, fileTag.Tag.FirstPerformer, pImageData, pSourceData, fileTag.Properties.Duration.ToString(@"mm\:ss"));
                    songs.Add(song);
                }
                return songs;
            }
            catch
            {
                return null;

            }
        }
    }
}
