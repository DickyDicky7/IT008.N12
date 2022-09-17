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
            Visualizer.Interval = 1;
            Visualizer.Start();
            Timer.Interval = 5000;
            Timer.Tick += new EventHandler(Visualizer_Tick);
            Timer.Start();

            siticoneColorTransition1.ColorArray = new Color[2];
            siticoneColorTransition1.ColorArray[0] =
            ColorTranslator.FromHtml("#fd2ea3");
            siticoneColorTransition1.ColorArray[1] =
            ColorTranslator.FromHtml("#03c6e3");
            siticoneColorTransition1.AutoTransition = true;
            siticoneColorTransition1.Interval = 2000;
        }

        private void Visualizer_Tick(object sender, EventArgs e)
        {
            //Visualizer.ColorBase =
            //ColorTranslator.FromHtml(ColorPalettes.Peek().Item1);
            //Visualizer.ColorMax =
            //ColorTranslator.FromHtml(ColorPalettes.Peek().Item2);
            //ColorPalettes.Enqueue(ColorPalettes.Peek());
            //ColorPalettes.Dequeue();
            Visualizer.ColorBase = siticoneColorTransition1.Value;
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

        private Timer Timer = new Timer();
        private Queue<(string, string)> ColorPalettes =
            new Queue<(string, string)>(
            new (string, string)[]
            { ("#fd2ea3", "#05eeff")
            , ("#fd2ea3", "#03c6e3")

            , ("#fe6fc5", "#05eeff")
            , ("#fe6fc5", "#03c6e3")

            , ("#fcadd8", "#05eeff")
            , ("#fcadd8", "#03c6e3")
            });
    }
}

