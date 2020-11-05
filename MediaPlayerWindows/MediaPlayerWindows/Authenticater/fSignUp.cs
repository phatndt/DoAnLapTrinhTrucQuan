using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerWindows
{
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
            btnSignUp.Click += BtnSignUp_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (tBName == null || tBPass == null || tBPass2 == null )
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (tBPass.Text != tBPass2.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            User U = new User() { Name = tBName.Text, Pass = tBPass.Text };
        }
    }
}
