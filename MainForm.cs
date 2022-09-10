using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            lbl_1.Text =
                String.Join("\n",
                System.IO.Directory.GetFiles("C:\\Users\\User\\Music")
                .Where(IsMusicMedia));

            var items = System.IO.Directory.GetFiles("C:\\Users\\User\\Music")
                .Where(IsMusicMedia);

            Action<object, EventArgs> f(string URL)
            {
                Action<object, EventArgs> g = 
                    new Action<object, EventArgs>((sender, e) =>
                {
                    media_controller.LoadMedia(URL);
                });
                return g;
            }

            int y = 0;

            foreach (string item in items)
            {
                Button m = new Button();
                m.Text = item.Substring(20);
                m.Click += new EventHandler(f(item));
                m.Location = new Point(0, y);
                groupBox1.Controls.Add(m);
                y += m.Height;
            }

        }

        private void btn_load_media_Click(object sender, EventArgs e)
        {
            media_controller.LoadMedia(
                "C:\\Users\\User\\Music\\Circus10529-VA-5631008.mp3"
            );
        }
    }
}
