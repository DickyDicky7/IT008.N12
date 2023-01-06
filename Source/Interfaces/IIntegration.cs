using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public interface IIntegration
    {
        public string GetBetterStreamingURL(string EncodeId);
        public Task<string> Search(string Query, int PageNumber, bool ReturnResult = false);
        public Task<string> GetLyrics(string EncodeId, bool ReturnResult = false);
        public Task<string> GetInformation(string EncodeId, bool ReturnResult = false);
        public Task<string> GetStreaming(string EncodeId, bool ReturnResult = false);
        public string SearchQueryHistory { get; set; }
    }
}
