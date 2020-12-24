using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcOnlineSong : UserControl
    {
        public UcOnlineSong()
        {
            InitializeComponent();
        }
        public UcOnlineSong(string a, string b, string c, string d)
        {
            InitializeComponent();
            this.lbName.Text = a;
            this.lbArtist.Text = b;
            this.gunaPictureBox1.ImageLocation = c;
        }
    }
}
