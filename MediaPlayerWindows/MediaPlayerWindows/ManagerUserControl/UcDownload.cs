using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcDownload : UserControl
    {
        public UcDownload()
        {
            InitializeComponent();
            btnDownload.Click += BtnDownload_Click;
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            if (boxLink.Text.Length == 0)
                MessageBox.Show("  Please input link download!");
            else
            {
                try
                {
                    FolderBrowserDialog folder = new FolderBrowserDialog();
                    if (boxLink.Text.Contains("nhaccuatui"))
                    {
                        if (folder.ShowDialog() == DialogResult.OK)
                        {
                            HttpRequest http1 = new HttpRequest();
                            string htmlSong = http1.Get(@boxLink.Text).ToString();
                            var Audio = Regex.Matches(htmlSong, @"player.peConfig.xmlURL = ""(.*?)""", RegexOptions.Singleline);
                            string AudioURL = Audio[0].ToString().Replace("player.peConfig.xmlURL = \"", "").Replace("\"", "");
                            HttpRequest http2 = new HttpRequest();
                            string htmlAudio = http2.Get(AudioURL).ToString();
                            var title = Regex.Matches(htmlAudio, @"<title>(.*?)title>", RegexOptions.Singleline);
                            var CDATA = Regex.Matches(title[0].ToString(), @"CDATA(.*?)]", RegexOptions.Singleline);
                            string NameSong = CDATA[0].ToString().Replace("CDATA[", "").Replace("]", "");
                            string Filename = folder.SelectedPath + "\\" + NameSong + ".mp3";
                            if (!File.Exists(Filename))
                            {
                                var Download = Regex.Matches(htmlAudio, @"http(.*?)]", RegexOptions.Singleline);
                                string DownloadURL = Download[0].ToString().Replace("]", "");
                                WebClient wb = new WebClient();
                                wb.DownloadFile(DownloadURL, Filename);
                            }            
                            MessageBox.Show("The file's in folder");
                        }
                    }
                    else
                    {
                        MessageBox.Show("  Please input link download Nhaccuatui!");
                    }
                }
                catch
                {
                    MessageBox.Show("Không có kết nối internet");
                }


            }
        }
    }
}
