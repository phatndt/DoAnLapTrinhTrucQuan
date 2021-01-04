using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MediaPlayerWindows.DAO
{
    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        //protected string connectionSTR = "Data Source=MSI;Initial Catalog=MEDIA_PLAYER_WINDOWS;Integrated Security=True";
        //protected string connectionSTR = @"Data Source=DESKTOP-2D2JACT\SQLEXPRESS;Initial Catalog=MEDIA_PLAYER_WINDOWS;Integrated Security=True";
        //protected string connectionSTR = "Data Source=:MEDIA_PLAYER_WINDOWS.db";
        protected string connectionSTR = "Data Source=MEDIA_PLAYER_WINDOWS.db;Version=3;";


        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionSTR))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        //public int ExecuteNonQueryCount(string query, object[] parameter = null)
        //{
        //    int data = 0;
        //    SqlDataReader reader = null;
        //    //using (SqlConnection connection = new SqlConnection(connectionSTR))
        //    using (SqlConnection connection = new SqlConnection(cs))
        //    {
        //        connection.Open();

        //        SqlCommand command = new SqlCommand(query, connection);

        //        if (parameter != null)
        //        {
        //            string[] listPara = query.Split(' ');
        //            int i = 0;
        //            foreach (string item in listPara)
        //            {
        //                if (item.Contains('@'))
        //                {
        //                    command.Parameters.AddWithValue(item, parameter[i]);
        //                    i++;
        //                }
        //            }
        //        }

        //        //data = command.ExecuteNonQuery();

        //        reader = command.ExecuteReader();

        //        connection.Close();
        //    }

        //    return data;
        //}
        public int ExecuteNonQueryCount(string query, object[] parameter = null)
        {
            int data = 0;

            using (SQLiteConnection connection = new SQLiteConnection(connectionSTR))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
        public bool ExecuteNonQuery(string query, object[] parameter = null)
        {
            bool data;
            DataTable dataTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionSTR))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        data = reader.Read();
                    }

                }
                connection.Close();

                //SqlDataAdapter adapter = new SqlDataAdapter(command);

                //adapter.Fill(dataTable);

            }
            //if (dataTable.Rows.Count > 0)
            //    return false;
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
