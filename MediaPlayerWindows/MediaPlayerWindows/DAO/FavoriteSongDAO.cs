using MediaPlayerWindows.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWindows.DAO
{
    class FavoriteSongDAO
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
    }
    
}
