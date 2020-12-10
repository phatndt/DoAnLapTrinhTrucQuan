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
namespace MediaPlayerWindows
{
    public delegate void ChangeListHandler();
    public delegate void CreatePlayList();

    public partial class UcPlaylist : UserControl
    {
        public bool check = false;
        public UcPlaylist()
        {
            InitializeComponent();
        }
    }
}
