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
        public string URL { get; set; }
        public Image Thumbnail { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public string PlaylistName { get; set; }
        public TimeSpan? Duration { get; set; }
        public EventHandler IMediaItem_Click { get; }
        public Action Play { get; }
        public UserControl UserControl { get; }
    }
}
