using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public interface IIntegration
    {
        Task<string> Search(string Query, bool ReturnResult = false);
    }
}
