using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace IT008.N12_015
{
    public partial class SoundCloudSearchBox : UserControl
    {
        public SoundCloudSearchBox()
        {
            InitializeComponent();

            Timer = new System.Threading.Timer(
                new System.Threading.TimerCallback((s) => {
                    if (LastMod != null)
                    {
                        if (DateTime.Now.Subtract(LastMod.Value) >= TimeSpan.FromSeconds(3))
                        {
                            TextBox.BeginInvoke((MethodInvoker)delegate ()
                            {
                                TextBox.Text = "";
                            });
                                LastMod = null;
                        }
                    }
                }), null,0,1);

            TextBox.TextChanged += new EventHandler((s, e) =>
            {
                LastMod = DateTime.Now;
            });
        }

        private DateTime? LastMod;
        private System.Threading.Timer Timer;
    }
}
