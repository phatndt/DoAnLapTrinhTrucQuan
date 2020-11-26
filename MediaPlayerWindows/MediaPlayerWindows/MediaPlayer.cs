using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using WMPLib;
using System.Windows.Controls;

namespace MediaPlayerWindows
{
    public partial class MediaPlayer
    {
        public IWMPPlayer4 M;
        public string Path { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public Image Image { get; set; }

    }
}
