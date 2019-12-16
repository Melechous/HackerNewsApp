using BusinessLogic.Services;
using DataProviders.Data_Contracts;
using DataProviders.Data_Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Mock_Classes;
using Xunit.Sdk;

namespace UnitTests
{
    [TestClass]
    public class HackerNewsDataProvider_Test
    {
        [TestMethod]
        public void GetItemByIdAsync_ReturnsFromCache()
        {
            var random = new Random();
            int randomId = random.Next();
            var mockCache = new List<HackerNewsItemContract> {
                new HackerNewsItemContract()
                {
                    id = randomId
                }
            };
            var target = new HackerNewsDataProvider(new Mock_Configuration(), new Mock_MemoryCache(mockCache));

            var result = target.GetItemByIdAsync(randomId).Result;

            Assert.AreEqual(randomId, result.id);
        }
    }
}
