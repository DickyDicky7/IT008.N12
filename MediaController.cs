using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            player.controls.play();
            btn_play.Text = "PAUSE";
        }

        private void PauseMedia()
        {
            player.controls.pause();
            btn_play.Text = "PLAY";
        }

        public void LoadMedia(string URL)
        {
            MediaController.URL = URL;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if  (URL != null)
            {
                player.URL = URL;
                PlayMedia();
                URL = null;
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PauseMedia();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                PlayMedia();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                player.URL = null;
            }
            else
            {
                MessageBox.Show("Media not found", "Error");
            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            player.controls.currentPosition += 10;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            player.controls.currentPosition -= 10;
        }

        private static WMPLib.WindowsMediaPlayer player
                 = new WMPLib.WindowsMediaPlayer();

        private static string URL = null;
    }
}
