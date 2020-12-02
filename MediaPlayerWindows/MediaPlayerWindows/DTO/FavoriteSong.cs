using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWindows.DTO
{
    class FavoriteSong
    {
        private string path;
        private string name;
        private string artist;
        private Image image;
        private double length;
        public string Path { get => path; set => path = value; }
        public string Name { get => name; set => name = value; }
        public string Artist { get => artist; set => artist = value; }
        public Image IMage { get => image; set => image = value; }
        public double Length { get => length; set => length = value; }

        public FavoriteSong(string a, string b, string c, Image d, double e)
        {
            this.path = a;
            this.name = b;
            this.artist = c;
            this.image = d;
            this.length = e;
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public FavoriteSong(DataRow Row)
        {
            this.Path = Row["PATHSONG"].ToString();
            this.name = Row["NAMESONG"].ToString();
            this.artist = Row["ARTISTSONG"].ToString();
            //byte[] bytes = (byte[])(Row["IMAGESONG"]);
            //MemoryStream ms = new MemoryStream(bytes);
            //Image returnImage = Image.FromStream(ms);
            //var v = new Bitmap(ms, false);
            //this.IMage = v;
            //this.image = (Image)Row["IMAGESONG"];
            //var mStream = new MemoryStream();
            //byte[] pData = (byte[])(Row["IMAGESONG"]);
            //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //var bm = new Bitmap(mStream, false);
            //mStream.Dispose();
            //byte[] pData = ;
            //pDat
            //byte[] imageBytes = (byte[])(Row["IMAGESONG"]);
            //MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            //ms.Write(imageBytes, 0, imageBytes.Length);
            //System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            //this.IMage = image;
            this.length = (double)Row["LENGTHSONG"];
        }
        public System.Drawing.Image Base64ToImage(string base64String)
        {
            
            return image;
        }
    }
}
