using System;
using WMPLib;
using AxWMPLib;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using FluentTransitions;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class VideoForm : Form, INotifyPropertyChanged
    {
        public VideoForm()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Icon = Properties.Resources.icon;

            Player.uiMode = "none";
            Player.enableContextMenu = false;

            TrackBar.Top = -30;
            VolumeTrackBar.Top = -10;
        }

        public VideoForm(string VideoURL)
        {
            InitializeComponent();
            this.TopMost = true;
            this.Icon = Properties.Resources.icon;

            Player.uiMode = "none";
            Player.enableContextMenu = false;

            TrackBar.Top = -30;
            VolumeTrackBar.Top = -10;

            TrackBar.Maximum = Common.GetDurationInSeconds(VideoURL);

            this.Load += (sender, e) =>
            {
                Player.URL = VideoURL;
                Player.Ctlcontrols.play();
            };
        }

        public void LoadVideo(string VideoURL)
        {
            Player.URL = VideoURL;
            Player.Ctlcontrols.play();

            TrackBar.Maximum = Common.GetDurationInSeconds(VideoURL);
        }

        public static void RunVideoFormInAnotherThread(string VideoURL)
        {
            Thread Thread = new Thread(() =>
            {
                Application.Run(new VideoForm(VideoURL));
            });
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
        }

        private void VideoForm_SizeChanged(object sender, EventArgs e)
        {
            Player.Location = new Point(1, 30);
            Player.Size = new Size(this.Size.Width - 2, this.Size.Height - 31);
        }

        public double VideoCurrentPosition
        {
            get => Player.Ctlcontrols.currentPosition;
            set => Player.Ctlcontrols.currentPosition = value;
        }

        public int VideoCurrentSettingsVolume
        {
            get => Player.settings.volume;
            set
            {
                Player.settings.volume = value;
                PropertyChanged?.Invoke
                (this, new PropertyChangedEventArgs("VideoCurrentSettingsVolume"));
            }
        }

        public string VideoTitle
        {
            get => Player.currentMedia.name;
        }

        public WMPPlayState VideoPlayState
        {
            get => Player.playState;
        }

        public IWMPMedia VideoCurrentMedia
        {
            get => Player.currentMedia;
        }

        //public bool ShouldClose { get; set; } = true;

        private void Player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            //if (e.newState == (int)WMPPlayState.wmppsMediaEnded)
            //{
            //    if (ShouldClose)
            //    {
            //        this.Close();
            //    }
            //}
        }

        public void Stop()
        {
            this.Close();
            this.Dispose();
        }

        public Action VideoControlsPlay
        {
            get => Player.Ctlcontrols.play;
        }

        public Action VideoControlsPause
        {
            get => Player.Ctlcontrols.pause;
        }

        public Action VideoControlsStop
        {
            get => Player.Ctlcontrols.stop;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void VolumeTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            VideoCurrentSettingsVolume = VolumeTrackBar.Value;
        }

        private void VolumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            VideoCurrentSettingsVolume = VolumeTrackBar.Value;
        }

        private void MaximizeControlBox_Click(object sender, EventArgs e)
        {
            VolumeTrackBar.Value = VideoCurrentSettingsVolume;
            if (TrackBar.Top < 0)
            {
                Transition.With(TrackBar, "Top", 0)
                .Decelerate(TimeSpan.FromSeconds(0.25));
            }
            else
            {
                Transition.With(TrackBar, "Top", -30)
                .Decelerate(TimeSpan.FromSeconds(0.25));
            }
            if (VolumeTrackBar.Top < 0)
            {
                Transition.With(VolumeTrackBar, "Top", 10)
                .Decelerate(TimeSpan.FromSeconds(0.25));
            }
            else
            {
                Transition.With(VolumeTrackBar, "Top", -10)
                .Decelerate(TimeSpan.FromSeconds(0.25));
            }
        }

        private readonly Watcher Watcher = new Watcher();

        private void VideoForm_Load(object sender, EventArgs e)
        {
            Watcher.Interval = TimeSpan.FromMilliseconds(100);
            Watcher.Action = () =>
            {
                if (IsHandleCreated)
                {
                    TrackBar.BeginInvoke((MethodInvoker)delegate ()
                    {
                        TrackBar.Value = (int)VideoCurrentPosition;
                    });
                }
            };
            Watcher.Start();
        }

        private void VideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Watcher.Stop();
        }

        private void TrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            VideoCurrentPosition = TrackBar.Value;
        }

        private void Player_ClickEvent(object sender, _WMPOCXEvents_ClickEvent e)
        {
            if (VideoPlayState is WMPPlayState.wmppsPlaying)
            {
                VideoControlsPause();
            }
            else
            if (VideoPlayState is WMPPlayState.wmppsPaused)
            {
                VideoControlsPlay();
            }
        }
    }
}
