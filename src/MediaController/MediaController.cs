﻿using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using IT008.N12_015.src.Util;
using System.Collections.Generic;

namespace IT008.N12_015
{
    public partial class MediaController : UserControl
    {
        public MediaController()
        {
            InitializeComponent();

            //Timer.Interval = 100;
            //Timer.Tick += new EventHandler(UpdateMediaController);
            Watcher.Interval = TimeSpan.FromMilliseconds(100);
            Watcher.Action = UpdateMediaController;

            TrackBar.Value = 0;

            Load += new EventHandler(MediaController_Load);

            #region Testing

            //Common.SetTimeout(() =>
            //{
            //    Watcher.Stop();
            //}, TimeSpan.FromSeconds(20));

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

            // OnLoadMedia(URL); // Đừng xóa dòng này
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (Player.currentMedia != null)
            {
                //MessageBox.Show(Player.currentMedia.sourceURL, "Media");

                if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    BtnPlay.Image = global::IT008.N12_015.Properties.Resources.play;
                    BtnPlay.ImageSize = new System.Drawing.Size(40, 40);
                    PauseMedia();
                }
                else
                if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    BtnPlay.Image = global::IT008.N12_015.Properties.Resources.pause;
                    BtnPlay.ImageSize = new System.Drawing.Size(40, 40);
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

        private void UpdateMediaController()
        {
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
            string currentMediaTime = $"{timeSpan.Minutes} : {timeSpan.Seconds}";
            //DurationLabel.Text = currentMediaTime;
            DurationLabel.Invoke((MethodInvoker)delegate ()
            {
                DurationLabel.Text = currentMediaTime;
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
            //Timer.Stop();
            Watcher.Stop();
        }

        private static readonly WMPLib.WindowsMediaPlayer Player
                          = new WMPLib.WindowsMediaPlayer();

        //private static readonly Timer Timer = new Timer();
        private static readonly Watcher Watcher = new Watcher();

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
