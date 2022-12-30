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

namespace MyMediaPlayer
{
    public partial class SearchResultList : UserControl, ISearchResultList
    {
        public SearchResultList()
        {
            InitializeComponent();

            this.AutoScroll = true;
        }

        public void LoadSearchResults(string JSONResult)
        {
            Task.Factory.StartNew(() =>
            {
                JSONResultObject = JObject.Parse(JSONResult);
                IList<string> Temp = JSONResultObject["data"]["songs"]
                .Select(Item => Item["thumbnailM"].ToString()).ToList();
                this.Invoke(new Action(() =>
                {
                    this.Controls.Clear();
                }));
                for (int k = 0; k < Temp.Count; k++)
                {
                    SearchResult TempSearchResult = new SearchResult(Temp[k]);
                    TempSearchResult.Location = new Point
                    (0, k * TempSearchResult.Size.Height);
                    this.Invoke(new Action(() =>
                    {
                        this.Controls.Add(TempSearchResult);
                    }));
                }
            });
        }

        public void LoadSearchResults()
        {
            this.Controls.Clear();
        }

        private JObject JSONResultObject;
    }
}
