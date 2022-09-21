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
            return new TimeSpan(time.Days, time.Hours, time.Minutes, time.Seconds);
        }
        #region Propreties

        private String url;
        private Image _thumbnail;
        private String _title;
        private String _artist;
        private String _album;
        private TimeSpan _duration;
        /// <summary>
        /// 
        /// </summary>
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
            set { _duration = value; durationLB.Text = value.ToString(); }
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
            set { _thumbnail = value; thumbNailPTB.Image = value; }
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
            this.URL = URL;
            InitializeMediaItem(URL);
            Click += new EventHandler(MediaItem_Click);
            
        }
        /// <summary>
        /// Load media item information to control
        /// </summary>
        /// <param name="URL">Media Item's URL</param>
        private void InitializeMediaItem(string URL)
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
            this.Title = file.Tag.Title;
            this.Artist = file.Tag.Artists.FirstOrDefault();
            this.Album = file.Tag.Album;
            this.Duration = StripMilliseconds(file.Properties.Duration);
        }

        private void MediaItem_Click(object sender, EventArgs e)
        {
            MediaController.LoadMedia(URL);
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control Control in Controls)
                {
                    Control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control Control in Controls)
                {
                    Control.Click -= value;
                }
            }
        }

        public static MediaController MediaController { get; set; }
    }
}
