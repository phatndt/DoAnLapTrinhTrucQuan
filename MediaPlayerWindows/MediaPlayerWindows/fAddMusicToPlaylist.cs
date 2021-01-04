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
    public partial class fAddMusicToPlaylist : Form
    {
        string a;
        string b;
        byte[] c;
        byte[] d;
        string e;
        public fAddMusicToPlaylist(string a, string b, byte[] c, byte[] d, string e)
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
            this.Load += FAddMusicToPlaylist_Load;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        private void FAddMusicToPlaylist_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();  
            List<Playlist> playlists = PlaylistDAO.Instance.LoadPlaylistFromDB();
            foreach (Playlist playlist in playlists)
            {
                UcDelelePlayList ucDelelePlayList = new UcDelelePlayList(playlist.Name, "A");
                ucDelelePlayList.Add += UcDelelePlayList_Add;
                flowLayoutPanel1.Controls.Add(ucDelelePlayList);
            }

        }

        private void UcDelelePlayList_Add(UcDelelePlayList ucDelelePlayList)
        {
            PlaylistSong playlistSong = new PlaylistSong(a,b,c,d,e,ucDelelePlayList.Playlist1.Name);
            PlaylistSongDAO.Instance.AddPlaylistSongToDB(playlistSong);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
