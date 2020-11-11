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
    public partial class UcSystemButton : UserControl
    {
        public UcSystemButton()
        {
            InitializeComponent();
            btnMaximize.Click += BtnMaximize_Click;
            btnMinimize.Click += BtnMinimize_Click; ;
            btnExit.Click += BtnExit_Click;
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.FindForm().WindowState == FormWindowState.Maximized)
                this.FindForm().WindowState = FormWindowState.Normal;
            else
                this.FindForm().WindowState = FormWindowState.Maximized;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
