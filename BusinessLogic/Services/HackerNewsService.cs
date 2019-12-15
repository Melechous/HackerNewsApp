using BusinessLogic.Interfaces;
using BusinessLogic.Service_Contracts;
using DataProviders.Data_Contracts;
using DataProviders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class HackerNewsService : IHackerNewsService
    {
        private readonly IHackerNewsDataProvider _hackerNewsProvider;

        public HackerNewsService(IHackerNewsDataProvider hackerNewsProvider)
        {
            _hackerNewsProvider = hackerNewsProvider;
        }

        public async Task<List<NewsStory>> GetTopNewsStoryIdsAsync(int limit)
        {
            // Get top story ids
            var topStoryIds = await _hackerNewsProvider.GetTopStoriesAsync();

            // Asyncrhonously get details for top stories up to the limit
            List<Task<HackerNewsItemContract>> tasks = topStoryIds.Take(limit).Select(
                x => _hackerNewsProvider.GetItemByIdAsync(x)).ToList();
            
            // Wait for all the async calls to finish
            await Task.WhenAll(tasks);

            // Return the top stories
            return tasks.Select(x => new NewsStory(x.Result)).ToList();
        }

        public NewsStory GetNewsStoryById(int storyId)
        {
            var contract = _hackerNewsProvider.GetItemByIdAsync(storyId).Result;
            var story = new NewsStory(contract);
            
            /*contract.kids.ForEach(x => story.Comments.Add(
                new Comment(_hackerNewsProvider.GetItemByIdAsync(x).Result))
            );*/


            return story;
        }
    }
}
