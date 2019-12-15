using BusinessLogic.Service_Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IHackerNewsService
    {
        public Task<List<NewsStory>> GetTopNewsStoryIdsAsync(int limit);
        
    }
}
