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
            player.currentMedia = player.newMedia(URL);
            btn_play.Text = "PAUSE";
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (player.currentMedia != null)
            {
                MessageBox.Show(player.currentMedia.sourceURL, "Media");
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    PauseMedia();
                }
                else 
                if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    PlayMedia();
                }
                else
                if (player.controls.currentPosition == 0)
                {
                    MessageBox.Show("Media Ended", "Info");
                    // player.currentMedia. = null;
                    btn_play.Text = "PLAY";
                }
            }
            else
            {
                btn_play.Text = "PLAY";
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
    }
}
