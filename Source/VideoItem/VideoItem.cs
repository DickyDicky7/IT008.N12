using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class VideoItem : UserControl//, IMediaItem
    {
        private string URL = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)}\\Pokémon Reborn- Elite 4 Battle Theme.mp4";
        public VideoItem()
        {
            InitializeComponent();
            if (Common.GetImage(URL) == null)
            {
                ThumbnailBox.Image = Common.GetImage(URL);
            }
            else
            {
                ThumbnailBox.Image = null;
            }
            TitleLB.Text = Path.GetFileNameWithoutExtension(URL);
        }

        private void VideoItem_Play()
        {
            ChangeLabelColor(Color.FromArgb(186, 24, 27));
            if (PlayItem != null && PlayItem != this)
            {
                PlayItem.ChangeLabelColor(Color.Black);
            }
            PlayItem = this;
            GlobalReferences.MediaController.LoadLocalVideo(URL);
        }

        private void ChangeLabelColor(Color color)
        {
            TitleLB.ForeColor = color;
        }
        public static VideoItem PlayItem { get; set; }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalReferences.MediaController.LoadLocalVideo(URL);
        }
    }
}
