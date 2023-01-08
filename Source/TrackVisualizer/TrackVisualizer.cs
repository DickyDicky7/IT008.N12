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
    public partial class TrackVisualizer : UserControl
    {
        public TrackVisualizer()
        {
            InitializeComponent();

            TrackTitle.ForeColor = Common.Black;
            TrackTitle.Text = "♫♫♫ Waiting... ♪♪♪";

            ColorTransitionB.ColorArray = new string[]
            { "#182cd4"
            , "#eeeeee"
            , "#c4fa6f"
            , "#3a3f47"

            , "#f72e9d"
            , "#06dcd4"
            , "#a0f4bc"
            , "#fff28f"
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

            , "#3433e0"
            , "#f23de8"
            , "#f7b054"
            , "#f6e648"
            }.Select(hex => ColorTranslator.FromHtml(hex)).ToArray();
            ColorTransitionM.Interval = 100;
            ColorTransitionM.AutoTransition = true;
            ColorTransitionM.StartColor = ColorTransitionM.ColorArray.First();
            ColorTransitionM.EndColor = ColorTransitionM.ColorArray.Last();

            Visualizer.Interval = 1;
            Visualizer.ColorBase = ColorTransitionB.ColorArray.First();
            Visualizer.ColorMax = ColorTransitionM.ColorArray.First();

            Watcher.Interval = TimeSpan.FromMilliseconds(100);
            Watcher.Action = UpdateVisualizer;

            Load += new EventHandler(MediaVisualizer_Load);
        }

        private void MediaVisualizer_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("ok ok ok");
            Visualizer.Start();
            Watcher.Start();
        }

        private void UpdateVisualizer()
        {
            try
            {
                if (IsHandleCreated)
                {
                    Visualizer.BeginInvoke((MethodInvoker)delegate ()
                    {
                        Visualizer.ColorBase = ColorTransitionB.Value;
                        Visualizer.ColorMax = ColorTransitionM.Value;
                    });
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Thread.CurrentThread.Abort();
            }
        }

        private void MediaController_OnLoadMedia(MediaControllerArgs MediaControllerArgs)
        {
            if (MediaControllerArgs.URL != null)
            {
                Invoke(new Action(() =>
                {
                    PictureBox.Left = -PictureBox.Size.Width;
                    PictureBox.Image = Common.GetImage(MediaControllerArgs.URL);
                    FluentTransitions.Transition
                    .With(PictureBox, nameof(Left), 0)
                    .Decelerate(TimeSpan.FromSeconds(0.5));

                    foreach (Label Label in Controls.OfType<Label>())
                        Label.ForeColor = Color.Transparent;

                    TrackStatus.Text = "On Track";
                    TrackTitle.Text = "   " + Common.GetTitle(MediaControllerArgs.URL);
                    TrackArtist.Text = Common.GetPerformers(MediaControllerArgs.URL);

                    FluentTransitions.Transition
                    .With(TrackStatus, nameof(ForeColor), Common.LightRed)
                    .With(TrackTitle, nameof(ForeColor), Common.Black)
                    .With(TrackArtist, nameof(ForeColor), Common.Black)
                    .EaseInEaseOut(TimeSpan.FromSeconds(1));
                }));
            }
            else
            if (MediaControllerArgs.EncodeId != null || MediaControllerArgs.Title != null ||
            MediaControllerArgs.ArtistsNames != null || MediaControllerArgs.ImageURL != null ||
            MediaControllerArgs.Duration != null)
            {
                Invoke(new Action(() =>
                {
                    PictureBox.Left = -PictureBox.Size.Width;
                    PictureBox.ImageLocation = MediaControllerArgs.ImageURL;
                    FluentTransitions.Transition
                    .With(PictureBox, nameof(Left), 0)
                    .Decelerate(TimeSpan.FromSeconds(0.5));

                    foreach (Label Label in Controls.OfType<Label>())
                        Label.ForeColor = Color.Transparent;

                    TrackStatus.Text = "On Track";
                    TrackTitle.Text = "   " + MediaControllerArgs.Title;
                    TrackArtist.Text = MediaControllerArgs.ArtistsNames;

                    FluentTransitions.Transition
                    .With(TrackStatus, nameof(ForeColor), Common.LightRed)
                    .With(TrackTitle, nameof(ForeColor), Common.Black)
                    .With(TrackArtist, nameof(ForeColor), Common.Black)
                    .EaseInEaseOut(TimeSpan.FromSeconds(1));
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
            Watcher.Stop();
        }

        private readonly Watcher Watcher = new Watcher();
    }
}

