using System;
using RestSharp;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using MyMediaPlayer.Properties;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MyMediaPlayer
{
    public partial class ZingMP3Integration : UserControl
    {
        public ZingMP3Integration()
        {
            InitializeComponent();

            //SoundCloudTabPage.ImageIndex = 8;
            //SoundCloudTabPage.Text = "SoundCloud";

            //SoundCloudTabPage.BackColor = Color.Gray;
            //SoundCloudTabPage.Controls.Add(new SearchBox());

            SearchRequest.AddParameter("ctime", "1671601473641");
            SearchRequest.AddParameter("version", "1.6.34");
            SearchRequest.AddParameter("apiKey", "88265e23d4284f25963e6eedac8fbfa3");
            SearchRequest.AddParameter("sig", "f50065df6b41dc92f6df765d783acb6aeaba26ccb9ee6ccf1d88570d1a2be521cc3571d1ff87258d87bd9f97c8fd8244d313c887354ebeae200148b31fbe2168");

            Search("@");
        }

        public Task<string> Search(string Query, bool ReturnResult = false)
        {
            return Task<string>.Factory.StartNew(() =>
            {
                SearchRequest.AddOrUpdateParameter("q", Query);
                string Result = (Client.Get(SearchRequest)).Content;
                return ReturnResult ? Result : null;
            });
        }

        //public TabPage SoundCloudTabPage = new TabPage();

        RestClient Client = new RestClient("https://zingmp3.vn");
        RestRequest SearchRequest =
        new RestRequest("/api/v2/search/multi", Method.Get);
    }
}

//https://zingmp3.vn/api/v2/search/multi?ctime=1671601473641&version=1.6.34&sig=f50065df6b41dc92f6df765d783acb6aeaba26ccb9ee6ccf1d88570d1a2be521cc3571d1ff87258d87bd9f97c8fd8244d313c887354ebeae200148b31fbe2168&apiKey=88265e23d4284f25963e6eedac8fbfa3

