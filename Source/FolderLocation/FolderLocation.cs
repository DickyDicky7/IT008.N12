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
        public FolderLocation(string URL)
        {
            InitializeComponent();
            folderURL.Text = URL;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.musicFolder.Remove(folderURL.Text);
            Properties.Settings.Default.Save();
            this.Parent.Controls.Remove(this);
        }

    }
}
