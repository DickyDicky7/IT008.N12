using System;
using RestSharp;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MyMediaPlayer
{
    internal class ZingMP3Integration : IIntegration
    {
        public ZingMP3Integration()
        {
            SearchRequest.AddParameter("apiKey", ApiKey);
            SearchRequest.AddParameter("version", Version);

            Search("@");
        }

        public Task<string> Search(string Query, bool ReturnResult = false)
        {
            //MessageBox.Show(System.Threading.Thread.CurrentThread.IsThreadPoolThread.ToString());

            return Task<string>.Factory.StartNew(() =>
            {
                SearchRequest.AddOrUpdateParameter("q", Query);
                Ctime = DateTimeOffset.Now.ToUnixTimeSeconds();
                SearchRequest.AddOrUpdateParameter("ctime", Ctime.ToString());
                SearchRequest.AddOrUpdateParameter("sig", MakeHashHMACSHA512
                (SearchRequest.Resource + MakeHashSHA256
                ($"ctime={Ctime}version={Version}"), SecretKey));
                string Result = (Client.Get(SearchRequest)).Content;
                return ReturnResult ? Result : null;
            });
        }

        private long Ctime;
        private readonly string Version = "1.6.34";
        private readonly string ApiKey = "88265e23d4284f25963e6eedac8fbfa3";
        private readonly string SecretKey = "2aa2d1c561e809b267f3638c4a307aab";

        private RestClient Client = new RestClient("https://zingmp3.vn");
        private RestRequest SearchRequest =
            new RestRequest("/api/v2/search/multi", Method.Get);

        public static string MakeHashSHA256(string Input)
        {
            using (SHA256 SHA256 = SHA256.Create())
            {
                return BitConverter.ToString
                (SHA256.ComputeHash(Encoding.UTF8.GetBytes(Input)))
                .Replace("-", "").ToLower();
            }
        }

        public static string MakeHashHMACSHA512(string Input, string Key)
        {
            using (var HMAC = HMACSHA512.Create(("HMACSHA512")))
            {
                HMAC.Key = Encoding.UTF8.GetBytes(Key);
                return BitConverter.ToString
                (HMAC.ComputeHash(Encoding.UTF8.GetBytes(Input)))
                .Replace("-", "").ToLower();
            }
        }
    }
}

//https://zingmp3.vn/api/v2/search/multi?ctime=1671601473641&version=1.6.34&sig=f50065df6b41dc92f6df765d783acb6aeaba26ccb9ee6ccf1d88570d1a2be521cc3571d1ff87258d87bd9f97c8fd8244d313c887354ebeae200148b31fbe2168&apiKey=88265e23d4284f25963e6eedac8fbfa3