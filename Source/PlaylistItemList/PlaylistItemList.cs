using System;
using System.IO;
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
    public partial class PlaylistItemList : UserControl
    {
        public PlaylistItemList()
        {
            InitializeComponent();
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = true;
            Render();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CP = base.CreateParams;
                CP.ExStyle = CP.ExStyle | 0x02000000;
                return CP;
            }
        }

        public void Render()
        {
            for (int k = 0; k < this.Controls.Count; k++)
            {
                ((IMediaItemList)this.Controls[k]).Clear();
                this.Controls[k].Dispose();
            }
            this.Controls.Clear();
            Directory.GetFiles(Common.PlaylistsFolder, "*.wpl").ToList()
            .ForEach(this.Add);
        }

        public void Add(string URL)
        {
            this.Controls.Add
            (new PlaylistItem(URL)
            {
                Dock = DockStyle.Top,
                Padding = new Padding(20, 7, 20, 7),
            });
        }
    }
}
