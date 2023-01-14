using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public class AMediaItemList<IMediaItemType> where IMediaItemType : IMediaItem
    {
        public List<IMediaItemType> MediaItems = new List<IMediaItemType>();

        public Action<string> AddFolderWith
        (Action<IMediaItemType> AddMediaItem, List<string> FileExtensions)
        {
            return (FolderPath) =>
            {
                FileExtensions.ForEach(FileExtension =>
                {
                    Directory.GetFiles(FolderPath, FileExtension).ToList().ForEach
                    (FileURL =>
                    {
                        AddMediaItem
                        ((IMediaItemType)Activator.CreateInstance(typeof(IMediaItemType), FileURL));
                    });
                });
            };
        }

        public void Clear()
        {
            MediaItems.Clear();
        }

        private int CurrentIndex = -1;
        private List<int> ShuffleList;
        private bool IsShuffle = false;
        private static readonly Random Random = new Random();

        public void GenerateShuffleList()
        {
            ShuffleList = Enumerable.Range(0, MediaItems.Count)
            .OrderBy(x => Random.Next()).ToList();
            IsShuffle = true;
        }

        public void UpdateCurrentIndex(IMediaItemType MediaItem)
        {
            CurrentIndex = MediaItems.IndexOf(MediaItem);
        }

        protected void Signal(int Index)
        {
            MediaItems[Index].Play();
        }

        public void Stop()
        {
            IsShuffle = false;
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
