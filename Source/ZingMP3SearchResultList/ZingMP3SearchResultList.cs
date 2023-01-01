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
            Task.Factory.StartNew(() =>
            {
                JSONResultObject = JObject.Parse(JSONResult);

                IList<ZingMP3SearchResult> SearchResults = JSONResultObject["data"]["songs"]
                .Select(Item => new ZingMP3SearchResult(Item["encodeId"].ToString()
                , Item["title"].ToString(), Item["artistsNames"].ToString()
                , Item["thumbnailM"].ToString())).ToList();

                this.Invoke(new Action(() =>
                {
                    this.Controls.Clear();
                }));

                CurrentLocationY = 0;
                foreach (ZingMP3SearchResult SearchResult in SearchResults)
                {
                    SearchResult.Location = new Point(20, CurrentLocationY);
                    CurrentLocationY += SearchResult.Size.Height;
                    SiticoneSeparator Separator = new SiticoneSeparator();
                    Separator.Size = new Size(SearchResult.Size.Width, 10);
                    Separator.Location = new Point(20, CurrentLocationY);
                    CurrentLocationY += Separator.Size.Height;
                    Separator.BackColor = Color.White;
                    Separator.FillColor = Color.White;
                    this.Invoke(new Action(() =>
                    {
                        this.Controls.Add(SearchResult);
                        this.Controls.Add(Separator);
                    }));
                }
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
