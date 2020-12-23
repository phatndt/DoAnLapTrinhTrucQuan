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
     class FavoriteSong : Song
     {
        public FavoriteSong()
        {

        }
        public FavoriteSong(string b, string c, byte[] d, byte[] e, string f, int status)
        {
            this.name = b;
            this.artist = c;
            this.image = d;
            this.source = e;
            this.length = f;
            this.status = status;
        }
        private int status;
        public int Status { get => status; set => status = value; }

        public FavoriteSong(DataRow Row)
        {
            this.name = Row["NAMESONG"].ToString();
            this.artist = Row["ARTISTSONG"].ToString();
            this.image = Convert.FromBase64String(Row["IMAGESONG"].ToString());
            this.source = Convert.FromBase64String(Row["DATASONG"].ToString());
            this.length = Row["LENGTHSONG"].ToString();
            this.status = (int)Row["STATUSSONG"];
        }

     }
}
