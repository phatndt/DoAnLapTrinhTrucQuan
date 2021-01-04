using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using MediaPlayerWindows;
using NAudio.Wave;
using System.Media;
using System.Diagnostics;
using static MediaPlayerWindows.ManagerUserControl.UcMusicControl;
using MediaPlayerWindows.DTO;
using static MediaPlayerWindows.ManagerUserControl.UcSongList;
using MediaPlayerWindows.DAO;

namespace MediaPlayerWindows.ManagerUserControl
{
    public delegate void DeletePlaylistSong(UcSong song);
    public partial class UcSong : UserControl
    {
        public event PlaySong PlaySong;

        public event DeletePlaylistSong Delete;

        private Song song;

        internal Song Song { get => song; set => song = value; }

        public UcSong()
        {
            InitializeComponent();
            btnSelect.Click += BtnSelect_Click;

        }
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            PlaySong(this);
        }
        public UcSong(string b, string c, byte[] d, byte[] e, string f)
        {
            InitializeComponent();
            if ( b is null && c is null)
            {
                b = "b";
                c = "c";
            }    
            //MessageBox.Show(b);
            song = new Song(b, c, d, e, f);
            this.gunaPictureBox1.Image = ConvertClass.Instance.ConvertByteToBitmap(d);
            this.lbName.Text = b;
            this.lbArtist.Text = c;
            this.lbTime.Text = f.ToString();
            btnSelect.Click += BtnSelect_Click;
        }
        public UcSong(string a, string b, string c, string d)
        {
            InitializeComponent();
            this.lbName.Text = a;
            this.lbArtist.Text = b;
            this.gunaPictureBox1.ImageLocation = c;
        }

        public UcSong(string b, string c, byte[] d, byte[] e, string f, string g)
        {
            InitializeComponent();
            song = new Song(b, c, d, e, f);
            this.gunaPictureBox1.Image = ConvertClass.Instance.ConvertByteToBitmap(d);
            this.lbName.Text = b;
            this.lbArtist.Text = c;
            this.lbTime.Text = f.ToString();
            btnSelect.Click += BtnSelect_Click;
            btnRemove.Visible = true;
            btnRemove.Click += BtnRemove_Click;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            PlaylistSongDAO.Instance.RemoveFavoriteSong(new PlaylistSong(song.Name, song.Artist, song.IMage, song.Source, song.Length,""));
            Delete(this);
        }

        public void Set(string a, string b, string c, Image d)
        {
            //this.path = a.ToString();
            this.lbName.Text = b.ToString();
            this.lbArtist.Text = c.ToString();
            //this.image = d;
            //this.Vs = f;
            //File.WriteAllBytes(this.path, Vs);
        }

    }
}
