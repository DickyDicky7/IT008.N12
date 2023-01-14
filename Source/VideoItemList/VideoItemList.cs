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
using System.Security.Policy;

namespace MyMediaPlayer
{
    public partial class VideoItemList : UserControl, IMediaItemList
    {
        public VideoItemList()
        {
            InitializeComponent();
            this.AutoScroll = true;
            //this.DoubleBuffered = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CP = base.CreateParams;
                CP.ExStyle = CP.ExStyle | 0x02000000;
                return CP;
            }
        }

        private readonly AMediaItemList<VideoItem> Self = new AMediaItemList<VideoItem>();

        public Action<string> AddVideosFolder
        {
            get => Self.AddFolderWith(AddVideos, Common.VideoFileExtensions);
        }

        private int i = 0;
        private int j = 0;
        public void AddVideos(VideoItem VideoItem)
        {
            //VideoItem.ParentVideoItemList = this;
            Self.MediaItems.Add(VideoItem);
            if (VideoItem.Size.Width * i + 20 * (i + 1) + VideoItem.Size.Width
            <= this.Size.Width - 20)
            {
                VideoItem.Location = new Point
                (VideoItem.Size.Width * i + 20 * (i + 1), VideoItem.Size.Height * j + 20 * (j + 1));
                i++;
            }
            else
            {
                j++;
                i = 0;
                VideoItem.Location = new Point
                (VideoItem.Size.Width * i + 20 * (i + 1), VideoItem.Size.Height * j + 20 * (j + 1));
            }
            this.Controls.Add(VideoItem);
        }

        public void AddVideos(string VideoURL)
        {
            if (!Self.MediaItems.Contains
                (Self.MediaItems.FirstOrDefault(MediaItem => MediaItem.URL == VideoURL)))
            {
                VideoItem VideoItem = new VideoItem(VideoURL);
                //VideoItem.ParentVideoItemList = this;
                AddVideos(VideoItem);
            }
        }

        public bool IsShuffle
        {
            get => Self.IsShuffle;
            set => Self.IsShuffle = value;
        }

        public Action Stop { get => Self.Stop; }
        public Action PlayNext { get => Self.PlayNext; }
        public Action PlayBack { get => Self.PlayBack; }
        public Action GenerateShuffleList { get => Self.GenerateShuffleList; }
    }
}
