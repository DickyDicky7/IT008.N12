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
    public partial class ZingMP3IntegrationSearchResultList : UserControl, IIntegrationSearchResultList
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


        }

        public void LoadIntegrationSearchResults(string JSONResult)
        {
            if (JSONResult == null)
            {
                return;
            }

            //MessageBox.Show(System.Threading.Thread.CurrentThread.IsThreadPoolThread.ToString());

            Task.Factory.StartNew(() =>
            {
                //MessageBox.Show(System.Threading.Thread.CurrentThread.IsThreadPoolThread.ToString());

                JSONResultObject = JObject.Parse(JSONResult);

                List<ZingMP3IntegrationSearchResult> IntegrationSearchResults = JSONResultObject["data"]?["items"]
                .Select(Item => new ZingMP3IntegrationSearchResult(Item["encodeId"].Value<string>()
                , Item["title"].Value<string>(), Item["artistsNames"].Value<string>()
                , Item["thumbnailM"].Value<string>(), Item["duration"].Value<int>()))
                .ToList();

                NumberOfItems = JSONResultObject["data"]?["total"]?.Value<int?>();

                if (IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
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
                });
            });
        }

        public void LoadIntegrationSearchResults()
        {
            this.Controls.Clear();
        }

        private JObject JSONResultObject;

        private int CurrentLocationY = 0;

        public int? NumberOfItems { get; set; } = null;
    }
}
