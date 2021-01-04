using MediaPlayerWindows.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows;

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
                RecentlySong recentlySong = new RecentlySong(row);
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

            string queryCheckExist = "SELECT * FROM RECENTLYSONGS WHERE (NAMESONG = '" + recentlySong.Name + "') AND (ARTISTSONG = '" + recentlySong.Artist + "')";
            if (DataProvider.Instance.ExecuteNonQuery(queryCheckExist))
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionSTR))
                {
                    connection.Open();
                    //string s = "DELETE FROM RECENTLYSONGS WHERE (NAMESONG = '" + recentlySong.Name + "')";
                    string s = String.Format("DELETE FROM RECENTLYSONGS WHERE (NAMESONG = '{0}')", recentlySong.Name);
                    using (SQLiteCommand command = new SQLiteCommand(s, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            using (SQLiteConnection connection = new SQLiteConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("INSERT INTO RECENTLYSONGS VALUES (@name,@artist,@image,@data,@length)", connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@name", recentlySong.Name);
                        command.Parameters.AddWithValue("@artist", recentlySong.Artist);
                        command.Parameters.AddWithValue("@image", Convert.ToBase64String(recentlySong.IMage));
                        command.Parameters.AddWithValue("@data", Convert.ToBase64String(recentlySong.Source));
                        command.Parameters.AddWithValue("@length", recentlySong.Length);

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

                }

            }
        }
    }
}
