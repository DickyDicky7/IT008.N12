using System;
using System.IO;
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
        public static TrackLyrics TrackLyrics { get; set; }
        public static MediaController MediaController { get; set; }
        public static IIntegration OnlineStoreIntegration { get; set; }

        public static readonly FileSystemWatcher PlaylistsFolderWatcher =
                           new FileSystemWatcher(Common.PlaylistsFolder);
    }
}
