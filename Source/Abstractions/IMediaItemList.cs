using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public interface IMediaItemList
    {
        public abstract Action Stop { get; }
        public abstract Action Clear { get; }
        public abstract Action PlayNext { get; }
        public abstract Action PlayBack { get; }
        public abstract Action GenerateShuffleList { get; }
        public abstract void UpdateCurrentIndex(IMediaItem MediaItem);
    }
}
