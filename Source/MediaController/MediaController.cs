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

namespace MyMediaPlayer
{
    public partial class MediaController : UserControl
    {
        public MediaController()
        {
            InitializeComponent();

            //MessageBox.Show(System.Threading.Thread.CurrentThread.IsThreadPoolThread.ToString());

            //Timer.Interval = 100;
            //Timer.Tick += new EventHandler(UpdateMediaController);
            Watcher.Interval = TimeSpan.FromMilliseconds(100);
            Watcher.Action = UpdateMediaController;

            TrackBar.Value = 0;

            Player.settings.volume = VolumeMeter.Value;

            TimeStamp.Hide();
            TimeStamp.BackColor = Common.White;
            TimeStamp.ForeColor = Common.White;

            Load += new EventHandler(MediaController_Load);

            #region Testing

            //Common.SetTimeout(() =>
            //{
            //    Watcher.Stop();
            //}, TimeSpan.FromSeconds(20));

            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += (sender, e) =>
            {
                if (Player.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    if (CurrentMusicList != null)
                        CurrentMusicList.PlayNext();
                }

                #region do not touch
                if (Player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
                {
                    MessageBox.Show("oh yeah");
                }
                #endregion
            };
            timer.Start();

            //Watcher watcher = new Watcher();
            //watcher.Interval = TimeSpan.FromMilliseconds(100);
            //watcher.Action = () =>
            //{
            //    if (Player.playState == WMPLib.WMPPlayState.wmppsStopped)
            //    {
            //        if (CurrentMusicList != null)
            //            CurrentMusicList.PlayNext();
            //    }
            //};
            //watcher.Start();

            //Common.SetTimeout(() =>
            //{
            //    Watcher.Action = UpdateMediaController;
            //    Watcher.Start();
            //}, TimeSpan.FromSeconds(30));

            #endregion
        }

        private void MediaController_Load(object sender, EventArgs e)
        {
            //Timer.Start();
            Watcher.Start();
        }

        private void PlayMedia()
        {
            Player.controls.play();
        }

        private void PauseMedia()
        {
            Player.controls.pause();
        }

        public void LoadMedia(string URL)
        {
            Player.currentMedia = Player.newMedia(URL);

            TrackBar.Value = 0;
            TrackBar.Minimum = 0;
            TrackBar.Maximum = Common.GetDurationInSeconds(URL);
            MediaTitle.Text = Common.GetTitle(URL);

            BtnPlay.Image = Properties.Resources.pause;

            GlobalReferences.MediaLyrics.GetLyrics(URL);

            OnLoadMedia(new MediaControllerArgs() { URL = URL }); // Đừng xóa dòng này
        }

        public async void LoadStreaming
        (string EncodeId, string Title, string ArtistsNames, string ImageURL, int Duration)
        {
            Player.currentMedia = Player.newMedia
            (GlobalReferences.OnlineStoreIntegration.GetBetterStreamingURL(EncodeId));

            TrackBar.Value = 0;
            TrackBar.Minimum = 0;
            TrackBar.Maximum = Duration;
            MediaTitle.Text = $"{ArtistsNames} - {Title}";

            BtnPlay.Image = Properties.Resources.pause;

            GlobalReferences.MediaLyrics.ParseStreamingLyrics
            (await GlobalReferences.OnlineStoreIntegration.GetLyrics(EncodeId, true));

            OnLoadMedia(new MediaControllerArgs()
            {
                EncodeId = EncodeId, Title = Title, ArtistsNames = ArtistsNames,
                ImageURL = ImageURL, Duration = Duration
            }); // Đừng xóa dòng này
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (Player.currentMedia != null)
            {
                //MessageBox.Show(Player.currentMedia.sourceURL, "Media");

                if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    BtnPlay.Image = Properties.Resources.black_play;
                    BtnPlay.ImageSize = new Size(40, 40);
                    PauseMedia();
                }
                else
                if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    BtnPlay.Image = Properties.Resources.pause;
                    BtnPlay.ImageSize = new Size(40, 40);
                    PlayMedia();
                }
                else
                if (Player.controls.currentPosition == 0)
                {
                    MessageBox.Show("Media Ended", "Info");
                    //BtnPlay.Text = "PLAY";
                    BtnPlay.Image = Properties.Resources.black_play;
                }
            }
            else
            {
                //BtnPlay.Text = "PLAY";
                MessageBox.Show("Media not found", "Error");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (CurrentMusicList != null)
                CurrentMusicList.PlayNext();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (CurrentMusicList != null)
                CurrentMusicList.PlayBack();
        }

