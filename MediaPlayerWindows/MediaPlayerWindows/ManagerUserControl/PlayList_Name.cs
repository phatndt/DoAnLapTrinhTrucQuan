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
    public partial class PlayList_Name : UserControl
    {
        public string name;
        public PlayList_Name()
        {
            InitializeComponent();
        }
        public void SetName()
        {
            PlayList_Name1.Text = name;
        }
    }
}
