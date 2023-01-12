using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TagLib;

namespace MyMediaPlayer.Source.VideoItem
{
    public partial class VideoItem : UserControl
    {
        private string URL = @"C:\Users\Admin\Videos\test.mp4";
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
