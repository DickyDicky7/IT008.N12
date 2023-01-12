using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public interface IIntegrationSearchResultList
    {
        public abstract void LoadIntegrationSearchResults(string JSONResult);
        public abstract void LoadIntegrationSearchResults();
        public abstract int? NumberOfItems { get; set; }
    }
}
