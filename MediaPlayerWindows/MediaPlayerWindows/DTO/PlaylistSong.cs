using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWindows.DTO
{
    class PlaylistSong : Song
    {
        private string playlistname;

        public string Playlistname { get => playlistname; set => playlistname = value; }

        public PlaylistSong()
        {

        }
        public PlaylistSong(string b, string c, byte[] d, byte[] e, string f, string g)
        {
            this.name = b;
            this.artist = c;
            this.image = d;
            this.source = e;
            this.length = f;
            this.playlistname = g;
        }

        public PlaylistSong(DataRow Row)
        {
            this.name = Row["NAMESONG"].ToString();
            this.artist = Row["ARTISTSONG"].ToString();
            this.image = Convert.FromBase64String(Row["IMAGESONG"].ToString());
            this.source = Convert.FromBase64String(Row["DATASONG"].ToString());
            this.length = Row["LENGTHSONG"].ToString();
            this.playlistname = Row["PLAYLISTNAME"].ToString();
        }
    }
}
