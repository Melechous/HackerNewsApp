using DataProviders.Data_Contracts;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests.Mock_Classes
{
    public class Mock_MemoryCache : IMemoryCache
    {
        private readonly List<HackerNewsItemContract> _mockCache;

        public Mock_MemoryCache (List<HackerNewsItemContract> mockCache)
        {
            _mockCache = mockCache;
        }

        public ICacheEntry CreateEntry(object key)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(object key, out object value)
        {
            value = _mockCache.FirstOrDefault(x => x.id == (int)key);
            return true;
        }
    }
}
