using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Siticone.Desktop.UI.WinForms;

namespace MyMediaPlayer
{
    public partial class SearchBox : UserControl
    {
        public SearchBox()
        {
            InitializeComponent();

            Watcher.Interval = TimeSpan.FromMilliseconds(100);
            Watcher.Action = UpdateSearchBox;

            TextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            Load += new EventHandler(SearchBox_Load);
        }

        private void UpdateSearchBox()
        {
            if (LastMod != null)
            {
                if (DateTime.Now.Subtract(LastMod.Value) >= TimeSpan.FromSeconds(3))
                {
                    TextBox.BeginInvoke((MethodInvoker)async delegate ()
                    {
                        if (Integration == null)
                        {
                            SearchResultList?.LoadSearchResults();
                        }
                        else
                        {
                            SearchResultList?.LoadSearchResults
                            (await Integration.Search(TextBox.Text, true));
                        }
                        TextBox.Text = "";
                    });
                    LastMod = null;
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            LastMod = DateTime.Now;
        }

        private void SearchBox_Load(object sender, EventArgs e)
        {
            Watcher.Start();
        }

        public void Stop()
        {
            Watcher.Stop();
        }

        private DateTime? LastMod;

        private readonly Watcher Watcher = new Watcher();

        public IIntegration Integration { get; set; } = null;

        public ISearchResultList SearchResultList = null;

        private void IntegrationButton_Click(object sender, EventArgs e)
        {
            SiticoneButton SenderButton = (SiticoneButton)sender;
            Point Point = new Point(0, SenderButton.Height);
            Point = SenderButton.PointToScreen(Point);
            ContextMenuStrip.Width = SenderButton.Width;
            ContextMenuStrip.Show(Point);
        }

        private void ZingMP3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntegrationButton.Text = "ZingMP3";
            Integration = new ZingMP3Integration();
            IntegrationButton.TextAlign = HorizontalAlignment.Left;
            IntegrationButton.Image = Properties.Resources.zing_mp3;
            IntegrationButton.ImageAlign = HorizontalAlignment.Right;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Task.Factory.StartNew(async () =>
                {
                    if (Integration == null)
                    {
                        SearchResultList?.LoadSearchResults();
                    }
                    else
                    {
                        SearchResultList?.LoadSearchResults
                        (await Integration.Search(TextBox.Text, true));
                    }
                });
            }
        }

        private void SoundCloudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integration = null;
            IntegrationButton.Text = "SoundCloud";
            IntegrationButton.TextAlign = HorizontalAlignment.Left;
            IntegrationButton.ImageAlign = HorizontalAlignment.Right;
            IntegrationButton.Image = Properties.Resources.sound_cloud;
        }

        private void SpotifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integration = null;
            IntegrationButton.Text = "Spotify";
            IntegrationButton.TextAlign = HorizontalAlignment.Left;
            IntegrationButton.Image = Properties.Resources.spotify;
            IntegrationButton.ImageAlign = HorizontalAlignment.Right;
        }
    }
}
