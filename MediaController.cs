using System;
using System.Linq;
using System.Text;
using System.Data;
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
        }

        private void PlayMedia()
        {
            Player.controls.play();
            BtnPlay.Text = "PAUSE";
        }

        private void PauseMedia()
        {
            Player.controls.pause();
            BtnPlay.Text = "PLAY";
        }

        public void LoadMedia(string URL)
        {
            Player.currentMedia = Player.newMedia(URL);
            BtnPlay.Text = "PAUSE";

            OnLoadMedia(URL); // Đừng xóa dòng này
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
                BtnPlay.Text = "PLAY";
                MessageBox.Show("Media not found", "Error");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Player.controls.currentPosition += 10;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Player.controls.currentPosition -= 10;
        }

        private static readonly WMPLib.WindowsMediaPlayer Player
                          = new WMPLib.WindowsMediaPlayer();

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
