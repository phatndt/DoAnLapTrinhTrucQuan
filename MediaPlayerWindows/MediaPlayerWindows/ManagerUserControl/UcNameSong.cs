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
namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcNameSong : UserControl
    {
        private string path;
        public UcNameSong()
        {
            InitializeComponent();
            this.Click += UcNameSong_Click;
        }

        private void UcNameSong_Click(object sender, EventArgs e)
        {
            //SaveFileDialog fileDialog = new SaveFileDialog();
            //fileDialog.FileName = this.path;
            WindowsMediaPlayer W = new WindowsMediaPlayer();
            W.URL = this.path;
        }

        public UcNameSong(string a, string b, string c, Image d, double e)
        {
            InitializeComponent();
            this.path = a.ToString();
            this.lbName.Text = b.ToString();
            this.lbArtist.Text = c.ToString();
            this.pictureBox1.Image= d;
            this.lbTime.Text = e.ToString();
        }
        

    }
}
