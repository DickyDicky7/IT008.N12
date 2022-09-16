using Common;
using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace IT008.N12_015
{
    public partial class MediaVisualizer : UserControl
    {
        public MediaVisualizer()
        {
            InitializeComponent();
        }

        private void MediaController_OnLoadMedia(string MediaURL)
        {
            MessageBox.Show("Load a new media");
            PictureBox.Image =
            Common.Common.GetImage
            ("C:\\Users\\User\\Music\\Waiting-For-You-MONO-Onionn.mp3");
        }

        public void InteractMediaController(MediaController MediaController)
        {
            MediaController.OnLoadMedia +=
            new MediaController.OnLoadMediaHandler(MediaController_OnLoadMedia);
        }
    }
}

