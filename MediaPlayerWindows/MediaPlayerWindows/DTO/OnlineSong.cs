using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWindows.DTO
{
    class OnlineSong  : Song
    {
        private string downloadURL;
        private string imageOnline;
        public string ImageOnline { get => imageOnline; set => imageOnline = value; }
        public string DownloadURL { get => downloadURL; set => downloadURL = value; }
        public OnlineSong()
        {

        }
        public OnlineSong(string a, string b, string c, string d)
        {
            this.name = a;
            this.artist = b;
            this.imageOnline = c;
            this.downloadURL = d;
        }

     
    }
}
