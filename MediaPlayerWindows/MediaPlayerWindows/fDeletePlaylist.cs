using MediaPlayerWindows.DAO;
using MediaPlayerWindows.DTO;
using MediaPlayerWindows.ManagerUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerWindows
{
    public partial class fDeletePlaylist : Form
    {
        public delegate void Change(string s);
        public event Change Reset;
        public fDeletePlaylist()
        {
            InitializeComponent();
            this.Load += FDeletePlaylist_Load;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FDeletePlaylist_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Playlist> playlists = PlaylistDAO.Instance.LoadPlaylistFromDB();
            foreach (Playlist playlist in playlists)
            {
                UcDelelePlayList ucDelelePlayList = new UcDelelePlayList(playlist.Name);
                ucDelelePlayList.Remove += UcDelelePlayList_Remove;
                flowLayoutPanel1.Controls.Add(ucDelelePlayList);
            }
        }

        private void UcDelelePlayList_Remove(UcDelelePlayList ucDelelePlayList)
        {
            flowLayoutPanel1.Controls.Remove(ucDelelePlayList);
            Reset(ucDelelePlayList.Playlist1.Name);
            
        }
    }
}
