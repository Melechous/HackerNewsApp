using BusinessLogic.Interfaces;
using DataProviders.Data_Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Service_Contracts
{
    public class HackerNewsBase
    {
        public int Id;
        public string Author;

        public HackerNewsBase(HackerNewsItemContract contract)
        {
            Id = contract.id;
            Author = contract.by;
        }
    }

    public class NewsStory : HackerNewsBase
    {
        public string StoryURL;
        public string Title;
        public List<Comment> Comments;

        public NewsStory(HackerNewsItemContract contract) : base(contract)
        {
            StoryURL = contract.url;
            Title = contract.title;
            Comments = new List<Comment>();
        }
    }

    public class Comment : HackerNewsBase
    {
        public string CommentText;
        public List<Comment> SubComments;

        public Comment(HackerNewsItemContract contract) : base(contract)
        {
            CommentText = contract.text;
            SubComments = new List<Comment>();
        }
    }


}
