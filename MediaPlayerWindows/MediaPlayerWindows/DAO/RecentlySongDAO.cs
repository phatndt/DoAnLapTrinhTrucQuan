using MediaPlayerWindows.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWindows.DAO
{
    class RecentlySongDAO : DataProvider
    {
        private static RecentlySongDAO instance;

        internal static RecentlySongDAO Instance
        {
            get { if (instance == null) instance = new RecentlySongDAO(); return RecentlySongDAO.instance; }
            private set { RecentlySongDAO.instance = value; }
        }
        public List<RecentlySong> LoadRencentlySongsFromDB()
        {
            List<RecentlySong> SongList = new List<RecentlySong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM RECENTLYSONGS");

            foreach (DataRow row in data.Rows)
            {
                RecentlySong recentlySong= new RecentlySong(row);
                SongList.Add(recentlySong);
            }
            return SongList;
        }
        public void AddRecentlyToDB(RecentlySong recentlySong)
        {

            //if (DataProvider.Instance.ExecuteNonQueryCount("SELECT COUNT(*) FROM RECENTLYSONGS") > 3 )
            //{
            //    using (SqlConnection connection = new SqlConnection(query))
            //    {
            //        connection.Open();
            //        string s = "DELETE FROM RECENTLYSONGS WHERE NAMESONG = N'" + recentlySong.Name + "'";
            //        SqlCommand command = new SqlCommand(s, connection);
            //        command.ExecuteNonQuery();
            //        connection.Close();
            //    }
            //}    

            string queryCheckExist = "SELECT * FROM RECENTLYSONGS WHERE NAMESONG = N'" + recentlySong.Name + "' AND ARTISTSONG = N'" + recentlySong.Artist + "'";

            if (DataProvider.Instance.ExecuteNonQuery(queryCheckExist))
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    string s = "DELETE FROM RECENTLYSONGS WHERE NAMESONG = N'" + recentlySong.Name + "'";
                    SqlCommand command = new SqlCommand(s, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO RECENTLYSONGS VALUES (@name,@artist,@image,@data,@length)", connection);

                command.Parameters.AddWithValue("@name", recentlySong.Name);
                command.Parameters.AddWithValue("@artist", recentlySong.Artist);
                command.Parameters.AddWithValue("@image", Convert.ToBase64String(recentlySong.IMage));
                command.Parameters.AddWithValue("@data", Convert.ToBase64String(recentlySong.Source));
                command.Parameters.AddWithValue("@length", recentlySong.Length);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
