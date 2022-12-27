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
    public partial class SearchResultList : UserControl
    {
        public SearchResultList()
        {
            InitializeComponent();

            //this.HorizontalScroll.Maximum = 0;
            //this.AutoScroll = false;
            //this.VerticalScroll.Visible = false;
            //this.AutoScroll = true;

            this.HScroll = true;
            this.HorizontalScroll.Visible = false;
            //this.VerticalScroll.Enabled = false;
            //this.AutoScroll = true;

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
                    //MessageBox.Show(Temp.Count.ToString());
                    this.Controls.Clear();
                }));
                for (int k = 0; k < Temp.Count; k++)
                {
                    SearchResult TempSearchResult = new SearchResult(Temp[k]);
                    TempSearchResult.Location =
                    new Point(k * TempSearchResult.Size.Width, 0);
                    //this.Size = new Size(this.Size.Width, TempSearchResult.Size.Height);
                    //TempSearchResult.Dock = DockStyle.Left;
                    this.Invoke(new Action(() =>
                    {
                        this.Controls.Add(TempSearchResult);
                    }));
                }
            });
        }

        private void SearchResultList_MouseWheel(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("$$$$");
            //this.ClientRectangle.Offset(new Point(this.Location.X + 10, 0));
            //this.ScrollControlIntoView(this.Controls[5]);
            //this.scroll
            this.OnScroll
            (null);
            //MessageBox.Show(this.VerticalScroll.Value.ToString());

        }

        private JObject JSONResultObject;
    }
}
