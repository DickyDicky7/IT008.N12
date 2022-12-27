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
    public partial class SearchResult : UserControl
    {
        public SearchResult(string ImageURL)
        {
            InitializeComponent();
            PictureBox.ImageLocation = ImageURL;
            this.BackgroundImage = PictureBox.Image;
        }
    }
}
