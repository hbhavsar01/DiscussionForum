using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussionForum.Model
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostContent { get; set; }
        public string IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int CreatedBy { get; set; }
        public int TopicId { get; set; }

    }
}