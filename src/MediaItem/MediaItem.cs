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
using IT008.N12_015.src.InputForm;

namespace IT008.N12_015
{
    public partial class MediaItem : UserControl
    {

        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

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

        public MediaItem(string title, string artist, string album, string genre, TimeSpan duration)
        {
            InitializeComponent();
            this.Title = title;
            this.Artist = artist;
            this.Album = album;
            this.Genre = genre;
            this.Duration = duration;
            Click += new EventHandler(testClick);
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
            try
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
                this.Title = file.Tag.Title;
                this.Artist = file.Tag.Performers.FirstOrDefault();
                this.Album = file.Tag.Album;
                this.Duration = StripMilliseconds(file.Properties.Duration);
            }
            //this.Size = new System.Drawing.Size(1000, 50);
            catch
            {
                
            }
        }

        private void MediaItem_Click(object sender, EventArgs e)
        {
            f.bringVisualizeToFront();

            ChangeLabelColor(Color.FromArgb(186, 24, 27));
            if(ClickedItem != null && ClickedItem != this)
            {
                ClickedItem.ChangeLabelColor(Color.Black);
            }
            ClickedItem = this;
            MediaController.LoadMedia(URL);
        }

        private void testClick(object sender, EventArgs e)
        {
            MessageBox.Show(this.Width + " " + this.Parent.Width);
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
                void Recursive(Control control, EventHandler e)
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
                void Recursive(Control control, EventHandler e)
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
        public static form f { get; set; }
        public static MediaItem ClickedItem { get; set; }
        public static MediaController MediaController { get; set; }

        private void MediaItem_MouseEnter(object sender, EventArgs e)
        {
            containerPanel.FillColor = Color.FromArgb(211, 211, 211);
        }

        private void MediaItem_MouseHover(object sender, EventArgs e)
        {
            containerPanel.FillColor = Color.FromArgb(211, 211, 211);
        }

        private void MediaItem_MouseLeave(object sender, EventArgs e)
        {
            containerPanel.FillColor = Color.FromArgb(255, 255, 255);
        }

        private void playMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLabelColor(Color.FromArgb(186, 24, 27));
            if (ClickedItem != null && ClickedItem != this)
            {
                ClickedItem.ChangeLabelColor(Color.Black);
            }
            ClickedItem = this;
            MediaController.LoadMedia(URL);
        }

        private void MediaItem_Load(object sender, EventArgs e)
        {
            addPlaylistToMenu();
            Common.SetDoubleBuffered(inforPanel);
            Common.SetDoubleBuffered(containerPanel);
        }
        private void addPlaylistToMenu()
        {
            var fileArray = Directory.GetFiles(Common.MusicFolder + "//Playlists","*.wpl").Select(filename => Path.GetFileNameWithoutExtension(filename));
            foreach (var file in fileArray)
            {
                ToolStripMenuItem playlist = new ToolStripMenuItem();
                playlist.Text = file;
                playlist.Click += addToPlaylist;
                addToMenuItem.DropDownItems.Add(playlist);
            }
        }
        public void addDeleteMenu()
        {
            ToolStripMenuItem delete = new ToolStripMenuItem();
            delete.Text = "Remove";
            delete.Name = "delete"; ;
            delete.ForeColor = Color.FromArgb(22, 26, 29);
            delete.Image = Properties.Resources.close;
            delete.Click += (object sender, EventArgs e) => { this.Parent.Controls.Remove(this); } ;
            contextMenu.Items.Add(delete);
        }
        private void addToPlaylist(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)(sender);
            MediaController.AddToPlaylist(item.Text, URL);

        }
        private void newPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputForm = new InputForm("Nhập tên playlist");
            inputForm.ShowDialog();
            
            ToolStripMenuItem playlist = new ToolStripMenuItem();
            playlist.Text = inputForm.Result;
            playlist.Click += addToPlaylist;
            addToMenuItem.DropDownItems.Add(playlist);
            if (!File.Exists($"{Common.MusicFolder}\\Playlists\\" + inputForm.Result + ".wpl"))
            {
                MediaController.CreatePlaylist(inputForm.Result);
                PlaylistItem item = new PlaylistItem($"{Common.MusicFolder}\\Playlists\\" + inputForm.Result + ".wpl");
                f.AddPlaylistToPanel(item);
                MediaController.AddToPlaylist(inputForm.Result, URL);
            }
            else
                MessageBox.Show("Playlist da ton tai");

        }
    }
}
