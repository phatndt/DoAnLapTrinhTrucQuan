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
    public partial class fLogin : Form
    {
        public event EventHandler CheckSignUp;
        public fLogin()
        {
            InitializeComponent();
            CheckSignUp += FLogin_CheckSignUp;
        }

        private void FLogin_CheckSignUp(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fMusicManager f = new fMusicManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
            
        }
        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            fSignUp SignUp = new fSignUp();
            SignUp.ShowDialog();

        }


        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }


    }
}
