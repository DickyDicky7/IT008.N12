using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public interface IIntegration
    {
        public abstract string SearchQueryHistory { get; set; }
        public abstract string GetBetterStreamingURL(string EncodeId);
        public abstract Task<string> GetLyrics(string EncodeId, bool ReturnResult = false);
        public abstract Task<string> GetStreaming(string EncodeId, bool ReturnResult = false);
        public abstract Task<string> GetInformation(string EncodeId, bool ReturnResult = false);
        public abstract Task<string> Search(string Query, int PageNumber, bool ReturnResult = false);
    }
}
