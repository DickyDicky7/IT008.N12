using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public interface ISearchResultList
    {
        public void LoadSearchResults(string JSONResult);
        public void LoadSearchResults();
        public int? NumberOfItems { get; set; }
    }
}
