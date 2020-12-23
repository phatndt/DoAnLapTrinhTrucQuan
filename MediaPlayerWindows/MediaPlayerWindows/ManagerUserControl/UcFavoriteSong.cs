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
        public event PlayFavoriteSong Play;
        //public event Action load;
        public event RemoveFavoriteSong Remove;

        public event RemoveFavoriteSong RemoveTym;

        private FavoriteSong favoriteSong;
        internal FavoriteSong FavoriteSong { get => favoriteSong; set => favoriteSong = value; }

        public UcFavoriteSong()
        {
            InitializeComponent();
        }
        public UcFavoriteSong(string b, string c, byte[] d, byte[] e, string f, int g )
        {
            InitializeComponent();
            favoriteSong = new FavoriteSong(b,c,d,e,f,g);
            lbName.Text = favoriteSong.Name;
            lbArtist.Text = favoriteSong.Artist;
            lbTime.Text = favoriteSong.Length;
            btnSelect.Click += BtnSelect_Click;
            btnTym.Click += BtnTym_Click;
        }

        private void BtnTym_Click(object sender, EventArgs e)
        {
            if (FavoriteSongDAO.Instance.RemoveFavoriteSong(favoriteSong))
                MessageBox.Show("co xoa");
            //if (load != null)
            //    load();
            Remove(this);
            RemoveTym(this);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a");
            Play(this);
        }

    }
    
}
