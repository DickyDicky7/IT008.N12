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
        public abstract Action PlayNext { get; }
        public abstract Action PlayBack { get; }
        public abstract bool IsShuffle { get; set; }
        public abstract Action GenerateShuffleList { get; }
    }
}
