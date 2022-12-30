using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public interface ISearchResultList
    {
        void LoadSearchResults(string JSONResult);
        void LoadSearchResults();
    }
}
