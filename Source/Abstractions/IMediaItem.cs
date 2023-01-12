using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public interface IMediaItem
    {
        public abstract Action Play { get; }
        public abstract string URL { get; set; }
        public abstract string Title { get; set; }
        public abstract string Album { get; set; }
        public abstract string Genre { get; set; }
        public abstract string Artist { get; set; }
        public abstract Image Thumbnail { get; set; }
        public abstract TimeSpan? Duration { get; set; }
        public abstract UserControl UserControl { get; }
        public abstract string PlaylistName { get; set; }
        public abstract EventHandler IMediaItem_Click { get; }
    }
}
