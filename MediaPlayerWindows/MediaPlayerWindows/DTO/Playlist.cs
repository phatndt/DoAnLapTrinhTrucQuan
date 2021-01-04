using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWindows.DTO
{
    class Playlist
    {
        private string name;
        private byte[] imagedata;
        public string Name { get => name; set => name = value; }
        public byte[] Imagedata { get => imagedata; set => imagedata = value; }

        public Playlist(DataRow Row)
        {
            this.name = Row["PLAYLISTNAME"].ToString();
            this.imagedata = Convert.FromBase64String(Row["PLAYLISTIMAGE"].ToString());
        }
        public Playlist(string s)
        {
            this.name = s;
        }
    }
}
