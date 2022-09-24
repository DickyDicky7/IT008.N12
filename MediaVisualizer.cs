using CSCore;
using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

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
            if (MediaURL != null)
            {
                Invoke(new Action(() =>
                {
                    PictureBox.Left = -PictureBox.Size.Width;
                    PictureBox.Image = Common.GetImage(MediaURL);
                    FluentTransitions.Transition
                    .With(PictureBox, nameof(Left), 0)
                    .Decelerate(TimeSpan.FromSeconds(0.5));

                    foreach (Label Label in Controls.OfType<Label>())
                        Label.ForeColor = Color.Transparent;

                    MediaStatus.Text = "On Track";
                    MediaTitle.Text = Common.GetTitle(MediaURL);
                    MediaArtist.Text = Common.GetPerformers(MediaURL);

                    foreach (Label Label in Controls.OfType<Label>())
                    {
                        FluentTransitions.Transition
                        .With(Label, nameof(ForeColor), Common._1D3557_)
                        .EaseInEaseOut(TimeSpan.FromSeconds(1));
                    }
                }));
            }
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
    }
}

