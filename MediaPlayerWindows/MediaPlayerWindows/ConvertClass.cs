using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWindows
{
    class ConvertClass
    {
        private static ConvertClass instance;

        internal static ConvertClass Instance
        {
            get { if (instance == null) instance = new ConvertClass(); return ConvertClass.instance; }
            private set { ConvertClass.instance = value; }
        }
        public byte[] ConvertImageToByte(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
            //using(MemoryStream mStream = new MemoryStream())
            //{
            //    image.Save(mStream, image.RawFormat);
            //    return mStream.ToArray();
            //}
            //FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //byte[] imgByteArr = new byte[fs.Length];
            //fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));
            //fs.Close();
            //return imgByteArr;

        }
        public byte[] ConvertDataMusicToByte(string s)
        {
            FileStream fs = new FileStream(s, FileMode.Open, FileAccess.Read);
            byte[] imgByteArr = new byte[fs.Length];
            fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return imgByteArr;
        }

    }
}
