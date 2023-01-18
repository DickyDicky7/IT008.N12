using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class TrackItem : UserControl, IMediaItem
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

        private TimeSpan StripMilliseconds(TimeSpan time)
        {
            if (time.Hours == 0)
            {
                return new TimeSpan(time.Hours, time.Minutes, time.Seconds);
            }
            return new TimeSpan(time.Days, time.Hours, time.Minutes, time.Seconds);
        }

        #region Propreties

        private string url;
        private string title;
        private string album;
        private string genre;
        private string artist;
        private Image thumbnail;
        private TimeSpan duration;

        public string URL
        {
            get => url;
            set => url = value;
        }

        public string Genre
        {
            get => genre;
            set => genre = genreLB.Text = value;
        }

        public string Album
        {
            get => album;
            set => album = albumLB.Text = value;
        }

        public string Title
        {
            get => title;
            set => title = titleLB.Text = value;
        }

        public string Artist
        {
            get => artist;
            set => artist = artistLB.Text = value;
        }

        public Image Thumbnail
        {
            get => thumbnail;
            set => thumbnail = value;
        }

        public TimeSpan? Duration
        {
            get => duration;
            set
            {
                duration = value.Value;
                durationLB.Text = value.Value.ToString(@"mm\:ss");
            }
        }

        #endregion

        public TrackItem()
        {
            InitializeComponent();
            this.Title = "test";
            this.Album = "test";
            this.Genre = "test";
            this.Artist = "test";
            this.Duration = new TimeSpan(0, 0, 0);
        }

        public TrackItem
        (string title, string artist, string album, string genre, TimeSpan duration)
        {
            InitializeComponent();
            this.Title = title;
            this.Album = album;
            this.Genre = genre;
            this.Artist = artist;
            this.Duration = duration;
        }

        /// <summary>
        /// Initialize a new TrackItem with a given URL
        /// </summary>
        /// <param name="URL">Track's URL</param>
        public TrackItem(string URL)
        {
            InitializeComponent();

            this.URL = URL;

            InitializeTrackItem(URL);
            this.Click += new EventHandler(TrackItem_Click);
        }

        /// <summary>
        /// Load track's information to TrackItem
        /// </summary>
        /// <param name="URL">Track's URL</param>
        private void InitializeTrackItem(string URL)
        {
            TagLib.File file = TagLib.File.Create(URL);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                this.Thumbnail = bm;
            }
            else
            {
                this.Thumbnail = Properties.Resources.mp3;
            }
            this.Genre = file.Tag.Genres.FirstOrDefault();
            this.Title = file.Tag.Title;
            this.Title = file.Tag.Title != null ? file.Tag.Title
            : URL.Substring(URL.LastIndexOf('\\') + 1);
            this.Artist = file.Tag.Performers.FirstOrDefault();
            this.Album = file.Tag.Album;
            this.Duration = StripMilliseconds(file.Properties.Duration);
        }

        public EventHandler IMediaItem_Click
        {
            get => TrackItem_Click;
        }

        public Action Play
        {
            get => TrackItem_Play;
        }

        public UserControl UserControl
        {
            get => this;
        }

        private void TrackItem_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button is MouseButtons.Left)
            {
                GlobalReferences.MainForm.BringVisualizeToFront();
                if (ParentTrackItemList != null)
                {
                    GlobalReferences.MediaController.LoadMediaItemList(ParentTrackItemList);
                    ParentTrackItemList.UpdateCurrentIndex(this);
                    TrackItem_Play();
                }
            }
            else
            if (((MouseEventArgs)e).Button is MouseButtons.Right)
            {
                GlobalReferences.PlaylistContextMenuStrip.Show
                (this, ((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                GlobalReferences.PlaylistContextMenuStripRecentMediaItem = this;
            }

        }

        private void TrackItem_Play()
        {
            ChangeLabelColor(Color.FromArgb(186, 24, 27));
            if (PlayItem != null && PlayItem != this)
            {
                PlayItem.ChangeLabelColor(Color.Black);
            }
            PlayItem = this;
            GlobalReferences.MediaController.LoadLocalTrack(URL);
        }

        private void ChangeLabelColor(Color color)
        {
            titleLB.ForeColor = color;
            albumLB.ForeColor = color;
            artistLB.ForeColor = color;
            genreLB.ForeColor = color;
            durationLB.ForeColor = color;
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                static void Recursive(Control control, EventHandler e)
                {
                    foreach (Control c in control.Controls)
                    {
                        c.Click += e;
                        Recursive(c, e);
                    }
                }
                Recursive(this, value);
            }
            remove
            {
                base.Click -= value;
                static void Recursive(Control control, EventHandler e)
                {
                    foreach (Control c in control.Controls)
                    {
                        c.Click -= e;
                        Recursive(c, e);
                    }
                }
                Recursive(this, value);
            }
        }

        public static TrackItem PlayItem { get; set; }

        public TrackItemList ParentTrackItemList { get; set; }

        private void TrackItem_MouseEnter(object sender, EventArgs e)
        {
            containerPanel.FillColor = Color.FromArgb(211, 211, 211);
        }

        private void TrackItem_MouseLeave(object sender, EventArgs e)
        {
            containerPanel.FillColor = Color.FromArgb(255, 255, 255);
        }

        private void TrackItem_Load(object sender, EventArgs e)
        {
            Common.SetDoubleBuffered(inforPanel);
            Common.SetDoubleBuffered(containerPanel);
        }
    }
}
