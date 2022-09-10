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
            lbl_media_title.Text = URL.Substring(20);
            picBox_media.ImageLocation = "C:\\Users\\User\\Pictures\\music.jpg";
        }

        public Action<object, EventArgs> MediaItem_Click
              (in object controller)
        {
            MediaController media_controller = (MediaController)controller;

            Action<object, EventArgs> ClickHandler =
        new Action<object, EventArgs>((sender, e) =>
            {
                media_controller.LoadMedia(URL);
            });
            return ClickHandler;
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        private readonly string URL;
    }
}
