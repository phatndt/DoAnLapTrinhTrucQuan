using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcTitleInfomationSong : UserControl
    {
        public UcTitleInfomationSong()
        {
            InitializeComponent();
        }
        public GunaLabel Guna()
        {
            return gunaLabel4;
        }
    }
}
