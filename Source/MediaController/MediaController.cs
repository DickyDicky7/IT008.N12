using WMPLib;
using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using PlaylistsNET.Models;
using PlaylistsNET.Content;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class MediaController : UserControl
    {
        public MediaController()
        {
            InitializeComponent();

            Watcher.Interval = TimeSpan.FromMilliseconds(100);
            Watcher.Action = UpdateMediaController;

            TrackBar.Value = 0;

            Player.settings.volume = VolumeMeter.Value;

            TimeStamp.Hide();
            TimeStamp.BackColor = Common.White;
            TimeStamp.ForeColor = Common.White;

            Load += new EventHandler(MediaController_Load);

            Timer Timer = new Timer
            {
                Interval = 1
            };
            Timer.Tick += (sender, e) =>
            {
                if (CurrentMode is Mode.Audio)
                {
                    if (Player.playState == WMPPlayState.wmppsStopped)
                    {
                        if (CurrentPlayingMode is PlayingMode.Normal)
                        {
                            BtnPlay.Image = Properties.Resources.rewind;
                        }
                        else
                        if (CurrentPlayingMode is PlayingMode.Repeat)
                        {
                            Player.controls.play();
                        }
                        else
                        if (CurrentPlayingMode is PlayingMode.AutoPlayNext)
                        {
                            CurrentMediaItemList?.PlayNext();
                        }
                    }
                }
                else
                if (CurrentMode is Mode.Video)
                {
                    if (VideoForm.VideoPlayState == WMPPlayState.wmppsStopped)
                    {
                        if (CurrentPlayingMode is PlayingMode.Normal)
                        {
                            BtnPlay.Image = Properties.Resources.rewind;
                        }
                        else
                        if (CurrentPlayingMode is PlayingMode.Repeat)
                        {
                            VideoForm.VideoControlsPlay();
                        }
                        else
                        if (CurrentPlayingMode is PlayingMode.AutoPlayNext)
                        {
                            CurrentMediaItemList?.PlayNext();
                        }
                    }
                }
            };
            Timer.Start();

            CurrentMode = Mode.None;
            CurrentPlayingMode = PlayingMode.Normal;

            MediaTitle.Text = string.Empty;
            DurationLabel.Text = "00 : 00";
        }

        private void MediaController_Load(object sender, EventArgs e)
        {
            Watcher.Start();
        }

        //private void PlayMedia() { Player.controls.play(); }

        //private void PauseMedia() { Player.controls.pause(); }

        public void LoadLocalTrack(string URL)
        {
            if (VideoForm != null)
            {
                VideoForm.Stop();
                VideoForm = null;
                Player.settings.volume = VolumeMeter.Value;
            }

            CurrentMode = Mode.Audio;
            Player.currentMedia = Player.newMedia(URL);

            TrackBar.Value = 0;
            TrackBar.Minimum = 0;
            TrackBar.Maximum = Common.GetDurationInSeconds(URL);

            MediaTitle.Text = Common.GetTitle(URL);
            BtnPlay.Image = Properties.Resources.pause;
            GlobalReferences.TrackLyrics.GetLyrics(URL);
            OnLoadMedia(new MediaControllerArgs() { URL = URL });
        }

        public async void LoadStreamingTrack
        (string EncodeId, string Title, string ArtistsNames, string ImageURL, int Duration)
        {
            if (VideoForm != null)
            {
                VideoForm.Stop();
                VideoForm = null;
                Player.settings.volume = VolumeMeter.Value;
            }

            CurrentMode = Mode.Audio;
            Player.currentMedia = Player.newMedia
            (GlobalReferences.OnlineStoreIntegration.GetBetterStreamingURL(EncodeId));

            TrackBar.Value = 0;
            TrackBar.Minimum = 0;
            TrackBar.Maximum = Duration;

            BtnPlay.Image = Properties.Resources.pause;
            MediaTitle.Text = $"{ArtistsNames} - {Title}";
            GlobalReferences.TrackLyrics.ParseStreamingLyrics
            (await GlobalReferences.OnlineStoreIntegration.GetLyrics(EncodeId, true));
            OnLoadMedia(new MediaControllerArgs()
            {
                Title = Title,
                EncodeId = EncodeId,
                ImageURL = ImageURL,
                Duration = Duration,
                ArtistsNames = ArtistsNames,
            });
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (CurrentMode == Mode.Audio)
            {
                if (Player.currentMedia != null)
                {
                    if (Player.playState == WMPPlayState.wmppsPlaying)
                    {
                        Player.controls.pause();
                        BtnPlay.ImageSize = new Size(40, 40);
                        BtnPlay.Image = Properties.Resources.black_play;
                    }
                    else
                    if (Player.playState == WMPPlayState.wmppsPaused)
                    {
                        Player.controls.play();
                        BtnPlay.ImageSize = new Size(40, 40);
                        BtnPlay.Image = Properties.Resources.pause;
                    }
                    else
                    if (Player.playState == WMPPlayState.wmppsStopped)
                    {
                        if (CurrentPlayingMode is PlayingMode.Normal)
                        {
                            Player.controls.play();
                            BtnPlay.Image = Properties.Resources.pause;
                        }
                        else
                        {
                            ModalBox.Show("Info", "Media Ended");
                            BtnPlay.Image = Properties.Resources.black_play;
                        }
                    }
                }
                else
                {
                    ModalBox.Show("Error", "Media Not Found");
                }
            }
            else
            if (CurrentMode is Mode.Video)
            {
                if (VideoForm.VideoCurrentMedia != null)
                {
                    if (VideoForm.VideoPlayState == WMPPlayState.wmppsPlaying)
                    {
                        VideoForm.VideoControlsPause();
                        BtnPlay.ImageSize = new Size(40, 40);
                        BtnPlay.Image = Properties.Resources.black_play;
                    }
                    else
                    if (VideoForm.VideoPlayState == WMPPlayState.wmppsPaused)
                    {
                        VideoForm.VideoControlsPlay();
                        BtnPlay.ImageSize = new Size(40, 40);
                        BtnPlay.Image = Properties.Resources.pause;
                    }
                    else
                    if (VideoForm.VideoPlayState == WMPPlayState.wmppsStopped)
                    {
                        if (CurrentPlayingMode is PlayingMode.Normal)
                        {
                            VideoForm.VideoControlsPlay();
                            BtnPlay.Image = Properties.Resources.pause;
                        }
                        else
                        {
                            ModalBox.Show("Info", "Media Ended");
                            BtnPlay.Image = Properties.Resources.black_play;
                        }
                    }
                }
                else
                {
                    ModalBox.Show("Error", "Media Not Found");
                }
            }
            else
            {
                ModalBox.Show("Error", "Media Not Found");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            CurrentMediaItemList?.PlayNext();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CurrentMediaItemList?.PlayBack();
        }

        private void UpdateMediaController()
        {
            if (CurrentMode is Mode.Audio)
            {
                try
                {
                    if (Player.controls.currentPosition < TrackBar.Minimum
                     || Player.controls.currentPosition > TrackBar.Maximum)
                    {
                        if (IsHandleCreated)
                        {
                            TrackBar.BeginInvoke((MethodInvoker)delegate ()
                            {
                                TrackBar.Value = 0;
                            });
                        }
                    }
                    else
                    {
                        if (IsHandleCreated)
                        {
                            TrackBar.BeginInvoke((MethodInvoker)delegate ()
                            {
                                TrackBar.Value = (int)Player.controls.currentPosition;
                            });
                        }
                    }

                    TimeSpan TimeSpan = TimeSpan.FromSeconds(Player.controls.currentPosition);
                    int Minutes = (int)(TimeSpan.TotalSeconds / 60);
                    int Seconds = (int)(TimeSpan.TotalSeconds % 60);
                    string CurrentMediaTime =
                    (Minutes < 10 ? $"0{Minutes}" : Minutes.ToString())
                    + " : " +
                    (Seconds < 10 ? $"0{Seconds}" : Seconds.ToString());
                    if (IsHandleCreated)
                    {
                        DurationLabel.BeginInvoke((MethodInvoker)delegate ()
                        {
                            DurationLabel.Text = CurrentMediaTime;
                        });
                    }
                }
                catch (Exception Error)
                {
                    if (Error.HResult != unchecked((int)0x8001010A))
                        ModalBox.Show("Error", Error.Message);
                }
            }
            else
            if (CurrentMode is Mode.Video)
            {
                try
                {
                    if (VideoForm.VideoCurrentPosition < TrackBar.Minimum
                     || VideoForm.VideoCurrentPosition > TrackBar.Maximum)
                    {
                        if (IsHandleCreated)
                        {
                            TrackBar.BeginInvoke((MethodInvoker)delegate ()
                            {
                                TrackBar.Value = 0;
                            });
                        }
                    }
                    else
                    {
                        if (IsHandleCreated)
                        {
                            TrackBar.BeginInvoke((MethodInvoker)delegate ()
                            {
                                TrackBar.Value = (int)VideoForm.VideoCurrentPosition;
                            });
                        }
                    }

                    TimeSpan TimeSpan = TimeSpan.FromSeconds(VideoForm.VideoCurrentPosition);
                    int Minutes = (int)(TimeSpan.TotalSeconds / 60);
                    int Seconds = (int)(TimeSpan.TotalSeconds % 60);
                    string CurrentMediaTime =
                    (Minutes < 10 ? $"0{Minutes}" : Minutes.ToString())
                    + " : " +
                    (Seconds < 10 ? $"0{Seconds}" : Seconds.ToString());
                    if (IsHandleCreated)
                    {
                        DurationLabel.BeginInvoke((MethodInvoker)delegate ()
                        {
                            DurationLabel.Text = CurrentMediaTime;
                        });
                    }
                }
                catch (Exception Error)
                {
                    if (Error.HResult != unchecked((int)0x8001010A))
                        ModalBox.Show("Error", Error.Message);
                }
            }
        }

        private void BtnNext10s_Click(object sender, EventArgs e)
        {
            if (CurrentMode is Mode.Audio)
            {
                if (Player.playState == WMPPlayState.wmppsPlaying
                 || Player.playState == WMPPlayState.wmppsPaused)
                {
                    Player.controls.currentPosition += 10;
                }
            }
            else
            if (CurrentMode is Mode.Video)
            {
                if (VideoForm.VideoPlayState == WMPPlayState.wmppsPlaying
                 || VideoForm.VideoPlayState == WMPPlayState.wmppsPaused)
                {
                    VideoForm.VideoCurrentPosition += 10;
                }
            }
        }

        private void BtnBack10s_Click(object sender, EventArgs e)
        {
            if (CurrentMode is Mode.Audio)
            {
                if (Player.playState == WMPPlayState.wmppsPlaying
                 || Player.playState == WMPPlayState.wmppsPaused)
                {
                    Player.controls.currentPosition -= 10;
                }
            }
            else
            if (CurrentMode is Mode.Video)
            {
                if (VideoForm.VideoPlayState == WMPPlayState.wmppsPlaying
                 || VideoForm.VideoPlayState == WMPPlayState.wmppsPaused)
                {
                    VideoForm.VideoCurrentPosition -= 10;
                }
            }
        }

        private void TrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (CurrentMode is Mode.Audio)
            {
                if (Player.currentMedia != null)
                    Player.controls.currentPosition = TrackBar.Value;
            }
            else
            if (CurrentMode is Mode.Video)
            {
                if (VideoForm.VideoCurrentMedia != null)
                    VideoForm.VideoCurrentPosition = TrackBar.Value;
            }
        }

        private void VolumeMeter_Scroll(object sender, ScrollEventArgs e)
        {
            if (CurrentMode is Mode.Audio || CurrentMode is Mode.None)
            {
                Player.settings.volume = VolumeMeter.Value;
            }
            else
            if (CurrentMode is Mode.Video)
            {
                VideoForm.VideoCurrentSettingsVolume = VolumeMeter.Value;
            }
        }

        private void VolumeMeter_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentMode is Mode.Audio || CurrentMode is Mode.None)
            {
                Player.settings.volume = VolumeMeter.Value;
            }
            else
            if (CurrentMode is Mode.Video)
            {
                VideoForm.VideoCurrentSettingsVolume = VolumeMeter.Value;
            }
        }

        private void TrackBar_MouseMove(object sender, MouseEventArgs e)
        {
            float Time = (float)TrackBar.Maximum / (float)TrackBar.Size.Width;
            TimeSpan TimeSpan =
            TimeSpan.FromSeconds(Time * (e.X - (TimeStamp.Size.Width / 2)) + 7);
            int Minutes = (int)(TimeSpan.TotalSeconds / 60);
            int Seconds = (int)(TimeSpan.TotalSeconds % 60);
            string CurrentTimeStamp =
            (Minutes < 10 ? $"0{Minutes}" : Minutes.ToString())
            + " : " +
            (Seconds < 10 ? $"0{Seconds}" : Seconds.ToString());

            TimeStamp.Location = new Point(e.X - (TimeStamp.Size.Width / 2), 0);
            TimeStamp.Text = CurrentTimeStamp;
        }

        private void TrackBar_MouseHover(object sender, EventArgs e)
        {
            TimeStamp.Show();
            FluentTransitions.Transition
            .With(TimeStamp, "BackColor", Common.LightRed)
            .With(TimeStamp, "ForeColor", Common.White)
            .Decelerate(TimeSpan.FromSeconds(0.3));
        }

        private async void TrackBar_MouseLeave(object sender, EventArgs e)
        {
            FluentTransitions.Transition
            .With(TimeStamp, "BackColor", Common.White)
            .With(TimeStamp, "ForeColor", Common.White)
            .Decelerate(TimeSpan.FromSeconds(0.3));
            await Task.Delay(TimeSpan.FromSeconds(0.3));
            TimeStamp.Hide();
        }

        public void Stop()
        {
            Watcher.Stop();
        }

        public void LoadMediaItemList(IMediaItemList MediaItemList)
        {
            CurrentMediaItemList?.Stop();
            CurrentMediaItemList = MediaItemList;
        }

        public void LoadMediaItemListWithShuffle(IMediaItemList MediaItemList)
        {
            CurrentMediaItemList?.Stop();
            CurrentMediaItemList = MediaItemList;
            CurrentMediaItemList.GenerateShuffleList();
            CurrentMediaItemList.PlayNext();
        }

        public static void CreatePlaylist(string PlaylistName)
        {
            Player.playlistCollection.newPlaylist(PlaylistName);
        }

        public static void AddToPlaylist(string PlaylistName, string TrackURL)
        {
            Task.Run(() =>
            {
                if (File.Exists($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl"))
                {
                    WplContent Content = new WplContent();
                    WplPlaylist Playlist = Content.GetFromString
                    (File.ReadAllText($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl"));
                    Playlist.PlaylistEntries.Add(new WplPlaylistEntry() { Path = TrackURL });

                    File.WriteAllText
                    ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl", Content.ToText(Playlist));
                }
            });
        }

        public static void RemoveFromPlaylist(string PlaylistName, string TrackURL)
        {
            Task.Run(() =>
            {
                if (File.Exists($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl"))
                {
                    WplContent Content = new WplContent();
                    WplPlaylist Playlist = Content.GetFromString
                    (File.ReadAllText($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl"));

                    int Index = Playlist.PlaylistEntries.FindIndex
                    ((Item) => { return Item.Path == TrackURL; });
                    if (Index >= 0) Playlist.PlaylistEntries.RemoveAt(Index);

                    File.WriteAllText
                    ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl", Content.ToText(Playlist));
                }
            });
        }

        public static void RenamePlaylist(string PlaylistName, string NewPlaylistName)
        {
            Task.Run(() =>
            {
                if (File.Exists($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl"))
                {
                    GlobalReferences.IsMySemaphore = true;

                    File.Move
                    ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl",
                     $"{Common.PlaylistsFolder}\\{NewPlaylistName}.wpl");

                    GlobalReferences.RenamePlaylistSemaphore.WaitOne();

                    GlobalReferences.IsMySemaphore = false;

                    WplContent Content = new WplContent();
                    WplPlaylist Playlist = Content.GetFromString
                    (File.ReadAllText($"{Common.PlaylistsFolder}\\{NewPlaylistName}.wpl"));

                    Playlist.Title = NewPlaylistName;

                    File.WriteAllText
                    ($"{Common.PlaylistsFolder}\\{NewPlaylistName}.wpl", Content.ToText(Playlist));
                }
            });
        }

        private static Mode CurrentMode;
        private static VideoForm VideoForm;
        private static PlayingMode CurrentPlayingMode;
        private static IMediaItemList CurrentMediaItemList;
        private static readonly Watcher Watcher = new Watcher();
        private static readonly WindowsMediaPlayer Player = new WindowsMediaPlayer();

        /// <summary>
        /// Handle the user's custom event when MediaController use LoadLocalTrack or LoadStreamingTrack
        /// </summary>
        /// <param name="MediaControllerArgs">Consist of URL; EncodeId; Title; ArtistsNames; ImageURL; Duration</param>
        public delegate void OnLoadMediaHandler(MediaControllerArgs MediaControllerArgs);

        /// <summary>
        /// Entry for a custom OnLoadMediaHandler
        /// </summary>
        public event OnLoadMediaHandler OnLoadMedia;

        private void MediaTitle_Click(object sender, EventArgs e)
        {
            GlobalReferences.MainForm.BringVisualizeToFront();
        }

        public int TrackCurrentTimeInSeconds
        {
            get
            {
                try
                {
                    return (int)Player.controls.currentPosition;
                }
                catch (Exception Error)
                {
                    if (Error.HResult != unchecked((int)0x8001010A))
                    {
                        ModalBox.Show("Error", Error.Message);
                        throw Error;
                    }
                    else return -1;
                }
            }
        }

        public void LoadLocalVideo(string VideoURL)
        {
            if (VideoForm != null)
            {
                VideoForm.Stop();
                VideoForm = null;
            }

            if (Player.currentMedia != null)
            {
                CurrentMode = Mode.None;
                Player.controls.stop();
            }

            TrackBar.Value = 0;
            TrackBar.Minimum = 0;
            TrackBar.Maximum = Common.GetDurationInSeconds(VideoURL);

            VideoForm = new VideoForm();
            VideoForm.LoadVideo(VideoURL);

            CurrentMode = Mode.Video;
            BtnPlay.Image = Properties.Resources.pause;
            MediaTitle.Text = VideoForm.VideoCurrentMedia.name;

            VideoForm.Show();
            VideoForm.FormClosing += (sender, e) =>
            {
                CurrentMode = Mode.None;
                VolumeMeter.DataBindings.Clear();
            };
            VideoForm.VideoCurrentSettingsVolume = VolumeMeter.Value;

            VolumeMeter.DataBindings.Clear();
            VolumeMeter.DataBindings.Add("Value", VideoForm
            , "VideoCurrentSettingsVolume", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public enum Mode
        {
            None,
            Audio,
            Video,
        }

        private void BtnPlayingMode_Click(object sender, EventArgs e)
        {
            if (CurrentPlayingMode is PlayingMode.Normal)
            {
                CurrentPlayingMode = PlayingMode.Repeat;
                BtnPlayingMode.Image = Properties.Resources.repeat_one;
                //if (CurrentMode is Mode.Video) VideoForm.ShouldClose = false;
            }
            else
            if (CurrentPlayingMode is PlayingMode.Repeat)
            {
                CurrentPlayingMode = PlayingMode.AutoPlayNext;
                BtnPlayingMode.Image = Properties.Resources.auto_play;
                //if (CurrentMode is Mode.Video) VideoForm.ShouldClose = false;
            }
            else
            if (CurrentPlayingMode is PlayingMode.AutoPlayNext)
            {
                CurrentPlayingMode = PlayingMode.Normal;
                BtnPlayingMode.Image = Properties.Resources.normal;
                //if (CurrentMode is Mode.Video) VideoForm.ShouldClose = true;
            }
            BtnPlayingMode_MouseEnter(null, null);
        }

        public enum PlayingMode
        {
            Normal,
            Repeat,
            AutoPlayNext,
        }

        private void BtnPlayingMode_MouseEnter(object sender, EventArgs e)
        {
            PlayingModeToolTip.Show($"Playing Mode: {CurrentPlayingMode}", BtnPlayingMode, 40, 45);
        }

        private void BtnPlayingMode_MouseLeave(object sender, EventArgs e)
        {
            PlayingModeToolTip.Hide(BtnPlayingMode);
        }
    }

    public class MediaControllerArgs
    {
        public string URL; public string EncodeId; public string Title;
        public string ArtistsNames; public string ImageURL; public int? Duration;
    }
}
