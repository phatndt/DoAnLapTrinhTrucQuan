using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWindows.DTO
{
    class FavoriteSong
    {
        public FavoriteSong()
        {

        }
        public FavoriteSong(string a)
        {
            this.Path = a;
        }    
        public FavoriteSong(string a, string b, string c, Image d, double e)
        {
            this.path = a;
            this.name = b;
            this.artist = c;
            this.image = d;
            this.length = e;
        }

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
        public byte[] Source { get => source; set => source = value; }

        private byte[] source;

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
            this.source = Convert.FromBase64String(Row["IMAGESONG"].ToString());
            //this.source = Encoding.ASCII.GetBytes(Row["IMAGESONG"]);
            this.length = (double)Row["LENGTHSONG"];
        }

    }
}
