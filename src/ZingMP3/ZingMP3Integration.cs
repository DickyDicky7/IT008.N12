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
    public partial class ZingMP3Integration : UserControl
    {
        public ZingMP3Integration()
        {
            InitializeComponent();

            SoundCloudTabPage.ImageIndex = 8;
            SoundCloudTabPage.Text = "SoundCloud";

            SoundCloudTabPage.BackColor = Color.Gray;
            SoundCloudTabPage.Controls.Add(new SearchBox());
        }

        public TabPage SoundCloudTabPage = new TabPage();
    }
}
