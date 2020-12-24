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
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO FAVORITESONGS VALUES (@name,@artist,@image,@data,@length,@status)", connection);
                command.Parameters.AddWithValue("@name", favoriteSong.Name);
                command.Parameters.AddWithValue("@artist", favoriteSong.Artist);
                command.Parameters.AddWithValue("@image", Convert.ToBase64String(favoriteSong.IMage));
                command.Parameters.AddWithValue("@data", Convert.ToBase64String(favoriteSong.Source));
                command.Parameters.AddWithValue("@length", favoriteSong.Length);
                command.Parameters.AddWithValue("@status", favoriteSong.Status);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public bool  RemoveFavoriteSong(FavoriteSong favoriteSong)
        {
            string query = "Data Source=MSI;Initial Catalog=MEDIA_PLAYER_WINDOWS;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string s = "DELETE FROM FAVORITESONGS WHERE NAMESONG = N'" + favoriteSong.Name +"'";
                SqlCommand command = new SqlCommand(s, connection);
                int i = command.ExecuteNonQuery();
                connection.Close();
                if (i == -1)
                    return true;
                else
                    return false;
            }
        }
    }
    
}
