using DataProviders.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProviders.Data_Contracts
{
    
    public class HackerNewsItemContract
    {
        public int id;
        public bool deleted;
        public string type;
        public string by;
        public int time;
        public string text;
        public bool dead;
        public int parent;
        public int poll;
        public List<int> kids;
        public string url;
        public int score;
        public string title;
        public List<int> parts;
        public int descendants;
    }
}
