using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussionForum.Model.DTO
{
    public class ForumDTO
    {
        public int CategoryId { get; set; }
        public int ForumId { get; set; }
        public string ForumName { get; set; }
        public string Description { get; set; }
        public int NumberOfTopics { get; set; }
        public int NumberOfPosts { get; set; }

        
    }
}