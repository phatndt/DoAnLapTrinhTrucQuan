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
    class PlaylistDAO : DataProvider
    {
        private static PlaylistDAO instance;

        internal static PlaylistDAO Instance
        {
            get { if (instance == null) instance = new PlaylistDAO(); return PlaylistDAO.instance; }
            private set { PlaylistDAO.instance = value; }
        }
        private PlaylistDAO()
        {

        }
        public List<Playlist> LoadPlaylistFromDB()
        {
            List<Playlist> playlists = new List<Playlist>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PLAYLIST");

            foreach (DataRow row in data.Rows)
            {
                Playlist playlist = new Playlist(row);
                playlists.Add(playlist);
            }
            return playlists;
        }
        public void AddPlaylistToDB(string s, byte[] bt)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO PLAYLIST VALUES (@name,@data)", connection);
                    command.Parameters.AddWithValue("@name", s);
                    command.Parameters.AddWithValue("@data", Convert.ToBase64String(bt));
                    command.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                    MessageBox.Show("Thêm playlist thành công");
                }
            }
        }
        public void RemovePlaylistFormDB(Playlist playlist)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    string s = "DELETE FROM PLAYLIST WHERE ( PLAYLISTNAME = '" + playlist.Name + "')";
                    SQLiteCommand command = new SQLiteCommand(s, connection);
                    int i = command.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                    MessageBox.Show("Xóa playlist thành công");
                }
            }
        }
    }
}
