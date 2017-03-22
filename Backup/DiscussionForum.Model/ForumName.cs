using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussionForum.Model
{
    public  class ForumName
    {
        public int ForumCategoryID { get; set; }
        public int ForumId { get; set; }
        public string ForumNamee { get; set; }
        public string Description { get; set; }
        public int NumberOfTopics { get; set; }
        public int NumberOfPosts { get; set; }


    }
}