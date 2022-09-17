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

            ColorTransitionB.ColorArray = new string[]
            { "#182cd4"
            , "#eeeeee"
            , "#c4fa6f"
            , "#3a3f47"
            }.Select(hex => ColorTranslator.FromHtml(hex)).ToArray();
            ColorTransitionB.Interval = 100;
            ColorTransitionB.AutoTransition = true;
            ColorTransitionB.StartColor = ColorTransitionB.ColorArray.First();
            ColorTransitionB.EndColor = ColorTransitionB.ColorArray.Last();

            ColorTransitionM.ColorArray = new string[]
            { "#06e19e"
            , "#02b3fc"
            , "#f8ce27"
            , "#063170"
            }.Select(hex => ColorTranslator.FromHtml(hex)).ToArray();
            ColorTransitionM.Interval = 100;
            ColorTransitionM.AutoTransition = true;
            ColorTransitionM.StartColor = ColorTransitionM.ColorArray.First();
            ColorTransitionM.EndColor = ColorTransitionM.ColorArray.Last();

            Visualizer.Interval = 1;
            Visualizer.ColorBase = ColorTransitionB.ColorArray.First();
            Visualizer.ColorMax = ColorTransitionM.ColorArray.First();

            Timer.Interval = 100;
            Timer.Tick += new EventHandler(Visualizer_Tick);

            Load += new EventHandler(MediaVisualizer_Load);
        }

        private void MediaVisualizer_Load(object sender, EventArgs e)
        {
            Visualizer.Start();
            Timer.Start();
        }

        private void Visualizer_Tick(object sender, EventArgs e)
        {
            Visualizer.ColorBase = ColorTransitionB.Value;
            Visualizer.ColorMax = ColorTransitionM.Value;
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

        public void Stop()
        {
            Visualizer.Stop();
            Timer.Stop();
        }

        private readonly Timer Timer = new Timer();

        //private Queue<(string, string)> ColorPalettes =
        //    new Queue<(string, string)>(
        //    new (string, string)[]
        //    { ("#fd2ea3", "#05eeff")
        //    , ("#fd2ea3", "#03c6e3")

        //    , ("#fe6fc5", "#05eeff")
        //    , ("#fe6fc5", "#03c6e3")

        //    , ("#fcadd8", "#05eeff")
        //    , ("#fcadd8", "#03c6e3")
        //    });
    }
}

