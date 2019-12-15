using DataProviders.Data_Contracts;
using DataProviders.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders.Data_Providers
{
    public class HackerNewsDataProvider : IHackerNewsDataProvider
    {
        private readonly HttpClient _hackerNewsHTTPClient;
        private readonly IMemoryCache _hackerNewsCache;

        public HackerNewsDataProvider(IConfiguration config, IMemoryCache cache)
        {
            _hackerNewsHTTPClient = new HttpClient()
            {
                BaseAddress = new Uri(config.GetSection("hackerNewsURL").Value)
            };
            _hackerNewsCache = cache;
        }

        public async Task<HackerNewsItemContract> GetItemByIdAsync(int id)
        {
            // check cache for record
            HackerNewsItemContract result;
            if(_hackerNewsCache.TryGetValue(id, out result))
            {
                return result;
            }

            // if not found in cache, call service synchronously
            var response = await _hackerNewsHTTPClient.GetStringAsync("v0/item/" + id + ".json").ConfigureAwait(false);
            
            // deserialize to object
            result = JsonConvert.DeserializeObject<HackerNewsItemContract>(response, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            // store in cache
            _hackerNewsCache.Set(result.id, result);

            return result;
        }

        public async Task<List<int>> GetTopStoriesAsync()
        {
            var response = await _hackerNewsHTTPClient.GetStringAsync("v0/beststories.json").ConfigureAwait(false);
            var result = JsonConvert.DeserializeObject<List<int>>(response, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return result;
        }
    }
}
