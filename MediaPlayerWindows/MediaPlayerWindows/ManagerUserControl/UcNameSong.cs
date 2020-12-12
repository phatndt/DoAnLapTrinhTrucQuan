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

namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcNameSong : UserControl
    {
        public event PlaySong PlayUcSong;

        private string path;
        private byte[] Vs;
        private Image image;

        public UcNameSong()
        {
            InitializeComponent();
            this.Click += UcNameSong_Click;
            btnSelect.Click += BtnSelect_Click;
            
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            PlayUcSong(this.path);
        }

        private void UcNameSong_Click(object sender, EventArgs e)
        {
            /*
            if (this.Vs == null)
                this.Vs = File.ReadAllBytes(this.path); // Ghi data vào Vs
            // tạo 1 file mới bao gồm tên vào đường dẫn
            string name = Path.ChangeExtension(Path.GetRandomFileName(), ".wav"); // tạo random 1 cái tên đẻ l luuw
            string path = Path.Combine(Path.GetTempPath(), name); // tạo 1 cái đường dẫn
            File.WriteAllBytes(path, this.Vs); // ghi cái data từ Vs vào cái đường dẫn
            WindowsMediaPlayer W = new WindowsMediaPlayer();
            W.URL = path; // phát nhạc thôi nào
            */
            //FileDialog fileDialog = null;
            //fileDialog.FileName = this.path;
            MessageBox.Show("a");
            

        }
        public UcNameSong(string a, string b, string c, Image d, double e, byte[] f)
        {
            InitializeComponent();
            this.path = a.ToString();
            this.lbName.Text = b.ToString();
            this.lbArtist.Text = c.ToString();
            this.pictureBox1.Image= d;
            this.lbTime.Text = e.ToString();
            //this.Vs = f;
            //File.WriteAllBytes(this.path, Vs);
        }
        public void Set(string a, string b, string c, Image d)
        {
            this.path = a.ToString();
            this.lbName.Text = b.ToString();
            this.lbArtist.Text = c.ToString();
            this.image = d;
            //this.Vs = f;
            //File.WriteAllBytes(this.path, Vs);
        }

    }
}
