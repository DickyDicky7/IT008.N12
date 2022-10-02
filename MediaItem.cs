using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace IT008.N12_015
{
    public partial class MediaItem : UserControl
    {
        private TimeSpan StripMilliseconds(TimeSpan time)
        {
            if(time.Hours == 0)
            {
                return new TimeSpan(time.Hours, time.Minutes, time.Seconds);
            }
            return new TimeSpan(time.Days, time.Hours, time.Minutes, time.Seconds);
        }
        #region Propreties

        private String url;
        private Image _thumbnail;
        private String _title;
        private String _artist;
        private String _album;
        private String _genre;


        private TimeSpan _duration;
        /// <summary>
        /// 
        /// </summary>
        public String Genre
        {
            get { return _genre; }
            set { _genre = value; genreLB.Text = value; }
        }
        public String URL
        {
            get { return url; }
            set { url = value; }
        }
        /// <summary>
        /// Media length
        /// </summary>
        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; durationLB.Text = value.ToString(@"mm\:ss"); }
        }
        /// <summary>
        /// Song's Album
        /// </summary>
        public String Album
        {
            get { return _album; }
            set { _album = value; albumLB.Text = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Artist
        {
            get { return _artist; }
            set { _artist = value; artistLB.Text = value; }
        }
        /// <summary>
        /// Media title
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; titleLB.Text = value; }
        }
        /// <summary>
        /// Media thumbnail image
        /// </summary>
        public Image Thumbnail
        {
            get { return _thumbnail; }
            set { _thumbnail = value; }
        }



        #endregion

        public MediaItem()
        {
            
        }

        /// <summary>
        /// Initialize a new MediaItem with given URL
        /// </summary>
        /// <param name="URL">Media Item's URL</param>
        public MediaItem(string URL)
        {
            InitializeComponent();
            Common.RoundedCorner(contextMenu);
            Common.RoundedCorner(addToMenuItem.DropDown);
            this.URL = URL;
            InitializeMediaItem(URL);
            Click += new EventHandler(MediaItem_Click);
            //MouseEnter += new EventHandler(MediaItem_MouseEnter);
            
            
        }
        /// <summary>
        /// Load media item information to control
        /// </summary>
        /// <param name="URL">Media Item's URL</param>
        private void InitializeMediaItem(string URL)
        {
            //this.Size = new System.Drawing.Size(1000, 50);
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
            this.Title = file.Tag.Title;
            this.Artist = file.Tag.Performers.FirstOrDefault();
            this.Album = file.Tag.Album;
            this.Duration = StripMilliseconds(file.Properties.Duration);
        }

        private void MediaItem_Click(object sender, EventArgs e)
        {
            ChangeLabelColor(Color.FromArgb(208, 64, 12));
            if(ClickedItem != null && ClickedItem != this)
            {
                ClickedItem.ChangeLabelColor(Color.Black);
            }
            ClickedItem = this;
            MediaController.LoadMedia(URL);
        }

        private void ChangeLabelColor(Color color)
        {
            titleLB.ForeColor = color;
            albumLB.ForeColor = color;
            artistLB.ForeColor = color;
            genreLB.ForeColor = color;
            durationLB.ForeColor = color;
        }

        public static MediaItem ClickedItem { get; set; }
        public static MediaController MediaController { get; set; }

        private void MediaItem_MouseEnter(object sender, EventArgs e)
        {
            containerPanel.FillColor = Color.FromArgb(239, 240, 243);

        }

        private void MediaItem_MouseHover(object sender, EventArgs e)
        {
            containerPanel.FillColor = Color.FromArgb(239, 240, 243);

        }

        private void MediaItem_MouseLeave(object sender, EventArgs e)
        {
            containerPanel.FillColor = Color.FromArgb(247, 250, 252);

        }

        private void playMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLabelColor(Color.FromArgb(208, 64, 12));
            if (ClickedItem != null && ClickedItem != this)
            {
                ClickedItem.ChangeLabelColor(Color.Black);
            }
            ClickedItem = this;
            MediaController.LoadMedia(URL);
        }
    }
}
