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
    public partial class ZingMP3IntegrationSearchResult : UserControl, IMediaItem
    {
        public ZingMP3IntegrationSearchResult
        (int Duration, string Title, string EncodeId, string ImageURL, string ArtistsNames)
        {
            InitializeComponent();
            this.Title = Title;
            this.EncodeId = EncodeId;
            this.ImageURL = ImageURL;
            this.Duration = Duration;
            this.ArtistsNames = ArtistsNames;
            PictureBox.ImageLocation = ImageURL;
            Panel.Text = $"{ArtistsNames} - {Title}";
            ImagePanel.BackgroundImage = PictureBox.Image;
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if ((ZingMP3IntegrationSearchResultList)this.Parent != null)
            {
                GlobalReferences.MediaController.LoadMediaItemList
                ((ZingMP3IntegrationSearchResultList)this.Parent);
                ((ZingMP3IntegrationSearchResultList)this.Parent)
                .UpdateCurrentIndex(this);
                GlobalReferences.MediaController.LoadStreamingTrack
                (EncodeId, Title, ArtistsNames, ImageURL, Duration);
                GlobalReferences.MainForm.BringVisualizeToFront();
            }
        }

        private readonly int Duration;
        private readonly string Title;
        private readonly string EncodeId;
        private readonly string ImageURL;
        private readonly string ArtistsNames;

        public Action Play => () =>
        GlobalReferences.MediaController.LoadStreamingTrack
        (EncodeId, Title, ArtistsNames, ImageURL, Duration);

        public UserControl UserControl => this;
        public EventHandler IMediaItem_Click => Panel_Click;
    }
}
