using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008.N12_015
{
    public partial class MusicList : UserControl
    {
        public MusicList()
        {
            InitializeComponent();
            
        }
        List<MediaItem> mediaItems = new List<MediaItem>();
        public bool shuffleMode = false;
        List<int> shuffleList = new List<int>();
        public void addMusicFolder(string folderPath)
        {
            string[] fileArray = Directory.GetFiles(folderPath, "*.mp3");
            foreach (string file in fileArray)
            {
                MediaItem media = new MediaItem(file);
                media.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                mediaItems.Add(media);
                mediaItemContainer.Controls.Add(media);
            }
        }
        public void addMusic(MediaItem mediaItem)
        {
            mediaItems.Add(mediaItem);
            mediaItemContainer.Controls.Add(mediaItem);
        }
        public void addMusic(string URL)
        {
            if(!mediaItems.Contains(mediaItems.FirstOrDefault(media => media.URL == URL)))
            {
                MediaItem media = new MediaItem(URL);
                addMusic(media);
            }
        }
        public void sortBy(SORTBY sort)
        {
            List<MediaItem> sortedList = new List<MediaItem>();
            switch (sort)
            {
                case SORTBY.AZ:
                    sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Title).ToList();
                    break;
                case SORTBY.ARTIST:
                    sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Artist).ToList();
                    break;
                case SORTBY.GENRE:
                    sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Genre).ToList();
                    break;
                case SORTBY.ALBUM:
                    sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Album).ToList();
                    break;
            }
            mediaItemContainer.Controls.Clear();
            mediaItemContainer.Controls.AddRange(sortedList.ToArray());
        }
        private void mediaItemContainer_Resize(object sender, EventArgs e)
        {
            //this.Visible = false;
            test();
            //this.Visible = true;
        }
        public void test()
        {
            foreach (Control c in mediaItemContainer.Controls)
            {
                c.Width = this.Width - c.Padding.Left - c.Padding.Right;

                //c.BeginInvoke(new Action(() => c.Width = this.Width - c.Padding.Left - c.Padding.Right));
            }
        }

        public void GenShuffleList()
        {
            Random random = new Random();
            shuffleList = Enumerable.Range(0, mediaItems.Count-1).OrderBy(x => random.Next()).ToList();
        }

        public enum SORTBY
        {
            AZ,
            ARTIST,
            ALBUM,
            GENRE
        }

        private void MusicList_Load(object sender, EventArgs e)
        {
            Common.SetDoubleBuffered(mediaItemContainer);
        }

        public void Clear()
        {
            mediaItems.Clear();
            mediaItemContainer.Controls.Clear();
        }

        public void Signal(int Index)
        {
            ((MediaItem)mediaItemContainer.Controls[Index])
            .MediaItem_Click(null, null);
        }

        private int CurrentIndex = -1;

        public void Stop()
        {
            CurrentIndex = -1;
        }

        public void PlayNext()
        {
            CurrentIndex++;
            if (CurrentIndex < mediaItems.Count)
            {
                if(shuffleMode == true)
                {
                    Signal(shuffleList[CurrentIndex]);
                }
                else
                    Signal(CurrentIndex);
            }
        }
    }
}
