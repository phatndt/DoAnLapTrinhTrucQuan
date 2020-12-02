using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayerWindows.DTO;
using MediaPlayerWindows.DAO;

namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcFavoriteSong : UserControl
    {
        List<UcNameSong> listControls = new List<UcNameSong>();
        public UcFavoriteSong()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            flowLayoutPanel.Controls.Clear();
            List<FavoriteSong> favoriteSongs = FavoriteSongDAO.Instance.LoadFavoriteSong();
            foreach (FavoriteSong favorite in favoriteSongs)
            {
                UcNameSong ucFavoriteSong = new UcNameSong(favorite.Path, favorite.Name, favorite.Artist, favorite.IMage, favorite.Length);
                flowLayoutPanel.Controls.Add(ucFavoriteSong);
            }    
        }
    }
}
