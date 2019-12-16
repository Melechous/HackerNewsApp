using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Mock_Classes
{
    public class Mock_Configuration : IConfiguration
    {
        public string this[string key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            throw new NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {
            throw new NotImplementedException();
        }

        public IConfigurationSection GetSection(string key)
        {
            switch (key)
            {
                case "hackerNewsURL":
                    return new Mock_ConfigurationSection("https://hacker-news.firebaseio.com/");

                case "topStoryLimit":
                    return new Mock_ConfigurationSection("20");

                default:
                    return null;
            }
        }
    }

    public class Mock_ConfigurationSection : IConfigurationSection
    {
        private readonly string _value;

        public Mock_ConfigurationSection(string value)
        {
            _value = value;
        }

        public string this[string key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Key => throw new NotImplementedException();

        public string Path => throw new NotImplementedException();

        public string Value { get => _value; set => throw new NotImplementedException(); }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            throw new NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {
            throw new NotImplementedException();
        }

        public IConfigurationSection GetSection(string key)
        {
            throw new NotImplementedException();
        }
    }
}
