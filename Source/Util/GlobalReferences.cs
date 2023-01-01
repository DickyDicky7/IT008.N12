using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    internal class GlobalReferences
    {
        public static MainForm MainForm { get; set; }
        public static MediaLyrics MediaLyrics { get; set; }
        public static MediaController MediaController { get; set; }
        public static IIntegration OnlineStoreIntegration { get; set; }
    }
}
