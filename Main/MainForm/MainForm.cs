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
using System.Security.Policy;
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
            VideoPageInit();
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

            if (!Directory.Exists(Common.MusicFolder))
            {
                Directory.CreateDirectory(Common.MusicFolder);
            }

            if (!Directory.Exists(Common.PlaylistsFolder))
            {
                Directory.CreateDirectory(Common.PlaylistsFolder);
            }

            GlobalReferences.PlaylistsFolderWatcher.EnableRaisingEvents = true;
            GlobalReferences.PlaylistsFolderWatcher.NotifyFilter
            = NotifyFilters.DirectoryName
            | NotifyFilters.CreationTime
            | NotifyFilters.Attributes
            | NotifyFilters.LastAccess
            | NotifyFilters.LastWrite
            | NotifyFilters.Security
            | NotifyFilters.FileName
            | NotifyFilters.Size;

            musicFolderPanel.AutoScroll = true;
            videosFolderPanel.AutoScroll = true;
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
                    musicList.AddMusicFolder(URL);
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

        private void VideoPageInit()
        {
            List<string> ToRemove = new List<string>();
            foreach (string VideosFolderURL in Properties.Settings.Default.videosFolder)
            {
                if (Directory.Exists(VideosFolderURL))
                {
                    videoItemList.AddVideosFolder(VideosFolderURL);
                }
                else
                {
                    ToRemove.Add(VideosFolderURL);
                }
            }
            ToRemove.ForEach(Item =>
            {
                Properties.Settings.Default.videosFolder.Remove(Item);
                Properties.Settings.Default.Save();
            });
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
                FolderLocation musicFolder = new FolderLocation(URL, FolderLocation.Mode.Audio);
                musicFolder.Dock = DockStyle.Top;
                musicFolderPanel.Controls.Add(musicFolder);
            }

            if (!Properties.Settings.Default.videosFolder.Contains(Common.VideosFolder))
            {
                Properties.Settings.Default.videosFolder.Add(Common.VideosFolder);
                Properties.Settings.Default.Save();
            }
            foreach (string VideosFolderURL in Properties.Settings.Default.videosFolder)
            {
                videosFolderPanel.Controls.Add(new FolderLocation(VideosFolderURL, FolderLocation.Mode.Video)
                {
                    Dock = DockStyle.Top,
                });
            }
        }

        public void BringVisualizeToFront()
        {
            visualizeContainer.Visible = true;
            visualizeContainer.BringToFront();
            tabControlBorder.SendToBack();
        }

        #endregion

        #region Add_Music_Videos

        private void AddMusicFolder_Click(object sender, EventArgs e)
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
                        FolderLocation folderLocation = new FolderLocation(fbd.SelectedPath, FolderLocation.Mode.Audio);
                        folderLocation.Dock = DockStyle.Top;
                        musicFolderPanel.Controls.Add(folderLocation);
                        musicList.AddMusicFolder(fbd.SelectedPath);
                    }
                }
            }
        }

        private void AddVideosFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (Properties.Settings.Default.videosFolder.Contains(fbd.SelectedPath) == false)
                    {
                        Properties.Settings.Default.videosFolder.Add(fbd.SelectedPath);
                        Properties.Settings.Default.Save();
                        FolderLocation folderLocation = new FolderLocation(fbd.SelectedPath, FolderLocation.Mode.Video);
                        folderLocation.Dock = DockStyle.Top;
                        videosFolderPanel.Controls.Add(folderLocation);
                        videoItemList.AddVideosFolder(fbd.SelectedPath);
                    }
                }
            }
        }

        public void AddMusicToPlayQ(TrackItem media)
        {
            PlayQMusicList.AddMusic(media);
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
            musicList.sortBy(TrackItemList.SORTBY.ARTIST);
            sortBtn.Text = "Sort By: Artist";
        }

        private void AZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList.sortBy(TrackItemList.SORTBY.AZ);
            sortBtn.Text = "Sort By: A-Z";
        }

        private void GenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList.sortBy(TrackItemList.SORTBY.GENRE);
            sortBtn.Text = "Sort By: Genre";
        }

        private void AlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList.sortBy(TrackItemList.SORTBY.ALBUM);
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
            mediaController.LoadMediaItemListWithShuffle(musicList);
        }

        private void PlayQueueClearButton_Click(object sender, EventArgs e)
        {
            PlayQMusicList.Clear();
        }
    }
}
