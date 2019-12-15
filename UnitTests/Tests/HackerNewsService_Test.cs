using BusinessLogic.Services;
using DataProviders.Data_Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Mock_Classes;
using Xunit.Sdk;

namespace UnitTests
{
    [TestClass]
    public class HackerNewsService_Test
    {
        [TestMethod]
        public void GetTopNewsStoryIdsAsync_ReturnsFromProvider()
        {
            List<int> idResults = new List<int> { 1, 3 };
            List<HackerNewsItemContract> itemResults = new List<HackerNewsItemContract>
            {
                new HackerNewsItemContract(){id = 1},
                new HackerNewsItemContract(){id = 2},
                new HackerNewsItemContract(){id = 3}
            };
            Mock_HackerNewsDataProvider mockProvider = new Mock_HackerNewsDataProvider(idResults, itemResults);
            HackerNewsService target = new HackerNewsService(mockProvider);

            var result = target.GetTopNewsStoryIdsAsync(2).Result;

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(idResults[0], result[0].Id);
            Assert.AreEqual(idResults[1], result[1].Id);
        }
    }
}
