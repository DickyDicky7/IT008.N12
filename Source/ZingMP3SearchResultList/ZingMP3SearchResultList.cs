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
    public partial class ZingMP3SearchResultList : UserControl, ISearchResultList
    {
        public ZingMP3SearchResultList()
        {
            InitializeComponent();

            this.AutoScroll = true;
        }

        public void LoadSearchResults(string JSONResult)
        {
            //MessageBox.Show(System.Threading.Thread.CurrentThread.IsThreadPoolThread.ToString());

            Task.Factory.StartNew(() =>
            {
                //MessageBox.Show(System.Threading.Thread.CurrentThread.IsThreadPoolThread.ToString());

                JSONResultObject = JObject.Parse(JSONResult);

                List<ZingMP3SearchResult> SearchResults = JSONResultObject["data"]?["items"]
                .Select(Item => new ZingMP3SearchResult(Item["encodeId"].Value<string>()
                , Item["title"].Value<string>(), Item["artistsNames"].Value<string>()
                , Item["thumbnailM"].Value<string>(), Item["duration"].Value<int>()))
                .ToList();

                this.Invoke(new Action(() =>
                {
                    this.Controls.Clear();
                }));

                CurrentLocationY = 0;
                SearchResults?.ForEach(SearchResult =>
                {
                    SearchResult.Location = new Point(20, CurrentLocationY);
                    CurrentLocationY += SearchResult.Size.Height;
                    SiticoneSeparator Separator = new SiticoneSeparator();
                    Separator.Size = new Size(SearchResult.Size.Width, 5);
                    Separator.Location = new Point(20, CurrentLocationY);
                    CurrentLocationY += Separator.Size.Height;
                    Separator.BackColor = Color.White;
                    Separator.FillColor = Color.White;
                    this.Invoke(new Action(() =>
                    {
                        this.Controls.Add(SearchResult);
                        this.Controls.Add(Separator);
                    }));
                });
                //foreach (ZingMP3SearchResult SearchResult in SearchResults)
                //{
                //    SearchResult.Location = new Point(20, CurrentLocationY);
                //    CurrentLocationY += SearchResult.Size.Height;
                //    SiticoneSeparator Separator = new SiticoneSeparator();
                //    Separator.Size = new Size(SearchResult.Size.Width, 10);
                //    Separator.Location = new Point(20, CurrentLocationY);
                //    CurrentLocationY += Separator.Size.Height;
                //    Separator.BackColor = Color.White;
                //    Separator.FillColor = Color.White;
                //    this.Invoke(new Action(() =>
                //    {
                //        this.Controls.Add(SearchResult);
                //        this.Controls.Add(Separator);
                //    }));
                //}
            });
        }

        public void LoadSearchResults()
        {
            this.Controls.Clear();
        }

        private JObject JSONResultObject;

        private int CurrentLocationY = 0;
    }
}
