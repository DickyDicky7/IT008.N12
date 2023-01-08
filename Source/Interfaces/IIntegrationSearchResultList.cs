using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public interface IIntegrationSearchResultList
    {
        public void LoadIntegrationSearchResults(string JSONResult);
        public void LoadIntegrationSearchResults();
        public int? NumberOfItems { get; set; }
    }
}
