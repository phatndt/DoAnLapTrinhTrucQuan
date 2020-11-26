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
    public partial class UcFavoriteSong : UserControl
    {
        List<UcNameSong> listControls = new List<UcNameSong>();
        private int STT = 0;
        public UcFavoriteSong()
        {
            InitializeComponent();
        }
        public void Add()
        {
            UcNameSong U = new UcNameSong();
            flowLayoutPanel.Controls.Add(U);
            listControls.Add(U);
            STT++;
        }
        public void Remove()
        {
            //flowLayoutPanel.Controls.RemoveByKey(listControls[STT]);
        }
    }
}