        private void UpdateMediaController()
        {
            try
            {
                //MessageBox.Show(System.Threading.Thread.CurrentThread.IsThreadPoolThread.ToString());

                if (Player.controls.currentPosition < TrackBar.Minimum
                 || Player.controls.currentPosition > TrackBar.Maximum)
                    //TrackBar.Value = 0;
                    TrackBar.Invoke((MethodInvoker)delegate ()
                    {
                        TrackBar.Value = 0;
                    });
                else
                    //TrackBar.Value = (int)Player.controls.currentPosition;
                    TrackBar.Invoke((MethodInvoker)delegate ()
                    {
                        TrackBar.Value = (int)Player.controls.currentPosition;
                    });

                TimeSpan timeSpan = TimeSpan.FromSeconds(Player.controls.currentPosition);
                int Minutes = (int)(timeSpan.TotalSeconds / 60);
                int Seconds = (int)(timeSpan.TotalSeconds % 60);
                string currentMediaTime =
                (Minutes < 10 ? $"0{Minutes}" : Minutes.ToString())
                + " : " +
                (Seconds < 10 ? $"0{Seconds}" : Seconds.ToString());
                //DurationLabel.Text = currentMediaTime;
                DurationLabel.Invoke((MethodInvoker)delegate ()
                {

                    //MessageBox.Show(System.Threading.Thread.CurrentThread.IsThreadPoolThread.ToString());

                    DurationLabel.Text = currentMediaTime;
                });
            }
            catch //(Exception Error)
            {
                //if (Error.HResult != unchecked((int)0x8001010A))
                //    MessageBox.Show(Error.Message);
            }
        }

        private void BtnNext10s_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Player.controls.currentPosition += 10;

                #region Testing
                GlobalReferences.MediaLyrics.SkipCurrentIndex((int)Player.controls.currentPosition);
                #endregion
            }
        }

        private void BtnBack10s_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Player.controls.currentPosition -= 10;
                
                #region Testing
                GlobalReferences.MediaLyrics.BackCurrentIndex((int)Player.controls.currentPosition);
                #endregion
            }
        }

        private void TrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (Player.currentMedia != null)
                Player.controls.currentPosition = TrackBar.Value;

            #region Testing
            GlobalReferences.MediaLyrics.SkipCurrentIndex((int)Player.controls.currentPosition);
            GlobalReferences.MediaLyrics.BackCurrentIndex((int)Player.controls.currentPosition);
            #endregion
        }

        private void VolumeMeter_Scroll(object sender, ScrollEventArgs e)
        {
            Player.settings.volume = VolumeMeter.Value;
        }

        private void VolumeMeter_ValueChanged(object sender, EventArgs e)
        {
            Player.settings.volume = VolumeMeter.Value;
        }

        private void TrackBar_MouseMove(object sender, MouseEventArgs e)
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

            TimeStamp.Location = new Point
            (e.X - (TimeStamp.Size.Width / 2), 0);
            TimeStamp.Text = currentTimeStamp;
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
            //Timer.Stop();
            Watcher.Stop();
        }

        public void LoadMusicList(MusicList musicList, bool shuffleMode = false)
        {

            //MessageBox.Show($"{PlaylistName}, {PlaylistPath}");
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

        private static readonly WMPLib.WindowsMediaPlayer Player
                          = new WMPLib.WindowsMediaPlayer();

        //private static readonly Timer Timer = new Timer();
        private static readonly Watcher Watcher = new Watcher();

        /// <summary>
        /// Handle the user's custom event when MediaController use LoadMedia or LoadStreaming
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
            GlobalReferences.MainForm.bringVisualizeToFront();
        }

        public Task<bool> CheckIfRightTime(int TimeInSeconds)
        {
            return Task<bool>.Factory.StartNew(() =>
            {
                try
                {
                    Console.WriteLine($"{TimeInSeconds} - {Player.controls.currentPosition}");
                    return TimeInSeconds == (int)Player.controls.currentPosition;
                }
                catch
                {
                    return false;
                }
            });
        }

        //public enum Ordering
        //{
        //    EQ, 
        //    LT, 
        //    GT,
        //}
    }

    public class MediaControllerArgs
    {
        public string URL; public string EncodeId; public string Title;
        public string ArtistsNames; public string ImageURL; public int? Duration;
    }
}
