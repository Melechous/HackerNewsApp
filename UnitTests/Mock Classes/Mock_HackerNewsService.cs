using BusinessLogic.Interfaces;
using BusinessLogic.Service_Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Mock_Classes
{
    public class Mock_HackerNewsService : IHackerNewsService
    {
        private readonly bool _throwException;

        public Mock_HackerNewsService(bool throwException)
        {
            _throwException = throwException;
        }

        public Task<List<NewsStory>> GetTopNewsStoryIdsAsync(int limit)
        {
            if (_throwException)
            {
                throw new Exception("Test Exception");
            }

            return null;
        }
    }
}
