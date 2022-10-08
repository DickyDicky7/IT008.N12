using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

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
