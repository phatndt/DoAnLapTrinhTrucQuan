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
        protected string name;
        protected string artist;
        protected byte[] image;
        protected string length;
        protected byte[] source;

        public string Name { get => name; set => name = value; }
        public string Artist { get => artist; set => artist = value; }
        public byte[] IMage { get => image; set => image = value; }
        public string Length { get => length; set => length = value; }
        public byte[] Source { get => source; set => source = value; }

        public Song()
        {

        }
        
        public Song(string b, string c, byte[] d, byte[] e, string f)
        {
            this.name = b;
            this.artist = c;
            this.image = d;
            this.source = e;
            this.length = f;
        }
        public Song(DataRow Row)
        {
            this.name = Row["NAMESONG"].ToString();
            this.artist = Row["ARTISTSONG"].ToString();
            this.image = Convert.FromBase64String(Row["IMAGESONG"].ToString());
            this.source = Convert.FromBase64String(Row["DATASONG"].ToString());
            this.length = Row["LENGTHSONG"].ToString();
        }
    }
}
