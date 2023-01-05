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
            foreach (RestRequest Request in Requests.Values)
            {
                Request.AddParameter("apiKey", ApiKey);
                Request.AddParameter("version", Version);
            }

            //SearchRequest.AddParameter("apiKey", ApiKey);
            //SearchRequest.AddParameter("version", Version);

            //GetLyricsRequest.AddParameter("apiKey", ApiKey);
            //GetLyricsRequest.AddParameter("version", Version);

            //GetLyricsRequest.AddParameter("apiKey", ApiKey);
            //GetLyricsRequest.AddParameter("version", Version);

            Search("@");
        }

        public string GetBetterStreamingURL(string EncodeId)
        {
            return $"http://api.mp3.zing.vn/api/streaming/audio/{EncodeId}/320";
        }

        //public Task<string> Search(string Query, bool ReturnResult = false)
        //{
        //    return Task<string>.Factory.StartNew(() =>
        //    {
        //        Requests["Search"].AddOrUpdateParameter("q", Query);
        //        CTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        //        Requests["Search"].AddOrUpdateParameter("ctime", CTime.ToString());
        //        Requests["Search"].AddOrUpdateParameter("sig", MakeHashHMACSHA512
        //        (Requests["Search"].Resource + MakeHashSHA256
        //        ($"ctime={CTime}version={Version}"), SecretKey));
        //        string Result = (Client.Get(Requests["Search"])).Content;
        //        return ReturnResult ? Result : null;
        //    });
        //}
        public Task<string> Search(string Query, bool ReturnResult = false)
        {
            return Task<string>.Factory.StartNew(() =>
            {
                Requests["Search"].AddOrUpdateParameter("q", Query);
                CTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                Requests["Search"].AddOrUpdateParameter("ctime", CTime.ToString());
                Requests["Search"].AddOrUpdateParameter("page", "1");
                Requests["Search"].AddOrUpdateParameter("count", "18");
                Requests["Search"].AddOrUpdateParameter("type", "song");
                Requests["Search"].AddOrUpdateParameter("sig", MakeHashHMACSHA512
                (Requests["Search"].Resource + MakeHashSHA256
                ($"count=18ctime={CTime}page=1type=songversion={Version}"), SecretKey));
                string Result = (Client.Get(Requests["Search"])).Content;
                return ReturnResult ? Result : null;
            });
        }

        public Task<string> GetLyrics(string EncodeId, bool ReturnResult = false)
        {
            return Task<string>.Factory.StartNew(() =>
            {
                Requests["GetLyrics"].AddOrUpdateParameter("id", EncodeId);
                CTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                Requests["GetLyrics"].AddOrUpdateParameter("ctime", CTime.ToString());
                Requests["GetLyrics"].AddOrUpdateParameter("sig", MakeHashHMACSHA512
                (Requests["GetLyrics"].Resource + MakeHashSHA256
                ($"ctime={CTime}id={EncodeId}version={Version}"), SecretKey));
                string Result = (Client.Get(Requests["GetLyrics"])).Content;
                return ReturnResult ? Result : null;
            });
        }

        public Task<string> GetInformation(string EncodeId, bool ReturnResult = false)
        {
            return Task<string>.Factory.StartNew(() =>
            {
                Requests["GetInformation"].AddOrUpdateParameter("id", EncodeId);
                CTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                Requests["GetInformation"].AddOrUpdateParameter("ctime", CTime.ToString());
                Requests["GetInformation"].AddOrUpdateParameter("sig", MakeHashHMACSHA512
                (Requests["GetInformation"].Resource + MakeHashSHA256
                ($"ctime={CTime}id={EncodeId}version={Version}"), SecretKey));
                string Result = (Client.Get(Requests["GetInformation"])).Content;
                return ReturnResult ? Result : null;
            });
        }

        public Task<string> GetStreaming(string EncodeId, bool ReturnResult = false)
        {
            return Task<string>.Factory.StartNew(() =>
            {
                Requests["GetStreaming"].AddOrUpdateParameter("id", EncodeId);
                CTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                Requests["GetStreaming"].AddOrUpdateParameter("ctime", CTime.ToString());
                Requests["GetStreaming"].AddOrUpdateParameter("sig", MakeHashHMACSHA512
                (Requests["GetStreaming"].Resource + MakeHashSHA256
                ($"ctime={CTime}id={EncodeId}version={Version}"), SecretKey));
                string Result = (Client.Get(Requests["GetStreaming"])).Content;
                return ReturnResult ? Result : null;
            });
        }

        private long CTime;
        private readonly string Version = "1.6.34";
        private readonly string ApiKey = "88265e23d4284f25963e6eedac8fbfa3";
        private readonly string SecretKey = "2aa2d1c561e809b267f3638c4a307aab";

        private RestClient Client = new RestClient("https://zingmp3.vn");
        //private RestRequest SearchRequest =
        //    new RestRequest("/api/v2/search/multi", Method.Get);
        //private RestRequest GetLyricsRequest =
        //    new RestRequest("/api/v2/lyric/get/lyric", Method.Get);
        //private RestRequest GetStreamingRequest =
        //    new RestRequest("/api/v2/song/get/streaming", Method.Get);

        private Dictionary<string, RestRequest> Requests =
            new Dictionary<string, RestRequest>()
            {
                //{ "Search", new RestRequest("/api/v2/search/multi", Method.Get) }
                { "Search", new RestRequest("/api/v2/search", Method.Get) }
            ,   { "GetLyrics", new RestRequest("/api/v2/lyric/get/lyric", Method.Get) }
            ,   { "GetInformation", new RestRequest("/api/v2/song/get/info", Method.Get) }
            ,   { "GetStreaming", new RestRequest("/api/v2/song/get/streaming", Method.Get) }
            };

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