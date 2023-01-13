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

namespace MyMediaPlayer
{
    public partial class TrackItemList : UserControl, IMediaItemList
    {
        public TrackItemList()
        {
            InitializeComponent();
        }

        private readonly AMediaItemList<TrackItem> Self = new AMediaItemList<TrackItem>();

        public Action<string> AddMusicFolder
        {
            get => Self.AddFolderWith(AddMusic, Common.AudioFileExtensions);
        }

        public void AddMusic(TrackItem mediaItem)
        {
            mediaItem.ParentTrackItemList = this;
            Self.MediaItems.Add(mediaItem);
            mediaItem.Dock = DockStyle.Top;
            mediaItemContainer.Controls.Add(mediaItem);
            sortBy(sortState);
        }

        public void AddMusic(string URL)
        {
            if (!Self.MediaItems.Contains
                (Self.MediaItems.FirstOrDefault(media => media.URL == URL)))
            {
                TrackItem media = new TrackItem(URL);
                media.ParentTrackItemList = this;
                AddMusic(media);
            }
        }

        public void sortBy(SORTBY sort)
        {
            switch (sort)
            {
                case SORTBY.AZ:
                    Self.MediaItems =
                    Self.MediaItems.OrderBy(mediaItem => mediaItem.Title).ToList();
                    break;
                case SORTBY.ARTIST:
                    Self.MediaItems =
                    Self.MediaItems.OrderBy(mediaItem => mediaItem.Artist).ToList();
                    break;
                case SORTBY.GENRE:
                    Self.MediaItems =
                    Self.MediaItems.OrderBy(mediaItem => mediaItem.Genre).ToList();
                    break;
                case SORTBY.ALBUM:
                    Self.MediaItems =
                    Self.MediaItems.OrderBy(mediaItem => mediaItem.Album).ToList();
                    break;
            }
            sortState = sort;
            // Reverse because how panel add controls
            Self.MediaItems.Reverse();
            mediaItemContainer.Controls.Clear();
            mediaItemContainer.Controls.AddRange
            (Self.MediaItems.Select(Item => Item.UserControl).ToArray());
            // Reverse again to match logic stupid but it work
            Self.MediaItems.Reverse();
        }

        private SORTBY sortState = SORTBY.AZ;

        public enum SORTBY
        {
            AZ, ARTIST, ALBUM, GENRE,
        }

        private void TrackItemList_Load(object sender, EventArgs e)
        {
            Common.SetDoubleBuffered(mediaItemContainer);
        }

        public int GetExpandSize()
        {
            return Self.MediaItems.Count == 0 ? 0
            : Self.MediaItems.Count * Self.MediaItems.First().UserControl.Height;
        }

        public void Clear()
        {
            Self.Clear();
            mediaItemContainer.Controls.Clear();
        }

        public bool IsShuffle
        {
            get => Self.IsShuffle;
            set => Self.IsShuffle = value;
        }

        public int CurrentIndex
        {
            get => Self.CurrentIndex;
            set => Self.CurrentIndex = value;
        }

        public Action GenerateShuffleList { get => Self.GenerateShuffleList; }

        public AMediaItemList<TrackItem>.GetMediaItemIndexHandler GetMediaItemIndex
        { get => Self.GetMediaItemIndex; }

        public Action Stop { get => Self.Stop; }

        public Action PlayNext { get => Self.PlayNext; }

        public Action PlayBack { get => Self.PlayBack; }

        private void mediaItemContainer_Resize(object sender, EventArgs e)
        {

        }
    }
}
