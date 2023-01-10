using WMPLib;
using System;
using System.IO;
using System.Net;
using NAudio.Wave;
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
            VolumeMeter.Minimum = 0;
            VolumeMeter.Maximum = 100;
            VolumeMeter.Value = 50;
            OutputDevice.Volume = (float)VolumeMeter.Value / (float)100;

            TimeStamp.Hide();
            TimeStamp.BackColor = Common.White;
            TimeStamp.ForeColor = Common.White;

            Load += new EventHandler(MediaController_Load);

            OutputDevice.PlaybackStopped += (sender, e) =>
            {
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    CurrentMusicList?.PlayNext();
                }
            };

            MediaTitle.Text = string.Empty;
            DurationLabel.Text = "00 : 00";
        }

        private void MediaController_Load(object sender, EventArgs e)
        {
            Watcher.Start();
        }

        private void PlayLocalTrack(string MediaURL)
        {
            LocalAudioFile?.Dispose();
            LocalAudioFile = null;
            LocalAudioFile = new AudioFileReader(MediaURL);
            OutputDevice.Stop();
            OutputDevice.Init(LocalAudioFile);
            OutputDevice.Play();
        }

        private void ResumeTrack()
        {
            OutputDevice.Play();
        }

        private void PauseTrack()
        {
            OutputDevice.Pause();
        }

        private void RewindTrack()
        {
            if (IsStreaming && StreamingAudioFile != null)
            {
                StreamingAudioFile.Position = 0;
                OutputDevice.Play();
            }
            else
            if (LocalAudioFile != null)
            {
                LocalAudioFile.Position = 0;
                OutputDevice.Play();
            }
        }

        public void LoadLocalTrack(string TrackURL)
        {
            CurrentMediaControllerMode = MediaControllerMode.Audio;
            IsStreaming = false;
            PlayLocalTrack(TrackURL);
            TrackBar.Value = 0;
            TrackBar.Minimum = 0;
            TrackBar.Maximum = (int)LocalAudioFile.TotalTime.TotalSeconds;
            MediaTitle.Text = Common.GetTitle(TrackURL);
            BtnPlay.Image = Properties.Resources.pause;
            GlobalReferences.TrackLyrics.GetLyrics(TrackURL);
            OnLoadMedia(new MediaControllerArgs() { URL = TrackURL });
        }

        public async void LoadStreamingTrack
        (string EncodeId, string Title, string ArtistsNames, string ImageURL, int Duration)
        {
            CurrentMediaControllerMode = MediaControllerMode.Audio;
            IsStreaming = true;
            PlayStreamingTrack(EncodeId);
            TrackBar.Value = 0;
            TrackBar.Minimum = 0;
            TrackBar.Maximum = Duration;
            MediaTitle.Text = $"{ArtistsNames} - {Title}";
            BtnPlay.Image = Properties.Resources.pause;
            GlobalReferences.TrackLyrics.ParseStreamingLyrics
            (await GlobalReferences.OnlineStoreIntegration.GetLyrics(EncodeId, true));
            OnLoadMedia(new MediaControllerArgs()
            {
                EncodeId = EncodeId,
                Title = Title,
                ArtistsNames = ArtistsNames,
                ImageURL = ImageURL,
                Duration = Duration
            });
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (LocalAudioFile != null || StreamingAudioFile != null)
            {
                if (OutputDevice.PlaybackState == PlaybackState.Playing)
                {
                    BtnPlay.Image = Properties.Resources.black_play;
                    BtnPlay.ImageSize = new Size(40, 40);
                    PauseTrack();
                }
                else
                if (OutputDevice.PlaybackState == PlaybackState.Paused)
                {
                    BtnPlay.Image = Properties.Resources.pause;
                    BtnPlay.ImageSize = new Size(40, 40);
                    ResumeTrack();
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
            if (StreamingAudioFile != null || LocalAudioFile != null)
            {
                if (IsHandleCreated)
                {
                    TrackBar.BeginInvoke((MethodInvoker)delegate ()
                    {
                        TrackBar.Value = IsStreaming
                        ? (int)StreamingAudioFile.CurrentTime.TotalSeconds
                        : (int)LocalAudioFile.CurrentTime.TotalSeconds;
                    });
                }

                TimeSpan timeSpan = TimeSpan.FromSeconds(IsStreaming && StreamingAudioFile != null
                ? StreamingAudioFile.CurrentTime.TotalSeconds : LocalAudioFile != null
                ? LocalAudioFile.CurrentTime.TotalSeconds : 0);
                int Minutes = (int)(timeSpan.TotalSeconds / 60);
                int Seconds = (int)(timeSpan.TotalSeconds % 60);
                string currentMediaTime =
                (Minutes < 10 ? $"0{Minutes}" : Minutes.ToString())
                + " : " +
                (Seconds < 10 ? $"0{Seconds}" : Seconds.ToString());
                if (IsHandleCreated)
                {
                    DurationLabel.BeginInvoke((MethodInvoker)delegate ()
                    {
                        DurationLabel.Text = currentMediaTime;
                    });
                }
            }
        }

        private void BtnNext10s_Click(object sender, EventArgs e)
        {
            if (CurrentMediaControllerMode is MediaControllerMode.Audio)
            {
                if (OutputDevice.PlaybackState == PlaybackState.Playing
                 || OutputDevice.PlaybackState == PlaybackState.Paused)
                {
                    if (IsStreaming && StreamingAudioFile != null)
                        StreamingAudioFile.CurrentTime =
                        StreamingAudioFile.CurrentTime.Add(TimeSpan.FromSeconds(10));
                    else
                    if (LocalAudioFile != null)
                        LocalAudioFile.CurrentTime =
                        LocalAudioFile.CurrentTime.Add(TimeSpan.FromSeconds(10));
                }
            }
            else
            if (CurrentMediaControllerMode is MediaControllerMode.Video)
            {
                VideoForm.VideoCurrentPosition += 10;
            }
        }

        private void BtnBack10s_Click(object sender, EventArgs e)
        {
            if (OutputDevice.PlaybackState == PlaybackState.Playing
             || OutputDevice.PlaybackState == PlaybackState.Paused)
            {
                if (IsStreaming && StreamingAudioFile != null)
                    StreamingAudioFile.CurrentTime =
                    StreamingAudioFile.CurrentTime.Subtract(TimeSpan.FromSeconds(10));
                else
                if (LocalAudioFile != null)
                    LocalAudioFile.CurrentTime =
                    LocalAudioFile.CurrentTime.Subtract(TimeSpan.FromSeconds(10));
            }
        }

        private void TrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (OutputDevice.PlaybackState == PlaybackState.Playing
             || OutputDevice.PlaybackState == PlaybackState.Paused)
            {
                if (IsStreaming && StreamingAudioFile != null)
                    StreamingAudioFile.CurrentTime = TimeSpan.FromSeconds(TrackBar.Value);
                else
                if (LocalAudioFile != null)
                    LocalAudioFile.CurrentTime = TimeSpan.FromSeconds(TrackBar.Value);
            }
        }

        private void VolumeMeter_Scroll(object sender, ScrollEventArgs e)
        {
            OutputDevice.Volume = (float)VolumeMeter.Value / (float)100;
        }

        private void VolumeMeter_ValueChanged(object sender, EventArgs e)
        {
            OutputDevice.Volume = (float)VolumeMeter.Value / (float)100;
        }

        private void TrackBar_MouseMove(object sender, MouseEventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                float Time = (float)TrackBar.Maximum / (float)TrackBar.Size.Width;
                TimeSpan timeSpan =
                TimeSpan.FromSeconds(Time * (e.X - (TimeStamp.Size.Width / 2)) + 7);
                int Minutes = (int)(timeSpan.TotalSeconds / 60);
                int Seconds = (int)(timeSpan.TotalSeconds % 60);
                string currentTimeStamp =
                (Minutes < 10 ? $"0{Minutes}" : Minutes.ToString())
                + " : " +
                (Seconds < 10 ? $"0{Seconds}" : Seconds.ToString());

                if (IsHandleCreated)
                {
                    TimeStamp.BeginInvoke((MethodInvoker)delegate ()
                    {
                        TimeStamp.Location = new Point
                        (e.X - (TimeStamp.Size.Width / 2), 0);
                        TimeStamp.Text = currentTimeStamp;
                    });
                }
            });
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

            OutputDevice.Stop();
            OutputDevice.Dispose();

            LocalAudioFile?.Dispose();
            LocalAudioFile = null;

            StreamingAudioFile?.Dispose();
            StreamingAudioFile = null;

            PlaylistsController.close();
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
            PlaylistsController.playlistCollection.newPlaylist(PlaylistName);
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
                Stream = null;

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
                Stream = null;

                File.WriteAllText
                ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl", NewContent);

                GlobalReferences.MainForm.UpdatePlaylistItem
                ($"{Common.PlaylistsFolder}\\{PlaylistName}.wpl");
            }
        }

        private bool IsStreaming = false;
        private AudioFileReader LocalAudioFile;
        private Mp3FileReader StreamingAudioFile;
        private readonly Watcher Watcher = new Watcher();
        private readonly VideoForm VideoForm = new VideoForm();
        private readonly WaveOutEvent OutputDevice = new WaveOutEvent();
        private MediaControllerMode CurrentMediaControllerMode = MediaControllerMode.Audio;
        private readonly static WindowsMediaPlayer PlaylistsController = new WindowsMediaPlayer();

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
            get => IsStreaming && StreamingAudioFile != null ?
            (int)StreamingAudioFile.CurrentTime.TotalSeconds :
            LocalAudioFile != null ? (int)LocalAudioFile.CurrentTime.TotalSeconds : -1;
        }

        public void LoadLocalVideo(string VideoURL)
        {
            CurrentMediaControllerMode = MediaControllerMode.Video;
            VideoForm.Show();
            VideoForm.LoadVideo(VideoURL);
            MediaTitle.Text = VideoForm.VideoTitle;
        }

        public void PlayStreamingTrack(string EncodeId)
        {
            Task.Factory.StartNew(() =>
            {
                using (Stream LocalStream = new MemoryStream())
                {
                    using (Stream OnlineStream = WebRequest.Create
                    (GlobalReferences.OnlineStoreIntegration.GetBetterStreamingURL
                    (EncodeId)).GetResponse().GetResponseStream())
                    {
                        byte[] Buffer = new byte[32768]; int NumberOfBytesReaded;
                        while
                        ((NumberOfBytesReaded = OnlineStream.Read(Buffer, 0, Buffer.Length)) > 0)
                        {
                            LocalStream.Write(Buffer, 0, NumberOfBytesReaded);
                        }
                    }

                    LocalStream.Position = 0;
                    StreamingAudioFile?.Dispose();
                    StreamingAudioFile = null;
                    StreamingAudioFile = new Mp3FileReader(LocalStream);
                    using (WaveStream BlockAlignReductionStream = new BlockAlignReductionStream
                    (WaveFormatConversionStream.CreatePcmStream(StreamingAudioFile)))
                    {
                        OutputDevice.Stop();
                        OutputDevice.Init(BlockAlignReductionStream);
                        OutputDevice.Play();
                        while (OutputDevice.PlaybackState == PlaybackState.Playing
                            || OutputDevice.PlaybackState == PlaybackState.Paused)
                        {
                            System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(100));
                        }
                    }
                }
            });
        }

        public enum MediaControllerMode
        {
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
