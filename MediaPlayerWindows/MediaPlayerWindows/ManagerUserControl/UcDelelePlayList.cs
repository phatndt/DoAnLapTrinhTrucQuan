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
    public delegate void RemovePlaylist(UcDelelePlayList ucDelelePlayList);
    public delegate void AddPlaylist(UcDelelePlayList ucDelelePlayList);
    public partial class UcDelelePlayList : UserControl
    {
        public event RemovePlaylist Remove;
        public event AddPlaylist Add;

        private Playlist Playlist;

        internal Playlist Playlist1 { get => Playlist; set => Playlist = value; }

        public UcDelelePlayList()
        {
            InitializeComponent();
            btnRemove.Click += BtnRemove_Click;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            PlaylistDAO.Instance.RemovePlaylistFormDB(Playlist1);
            Remove(this);
        }
        public UcDelelePlayList(string a)
        {
            InitializeComponent();
            Playlist1 = new Playlist(a);
            gunaLabel1.Text = a;
            btnAdd.Visible = false;
            btnAdd.Enabled = false;
            btnRemove.Click += BtnRemove_Click;

        }
        public UcDelelePlayList(string a, string b)
        {
            InitializeComponent();
            Playlist1 = new Playlist(a);
            gunaLabel1.Text = a;
            btnRemove.Visible = false;
            btnRemove.Enabled = false;
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add(this);
        }
    }
}
