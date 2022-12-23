using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Siticone.Desktop.UI.WinForms;

namespace MyMediaPlayer
{
    public partial class form : Form
    {
        public form(string[] args)
        {
            InitializeComponent();
            Common.RoundedCorner(this);
            settingPageInit();
            musicPageInit();
            playlistPageInit();
            Responsive();
            designInit();
            MediaController.lyrics = mediaLyrics1;
            Load += new EventHandler(form_Load(args));


            #region Tuan Anh Testing

            //var f = new InputForm("My title");
            //this.Controls.Add(f);
            //f.Show();
            //var sci = new SoundCloudIntegration();
            //siticoneTabControl1.TabPages.Add(sci.SoundCloudTabPage);

            //PlaylistItem.MediaController = mediaController;
            //PlaylistItem p1 = new PlaylistItem(
            //    "C:\\Users\\Admin\\Music\\Playlists\\hello.wpl"
            //    );
            //PlaylistItem p2 = new PlaylistItem(
            //    "C:\\Users\\User\\Music\\Playlists\\def.wpl"
            //    );
            //p1.AdjacentOne = p2;
            //p1.Location = new Point(10, 10);
            //p2.Location = new Point(10, 60);
            //playlistsPanel.Controls.Add(p1);
            //playlistsPanel.Controls.Add(p2);
            ZingMP3Integration a = new ZingMP3Integration();

            //a.Search("@");
            
            ////this.BackColor = Color.White;
            ////this.TransparencyKey = Color.White;
            ////this.Opacity = 100;
            //////tabPage4.BackColor = Color.Transparent;

            this.Icon = Properties.Resources.icon;

            mediaVisualizer1.InteractMediaController(mediaController);
            MediaController.form = this;
            MediaController
            .RemoveFromPlaylist("a", "C:\\Users\\User\\Music\\Circus10529-VA-5631008.mp3");
            ////Form a = new Form();
            ////a.BackColor = Color.Black;
            ////a.TransparencyKey = Color.Black;
            ////a.Opacity = 20;
            ////a.Show();

            //if (!File.Exists($"{Common.MusicFolder}\\Playlists\\hello.wpl"))
            //    MediaController.CreatePlaylist("hello");

            //MediaController.AddToPlaylist
            //("hello", $"{Common.MusicFolder}\\Waiting-For-You-MONO-Onionn.mp3");
            //MediaController.AddToPlaylist
            //("hello", $"{Common.MusicFolder}\\Waiting.mp3");
            //
            #endregion
        }

        private Action<object, EventArgs> form_Load(string[] args)
        {
            Action<object, EventArgs> LoadHandler = new
            Action<object, EventArgs>((sender, e) =>
            {
                if (args.Length != 0)
                {
                    //MessageBox.Show(args[0], "File");
                    //MediaController.LoadMedia(args[0]);
                    bringVisualizeToFront();
                    mediaController.LoadMedia(args[0]);
                }
            });
            return LoadHandler;
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            mediaVisualizer1.Stop();
        }

        #region Initialize
        private void designInit()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
            PlaylistItem.MediaController = mediaController;
            MediaItem.f = this;
            FormClosing += new FormClosingEventHandler(form_FormClosing);
            tabControlBorder.BringToFront();
            visualizeContainer.Visible = false;
        }
        private void musicPageInit()
        {
            Common.RoundedCorner(this.sortByMenu);
            this.shuffleAndPlayBtn.AutoSize = true;
            this.sortBtn.AutoSize = true;
            MediaItem.MediaController = mediaController;
            List<string> removeL = new List<string>();
            foreach (string URL in Properties.Settings.Default.musicFolder)
            {
                if (Directory.Exists(URL))
                    musicList1.addMusicFolder(URL);
                else
                {
                    removeL.Add(URL);
                }
            }
            foreach (string URL in removeL)
            {
                Properties.Settings.Default.musicFolder.Remove(URL);
                Properties.Settings.Default.Save();
            }
        }
        private void settingPageInit()
        {
            string musicPath = Common.MusicFolder;
            if (Properties.Settings.Default.musicFolder.Contains(musicPath) == false)
            {
                Properties.Settings.Default.musicFolder.Add(musicPath);
                Properties.Settings.Default.Save();
            }
            foreach (string URL in Properties.Settings.Default.musicFolder)
            {
                FolderLocation musicFolder = new FolderLocation(URL);
                musicFolder.Dock = DockStyle.Top;
                musicFolderPanel.Controls.Add(musicFolder);
            }
        }
        private void playlistPageInit()
        {
            var fileArray = Directory.GetFiles(Common.PlaylistsFolder, "*.wpl");
            foreach (string file in fileArray)
            {
                PlaylistItem item = new PlaylistItem(file);
                AddPlaylistToPanel(item);
            }
        }
        public void bringVisualizeToFront()
        {
            visualizeContainer.Visible = true;
            visualizeContainer.BringToFront();
            tabControlBorder.SendToBack();
        }

