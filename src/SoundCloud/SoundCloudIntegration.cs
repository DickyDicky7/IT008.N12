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
    public partial class SoundCloudIntegration : UserControl
    {
        public SoundCloudIntegration()
        {
            InitializeComponent();

            SoundCloudTabPage.ImageIndex = 8;
            SoundCloudTabPage.Text = "SoundCloud";

            SoundCloudTabPage.BackColor = Color.Gray;
            SoundCloudTabPage.Controls.Add(new SoundCloudSearchBox());
        }

        public TabPage SoundCloudTabPage = new TabPage();
    }
}
