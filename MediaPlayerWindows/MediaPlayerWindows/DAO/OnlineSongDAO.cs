using MediaPlayerWindows.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MediaPlayerWindows.DAO
{
    class OnlineSongDAO
    {
        private static OnlineSongDAO instance;

        internal static OnlineSongDAO Instance
        {
            get { if (instance == null) instance = new OnlineSongDAO(); return OnlineSongDAO.instance; }
            private set { OnlineSongDAO.instance = value; }
        }

        public List<OnlineSong> LoadOnlineSongVN()
        {
            try
            {
                List<OnlineSong> SongList = new List<OnlineSong>();
                HttpRequest http = new HttpRequest();
                string htmlBXH = http.Get(@"https://www.nhaccuatui.com/bai-hat/top-20.nhac-viet.html").ToString();
                string bxhPattern = @"<ul class=""list_show_chart"">(.*?)</ul>";
                var listBXH = Regex.Matches(htmlBXH, bxhPattern, RegexOptions.Singleline);
                string bxhVN = listBXH[0].ToString();
                var listSongHTML = Regex.Matches(bxhVN, @"<li>(.*?)</li>", RegexOptions.Singleline);
                for (int i = 0; i < 10; i++)
                {
                    var songandsinger = Regex.Matches(listSongHTML[i].ToString(), @"<a\s\S*\stitle=""(.*?)""", RegexOptions.Singleline);
                    string songString = songandsinger[0].ToString();
                    int indexSong = songString.IndexOf("title=\"");
                    string songName = songString.Substring(indexSong, songString.Length - indexSong - 1).Replace("title=\"", "");

                    string[] arrListStr = songName.Split('-');
                    string Name = arrListStr[0];
                    string Artist = arrListStr[1];
                    int indexURL = songString.IndexOf("href=");
                    string URL = songString.Substring(indexURL, indexSong - indexURL - 2).Replace("href=\"", "");

                    var imageurl = Regex.Matches(listSongHTML[i].ToString(), @"<img src=""(.*?)""", RegexOptions.Singleline);
                    string ImageURL = imageurl[0].ToString();
                    ImageURL = ImageURL.Replace("<img src=\"", "").Replace("\"", "");

                    HttpRequest http1 = new HttpRequest();
                    string htmlSong = http1.Get(@URL).ToString();
                    var Audio = Regex.Matches(htmlSong, @"player.peConfig.xmlURL = ""(.*?)""", RegexOptions.Singleline);
                    string AudioURL = Audio[0].ToString().Replace("player.peConfig.xmlURL = \"", "").Replace("\"", "");

                    HttpRequest http2 = new HttpRequest();
                    string htmlAudio = http2.Get(AudioURL).ToString();
                    var Location = Regex.Matches(htmlAudio, @"<location>(.*?)</location>", RegexOptions.Singleline);
                    string LocationAudio = Location[0].ToString();
                    var Download = Regex.Matches(htmlAudio, @"http(.*?)]", RegexOptions.Singleline);
                    string DownloadURL = Download[0].ToString().Replace("]", "");
                    OnlineSong onlineSong = new OnlineSong(Name, Artist, ImageURL, DownloadURL);
                    SongList.Add(onlineSong);
                }

                return SongList;
            }
            catch
            {
                return null;
            }
            
        }

        public List<OnlineSong> LoadOnlineSongEA()
        {
            try
            {
                List<OnlineSong> SongList = new List<OnlineSong>();
                HttpRequest http = new HttpRequest();
                string htmlBXH = http.Get(@"https://www.nhaccuatui.com/bai-hat/top-20.au-my.html").ToString();
                string bxhPattern = @"<ul class=""list_show_chart"">(.*?)</ul>";
                var listBXH = Regex.Matches(htmlBXH, bxhPattern, RegexOptions.Singleline);
                string bxhVN = listBXH[0].ToString();
                var listSongHTML = Regex.Matches(bxhVN, @"<li>(.*?)</li>", RegexOptions.Singleline);
                for (int i = 0; i < 10; i++)
                {
                    var songandsinger = Regex.Matches(listSongHTML[i].ToString(), @"<a\s\S*\stitle=""(.*?)""", RegexOptions.Singleline);
                    string songString = songandsinger[0].ToString();
                    int indexSong = songString.IndexOf("title=\"");
                    string songName = songString.Substring(indexSong, songString.Length - indexSong - 1).Replace("title=\"", "");

                    string[] arrListStr = songName.Split('-');
                    string Name = arrListStr[0];
                    string Artist = arrListStr[1];
                    int indexURL = songString.IndexOf("href=");
                    string URL = songString.Substring(indexURL, indexSong - indexURL - 2).Replace("href=\"", "");

                    var imageurl = Regex.Matches(listSongHTML[i].ToString(), @"<img src=""(.*?)""", RegexOptions.Singleline);
                    string ImageURL = imageurl[0].ToString();
                    ImageURL = ImageURL.Replace("<img src=\"", "").Replace("\"", "");

                    HttpRequest http1 = new HttpRequest();
                    string htmlSong = http1.Get(@URL).ToString();
                    var Audio = Regex.Matches(htmlSong, @"player.peConfig.xmlURL = ""(.*?)""", RegexOptions.Singleline);
                    string AudioURL = Audio[0].ToString().Replace("player.peConfig.xmlURL = \"", "").Replace("\"", "");

                    HttpRequest http2 = new HttpRequest();
                    string htmlAudio = http2.Get(AudioURL).ToString();
                    var Location = Regex.Matches(htmlAudio, @"<location>(.*?)</location>", RegexOptions.Singleline);
                    string LocationAudio = Location[0].ToString();
                    var Download = Regex.Matches(htmlAudio, @"http(.*?)]", RegexOptions.Singleline);
                    string DownloadURL = Download[0].ToString().Replace("]", "");
                    OnlineSong onlineSong = new OnlineSong(Name, Artist, ImageURL, DownloadURL);
                    SongList.Add(onlineSong);
                }

                return SongList;
            }
            catch
            {
                return null;
            }
            
        }

        public List<OnlineSong> LoadOnlineSongKO()
        {
            try
            {
                List<OnlineSong> SongList = new List<OnlineSong>();
                HttpRequest http = new HttpRequest();
                string htmlBXH = http.Get(@"https://www.nhaccuatui.com/bai-hat/top-20.nhac-han.html").ToString();
                string bxhPattern = @"<ul class=""list_show_chart"">(.*?)</ul>";
                var listBXH = Regex.Matches(htmlBXH, bxhPattern, RegexOptions.Singleline);
                string bxhVN = listBXH[0].ToString();
                var listSongHTML = Regex.Matches(bxhVN, @"<li>(.*?)</li>", RegexOptions.Singleline);
                for (int i = 0; i < 10; i++)
                {
                    var songandsinger = Regex.Matches(listSongHTML[i].ToString(), @"<a\s\S*\stitle=""(.*?)""", RegexOptions.Singleline);
                    string songString = songandsinger[0].ToString();
                    int indexSong = songString.IndexOf("title=\"");
                    string songName = songString.Substring(indexSong, songString.Length - indexSong - 1).Replace("title=\"", "");

                    string[] arrListStr = songName.Split('-');
                    string Name = arrListStr[0];
                    string Artist = arrListStr[1];
                    int indexURL = songString.IndexOf("href=");
                    string URL = songString.Substring(indexURL, indexSong - indexURL - 2).Replace("href=\"", "");

                    var imageurl = Regex.Matches(listSongHTML[i].ToString(), @"<img src=""(.*?)""", RegexOptions.Singleline);
                    string ImageURL = imageurl[0].ToString();
                    ImageURL = ImageURL.Replace("<img src=\"", "").Replace("\"", "");

                    HttpRequest http1 = new HttpRequest();
                    string htmlSong = http1.Get(@URL).ToString();
                    var Audio = Regex.Matches(htmlSong, @"player.peConfig.xmlURL = ""(.*?)""", RegexOptions.Singleline);
                    string AudioURL = Audio[0].ToString().Replace("player.peConfig.xmlURL = \"", "").Replace("\"", "");

                    HttpRequest http2 = new HttpRequest();
                    string htmlAudio = http2.Get(AudioURL).ToString();
                    var Location = Regex.Matches(htmlAudio, @"<location>(.*?)</location>", RegexOptions.Singleline);
                    string LocationAudio = Location[0].ToString();
                    var Download = Regex.Matches(htmlAudio, @"http(.*?)]", RegexOptions.Singleline);
                    string DownloadURL = Download[0].ToString().Replace("]", "");
                    OnlineSong onlineSong = new OnlineSong(Name, Artist, ImageURL, DownloadURL);
                    SongList.Add(onlineSong);
                }

                return SongList;
            }
            catch
            {
                return null;
            }
            
        }
    }
}
