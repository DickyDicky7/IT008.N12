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
    public partial class MainForm : Form
    {
        public MainForm(string[] args)
        {
            InitializeComponent();

            Common.RoundedCorner(this);
            SettingPageInit();
            MusicPageInit();
            PlaylistPageInit();
            Responsive();
            DesignInit();

            Load += new EventHandler(MainForm_Load(args));

            #region Tuan Anh Testing

            this.DoubleBuffered = true;
            Common.SetDoubleBuffered_v2(this);
            Common.SetDoubleBuffered_v2(integrationSearchResultList);
            Common.SetDoubleBuffered_v2(musicLibraryTabPage);
            Common.SetDoubleBuffered_v2(videoLibraryTabPage);
            Common.SetDoubleBuffered_v2(onlineStoreTabPage);
            Common.SetDoubleBuffered_v2(playQueueTabPage);
            Common.SetDoubleBuffered_v2(playlistsTabPage);
            Common.SetDoubleBuffered_v2(settingsTabPage);

            onlineStoreIntegrationSearchBox.IntegrationSearchResultList =
            integrationSearchResultList;

            GlobalReferences.MainForm = this;
            GlobalReferences.TrackLyrics = trackLyrics;
            GlobalReferences.MediaController = mediaController;

            this.Icon = Properties.Resources.icon;

            trackVisualizer.InteractMediaController(mediaController);

            #endregion

            musicLabel.Click += (s, e) =>
            {
                TagLib.Mpeg4.File file = (TagLib.Mpeg4.File)TagLib.File.Create($"{Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)}\\sample-mp4-file.mp4");
                MessageBox.Show(file.Tag.Title);
                MessageBox.Show(Common.GetTitle($"{Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)}\\sample-mp4-file.mp4"));
                //GlobalReferences.MediaController.LoadLocalVideo("C:\\Users\\User\\Videos\\Pokémon Reborn- Elite 4 Battle Theme.mp4");
            };
        }

        private Action<object, EventArgs> MainForm_Load(string[] args)
        {
            Action<object, EventArgs> LoadHandler = new
            Action<object, EventArgs>((sender, e) =>
            {
                if (args.Length != 0)
                {
                    BringVisualizeToFront();
                    mediaController.LoadLocalTrack(args[0]);
                }
            });
            return LoadHandler;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            trackVisualizer.Stop();
            mediaController.Stop();
        }

        #region Initialize

        private void DesignInit()
        {
            this.SetStyle
            (ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer
            | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor
            , true);
            FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            tabControlBorder.BringToFront();
            visualizeContainer.Visible = false;
        }

        private void MusicPageInit()
        {
            Common.RoundedCorner(this.sortByMenu);
            this.shuffleAndPlayBtn.AutoSize = true;
            this.sortBtn.AutoSize = true;
            List<string> removeL = new List<string>();
            foreach (string URL in Properties.Settings.Default.musicFolder)
            {
                if (Directory.Exists(URL))
                    musicList.addMusicFolder(URL);
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

        private void SettingPageInit()
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

        private void PlaylistPageInit()
        {
            var fileArray = Directory.GetFiles(Common.PlaylistsFolder, "*.wpl");
            foreach (string file in fileArray)
            {
                PlaylistItem item = new PlaylistItem(file);
                AddPlaylistToPanel(item);
            }
        }

        public void BringVisualizeToFront()
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

        private void AddFolder_Click(object sender, EventArgs e)
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
                        musicList.addMusicFolder(fbd.SelectedPath);
                    }
                }
            }
        }

        public void AddMusicToPlayQ(TrackItem media)
        {
            PlayQMusicList.addMusic(media);
        }

        #endregion

        #region Responsive

        private void Responsive()
        {
            List<string> list = new List<string>()
            { "Music library", "Video library", "Play queue"
            , "Playlists", "Settings", "Online Store" };
            if (this.Width <= 1000)
            {
                tabControl.TabButtonSize = new Size(55, 50);
                foreach (TabPage tab in tabControl.TabPages)
                {
                    tab.Text = "";
                }
            }
            else
            {
                tabControl.TabButtonSize = new Size(210, 50);
                for (int i = 0; i < tabControl.TabPages.Count; i++)
                {
                    tabControl.TabPages[i].Text = list[i];
                }
            }
            nameContainer.Width = tabControl.TabButtonSize.Width;

            tabControlBorder.Location = new Point(tabControl.TabButtonSize.Width, 0);
            tabControlBorder.Size = new Size(1, nameContainer.Height + tabControl.Height);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            Responsive();
            //siticoneTabControl1.Visible = true;
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            //siticoneTabControl1.Visible = false;
            //Responsive();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //Responsive();
            if (WindowState == FormWindowState.Maximized
             || WindowState == FormWindowState.Normal)
            {
                //Responsive();
            }
        }

        #endregion

        #region Sort_Music

        private void SortBtn_Click(object sender, EventArgs e)
        {
            SiticoneButton btnSender = (SiticoneButton)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            sortByMenu.Width = sortBtn.Width;
            sortByMenu.Show(ptLowerLeft);
        }

        private void ArtistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList.sortBy(MusicList.SORTBY.ARTIST);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Artist).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort By: Artist";
        }

        private void AZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList.sortBy(MusicList.SORTBY.AZ);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Title).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort By: A-Z";
        }

        private void GenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList.sortBy(MusicList.SORTBY.GENRE);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Genre).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort By: Genre";
        }

        private void AlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList.sortBy(MusicList.SORTBY.ALBUM);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Album).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort By: Album";
        }

        #endregion

        private void ExitButton_Click(object sender, EventArgs e)
        {
            tabControl.BringToFront();
            visualizeContainer.Visible = false;
            tabControlBorder.BringToFront();
        }

        private void ShuffleAndPlayBtn_Click(object sender, EventArgs e)
        {
            mediaController.LoadMusicList(musicList, true);
        }

        private void PlayQueueClearButton_Click(object sender, EventArgs e)
        {
            PlayQMusicList.Controls.Clear();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
