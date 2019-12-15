using DataProviders.Data_Contracts;
using DataProviders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Mock_Classes
{
    public class Mock_HackerNewsDataProvider : IHackerNewsDataProvider
    {
        private readonly List<int> _topStoryIds;
        private readonly List<HackerNewsItemContract> _mockResults;

        public Mock_HackerNewsDataProvider(List<int> topStoryIds, List<HackerNewsItemContract> mockResults)
        {
            _topStoryIds = topStoryIds;
            _mockResults = mockResults;
        }

        public async Task<HackerNewsItemContract> GetItemByIdAsync(int id)
        {
            return _mockResults.FirstOrDefault(x => x.id == id);
        }

        public async Task<List<int>> GetTopStoriesAsync()
        {
            return _topStoryIds;
        }
    }
}
