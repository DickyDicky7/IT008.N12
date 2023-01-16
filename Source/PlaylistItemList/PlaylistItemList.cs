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

            GlobalReferences.PlaylistsFolderWatcher.Changed += (sender, e) =>
            {
                if (IsHandleCreated)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        Render();
                    });
                }
            };

            GlobalReferences.PlaylistsFolderWatcher.Created += (sender, e) =>
            {
                if (IsHandleCreated)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        Render();
                    });
                }
            };

            GlobalReferences.PlaylistsFolderWatcher.Deleted += (sender, e) =>
            {
                if (IsHandleCreated)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        Render();
                    });
                }
            };
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
            this.Controls.Clear();
            Directory.GetFiles(Common.PlaylistsFolder, "*.wpl").ToList()
            .ForEach(Path =>
            {
                PlaylistItem PlaylistItem = new PlaylistItem(Path);
                PlaylistItem.Padding = new Padding(20, 7, 20, 7);
                PlaylistItem.Dock = DockStyle.Top;
                this.Controls.Add(PlaylistItem);
            });
        }
    }
}
