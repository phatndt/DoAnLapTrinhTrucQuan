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
            UcplayList_Name.ChangeList += UcplayList_Name_ChangeList;
        }
        private void UcplayList_Name_ChangeList()
        {
            if (ucSongList1.Visible == true)
            {
                ucSongList1.Visible = false;
            }    
            else
                ucSongList1.Visible = true;
        }
        public void AddPlayList_Name()
        {
            UcPlayList_Name U = new UcPlayList_Name();
            flowLayoutPanel.Controls.Add(U);
            U.Dock = UcplayList_Name.Dock;
        }
    }
}
