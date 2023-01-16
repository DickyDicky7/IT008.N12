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
        public abstract UserControl UserControl { get; }
        public abstract EventHandler IMediaItem_Click { get; }
    }
}