        public void AddPlaylistToPanel(Control c)
        {
            PlaylistItem Head =
            playlistsPanel.Controls.OfType<PlaylistItem>().LastOrDefault();
            if (Head != null)
            {
                //MessageBox.Show(Head.Name);
                Head.AdjacentOne = (PlaylistItem)c;
            }
            playlistsPanel.Controls.Add(c);
        }

        public void UpdatePlaylistItem(string PlaylistURL)
        {
            ((PlaylistItem)playlistsPanel.Controls
        .Find(PlaylistURL, false).FirstOrDefault()).Reset();
        }

        #endregion

        #region Add_Music
        private void addFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (Properties.Settings.Default.musicFolder.Contains(fbd.SelectedPath) == false)
                    {
                        Properties.Settings.Default.musicFolder.Add(fbd.SelectedPath);
                        Properties.Settings.Default.Save();
                        FolderLocation folderLocation = new FolderLocation(fbd.SelectedPath);
                        musicFolderPanel.Controls.Add(folderLocation);
                        musicList1.addMusicFolder(fbd.SelectedPath);
                    }
                }
            }
        }
        public void addMusicToPlayQ(MediaItem media)
        {
            PlayQMusicList.addMusic(media);
        }
        #endregion

        #region Responsive
        private void Responsive()
        {
            List<string> list = new List<string>() { "Music library", "Video library", "Play queue", "Playlists", "Settings", "SoundCloud" };
            if (this.Width <= 1000)
            {
                siticoneTabControl1.TabButtonSize = new Size(55, 50);
                foreach (TabPage tab in siticoneTabControl1.TabPages)
                {
                    tab.Text = "";
                }
            }
            else
            {
                siticoneTabControl1.TabButtonSize = new Size(210, 50);
                for (int i = 0; i < siticoneTabControl1.TabPages.Count; i++)
                {
                    siticoneTabControl1.TabPages[i].Text = list[i];
                }
            }
            nameContainer.Width = siticoneTabControl1.TabButtonSize.Width;

            tabControlBorder.Location = new Point(siticoneTabControl1.TabButtonSize.Width, 0);
            tabControlBorder.Size = new Size(1, nameContainer.Height + siticoneTabControl1.Height);
        }

        private void form_ResizeEnd(object sender, EventArgs e)
        {
            Responsive();
            //siticoneTabControl1.Visible = true;
        }

        private void form_ResizeBegin(object sender, EventArgs e)
        {
            //siticoneTabControl1.Visible = false;
            //Responsive();
        }
        private void form_Resize(object sender, EventArgs e)
        {
            //Responsive();
            if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
            {
                //Responsive();
            }

        }
        #endregion

        #region Sort_Music

        private void sortBtn_Click(object sender, EventArgs e)
        {
            SiticoneButton btnSender = (SiticoneButton)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            sortByMenu.Width = sortBtn.Width;
            sortByMenu.Show(ptLowerLeft);

        }

        private void artistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.sortBy(MusicList.SORTBY.ARTIST);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Artist).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: Artist";
        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.sortBy(MusicList.SORTBY.AZ);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Title).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: A-Z";
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.sortBy(MusicList.SORTBY.GENRE);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Genre).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: Genre";
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.sortBy(MusicList.SORTBY.ALBUM);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Album).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: Album";

        }
        #endregion

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            siticoneTabControl1.BringToFront();
            visualizeContainer.Visible = false;
            tabControlBorder.BringToFront();

        }

        private void shuffleAndPlayBtn_Click(object sender, EventArgs e)
        {
            mediaController.LoadMusicList(musicList1, true);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            PlayQMusicList.Controls.Clear();
        }

        private void siticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
