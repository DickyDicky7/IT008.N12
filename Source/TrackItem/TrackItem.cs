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
            if (time.Hours == 0)
            {
                return new TimeSpan(time.Hours, time.Minutes, time.Seconds);
            }
            return new TimeSpan(time.Days, time.Hours, time.Minutes, time.Seconds);
        }

        #region Propreties

        private string url;
        private Image thumbnail;
        private string title;
        private string artist;
        private string album;
        private string genre;
        private string playlistName;
        private TimeSpan duration;

        public TimeSpan? Duration
        {
            get => duration;
            set
            {
                duration = value.Value;
                durationLB.Text = value.Value.ToString(@"mm\:ss");
            }
        }

        public string PlaylistName
        {
            get => playlistName;
            set => playlistName = value;
        }

        public string Genre
        {
            get => genre;
            set => genre = genreLB.Text = value;
        }

        public string URL
        {
            get => url;
            set => url = value;
        }

        public string Album
        {
            get => album;
            set => album = albumLB.Text = value;
        }

        public string Artist
        {
            get => artist;
            set => artist = artistLB.Text = value;
        }

        public string Title
        {
            get => title;
            set => title = titleLB.Text = value;
        }

        public Image Thumbnail
        {
            get => thumbnail;
            set => thumbnail = value;
        }

        #endregion

        public TrackItem()
        {
            InitializeComponent();
            this.Title = "test";
            this.Artist = "test";
            this.Album = "test";
            this.Genre = "test";
            this.Duration = new TimeSpan(0, 0, 0);
        }

        public TrackItem
        (string title, string artist, string album, string genre, TimeSpan duration)
        {
            InitializeComponent();
            this.Title = title;
            this.Artist = artist;
            this.Album = album;
            this.Genre = genre;
            this.Duration = duration;
        }

        /// <summary>
        /// Initialize a new TrackItem with a given URL
        /// </summary>
        /// <param name="URL">Track's URL</param>
        public TrackItem(string URL)
        {
            InitializeComponent();

            Common.RoundedCorner(contextMenu);
            Common.RoundedCorner(addToMenuItem.DropDown);

            this.URL = URL;

            InitializeTrackItem(URL);
            this.Click += new EventHandler(TrackItem_Click);

            instances.Add(new WeakReference(this));
        }

        /// <summary>
        /// Load track's information to TrackItem
        /// </summary>
        /// <param name="URL">Track's URL</param>
        private void InitializeTrackItem(string URL)
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
                this.Title = file.Tag.Title != null ? file.Tag.Title
                : URL.Substring(URL.LastIndexOf('\\') + 1);
                this.Artist = file.Tag.Performers.FirstOrDefault();
                this.Album = file.Tag.Album;
                this.Duration = StripMilliseconds(file.Properties.Duration);
            }
            catch
            {

            }
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
            GlobalReferences.MainForm.BringVisualizeToFront();
            if (ParentMusicList != null)
            {
                ParentMusicList.CurrentIndex = ParentMusicList.GetMediaIndex(this) - 1;
                GlobalReferences.MediaController.LoadMusicList(ParentMusicList);
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
            GlobalReferences.MediaController.LoadMedia(URL);
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
                        if (c is CheckBox)
                        {

                        }
                        else
                        {
                            c.Click += e;
                            Recursive(c, e);
                        }
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

        public MusicList ParentMusicList { get; set; }

        private static readonly List<WeakReference> instances = new List<WeakReference>();

        public static void AddToAllMenu(string playlistName)
        {
            var items = GetInstances();
            foreach (var item in items)
            {
                item.AddItemToMenu(playlistName);
            }
        }

        public static void RemoveFromAllMenu(string playlistName)
        {
            var instances = GetInstances();
            foreach (var item in instances)
            {
                item.RemoveItemFromMenu(playlistName);
            }
        }

        public void RemoveItemFromMenu(string playlistName)
        {
            addToMenuItem.DropDownItems.RemoveByKey(playlistName);
        }

        public static IList<TrackItem> GetInstances()
        {
            List<TrackItem> realInstances = new List<TrackItem>();
            List<WeakReference> toDelete = new List<WeakReference>();

            foreach (WeakReference reference in instances)
            {
                if (reference.IsAlive)
                {
                    realInstances.Add((TrackItem)reference.Target);
                }
                else
                {
                    toDelete.Add(reference);
                }
            }

            foreach (WeakReference reference in toDelete) instances.Remove(reference);

            return realInstances;
        }

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
            AddPlaylistToMenu();
            Common.SetDoubleBuffered(inforPanel);
            Common.SetDoubleBuffered(containerPanel);
        }

        public void AddItemToMenu(string playlistName)
        {
            ToolStripMenuItem playlist = new ToolStripMenuItem();
            playlist.Text = playlistName;
            playlist.Name = playlistName;
            playlist.Click += AddToPlaylist;
            addToMenuItem.DropDownItems.Add(playlist);
        }

        private void AddPlaylistToMenu()
        {
            var fileArray = Directory.GetFiles(Common.PlaylistsFolder, "*.wpl")
            .Select(filename => Path.GetFileNameWithoutExtension(filename));
            foreach (var file in fileArray)
            {
                AddItemToMenu(file);
            }
        }

        public void AddDeleteToMenu()
        {
            ToolStripMenuItem delete = new ToolStripMenuItem();
            delete.Text = "Remove";
            delete.Name = "delete"; ;
            delete.ForeColor = Color.FromArgb(22, 26, 29);
            delete.Image = Properties.Resources.close;
            delete.Click += (object sender, EventArgs e) =>
            {
                this.Parent.Controls.Remove(this);
                MessageBox.Show(this.PlaylistName + " " + URL);
                MediaController.RemoveFromPlaylist(this.PlaylistName, URL);
            };
            contextMenu.Items.Add(delete);
        }

        private void AddToPlaylist(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)(sender);
            MediaController.AddToPlaylist(item.Text, URL);

        }

        private void NewPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputForm = new InputForm("Enter playlist's name");
            inputForm.ShowDialog();

            AddToAllMenu(inputForm.Result);
            if (!File.Exists($"{Common.PlaylistsFolder}\\{inputForm.Result}.wpl"))
            {
                MediaController.CreatePlaylist(inputForm.Result);
                PlaylistItem item = new PlaylistItem
                ($"{Common.PlaylistsFolder}\\{inputForm.Result}.wpl");
                GlobalReferences.MainForm.AddPlaylistToPanel(item);
                MediaController.AddToPlaylist(inputForm.Result, URL);
            }
            else
                MessageBox.Show("Playlist exists!");
        }

        private void PlayQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrackItem item = new TrackItem(URL)
            {
                Width = this.Width
            };
            GlobalReferences.MainForm.AddMusicToPlayQ(item);
        }
    }
}
