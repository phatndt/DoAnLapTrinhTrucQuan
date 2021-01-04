using MediaPlayerWindows.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MediaPlayerWindows.DAO
{
    class PlaylistSongDAO : DataProvider
    {
        private static PlaylistSongDAO instance;

        internal static PlaylistSongDAO Instance
        {
            get { if (instance == null) instance = new PlaylistSongDAO(); return PlaylistSongDAO.instance; }
            private set { PlaylistSongDAO.instance = value; }
        }
        private PlaylistSongDAO()
        {

        }
        public List<PlaylistSong> LoadPlaylistSongFromDB(string s)
        {
            string loadquery = "SELECT * FROM PLAYLISTSONGS WHERE ( PLAYLISTNAME = '" + s + "' )";

            List<PlaylistSong> playlistSongs = new List<PlaylistSong>();
            DataTable data = DataProvider.Instance.ExecuteQuery(loadquery);

            foreach (DataRow row in data.Rows)
            {
                PlaylistSong playlistSong = new PlaylistSong(row);
                playlistSongs.Add(playlistSong);
            }
            return playlistSongs;
        }
        public void AddPlaylistSongToDB(PlaylistSong playlistSong)
        {
            string s = "SELECT * FROM PLAYLISTSONGS WHERE ( NAMESONG = '" + playlistSong.Name + "' ) AND ( ARTISTSONG = '" + playlistSong.Artist + "' ) AND ( PLAYLISTNAME = '" + playlistSong.Playlistname + "' )";
            if (DataProvider.Instance.ExecuteNonQuery(s))
            {
                MessageBox.Show("Bài hát đã tồn tại trong playlist");
            }    
            else
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionSTR))
                {
                    try
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand("INSERT INTO PLAYLISTSONGS VALUES (@name,@artist,@image,@data,@length,@playlistname)", connection))
                        {
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@name", playlistSong.Name);
                            command.Parameters.AddWithValue("@artist", playlistSong.Artist);
                            command.Parameters.AddWithValue("@image", Convert.ToBase64String(playlistSong.IMage));
                            command.Parameters.AddWithValue("@data", Convert.ToBase64String(playlistSong.Source));
                            command.Parameters.AddWithValue("@length", playlistSong.Length);
                            command.Parameters.AddWithValue("@playlistname", playlistSong.Playlistname);

                            command.ExecuteNonQuery();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("");
                    }
                    finally
                    {
                        connection.Close();
                        MessageBox.Show("Thêm nhạc vào playlist thành công");
                    }
                }
            }    

        }
        public void RemoveFavoriteSong(PlaylistSong playlistSong)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    string s = "DELETE FROM PLAYLISTSONGS WHERE ( NAMESONG = '" + playlistSong.Name + "') AND ( ARTISTSONG = '" + playlistSong.Artist + "' )";
                    SQLiteCommand command = new SQLiteCommand(s, connection);
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {

                }
                finally
                {
                    MessageBox.Show("Xóa nhạc ra khỏi playlist thành công");
                }
            }
        }
    }
}
