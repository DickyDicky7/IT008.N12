using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
                addMusic(media);
            }
        }
        public void addMusic(MediaItem mediaItem)
        {
            mediaItem.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            mediaItem.Dock = DockStyle.Top;
            mediaItem.ParentMusicList = this;
            mediaItems.Add(mediaItem);
            mediaItemContainer.Controls.Add(mediaItem);
            sortBy(sortState);
        }
        public void addMusic(string URL)
        {
            if(!mediaItems.Contains(mediaItems.FirstOrDefault(media => media.URL == URL)))
            {
                MediaItem media = new MediaItem(URL);
                media.ParentMusicList = this;
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
            sortState = sort;
            mediaItemContainer.Controls.Clear();
            // Reverse cause how panel add control
            sortedList.Reverse();
            mediaItemContainer.Controls.AddRange(sortedList.ToArray());
        }
        private void mediaItemContainer_Resize(object sender, EventArgs e)
        {
            //this.Visible = false;
            //Responsive();
            //this.Visible = true;
        }
        public void Responsive()
        {
            //foreach (Control c in mediaItemContainer.Controls)
            //{
            //    c.Width = this.Width - c.Padding.Left - c.Padding.Right;

            //    //c.BeginInvoke(new Action(() => c.Width = this.Width - c.Padding.Left - c.Padding.Right));
            //}
        }

        public void GenShuffleList()
        {
            Random random = new Random();
            shuffleList = Enumerable.Range(0, mediaItems.Count-1).OrderBy(x => random.Next()).ToList();
        }

        SORTBY sortState = SORTBY.AZ;

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

        public int GetMediaIndex(MediaItem item)
        {
            //Lỗi logic dòng 116, đã sửa và thay bằng dòng 119
            //return mediaItems.IndexOf(item);
            //Dòng 118 dùng để debug
            //MessageBox.Show(mediaItemContainer.Controls.IndexOf(item).ToString());
            return mediaItemContainer.Controls.IndexOf(item);
        }

        public void Clear()
        {
            mediaItems.Clear();
            mediaItemContainer.Controls.Clear();
        }

        public void Signal(int Index)
        {
            ((MediaItem)mediaItemContainer.Controls[Index])
            .MediaItemPlay();
        }

        public int CurrentIndex = -1;

        public void Stop()
        {
            CurrentIndex = -1;
        }

        public void PlayNext()
        {
            CurrentIndex++;
            //MessageBox.Show(CurrentIndex.ToString());
            if (CurrentIndex < mediaItems.Count)
            {
                if (shuffleMode == true)
                {
                    Signal(shuffleList[CurrentIndex]);
                }
                else
                    Signal(CurrentIndex);
            }
            else
            {
                CurrentIndex = mediaItems.Count - 1;
            }
        }
        public void PlayBack()
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex--;
                if (shuffleMode == true)
                {
                    Signal(shuffleList[CurrentIndex]);
                }
                else
                    Signal(CurrentIndex);
            }
        }
    }
}
