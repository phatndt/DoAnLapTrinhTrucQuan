using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
namespace MediaPlayerWindows.ManagerUserControl
{
    public partial class UcNameSong : UserControl
    {
        MediaPlayer M = new MediaPlayer();
        WindowsMediaPlayer W = new WindowsMediaPlayer();
        string Path = "";
        public UcNameSong()
        {
            InitializeComponent();
            if (Path != "")
                Set();
        }
        public UcNameSong(string FilePath)
        {
            Path = FilePath;
            MessageBox.Show(Path);
        }
        public void Set()
        {
            TagLib.File tagFile = TagLib.File.Create(Path);
            //var fileTag = TagLib.File.Create(W.URL);
            MessageBox.Show(tagFile.Tag.Title);
            //lbName.Text = tagFile.Tag.Title;
            //lbArtist.Text = tagFile.Tag.FirstPerformer;
            //var mStream = new MemoryStream();
            //var firstPicture = tagFile.Tag.Pictures.FirstOrDefault();
            //if (firstPicture != null)
            //{
            //    byte[] pData = firstPicture.Data.Data;
            //    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //    var bm = new Bitmap(mStream, false);
            //    mStream.Dispose();
            //    //pictureSong.Image = bm;
            //}
            //else
            //{
            //    //pictureSong.Image = global::MediaPlayerWindows.Properties.Resources.pictureBoxNotFound;
            //}
        }

    }
}
