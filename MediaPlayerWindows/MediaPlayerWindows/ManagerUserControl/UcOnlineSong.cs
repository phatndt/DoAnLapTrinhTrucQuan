using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MediaPlayerWindows.ManagerUserControl.UcMusicControl;
using MediaPlayerWindows.DTO;
using static MediaPlayerWindows.ManagerUserControl.UcSongList;

namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcOnlineSong : UserControl
    {
        public event PlayOnlineSong PlayOnlineSong;

        private string downloadURL;
        private string nameSong;

        private OnlineSong onlinesong;

        internal OnlineSong onlineSong { get => onlinesong; set => onlinesong = value; }
        public string DownloadURL { get => downloadURL; set => downloadURL = value; }
        public string NameSong { get => nameSong; set => nameSong = value; }

        public UcOnlineSong()
        {
            InitializeComponent();
        }
        public UcOnlineSong(string a, string b, string c, string d)
        {
            InitializeComponent();
            this.lbName.Text = a;
            this.nameSong = a;
            this.lbArtist.Text = b;
            this.gunaPictureBox1.ImageLocation = c;
            this.downloadURL = d;
            this.btnSelect.Click += BtnSelect_Click;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            PlayOnlineSong(this);
        }
    }
}
