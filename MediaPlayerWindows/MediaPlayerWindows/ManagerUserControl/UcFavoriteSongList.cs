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
using static MediaPlayerWindows.ManagerUserControl.UcMusicControl;

namespace MediaPlayerWindows.ManagerUserControl
{
    public delegate void PlayFavoriteSong(UcFavoriteSong ucFavoriteSong);
    public delegate void RemoveFavoriteSong(UcFavoriteSong ucFavoriteSong);
    public partial class UcFavoriteSongList : UserControl
    {
        public UcFavoriteSongList()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            //FlowLayoutPanel.Dock = DockStyle.Top;
            //FlowLayoutPanel.BringToFront();
            //FlowLayoutPanel.Show();
            //this.Controls.Add(FlowLayoutPanel);
            flowLayoutPanel1.Controls.Clear();
            List<FavoriteSong> favoriteSongs = FavoriteSongDAO.Instance.LoadFavoriteSong();
            foreach (FavoriteSong favorite in favoriteSongs)
            {
                UcFavoriteSong ucFavoriteSong = new UcFavoriteSong(favorite.Name, favorite.Artist, favorite.IMage, favorite.Source, favorite.Length, favorite.Status);
                ucFavoriteSong.Remove += UcFavoriteSong_Remove;
                flowLayoutPanel1.Controls.Add(ucFavoriteSong);
            }
        }

        private void UcFavoriteSong_Remove(UcFavoriteSong ucFavoriteSong)
        {
            flowLayoutPanel1.Controls.Remove(ucFavoriteSong);
        }

        public FlowLayoutPanel FlowLayoutPanel()
        {
            return flowLayoutPanel1;
        }
    }
}
