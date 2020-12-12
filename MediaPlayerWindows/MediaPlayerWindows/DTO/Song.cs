using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWindows.DTO
{
    class Song
    {
        private string path;
        private string name;
        private string artist;
        private byte[] image;
        private double length;
        private byte[] source;
        private int status;
        public string Path { get => path; set => path = value; }
        public string Name { get => name; set => name = value; }
        public string Artist { get => artist; set => artist = value; }
        public byte[] IMage { get => image; set => image = value; }
        public double Length { get => length; set => length = value; }
        public byte[] Source { get => source; set => source = value; }
        public int Status { get => status; set => status = value; }

        public Song()
        {

        }
        public Song(string a, string b, string c, byte[] d, byte[] e, double f, int status)
        {
            this.path = a;
            this.name = b;
            this.artist = c;
            this.image = d;
            this.source = e;
            this.length = f;
            this.status = status;
        }
        public Song(DataRow Row)
        {
            this.Path = Row["PATHSONG"].ToString();
            this.name = Row["NAMESONG"].ToString();
            this.artist = Row["ARTISTSONG"].ToString();
            this.image = Convert.FromBase64String(Row["IMAGESONG"].ToString());
            this.source = Convert.FromBase64String(Row["DATASONG"].ToString());
            this.length = (double)Row["LENGTHSONG"];
            this.status = (int)Row["STATUSSONG"];
        }
    }
}
