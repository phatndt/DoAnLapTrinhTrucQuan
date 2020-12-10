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
namespace MediaPlayerWindows.ManagerUserControl
{

    public partial class UcPlayList_Name : UserControl
    {
        public event ChangeListHandler ChangeList;
        public UcPlayList_Name()
        {
            InitializeComponent();
            //PlayList_Name.Click += PlayList_Name_Click;
        }

        private void PlayList_Name_Click(object sender, EventArgs e)
        {
            ChangeList();
        }
    }
}
