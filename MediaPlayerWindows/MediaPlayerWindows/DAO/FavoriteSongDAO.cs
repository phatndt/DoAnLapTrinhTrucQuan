using MediaPlayerWindows.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using NAudio.Wave;
using System.Data.SQLite;
using System.Windows;

namespace MediaPlayerWindows.DAO
{
    class FavoriteSongDAO : DataProvider
    {
        private static FavoriteSongDAO instance;

        internal static FavoriteSongDAO Instance 
        {
            get { if (instance == null) instance = new FavoriteSongDAO(); return FavoriteSongDAO.instance; }
            private set { FavoriteSongDAO.instance = value; }
        }
        private FavoriteSongDAO()
        {

        }
        public List<FavoriteSong> LoadFavoriteSong()
        {
            List<FavoriteSong> favoriteSongsList = new List<FavoriteSong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM FAVORITESONGS");
            
            foreach (DataRow row in data.Rows)
            {
                FavoriteSong favorite = new FavoriteSong(row);
                favoriteSongsList.Add(favorite);
            }
            return favoriteSongsList;
        }
        //public byte[] convert(FavoriteSong favoriteSong)
        //{
        //    FileStream fs = new FileStream(favoriteSong.Path, FileMode.Open, FileAccess.Read);
        //    byte[] imgByteArr = new byte[fs.Length];
        //    fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));
        //    fs.Close();
        //    return imgByteArr;
        //}
        public void AddFavoriteSong(FavoriteSong favoriteSong)
        {
            using (SQLiteConnection connection  = new SQLiteConnection(connectionSTR))
            {
               try
               {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO FAVORITESONGS VALUES (@name,@artist,@image,@data,@length)", connection);
                    command.Parameters.AddWithValue("@name", favoriteSong.Name);
                    command.Parameters.AddWithValue("@artist", favoriteSong.Artist);
                    command.Parameters.AddWithValue("@image", Convert.ToBase64String(favoriteSong.IMage));
                    command.Parameters.AddWithValue("@data", Convert.ToBase64String(favoriteSong.Source));
                    command.Parameters.AddWithValue("@length", favoriteSong.Length);

                    command.ExecuteNonQuery();
               }
               catch
               {

               }
               finally
               {
                    connection.Close();
                    MessageBox.Show("Thêm vào nhạc yêu thích thành công");
               }
            }
        }
        public void RemoveFavoriteSong(FavoriteSong favoriteSong)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    string s = "DELETE FROM FAVORITESONGS WHERE ( NAMESONG = '" + favoriteSong.Name + "' ) AND ( ARTISTSONG = '" + favoriteSong.Artist + "' )";
                    SQLiteCommand command = new SQLiteCommand(s, connection);
                    int i = command.ExecuteNonQuery();

                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                    MessageBox.Show("Xóa khỏi nhạc yêu thích thành công");
                }
            }
        }
    }
    
}
