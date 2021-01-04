using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayerWindows.ManagerUserControl;
using MediaPlayerWindows;
using MediaPlayerWindows.DAO;
using MediaPlayerWindows.DTO;
using System.Data.SQLite;

namespace MediaPlayerWindows
{
    public delegate void ChangeListHandler(UcPlaylistList ucPlaylistList);
    public delegate void CreatePlayList();

    public partial class UcPlaylistList : UserControl
    {
        public bool check = false;

        public event EventHandler Reset; 

        public UcPlaylistList()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            this.Load += UcPlaylistList_Load;
            
        }

        private void UcPlaylistList_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Playlist> playlists = PlaylistDAO.Instance.LoadPlaylistFromDB();
            foreach (Playlist playlist in playlists)
            {
                UcPlayList_Name ucPlayList_Name = new UcPlayList_Name(playlist.Name,playlist.Imagedata);
                flowLayoutPanel1.Controls.Add(ucPlayList_Name);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            fDeletePlaylist fDeletePlaylist = new fDeletePlaylist();
            fDeletePlaylist.Show();
            fDeletePlaylist.Reset += FDeletePlaylist_Reset;
        }

        private void FDeletePlaylist_Reset(string s)
        {
            foreach (UcPlayList_Name ucPlayList_Name in flowLayoutPanel1.Controls)
            {
                if (ucPlayList_Name.Playlist1.Name == s)
                    flowLayoutPanel1.Controls.Remove(ucPlayList_Name);
            }    
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            fCreatePlaylist fCreatePlaylist = new fCreatePlaylist();
            fCreatePlaylist.Show();
            fCreatePlaylist.Reset += FCreatePlaylist_Reset;
        }

        private void FCreatePlaylist_Reset(object sender, EventArgs e)
        {
            Reset(sender, e);
        }


        //private void FCreatePlaylist_Reset(string s, byte[] vs)
        //{
        //    //UcPlayList_Name ucPlayList_Name = new UcPlayList_Name(s, vs);
        //    //ucPlayList_Name.LoadSongs += UcPlayList_Name_LoadSongs;
        //    //flowLayoutPanel1.Controls.Add(ucPlayList_Name);
        //    Reset(this);
        //}

        private void UcPlayList_Name_LoadSongs(string s)
        {
            
        }

        public FlowLayoutPanel FlowLayoutPanel()
        {
            return flowLayoutPanel1;
        }
    }
}
