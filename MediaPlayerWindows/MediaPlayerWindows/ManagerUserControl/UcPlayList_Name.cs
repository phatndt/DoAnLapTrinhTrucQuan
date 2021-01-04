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
using MediaPlayerWindows.DTO;

namespace MediaPlayerWindows.ManagerUserControl
{
    public delegate void LoadSong(string s);
    public partial class UcPlayList_Name : UserControl
    {
        public event LoadSong LoadSongs;

        public event LoadSong LoadEventSongs;

        private Playlist Playlist;

        internal Playlist Playlist1 { get => Playlist; set => Playlist = value; }

        public UcPlayList_Name()
        {
            InitializeComponent();
        }
        public UcPlayList_Name(string s, byte[] vs)
        {
            InitializeComponent();
            Playlist1 = new Playlist(s); 
            gunaLabel1.Text = s;
            gunaCirclePictureBox1.Image = ConvertClass.Instance.ConvertByteToBitmap(vs);
            gunaCirclePictureBox1.Click += GunaCirclePictureBox1_Click;
            gunaCirclePictureBox1.Click += GunaCirclePictureBox1_Click;
        }

        private void GunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            LoadSongs(Playlist1.Name);
        }
    }
}
