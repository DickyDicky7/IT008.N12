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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CP = base.CreateParams;
                CP.ExStyle |= 0x02000000;
                return CP;
            }
        }

        public TrackItemList()
        {
            InitializeComponent();

            Watcher Watcher = new Watcher();
            Watcher.Interval = TimeSpan.FromMilliseconds(500);
            Watcher.Action = () =>
            {
                if (LastTimeModified != null)
                {
                    if (DateTime.Now.Subtract(LastTimeModified.Value) >= TimeSpan.FromSeconds(2))
                    {
                        if (IsHandleCreated)
                        {
                            mediaItemContainer.BeginInvoke((MethodInvoker)delegate ()
                            {
                                SortBy(sortState);
                            });
                        }
                        LastTimeModified = null;
                    }
                }
            };
            Watcher.Start();
        }

        private DateTime? LastTimeModified = null;

        private readonly AMediaItemList<TrackItem> Self = new AMediaItemList<TrackItem>();

        public Action<string> AddMusicFolder
        {
            get => Self.AddFolderWith(AddMusic, Common.AudioFileExtensions);
        }

        public void AddMusic(TrackItem mediaItem)
        {
            LastTimeModified = DateTime.Now;
            mediaItem.ParentTrackItemList = this;
            Self.MediaItems.Add(mediaItem);
            mediaItem.Dock = DockStyle.Top;
            mediaItemContainer.Controls.Add(mediaItem);
            //SortBy(sortState);
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

        public void SortBy(SORTBY sort)
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

        public Action Stop { get => Self.Stop; }
        public Action Clear
        {
            get => () =>
            {
                for (int k = 0; k < mediaItemContainer.Controls.Count; k++)
                {
                    mediaItemContainer.Controls[k].Dispose();
                }
                Self.Clear();
                mediaItemContainer.Controls.Clear();
            };
        }
        public Action PlayNext { get => Self.PlayNext; }
        public Action PlayBack { get => Self.PlayBack; }
        public Action GenerateShuffleList { get => Self.GenerateShuffleList; }

        public void UpdateCurrentIndex(IMediaItem MediaItem)
        {
            TrackItem TrackItem = (TrackItem)MediaItem;
            if (TrackItem != null)
                Self.UpdateCurrentIndex(TrackItem);
        }

        private void MediaItemContainer_Resize(object sender, EventArgs e)
        {

        }
    }
}
