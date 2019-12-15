using DataProviders.Data_Providers;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using UnitTests.Mock_Classes;

namespace IntergrationTests
{
    [TestClass]
    public class HackerNewsDataProvider_Test
    {
        [TestMethod]
        public void Test_GetItemById_NoErrors()
        {
            int id = 9224;
            HackerNewsDataProvider target = new HackerNewsDataProvider(new Mock_Configuration(), new MemoryCache(new MemoryCacheOptions()));

            var result = target.GetItemByIdAsync(id).Result;

            Assert.AreEqual(id, result.id, "The Id of the item was not what was requested");
        }


        [TestMethod]
        public void Test_GetTopStories_NoErrors()
        {
            HackerNewsDataProvider target = new HackerNewsDataProvider(new Mock_Configuration(), new MemoryCache(new MemoryCacheOptions()));

            var result = target.GetTopStoriesAsync().Result;

            Assert.IsTrue(result.Count > 0, "Did not return at least one top story id");
        }


    }
}
