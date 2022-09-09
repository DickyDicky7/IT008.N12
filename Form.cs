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
        }

        private void btn_load_media_Click(object sender, EventArgs e)
        {
            media_controller.LoadMedia(
                "C:\\Users\\User\\Music\\Circus10529-VA-5631008.mp3"
            );
        }
    }
}
