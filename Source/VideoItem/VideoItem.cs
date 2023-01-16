using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class VideoItem : UserControl, IMediaItem
    {
        public VideoItem(string URL)
        {
            InitializeComponent();
            this.URL = URL;
            this.Title = this.URL.Split('\\').Last();
            this.Click += new EventHandler(VideoItem_Click);
            this.MouseEnter += new EventHandler(VideoItem_MouseEnter);
            this.MouseLeave += new EventHandler(VideoItem_MouseLeave);
        }

        public readonly string URL;
        private string Title { get => Label.Text; set => Label.Text = value; }

        public Action Play { get => VideoItem_Play; }
        public UserControl UserControl { get => this; }
        public EventHandler IMediaItem_Click { get => VideoItem_Click; }

        private void VideoItem_Play()
        {
            GlobalReferences.MediaController.LoadLocalVideo(this.URL);
        }

        private void VideoItem_Click(object sender, EventArgs e)
        {
            if ((VideoItemList)this.Parent != null)
            {
                GlobalReferences.MediaController.LoadMediaItemList((VideoItemList)this.Parent);
                ((VideoItemList)this.Parent).UpdateCurrentIndex(this);
                this.VideoItem_Play();
            }
        }

        private void VideoItem_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.Show(this.Title, Label);
        }

        private void VideoItem_MouseLeave(object sender, EventArgs e)
        {
            ToolTip.Hide(Label);
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                static void Recursive(Control control, EventHandler e)
                {
                    foreach (Control c in control.Controls)
                    {
                        c.Click += e;
                        Recursive(c, e);
                    }
                }
                Recursive(this, value);
            }
            remove
            {
                base.Click -= value;
                static void Recursive(Control control, EventHandler e)
                {
                    foreach (Control c in control.Controls)
                    {
                        c.Click -= e;
                        Recursive(c, e);
                    }
                }
                Recursive(this, value);
            }
        }

        public new event EventHandler MouseEnter
        {
            add
            {
                base.MouseEnter += value;
                static void Recursive(Control control, EventHandler e)
                {
                    foreach (Control c in control.Controls)
                    {
                        c.MouseEnter += e;
                        Recursive(c, e);
                    }
                }
                Recursive(this, value);
            }
            remove
            {
                base.MouseEnter -= value;
                static void Recursive(Control control, EventHandler e)
                {
                    foreach (Control c in control.Controls)
                    {
                        c.MouseEnter -= e;
                        Recursive(c, e);
                    }
                }
                Recursive(this, value);
            }
        }

        public new event EventHandler MouseLeave
        {
            add
            {
                base.MouseLeave += value;
                static void Recursive(Control control, EventHandler e)
                {
                    foreach (Control c in control.Controls)
                    {
                        c.MouseLeave += e;
                        Recursive(c, e);
                    }
                }
                Recursive(this, value);
            }
            remove
            {
                base.MouseLeave -= value;
                static void Recursive(Control control, EventHandler e)
                {
                    foreach (Control c in control.Controls)
                    {
                        c.MouseLeave -= e;
                        Recursive(c, e);
                    }
                }
                Recursive(this, value);
            }
        }
    }
}
