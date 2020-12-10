using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using WMPLib;
using System.Windows.Controls;
using NAudio.Wave;
namespace MediaPlayerWindows
{
    public partial class MediaPlayer 
    {
        private IWMPControls3 wpmPlayer;
        private string path;
        private string name;
        private string artist;
        private Image image;
        private double length;
        public string Path { get => path; set => path = value; }
        public string Name { get => name; set => name = value; }
        public string Artist { get => artist; set => artist = value; }
        public Image Image { get => image; set => image = value; }
        public double Length { get => length; set => length = value; }
        public IWMPControls3 WpmPlayer { get => wpmPlayer; set => wpmPlayer = value; }
    }
}
