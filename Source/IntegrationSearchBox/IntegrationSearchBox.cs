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
    public partial class IntegrationSearchBox : UserControl
    {
        public IntegrationSearchBox()
        {
            InitializeComponent();

            Watcher.Interval = TimeSpan.FromMilliseconds(100);
            Watcher.Action = UpdateIntegrationSearchBox;

            TextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            Load += new EventHandler(IntegrationSearchBox_Load);

            Pagination.BackPageButton_Click = new EventHandler(Pagination_BackPageButton_Click);
            Pagination.NextPageButton_Click = new EventHandler(Pagination_NextPageButton_Click);
        }

        private void UpdateIntegrationSearchBox()
        {
            if (LastMod != null)
            {
                if (DateTime.Now.Subtract(LastMod.Value) >= TimeSpan.FromSeconds(3))
                {
                    TextBox.BeginInvoke((MethodInvoker)async delegate ()
                    {
                        #region Testing

                        if (string.IsNullOrEmpty(TextBox.Text)
                         || string.IsNullOrWhiteSpace(TextBox.Text))
                        {
                            //MessageBox.Show("ok");
                            TextBox.Text = "";
                            return;
                        }

                        #endregion

                        if (Integration == null)
                        {
                            IntegrationSearchResultList?.LoadIntegrationSearchResults();
                        }
                        else
                        {
                            IntegrationSearchResultList?.LoadIntegrationSearchResults
                            (await Integration.Search(TextBox.Text, 1, true));
                        }
                        TextBox.Text = "";
                    });
                    Pagination.CurrentPageNumber = 1;
                    LastMod = null;
                }
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                #region Testing

                if (string.IsNullOrEmpty(TextBox.Text)
                 || string.IsNullOrWhiteSpace(TextBox.Text))
                {
                    //MessageBox.Show("ok");
                    TextBox.Text = "";
                    return;
                }

                #endregion

                Task.Factory.StartNew(async () =>
                {
                    if (Integration == null)
                    {
                        IntegrationSearchResultList?.LoadIntegrationSearchResults();
                    }
                    else
                    {
                        #region Testing

                        //Console.WriteLine
                        //(await Integration.Search(TextBox.Text, 1, true));

                        #endregion

                        IntegrationSearchResultList?.LoadIntegrationSearchResults
                        (await Integration.Search(TextBox.Text, 1, true));
                    }
                    TextBox.BeginInvoke((MethodInvoker)delegate ()
                    {
                        TextBox.Text = "";
                    });
                    Pagination.CurrentPageNumber = 1;
                    LastMod = null;
                });
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            LastMod = DateTime.Now;
        }

        private void IntegrationSearchBox_Load(object sender, EventArgs e)
        {
            Watcher.Start();
        }

        public void Stop()
        {
            Watcher.Stop();
        }

        private DateTime? LastMod;

        private readonly Watcher Watcher = new Watcher();

        private IIntegration integration = null;
        public IIntegration Integration
        {
            get => integration;
            set
            {
                integration = value;
                GlobalReferences.OnlineStoreIntegration = value;
            }
        }

        public IIntegrationSearchResultList IntegrationSearchResultList { get; set; } = null;

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

        private void Pagination_BackPageButton_Click(object sender, EventArgs e)
        {
            if (Pagination.CurrentPageNumber - 1 >= 1)
            {
                Pagination.CurrentPageNumber -= 1;
                Task.Factory.StartNew(async () =>
                {
                    IntegrationSearchResultList?.LoadIntegrationSearchResults
                    (await Integration.Search(Integration.SearchQueryHistory
                    , Pagination.CurrentPageNumber, true));
                });
            }
        }

        private void Pagination_NextPageButton_Click(object sender, EventArgs e)
        {
            if (IntegrationSearchResultList.NumberOfItems != null)
                if (Pagination.CurrentPageNumber * 18 <= IntegrationSearchResultList.NumberOfItems)
                {
                    Pagination.CurrentPageNumber += 1;
                    Task.Factory.StartNew(async () =>
                    {
                        IntegrationSearchResultList?.LoadIntegrationSearchResults
                        (await Integration.Search(Integration.SearchQueryHistory
                        , Pagination.CurrentPageNumber, true));
                    });
                }
        }
    }
}
