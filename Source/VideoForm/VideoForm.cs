using System;
using WMPLib;
using AxWMPLib;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class VideoForm : Form
    {
        public VideoForm()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Icon = Properties.Resources.icon;

            Player.uiMode = "none";
            Player.enableContextMenu = false;
        }

        public VideoForm(string VideoURL)
        {
            InitializeComponent();
            this.TopMost = true;
            this.Icon = Properties.Resources.icon;

            Player.uiMode = "none";
            Player.enableContextMenu = false;

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
            set => Player.settings.volume = value;
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
    }
}
