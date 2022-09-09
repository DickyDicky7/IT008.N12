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

        private static bool trackOn = false;

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (btn_play.Text == "PLAY")
            {
                if (trackOn)
                {
                    player.controls.play();
                    btn_play.Text = "PAUSE";
                }
                else
                if (URL != null)
                {
                    player.URL = URL;
                    player.controls.play();
                    // MessageBox.Show("Media found", "Info");
                    btn_play.Text = "PAUSE";
                    trackOn = true;
                }
                else
                {
                    player.controls.stop();
                    MessageBox.Show("Media not found", "Error");
                    trackOn = false;
                }
            }
            else
            {
                player.controls.pause();
                btn_play.Text = "PLAY";
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

        public static string URL { get; set; } = null;
    }
}
