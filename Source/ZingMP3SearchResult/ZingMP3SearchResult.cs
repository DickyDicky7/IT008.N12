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
    public partial class ZingMP3SearchResult : UserControl
    {
        public ZingMP3SearchResult
        (string EncodeId, string Title, string ArtistsNames, string ImageURL)
        {
            InitializeComponent();
            this.EncodeId = EncodeId;
            PictureBox.ImageLocation = ImageURL;
            Panel.Text = $"{ArtistsNames} - {Title}";
            ImagePanel.BackgroundImage = PictureBox.Image;
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            GlobalReferences.MediaController.LoadStreaming(EncodeId);
        }

        private readonly string EncodeId;
    }
}
