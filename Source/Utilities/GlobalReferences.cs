using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using Siticone.Desktop.UI.WinForms;

namespace MyMediaPlayer
{
    public static class GlobalReferences
    {
        public static MainForm MainForm { get; set; }
        public static TrackLyrics TrackLyrics { get; set; }
        public static MediaController MediaController { get; set; }
        public static IIntegration OnlineStoreIntegration { get; set; }
        public static SiticoneContextMenuStrip PlaylistContextMenuStrip { get; set; }
        public static IMediaItem PlaylistContextMenuStripRecentMediaItem { get; set; }

        public static bool IsMySemaphore = false;
        public static readonly Semaphore RenamePlaylistSemaphore =
                           new Semaphore(initialCount: 0, maximumCount: 1);
    }
}
