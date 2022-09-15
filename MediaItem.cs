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
    public partial class MediaItem : UserControl
    {
        public MediaItem(string URL)
        {
            InitializeComponent();
            this.URL = URL;
            Click += new EventHandler(MediaItem_Click);
            LabelMediaTitle.Text = URL.Substring(20);
            PicBoxMedia.ImageLocation = "C:\\Users\\User\\Pictures\\music.jpg";
        }

        private void MediaItem_Click(object sender, EventArgs e)
        {
            MediaController.LoadMedia(URL);
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control Control in Controls)
                {
                    Control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control Control in Controls)
                {
                    Control.Click -= value;
                }
            }
        }

        private readonly string URL;

        public static MediaController MediaController { get; set; }
    }
}
