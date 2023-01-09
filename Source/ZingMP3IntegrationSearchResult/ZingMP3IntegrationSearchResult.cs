using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class ZingMP3IntegrationSearchResult : UserControl
    {
        public ZingMP3IntegrationSearchResult
        (string EncodeId, string Title, string ArtistsNames, string ImageURL, int Duration)
        {
            InitializeComponent();
            this.EncodeId = EncodeId;
            this.Title = Title;
            this.ArtistsNames = ArtistsNames;
            this.ImageURL = ImageURL;
            this.Duration = Duration;
            PictureBox.ImageLocation = ImageURL;
            Panel.Text = $"{ArtistsNames} - {Title}";
            ImagePanel.BackgroundImage = PictureBox.Image;
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            GlobalReferences.MediaController.LoadStreamingTrack
            (EncodeId, Title, ArtistsNames, ImageURL, Duration);
            GlobalReferences.MainForm.BringVisualizeToFront();
        }

        private readonly string EncodeId;
        private readonly string Title;
        private readonly string ArtistsNames;
        private readonly string ImageURL;
        private readonly int Duration;
    }
}
