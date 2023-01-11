using WMPLib;
using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using PlaylistsNET.Models;
using PlaylistsNET.Content;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows;

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
                if (Player.playState == WMPPlayState.wmppsStopped)
                {
                    if (CurrentMode is Mode.Audio)
                        CurrentMusicList?.PlayNext();
                }

                if (Player.playState == WMPPlayState.wmppsMediaEnded)
                {
                    ModalBox.Show("Info", "Media Ended");
                }
            };
            Timer.Start();

            CurrentMode = Mode.None;
        }

        private void MediaController_Load(object sender, EventArgs e)
        {
            Watcher.Start();
        }

        private void PlayMedia() { Player.controls.play(); }

        private void PauseMedia() { Player.controls.pause(); }

        public void LoadLocalTrack(string URL)
        {
            if (VideoForm != null)
            {
                VideoForm.Stop();
                VideoForm = null;
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
            if (Player.currentMedia != null)
            {
                if (Player.playState == WMPPlayState.wmppsPlaying)
                {
                    BtnPlay.Image = Properties.Resources.black_play;
                    BtnPlay.ImageSize = new Size(40, 40);
                    PauseMedia();
                }
                else
                if (Player.playState == WMPPlayState.wmppsPaused)
                {
                    BtnPlay.Image = Properties.Resources.pause;
                    BtnPlay.ImageSize = new Size(40, 40);
                    PlayMedia();
                }
                else
                if (Player.controls.currentPosition == 0)
                {
                    BtnPlay.Image = Properties.Resources.black_play;
                    ModalBox.Show("Info", "Media Ended");
                }
            }
            else
            {
                ModalBox.Show("Error", "Media Not Found");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            CurrentMusicList?.PlayNext();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CurrentMusicList?.PlayBack();
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
            if (CurrentMode is Mode.Audio)
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
            if (CurrentMode is Mode.Audio)
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

        public void LoadMusicList(MusicList musicList, bool shuffleMode = false)
        {
            if (CurrentMusicList != null && CurrentMusicList != musicList)
                CurrentMusicList.Stop();
            CurrentMusicList = musicList;
            CurrentMusicList.shuffleMode = shuffleMode;
            if (shuffleMode == true)
            {
                CurrentMusicList.GenShuffleList();
            }
            CurrentMusicList.PlayNext();
        }

        public static void CreatePlaylist(string PlaylistName)
        {
            Player.playlistCollection.newPlaylist(PlaylistName);
        }

        public static void AddToPlaylist(string PlaylistName, string TrackURL)
        {
            if (File.Exists($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl"))
            {
                Stream Stream = File.OpenRead
                ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl");

                WplContent Content = new WplContent();
                WplPlaylist Playlist = Content.GetFromStream(Stream);
                Playlist.PlaylistEntries
                .Add(new WplPlaylistEntry() { Path = TrackURL });
                string NewContent = Content.ToText(Playlist);

                Stream.Dispose();

                File.WriteAllText
                ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl", NewContent);

                GlobalReferences.MainForm.UpdatePlaylistItem
                ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl");
            }
        }

        public static void RemoveFromPlaylist(string PlaylistName, string TrackURL)
        {
            if (File.Exists($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl"))
            {
                Stream Stream = File.OpenRead
                ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl");

                WplContent Content = new WplContent();
                WplPlaylist Playlist = Content.GetFromStream(Stream);
                int Index = Playlist.PlaylistEntries
                .FindIndex((Item) =>
                {
                    return Item.Path == TrackURL;
                });
                if (Index >= 0)
                    Playlist.PlaylistEntries.RemoveAt(Index);
                string NewContent = Content.ToText(Playlist);

                Stream.Dispose();

                File.WriteAllText
                ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl", NewContent);

                GlobalReferences.MainForm.UpdatePlaylistItem
                ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl");
            }
        }

        private static Mode CurrentMode;
        private static VideoForm VideoForm;
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

        private static MusicList CurrentMusicList;

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
            VideoForm.FormClosing += (sender, e) => { CurrentMode = Mode.None; };
        }

        public enum Mode
        {
            None,
            Audio,
            Video,
        }
    }

    public class MediaControllerArgs
    {
        public string URL; public string EncodeId; public string Title;
        public string ArtistsNames; public string ImageURL; public int? Duration;
    }
}
