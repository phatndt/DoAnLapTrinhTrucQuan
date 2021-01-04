using MediaPlayerWindows.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerWindows
{
    public partial class fCreatePlaylist : Form
    {
        public delegate void Change(string s, byte[] vs);

        //public event Change Reset;
        public event EventHandler Reset;
        byte[] byts = null ;
        public fCreatePlaylist()
        {
            InitializeComponent();
            btnOpen.Click += BtnOpen_Click;
            btnAdd.Click += BtnAdd_Click;
            btnCancle.Click += BtnCancle_Click;
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên playlist", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string queryCheckExist = "SELECT * FROM PLAYLIST WHERE (PLAYLISTNAME = '" + gunaTextBox1.Text + "')";
                if (DataProvider.Instance.ExecuteNonQuery(queryCheckExist))
                {
                    MessageBox.Show("Tên playlist đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (gunaTextBox2.Text == "")
                    {
                        byts = ConvertClass.Instance.ConvertImageToByte(global::MediaPlayerWindows.Properties.Resources.BackgroundLogin);
                    }
                    PlaylistDAO.Instance.AddPlaylistToDB(gunaTextBox1.Text, byts);
                    //Reset(gunaTextBox1.Text, byts);
                    Reset(sender,e);
                    this.Close();
                }    
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            dlg.FilterIndex = 1;
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                byts = File.ReadAllBytes(dlg.FileName);
                gunaTextBox2.Text = dlg.FileName;
            }    
        }
    }
}
