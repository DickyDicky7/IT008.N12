using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public class AMediaItemList<IMediaItemType> where IMediaItemType : IMediaItem
    {
        public List<IMediaItemType> MediaItems = new List<IMediaItemType>();

        public int GetMediaItemIndex(IMediaItemType MediaItem)
        {
            return MediaItems.IndexOf(MediaItem);
        }

        public void Clear()
        {
            MediaItems.Clear();
        }

        public int CurrentIndex = -1;
        public bool IsShuffle = false;
        public List<int> ShuffleList = new List<int>();
        public delegate int GetMediaItemIndexHandler(IMediaItemType MediaItem);

        public void GenerateShuffleList()
        {
            Random Random = new Random();
            ShuffleList = Enumerable.Range
            (0, MediaItems.Count).OrderBy(x => Random.Next()).ToList();
        }

        protected void Signal(int Index)
        {
            MediaItems[Index].Play();
        }

        public void Stop()
        {
            CurrentIndex = -1;
        }

        public void PlayNext()
        {
            CurrentIndex++;
            if (CurrentIndex < MediaItems.Count)
            {
                if (IsShuffle)
                {
                    Signal(ShuffleList[CurrentIndex]);
                }
                else
                {
                    Signal(CurrentIndex);
                }
            }
            else
            {
                CurrentIndex = MediaItems.Count - 1;
            }
        }

        public void PlayBack()
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex--;
                if (IsShuffle)
                {
                    Signal(ShuffleList[CurrentIndex]);
                }
                else
                {
                    Signal(CurrentIndex);
                }
            }
        }
    }
}
