using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public interface IIntegration
    {
        string GetBetterStreamingURL(string EncodeId);
        Task<string> Search(string Query, bool ReturnResult = false);
        Task<string> GetLyrics(string EncodeId, bool ReturnResult = false);
        Task<string> GetInformation(string EncodeId, bool ReturnResult = false);
        Task<string> GetStreaming(string EncodeId, bool ReturnResult = false);
    }
}
