using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussionForum.Model.DTO
{
    public class TopicDTO
    {
        public int ForumId { get; set; }
        public int TopicId { get; set; }
        public string Title { get; set; }
        public int NumberOfPosts { get; set; }
        public string Author { get; set; }

    }
}