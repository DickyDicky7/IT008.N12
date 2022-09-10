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
        public form()
        {
            InitializeComponent();

            string musicMediaPattern = @"\.mp3$";
            System.Text.RegularExpressions.Regex musicMediaRegex = new
            System.Text.RegularExpressions.Regex(musicMediaPattern);
            Func<string, bool> IsMusicMedia =
                filePath => musicMediaRegex.IsMatch(filePath);

            var items = System.IO.Directory.GetFiles("C:\\Users\\User\\Music")
                .Where(IsMusicMedia);

            int y = 0;

            void f (object sender, EventArgs e)
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

        }
    }
}
