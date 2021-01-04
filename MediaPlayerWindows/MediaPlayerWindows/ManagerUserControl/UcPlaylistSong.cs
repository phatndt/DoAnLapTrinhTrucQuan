using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using MediaPlayerWindows.DTO;
using MediaPlayerWindows.DAO;

namespace MediaPlayerWindows.ManagerUserControl
{
    public delegate void PlayPlaylistSong(UcSong ucSong);

    public delegate void LoadPlaylistSong(string s);
    public partial class UcPlaylistSong : UserControl
    {
        public event PlayPlaylistSong Play;
        public event LoadPlaylistSong LoadList;
             
        public UcPlaylistList ucPlaylistList = new UcPlaylistList();

        List<PlaylistSong> playlistSongs;
        public UcPlaylistSong()
        {
            InitializeComponent();
            this.Load += UcPlaylistSong_Load;
            ucPlaylistList.Reset += UcPlaylistList_Reset; 
        }

        private void UcPlaylistList_Reset(object sender, EventArgs e)
        {
            ucPlaylistList = new UcPlaylistList();
            ucPlaylistList.Reset += UcPlaylistList_Reset;
            UcPlaylistSong_Load(sender, e);
        }

        private void UcPlaylistList_Reset1(object sender, EventArgs e)
        {
            
        }

        internal List<PlaylistSong> PlaylistSongs { get => playlistSongs; set => playlistSongs = value; }

        private void UcPlaylistSong_Load(object sender, EventArgs e)
        {
            ucPlaylistList.Dock = DockStyle.Bottom;
            ucPlaylistList.BringToFront();
            ucPlaylistList.Show();
            this.Controls.Add(ucPlaylistList);
            foreach (UcPlayList_Name ucPlayList_Name in ucPlaylistList.FlowLayoutPanel().Controls)
            {
                ucPlayList_Name.LoadSongs += UcPlayList_Name_LoadSongs;
            }   
        }

        private void UcPlayList_Name_LoadSongs(string s)
        {
            ucSongList2.FlowLayoutPanel().Controls.Clear();
            PlaylistSongs = PlaylistSongDAO.Instance.LoadPlaylistSongFromDB(s);
            foreach (PlaylistSong playlistSong in PlaylistSongs)
            {
                UcSong ucSong = new UcSong(playlistSong.Name, playlistSong.Artist, playlistSong.IMage, playlistSong.Source, playlistSong.Length,"");
                ucSong.Delete += UcSong_Delete;
                ucSong.PlaySong += UcSong_PlaySong;
                ucSongList2.FlowLayoutPanel().Controls.Add(ucSong);
            }
            LoadList(s);
        }

        private void UcSong_PlaySong(UcSong ucSong)
        {
            Play(ucSong);
        }

        private void UcSong_Delete(UcSong song)
        {
            ucSongList2.FlowLayoutPanel().Controls.Remove(song);
        }
        public UcSongList UcSongList()
        {
            return ucSongList2;
        }
        public FlowLayoutPanel FlowLayoutPanel()
        {
            return ucSongList2.FlowLayoutPanel();
        }
    }
}
