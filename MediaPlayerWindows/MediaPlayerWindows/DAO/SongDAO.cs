﻿using MediaPlayerWindows.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWindows.DAO
{
    class SongDAO
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
        public void AddSongToDB(Song song)
        {
            //favoriteSong.Source = File.ReadAllBytes(favoriteSong.Path);
            string query = "Data Source=MSI;Initial Catalog=MEDIA_PLAYER_WINDOWS;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(query))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO DATAMUSIC VALUES (@file)", connection);
                
                command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
        }
    }
}
