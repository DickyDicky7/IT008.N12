using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IT008.N12_015
{
    public partial class MediaController : UserControl
    {
        public MediaController()
        {
            InitializeComponent();
            
            Timer =
              new System.Threading.Timer(
              new System.Threading.TimerCallback(UpdateMediaController)
            , null
            , TimeSpan.FromMilliseconds(0)
            , TimeSpan.FromMilliseconds(1)
            );

            TrackBar.Value = 0;

            Load += new EventHandler(MediaController_Load);
        }

        private void MediaController_Load(object sender, EventArgs e)
        {

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

            // OnLoadMedia(URL); // Đừng xóa dòng này
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (Player.currentMedia != null)
            {
                MessageBox.Show(Player.currentMedia.sourceURL, "Media");
                if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    PauseMedia();
                }
                else
                if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    PlayMedia();
                }
                else
                if (Player.controls.currentPosition == 0)
                {
                    MessageBox.Show("Media Ended", "Info");
                    BtnPlay.Text = "PLAY";
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

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void UpdateMediaController(object State)
        {
            if (Player.controls.currentPosition < TrackBar.Minimum
             || Player.controls.currentPosition > TrackBar.Maximum)
                TrackBar.BeginInvoke((MethodInvoker)delegate ()
                {
                    TrackBar.Value = 0;
                });
            else
                TrackBar.BeginInvoke((MethodInvoker)delegate ()
                {
                    TrackBar.Value = (int)Player.controls.currentPosition;
                });
        }

        private void BtnNext10s_Click(object sender, EventArgs e)
        {
            Player.controls.currentPosition += 10;
        }

        private void BtnBack10s_Click(object sender, EventArgs e)
        {
            Player.controls.currentPosition -= 10;
        }

        private void TrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            Player.controls.currentPosition = TrackBar.Value;
        }

        private void VolumeMeter_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void VolumeMeter_ValueChanged(object sender, EventArgs e)
        {

        }

        public void Stop()
        {
            Timer.Change(
            System.Threading.Timeout.Infinite, 
            System.Threading.Timeout.Infinite);
        }
        private static readonly WMPLib.WindowsMediaPlayer Player
                          = new WMPLib.WindowsMediaPlayer();

        private readonly System.Threading.Timer Timer;

        /// <summary>
        /// Handle the user's custom event when MediaController use LoadMedia
        /// </summary>
        /// <param name="MediaURL">Media's file path</param>
        public delegate void OnLoadMediaHandler(string MediaURL);

        /// <summary>
        /// Entry for a custom OnLoadMediaHandler
        /// </summary>
        public event OnLoadMediaHandler OnLoadMedia;
    }
}
