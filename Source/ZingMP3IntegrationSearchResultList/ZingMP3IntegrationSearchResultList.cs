using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Siticone.Desktop.UI.WinForms;

namespace MyMediaPlayer
{
    public partial class ZingMP3IntegrationSearchResultList : UserControl
    , IIntegrationSearchResultList, IMediaItemList
    {
        public ZingMP3IntegrationSearchResultList()
        {
            InitializeComponent();

            this.AutoScroll = true;

            //this.Scroll += (s, e) =>
            //{
            //    if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            //    {
            //        this.VerticalScroll.Value = e.NewValue;
            //    }
            //    this.Refresh();
            //    MessageBox.Show("2");
            //};

            this.Resize += new EventHandler(ZingMP3IntegrationSearchResultList_Resize);
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

        private void ZingMP3IntegrationSearchResultList_Resize(object sender, EventArgs e)
        {
            foreach (Control Control in this.Controls)
            {
                Control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                Control.Size = new Size(((Control)sender).Size.Width - 70, Control.Size.Height);
            }
        }

        private readonly AMediaItemList<ZingMP3IntegrationSearchResult> Self =
                     new AMediaItemList<ZingMP3IntegrationSearchResult>();

        public void LoadIntegrationSearchResults(string JSONResult)
        {
            if (JSONResult == null)
            {
                return;
            }

            //MessageBox.Show(System.Threading.Thread.CurrentThread.IsThreadPoolThread.ToString());

            Task.Run(() =>
            {
                //MessageBox.Show(System.Threading.Thread.CurrentThread.IsThreadPoolThread.ToString());

                JSONResultObject = JObject.Parse(JSONResult);

                List<ZingMP3IntegrationSearchResult> IntegrationSearchResults =
                JSONResultObject["data"]?["items"].Select
                (
                    Item => new ZingMP3IntegrationSearchResult
                    (
                      Item["duration"].Value<int>()
                    , Item["title"].Value<string>()
                    , Item["encodeId"].Value<string>()
                    , Item["thumbnailM"].Value<string>()
                    , Item["artistsNames"].Value<string>()
                    )
                ).ToList();

                NumberOfItems = JSONResultObject["data"]?["total"]?.Value<int?>();

                if (IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        for (int k = 0; k < this.Controls.Count; k++) this.Controls[k].Dispose();
                        this.Controls.Clear();
                    }));
                }

                CurrentLocationY = 0;
                IntegrationSearchResults?.ForEach(IntegrationSearchResult =>
                {
                    IntegrationSearchResult.Location = new Point(20, CurrentLocationY);
                    CurrentLocationY += IntegrationSearchResult.Size.Height;
                    SiticoneSeparator Separator = new SiticoneSeparator();
                    Separator.Size = new Size(IntegrationSearchResult.Size.Width, 5);
                    Separator.Location = new Point(20, CurrentLocationY);
                    CurrentLocationY += Separator.Size.Height;
                    Separator.BackColor = Color.White;
                    Separator.FillColor = Color.White;
                    if (IsHandleCreated)
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            this.Controls.Add(IntegrationSearchResult);
                            this.Controls.Add(Separator);
                        }));
                    }

                    Self.MediaItems.Add(IntegrationSearchResult);

                });
            });
        }

        public void LoadIntegrationSearchResults()
        {
            for (int k = 0; k < this.Controls.Count; k++) this.Controls[k].Dispose();
            this.Controls.Clear();
        }

        private JObject JSONResultObject;

        private int CurrentLocationY = 0;

        public int? NumberOfItems { get; set; } = null;

        public Action Stop => Self.Stop;
        public Action Clear => () =>
        {
            for (int k = 0; k < this.Controls.Count; k++)
            {
                this.Controls[k].Dispose();
            }
            Self.Clear();
            this.Controls.Clear();
        };
        public Action PlayNext => Self.PlayNext;
        public Action PlayBack => Self.PlayBack;
        public Action GenerateShuffleList => Self.GenerateShuffleList;

        public void UpdateCurrentIndex(IMediaItem MediaItem)
        {
            ZingMP3IntegrationSearchResult ZingMP3IntegrationSearchResult = MediaItem as
            ZingMP3IntegrationSearchResult;
            if (ZingMP3IntegrationSearchResult != null)
            {
                Self.UpdateCurrentIndex(ZingMP3IntegrationSearchResult);
            }
        }
    }
}
