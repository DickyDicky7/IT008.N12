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
    public partial class form : Form
    {
        public form(string[] args)
        {
            InitializeComponent();

            //av.VisMode = CSAudioVisualization.GraphMode.Mode3D;
            av.Interval = 1;
            av.ColorMax = ColorTranslator.FromHtml("#1D3557");
            av.ColorBase = ColorTranslator.FromHtml("#A8DADC");
            FormClosing += new FormClosingEventHandler(form_FormClosing);
            //av.HighQuality = true;
            //av.FileName = "";
            av.Start();

            t.Interval = 3000;

            void g(object sender, EventArgs e)
            {
                if (av.ColorMax == ColorTranslator.FromHtml("#1D3557"))
                {
                    av.ColorMax = ColorTranslator.FromHtml("#386641");
                    av.ColorBase = ColorTranslator.FromHtml("#A7C957");
                }
                else
                {
                    av.ColorMax = ColorTranslator.FromHtml("#1D3557");
                    av.ColorBase = ColorTranslator.FromHtml("#A8DADC");
                }
            }

            t.Tick += new EventHandler(g);
            t.Start();

            t1.Tick += new EventHandler((s, e) => { 
            });

            //media_controller.Top = ClientSize.Height - media_controller.Height;
            MediaController.Location = new
                Point(
                (ClientSize.Width - MediaController.Width) / 2
                , ClientSize.Height - MediaController.Height);
            Resize += new EventHandler(form_Resize);

            panel1.Location = new Point(0, 0);
            panel1.Width = 500;

            string musicMediaPattern = @"\.mp3$";
            System.Text.RegularExpressions.Regex musicMediaRegex = new
            System.Text.RegularExpressions.Regex(musicMediaPattern);
            Func<string, bool> IsMusicMedia =
                filePath => musicMediaRegex.IsMatch(filePath);

            var items = System.IO.Directory.GetFiles("C:\\Users\\User\\Music")
                .Where(IsMusicMedia);

            int y = 0;

            void f(object sender, EventArgs e)
            {
                MessageBox.Show("Clicked", "!!!");
            }

            MediaItem.MediaController = MediaController;
            foreach (string item in items)
            {
                MediaItem mediaItem = new MediaItem(item);
                mediaItem.Location = new Point(0, y);
                panel1.Controls.Add(mediaItem);
                y += mediaItem.Height;
            }

            Load += new EventHandler(form_Load(args));
        }

        private void form_Resize(object sender, EventArgs e)
        {
            MediaController.Location = new
                Point(
                (ClientSize.Width - MediaController.Width) / 2
                , ClientSize.Height - MediaController.Height);
        }

        private Action<object, EventArgs> form_Load(string[] args)
        {
            Action<object, EventArgs> LoadHandler = new
            Action<object, EventArgs>((sender, e) =>
            {
                if (args.Length != 0)
                {
                    MessageBox.Show(args[0], "File");
                    MediaController.LoadMedia(args[0]);
                }
            });
            return LoadHandler;
        }

        private static Timer t = new Timer();
        private static Timer t1 = new Timer();

        private void form_FormClosing(object sender, EventArgs e)
        {
            av.Stop();
            t.Stop();
        }
    }
}
