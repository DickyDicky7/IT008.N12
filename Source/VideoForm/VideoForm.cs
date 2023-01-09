using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class VideoForm : Form
    {
        public VideoForm(string VideoURL)
        {
            InitializeComponent();
        }

        private static Thread Thread;

        private static readonly AxWMPLib.AxWindowsMediaPlayer VideoPlayer =
                            new AxWMPLib.AxWindowsMediaPlayer();

        public static void LoadLocalVideo(string VideoURL)
        {
            Thread = new Thread(() =>
            {
                Application.Run(new VideoForm(VideoURL));
            });
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
        }
    }
}
