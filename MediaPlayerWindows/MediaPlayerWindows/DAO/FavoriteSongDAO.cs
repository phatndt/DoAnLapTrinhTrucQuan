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
        public byte[] convert(FavoriteSong favoriteSong)
        {
            FileStream fs = new FileStream(favoriteSong.Path, FileMode.Open, FileAccess.Read);
            byte[] imgByteArr = new byte[fs.Length];
            fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return imgByteArr;
        }
        public void AddFavoriteSong(FavoriteSong favoriteSong)
        {
            //favoriteSong.Source = File.ReadAllBytes(favoriteSong.Path);
            string query = "Data Source=MSI;Initial Catalog=MEDIA_PLAYER_WINDOWS;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(query))
            {
                connection.Open();

                //SqlCommand command = new SqlCommand("INSERT INTO DATAMUSIC VALUES (CONVERT(VARBINARY(MAX),'" + favoriteSong.Source + "'))", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO DATAMUSIC VALUES (@file)", connection);
                SqlCommand command = new SqlCommand("INSERT INTO FAVORITESONGS VALUES (@path,@name,@artist,@image,@data,@length,@status)", connection);
                //command.Parameters.AddWithValue("file", SqlDbType.VarBinary).Value = File.ReadAllBytes(favoriteSong.Path);
                command.Parameters.AddWithValue("@path", favoriteSong.Path);
                command.Parameters.AddWithValue("@name", favoriteSong.Name);
                command.Parameters.AddWithValue("@artist", favoriteSong.Artist);
                command.Parameters.AddWithValue("@image", Convert.ToBase64String(favoriteSong.IMage));
                command.Parameters.AddWithValue("@data", Convert.ToBase64String(favoriteSong.Source));
                command.Parameters.AddWithValue("@length", favoriteSong.Length);
                command.Parameters.AddWithValue("@status", favoriteSong.Status);
                command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
        }
        public void CheckExistFavoriteSong(FavoriteSong favoriteSong)
        {
            //favoriteSong.Source = File.ReadAllBytes(favoriteSong.Path);
            string query = "Data Source=MSI;Initial Catalog=MEDIA_PLAYER_WINDOWS;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(query))
            {
                connection.Open();

                //SqlCommand command = new SqlCommand("INSERT INTO DATAMUSIC VALUES (CONVERT(VARBINARY(MAX),'" + favoriteSong.Source + "'))", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO DATAMUSIC VALUES (@file)", connection);
                SqlCommand command = new SqlCommand("INSERT INTO FAVORITESONGS VALUES (@path,@name,@artist,@image,@data,@length,@status)", connection);
                //command.Parameters.AddWithValue("file", SqlDbType.VarBinary).Value = File.ReadAllBytes(favoriteSong.Path);
                command.Parameters.AddWithValue("@path", favoriteSong.Path);
                command.Parameters.AddWithValue("@name", favoriteSong.Name);
                command.Parameters.AddWithValue("@artist", favoriteSong.Artist);
                command.Parameters.AddWithValue("@image", Convert.ToBase64String(favoriteSong.IMage));
                command.Parameters.AddWithValue("@data", Convert.ToBase64String(favoriteSong.Source));
                command.Parameters.AddWithValue("@length", favoriteSong.Length);
                command.Parameters.AddWithValue("@status", favoriteSong.Status);
                command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
        }
        public void PlayfavoriteSongFromDB(FavoriteSong favoriteSong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TOP(1) * FROM DATAMUSIC");

            byte[] binaryData = Convert.FromBase64String(data.ToString());
            string name = Path.ChangeExtension(Path.GetRandomFileName(), ".wav"); // tạo random 1 cái tên đẻ l luuw
            string path = Path.Combine(Path.GetTempPath(), name); // tạo 1 cái đường dẫn
            File.WriteAllBytes(path, binaryData); // ghi cái data từ Vs vào cái đường dẫn
            WindowsMediaPlayer W = new WindowsMediaPlayer();
            W.URL = path;
            //WindowsMediaPlayer windowsMediaPlayer = new WindowsMediaPlayer();
            //WaveFormat waveFormat = new WaveFormat();
            //waveFormat.
        }

            internal void AddFavoriteSong(object favoriteSong)
        {
            throw new NotImplementedException();
        }
    }
    
}
