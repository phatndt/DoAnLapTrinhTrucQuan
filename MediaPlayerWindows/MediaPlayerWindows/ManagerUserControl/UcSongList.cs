using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayerWindows;
using WMPLib;
namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcSongList : UserControl
    {
        List<UcNameSong> ucNameSongs = new List<UcNameSong>();
        private int i = 0;
        public UcSongList()
        {
            InitializeComponent();
            
        }
        public void Add()
        {
            flowLayoutPanel.Controls.Add(new UcNameSong());
            i++;
        }
        public void Remove()
        {
            //flowLayoutPanel.Controls.Remove()
        }

        private void FlowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            //MessageBox.Show("b");
            //flowLayoutPanel.Controls.Add(new UcNameSong());
           
        }

        public FlowLayoutPanel GetFlowLayoutPanel()
        {
            return flowLayoutPanel;
        }
    }
}
