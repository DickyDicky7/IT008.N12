using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class FolderLocation : UserControl
    {
        public FolderLocation(string URL, Mode mode)
        {
            InitializeComponent();
            FolderURL = URL;
            if (mode is Mode.Audio)
                removeBtn.Click += removeBtn_Click_1;
            else
            if (mode is Mode.Video)
                removeBtn.Click += removeBtn_Click_2;
        }

        public string FolderURL
        {
                    get => folderURL.Text;
            private set => folderURL.Text = value;
        }

        private void removeBtn_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.musicFolder.Remove(folderURL.Text);
            Properties.Settings.Default.Save();
            this.Parent.Controls.Remove(this);
            //this.Dispose();
        }

        private void removeBtn_Click_2(object sender, EventArgs e)
        {
            Properties.Settings.Default.videosFolder.Remove(folderURL.Text);
            Properties.Settings.Default.Save();
            this.Parent.Controls.Remove(this);
            //this.Dispose();
        }

        public enum Mode
        {
            None,
            Audio,
            Video,
        }
    }
}
