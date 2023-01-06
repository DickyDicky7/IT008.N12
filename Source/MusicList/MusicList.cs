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

namespace MyMediaPlayer
{
    public partial class MusicList : UserControl
    {
        public MusicList()
        {
            InitializeComponent();
            
        }
        List<IMediaItem> mediaItems = new List<IMediaItem>();
        public bool shuffleMode = false;
        List<int> shuffleList = new List<int>();
        public void addMusicFolder(string folderPath)
        {
            string[] fileArray = Directory.GetFiles(folderPath, "*.mp3");
            foreach (string file in fileArray)
            {
                TrackItem media = new TrackItem(file);
                addMusic(media);
            }
        }
        public void addMusic(TrackItem mediaItem)
        {
            //mediaItem.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            mediaItem.ParentMusicList = this;
            mediaItems.Add(mediaItem);
            mediaItem.Dock = DockStyle.Top;
            mediaItemContainer.Controls.Add(mediaItem);
            //mediaItem.BringToFront();
            sortBy(sortState);
        }
        public void addMusic(string URL)
        {
            if(!mediaItems.Contains(mediaItems.FirstOrDefault(media => media.URL == URL)))
            {
                TrackItem media = new TrackItem(URL);
                media.ParentMusicList = this;
                addMusic(media);
            }
        }
        public void sortBy(SORTBY sort)
        {
            switch (sort)
            {
                case SORTBY.AZ:
                    mediaItems = mediaItems.OrderBy(mediaItem => mediaItem.Title).ToList();
                    break;
                case SORTBY.ARTIST:
                    mediaItems = mediaItems.OrderBy(mediaItem => mediaItem.Artist).ToList();
                    break;
                case SORTBY.GENRE:
                    mediaItems = mediaItems.OrderBy(mediaItem => mediaItem.Genre).ToList();
                    break;
                case SORTBY.ALBUM:
                    mediaItems = mediaItems.OrderBy(mediaItem => mediaItem.Album).ToList();
                    break;
            }
            sortState = sort;
            // Reverse because how panel add controls
            mediaItems.Reverse();
            mediaItemContainer.Controls.Clear();
            mediaItemContainer.Controls.AddRange(mediaItems.Select(Item => Item.UserControl).ToArray());
            // Reverse again to match logic stupid but it work
            mediaItems.Reverse();
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
            shuffleList = Enumerable.Range(0, mediaItems.Count).OrderBy(x => random.Next()).ToList();
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
        
        public int GetMediaIndex(TrackItem item)
        {
            //Lỗi logic dòng 116, đã sửa và thay bằng dòng 119
            //return mediaItems.IndexOf(item);
            //Dòng 118 dùng để debug
            //MessageBox.Show(mediaItemContainer.Controls.IndexOf(item).ToString());
            return mediaItems.IndexOf(item);
        }
        public int GetExpandSize()
        {
            if(mediaItems.Count == 0) return 0;
            return mediaItems.Count * mediaItems.First().UserControl.Height;
        }
        public void Clear()
        {
            mediaItems.Clear();
            mediaItemContainer.Controls.Clear();
        }

        public void Signal(int Index)
        {
            mediaItems[Index].Play();
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
