using DataProviders.Data_Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders.Interfaces
{
    public interface IHackerNewsDataProvider
    {
        public Task<List<int>> GetTopStoriesAsync();
        public Task<HackerNewsItemContract> GetItemByIdAsync(int id);
    }
}
