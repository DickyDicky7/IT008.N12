using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Threading;
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

            musicFolderPanel.ControlAdded += MusicFolderPanel_ControlAdded;
            musicFolderPanel.ControlRemoved += MusicFolderPanel_ControlRemoved;

            videosFolderPanel.ControlAdded += VideosFolderPanel_ControlAdded;
            videosFolderPanel.ControlRemoved += VideosFolderPanel_ControlRemoved;

            Common.RoundedCorner(this);
            Common.RoundedCorner(this.sortByMenu);

            this.sortBtn.AutoSize = true;
            this.shuffleAndPlayBtn.AutoSize = true;

            Responsive();
            DesignInit();

            Load += new EventHandler(MainForm_Load(args));
            FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

            #region Smol Testing

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
            GlobalReferences.PlaylistContextMenuStrip = PlaylistContextMenuStrip;

            this.Icon = Properties.Resources.icon;

            trackVisualizer.InteractMediaController(mediaController);

            #endregion

            Common.RoundedCorner(PlaylistContextMenuStrip);
            Common.RoundedCorner(AddToToolStripMenuItem.DropDown);

            musicFolderPanel.AutoScroll = true;
            videosFolderPanel.AutoScroll = true;

            Directory.GetFiles(Common.PlaylistsFolder, "*.wpl", SearchOption.TopDirectoryOnly)
            .ToList().ForEach(PlaylistURL =>
            {
                ToolStripMenuItem ToolStripMenuItem = new
                ToolStripMenuItem(Path.GetFileNameWithoutExtension(PlaylistURL));
                ToolStripMenuItem.Name = Path.GetFileNameWithoutExtension(PlaylistURL);
                ToolStripMenuItem.BackColor = Common.Gray;
                ToolStripMenuItem.ForeColor = Common.Black;
                ToolStripMenuItem.Click += ToolStripMenuItem_Click;
                AddToToolStripMenuItem.DropDownItems.Add(ToolStripMenuItem);
            });

            PlaylistsFolderWatcher.Error += PlaylistsFolderWatcher_Error;
            PlaylistsFolderWatcher.IncludeSubdirectories = false;
            PlaylistsFolderWatcher.EnableRaisingEvents = true;
            PlaylistsFolderWatcher.Filter = "*.wpl";
            PlaylistsFolderWatcher.NotifyFilter
            = NotifyFilters.DirectoryName
            | NotifyFilters.CreationTime
            | NotifyFilters.Attributes
            | NotifyFilters.LastAccess
            | NotifyFilters.LastWrite
            | NotifyFilters.Security
            | NotifyFilters.FileName
            | NotifyFilters.Size;


            #region Smol Testing

            Watcher Watcher = new Watcher();
            Watcher.Interval = TimeSpan.FromSeconds(10);
            Watcher.Action = () =>
            {
                //MessageBox.Show("Collect");
                System.GC.Collect();
            };
            Watcher.Start();
            //this.videoItemList.AutoScroll = true;
            #endregion
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SettingPageInit();
            PlaylistsFolderWatcher.Changed += PlaylistsFolderWatcher_Changed;
            PlaylistsFolderWatcher.Created += PlaylistsFolderWatcher_Created;
            PlaylistsFolderWatcher.Deleted += PlaylistsFolderWatcher_Deleted;
        }

        private async void MusicFolderPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            await Task.Run(() =>
            {
                Common.AudioFileExtensions.ForEach(FileExtension =>
                {
                    FileSystemWatcherService.Subscribe
                    (((FolderLocation)e.Control).FolderURL, FileExtension);

                    FileSystemWatcherService.Register(FileSystemWatcherService.Event.Created,
                    (_sender_, _e_) =>
                    {
                        if (IsHandleCreated)
                        {
                            musicList.BeginInvoke((MethodInvoker)delegate ()
                            {
                                musicList.Clear();
                                foreach (string MusicFolderURL in
                                Properties.Settings.Default.musicFolder)
                                {
                                    musicList.AddMusicFolder(MusicFolderURL);
                                }
                            });
                        }

                        #region Debug
                        //ModalBox.Show
                        //("", $"{((FolderLocation)e.Control).FolderURL} - {FileExtension} - Created");
                        #endregion

                    },
                    ((FolderLocation)e.Control).FolderURL, FileExtension);

                    FileSystemWatcherService.Register(FileSystemWatcherService.Event.Deleted,
                    (_sender_, _e_) =>
                    {
                        if (IsHandleCreated)
                        {
                            musicList.BeginInvoke((MethodInvoker)delegate ()
                            {
                                musicList.Clear();
                                foreach (string MusicFolderURL in
                                Properties.Settings.Default.musicFolder)
                                {
                                    musicList.AddMusicFolder(MusicFolderURL);
                                }
                            });
                        }

                        #region Debug
                        //ModalBox.Show
                        //("", $"{((FolderLocation)e.Control).FolderURL} - {FileExtension} - Deleted");
                        #endregion

                    },
                    ((FolderLocation)e.Control).FolderURL, FileExtension);
                });
            });
            await Task.Run(() =>
            {
                if (IsHandleCreated)
                {
                    musicList.BeginInvoke((MethodInvoker)delegate ()
                    {
                        musicList.AddMusicFolder(((FolderLocation)e.Control).FolderURL);
                    });
                }
            });
        }

        private async void MusicFolderPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            await Task.Run(() =>
            {
                Common.AudioFileExtensions.ForEach(FileExtension =>
                {
                    FileSystemWatcherService.Unsubscribe
                    (((FolderLocation)e.Control).FolderURL, FileExtension);
                });
            });
            await Task.Run(() =>
            {
                if (IsHandleCreated)
                {
                    musicList.BeginInvoke((MethodInvoker)delegate ()
                    {
                        musicList.Clear();
                        foreach (string MusicFolderURL in Properties.Settings.Default.musicFolder)
                        {
                            musicList.AddMusicFolder(MusicFolderURL);
                        }
                    });
                }
            });
        }

        private async void VideosFolderPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            await Task.Run(() =>
            {
                Common.VideoFileExtensions.ForEach(FileExtension =>
                {
                    FileSystemWatcherService.Subscribe
                    (((FolderLocation)e.Control).FolderURL, FileExtension);

                    FileSystemWatcherService.Register(FileSystemWatcherService.Event.Created,
                    (_sender_, _e_) =>
                    {
                        if (IsHandleCreated)
                        {
                            videoItemList.BeginInvoke((MethodInvoker)delegate ()
                            {
                                videoItemList.Clear();
                                foreach (string VideosFolderURL in
                                Properties.Settings.Default.videosFolder)
                                {
                                    videoItemList.AddVideosFolder(VideosFolderURL);
                                }
                            });
                        }

                        #region Debug
                        //ModalBox.Show
                        //("", $"{((FolderLocation)e.Control).FolderURL} - {FileExtension} - Created");
                        #endregion

                    },
                    ((FolderLocation)e.Control).FolderURL, FileExtension);

                    FileSystemWatcherService.Register(FileSystemWatcherService.Event.Deleted,
                    (_sender_, _e_) =>
                    {
                        if (IsHandleCreated)
                        {
                            videoItemList.BeginInvoke((MethodInvoker)delegate ()
                            {
                                videoItemList.Clear();
                                foreach (string VideosFolderURL in
                                Properties.Settings.Default.videosFolder)
                                {
                                    videoItemList.AddVideosFolder(VideosFolderURL);
                                }
                            });
                        }

                        #region Debug
                        //ModalBox.Show
                        //("", $"{((FolderLocation)e.Control).FolderURL} - {FileExtension} - Deleted");
                        #endregion

                    },
                    ((FolderLocation)e.Control).FolderURL, FileExtension);
                });
            });
            await Task.Run(() =>
            {
                if (IsHandleCreated)
                {
                    videoItemList.BeginInvoke((MethodInvoker)delegate ()
                    {
                        videoItemList.AddVideosFolder(((FolderLocation)e.Control).FolderURL);
                    });
                }
            });
        }

        private async void VideosFolderPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            await Task.Run(() =>
            {
                Common.VideoFileExtensions.ForEach(FileExtension =>
                {
                    FileSystemWatcherService.Unsubscribe
                    (((FolderLocation)e.Control).FolderURL, FileExtension);
                });
            });
            await Task.Run(() =>
            {
                if (IsHandleCreated)
                {
                    videoItemList.BeginInvoke((MethodInvoker)delegate ()
                    {
                        videoItemList.Clear();
                        foreach (string VideosFolderURL in Properties.Settings.Default.videosFolder)
                        {
                            videoItemList.AddVideosFolder(VideosFolderURL);
                        }
                    });
                }
            });
        }

        private FileSystemWatcher PlaylistsFolderWatcher =
            new FileSystemWatcher(Common.PlaylistsFolder);

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaController.AddToPlaylist(((ToolStripMenuItem)sender).Name
            , GlobalReferences.PlaylistContextMenuStripRecentMediaItem.URL);
            GlobalReferences.PlaylistContextMenuStripRecentMediaItem = null;
        }

        private void PlaylistsFolderWatcher_Error(object sender, ErrorEventArgs e)
        {
            Exception Error = e.GetException();
            ModalBox.Show("Error", $@"
            - {Error.Message}
            - {Error.HResult}
            - {Error.StackTrace}
            - .");
        }

        private void NewPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InputForm InputForm = new InputForm("Playlist's name"))
            {
                InputForm.ShowDialog();
                if (string.IsNullOrWhiteSpace(InputForm.Result)) return;
                if (!File.Exists($"{Common.PlaylistsFolder}\\{InputForm.Result}.wpl"))
                {
                    MediaController.CreatePlaylist(InputForm.Result);
                    if (playlistItemList.Controls.Find
                       ($"{Common.PlaylistsFolder}\\{InputForm.Result}.wpl", false).Length == 0)
                    {
                        playlistItemList.Add($"{Common.PlaylistsFolder}\\{InputForm.Result}.wpl");
                    }
                    MediaController.AddToPlaylist(InputForm.Result,
                    GlobalReferences.PlaylistContextMenuStripRecentMediaItem.URL);
                }
                else
                {
                    ModalBox.Show("Error", "Playlist exists!");
                }
            }
            GlobalReferences.PlaylistContextMenuStripRecentMediaItem = null;
        }

        private void PlaylistsFolderWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (IsHandleCreated)
            {
                playlistItemList.BeginInvoke((MethodInvoker)delegate ()
                {
                    if (playlistItemList.Controls.Find(e.FullPath, false).Length != 0)
                    {
                        ((PlaylistItem)
                        playlistItemList.Controls.Find(e.FullPath, false).First()).Render();
                    }
                });
            }
        }

        private void PlaylistsFolderWatcher_Created(object sender, FileSystemEventArgs e)
        {
            ToolStripMenuItem ToolStripMenuItem = new
            ToolStripMenuItem(Path.GetFileNameWithoutExtension(e.Name));
            ToolStripMenuItem.Name = Path.GetFileNameWithoutExtension(e.Name);
            ToolStripMenuItem.Click += ToolStripMenuItem_Click;
            ToolStripMenuItem.BackColor = Common.Gray;
            ToolStripMenuItem.ForeColor = Common.Black;
            if (IsHandleCreated)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    AddToToolStripMenuItem.DropDownItems.Add(ToolStripMenuItem);
                });
                playlistItemList.BeginInvoke((MethodInvoker)delegate ()
                {
                    if (playlistItemList.Controls.Find(e.FullPath, false).Length == 0)
                    {
                        playlistItemList.Add(e.FullPath);
                    }
                });
            }
        }

        private void PlaylistsFolderWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            if (IsHandleCreated)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    AddToToolStripMenuItem.DropDownItems
                    .RemoveByKey(Path.GetFileNameWithoutExtension(e.Name));
                });
                playlistItemList.BeginInvoke((MethodInvoker)delegate ()
                {
                    if (playlistItemList.Controls.Find(e.FullPath, false).Length != 0)
                    {
                        playlistItemList.Controls.Find(e.FullPath, false).First().Dispose();
                    }
                });
            }
        }

        private Action<object, EventArgs> MainForm_Load(string[] args)
        {
            Action<object, EventArgs> LoadHandler = new
            Action<object, EventArgs>((sender, e) =>
            {
                if (args.Length != 0)
                {
                    if (Common.AudioFileExtensions.Any
                       (FileExtension => args[0].EndsWith(FileExtension.Substring(1))))
                    {
                        BringVisualizeToFront();
                        mediaController.LoadLocalTrack(args[0]);
                    }
                    else
                    if (Common.VideoFileExtensions.Any
                       (FileExtension => args[0].EndsWith(FileExtension.Substring(1))))
                    {
                        mediaController.LoadLocalVideo(args[0]);
                    }
                    else
                    if (args[0].EndsWith(".wpl"))
                    {
                        PlaylistItem PlaylistItem = new PlaylistItem(args[0]);
                        mediaController.LoadMediaItemList(PlaylistItem);
                        PlaylistItem.PlayNext();
                    }
                }
            });
            return LoadHandler;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            trackVisualizer.Stop();
            mediaController.Stop();
            PlaylistsFolderWatcher.Dispose();
            PlaylistsFolderWatcher = null;
        }

        #region Initialize

        private void DesignInit()
        {
            this.SetStyle
            (
              ControlStyles.UserPaint
            | ControlStyles.AllPaintingInWmPaint
            | ControlStyles.OptimizedDoubleBuffer
            | ControlStyles.SupportsTransparentBackColor
            , true);
            tabControlBorder.BringToFront();
            visualizeContainer.Visible = false;
        }

        private void SettingPageInit()
        {
            List<string> ToRemoveList = new List<string>();

            if (!Properties.Settings.Default.musicFolder.Contains(Common.MusicFolder))
            {
                Properties.Settings.Default.musicFolder.Add(Common.MusicFolder);
                Properties.Settings.Default.Save();
            }
            foreach (string MusicFolderURL in Properties.Settings.Default.musicFolder)
            {
                if (Directory.Exists(MusicFolderURL))
                {
                    musicFolderPanel.Controls.Add
                    (new FolderLocation(MusicFolderURL, FolderLocation.Mode.Audio)
                    { Dock = DockStyle.Top, });
                }
                else
                {
                    ToRemoveList.Add(MusicFolderURL);
                }
            }
            ToRemoveList.ForEach(UnknownURL =>
            {
                Properties.Settings.Default.musicFolder.Remove(UnknownURL);
                Properties.Settings.Default.Save();
            });

            ToRemoveList.Clear();

            if (!Properties.Settings.Default.videosFolder.Contains(Common.VideosFolder))
            {
                Properties.Settings.Default.videosFolder.Add(Common.VideosFolder);
                Properties.Settings.Default.Save();
            }
            foreach (string VideosFolderURL in Properties.Settings.Default.videosFolder)
            {
                if (Directory.Exists(VideosFolderURL))
                {
                    videosFolderPanel.Controls.Add
                    (new FolderLocation(VideosFolderURL, FolderLocation.Mode.Video)
                    { Dock = DockStyle.Top, });
                }
                else
                {
                    ToRemoveList.Add(VideosFolderURL);
                }
            }
            ToRemoveList.ForEach(UnknownURL =>
            {
                Properties.Settings.Default.videosFolder.Remove(UnknownURL);
                Properties.Settings.Default.Save();
            });

            ToRemoveList.Clear();
            ToRemoveList = null;
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
            using (FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult DialogResult = FolderBrowserDialog.ShowDialog();

                if (DialogResult is DialogResult.OK
                && !string.IsNullOrWhiteSpace(FolderBrowserDialog.SelectedPath))
                {
                    if (!Properties.Settings.Default.musicFolder.Contains
                        (FolderBrowserDialog.SelectedPath))
                    {
                        Properties.Settings.Default.musicFolder.Add
                        (FolderBrowserDialog.SelectedPath);
                        Properties.Settings.Default.Save();

                        musicFolderPanel.Controls.Add
                        (new FolderLocation
                        (FolderBrowserDialog.SelectedPath, FolderLocation.Mode.Audio)
                        { Dock = DockStyle.Top, });
                    }
                }
            }
        }

        private void AddVideosFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult DialogResult = FolderBrowserDialog.ShowDialog();

                if (DialogResult is DialogResult.OK
                && !string.IsNullOrWhiteSpace(FolderBrowserDialog.SelectedPath))
                {
                    if (!Properties.Settings.Default.videosFolder.Contains
                        (FolderBrowserDialog.SelectedPath))
                    {
                        Properties.Settings.Default.videosFolder.Add
                        (FolderBrowserDialog.SelectedPath);
                        Properties.Settings.Default.Save();

                        videosFolderPanel.Controls.Add
                        (new FolderLocation
                        (FolderBrowserDialog.SelectedPath, FolderLocation.Mode.Video)
                        { Dock = DockStyle.Top, });
                    }
                }
            }
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
            musicList.SortBy(TrackItemList.SORTBY.ARTIST);
            sortBtn.Text = "Sort By: Artist";
        }

        private void AZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList.SortBy(TrackItemList.SORTBY.AZ);
            sortBtn.Text = "Sort By: A-Z";
        }

        private void GenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList.SortBy(TrackItemList.SORTBY.GENRE);
            sortBtn.Text = "Sort By: Genre";
        }

        private void AlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList.SortBy(TrackItemList.SORTBY.ALBUM);
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

        private void PlayQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Common.AudioFileExtensions.Any(FileExtension => Path.GetExtension
            (GlobalReferences.PlaylistContextMenuStripRecentMediaItem.URL) ==
            FileExtension.Substring(1)))
            {
                TrackItem TrackItem = new TrackItem
                (GlobalReferences.PlaylistContextMenuStripRecentMediaItem.URL)
                {
                    Width = ((TrackItem)GlobalReferences.PlaylistContextMenuStripRecentMediaItem).
                    Width,
                };
                PlayQMusicList.AddMusic(TrackItem);
            }
            GlobalReferences.PlaylistContextMenuStripRecentMediaItem = null;
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalReferences.PlaylistContextMenuStripRecentMediaItem.Play();
            GlobalReferences.PlaylistContextMenuStripRecentMediaItem = null;
        }
    }
}
