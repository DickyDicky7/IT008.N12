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

            //media_controller.Top = ClientSize.Height - media_controller.Height;
            media_controller.Location = new
                Point(
                (ClientSize.Width - media_controller.Width) / 2
                , ClientSize.Height - media_controller.Height);
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

            foreach (string item in items)
            {
                MediaItem mediaItem = new MediaItem(item);
                mediaItem.Click += new EventHandler
                    (mediaItem.MediaItem_Click(media_controller));
                mediaItem.Location = new Point(0, y);
                panel1.Controls.Add(mediaItem);
                y += mediaItem.Height;
            }

            Load += new EventHandler(form_Load(args));
        }

        private void form_Resize(object sender, EventArgs e)
        {
            media_controller.Location = new
                Point(
                (ClientSize.Width - media_controller.Width) / 2
                , ClientSize.Height - media_controller.Height);
        }

        private Action<object, EventArgs> form_Load(string[] args)
        {
            Action<object, EventArgs> LoadHandler = new
            Action<object, EventArgs>((sender, e) =>
            {
                MessageBox.Show(args.Length == 0 ? "Nothing" : args[0], "File");
                if (args.Length > 1)
                    media_controller.LoadMedia(args[0]);
            });
            return LoadHandler;
        }
    }
}
