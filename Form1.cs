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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = "C:\\Users\\User\\Music\\Circus10529-VA-5631008.mp3";
            player.controls.play();
        }
    }
}
