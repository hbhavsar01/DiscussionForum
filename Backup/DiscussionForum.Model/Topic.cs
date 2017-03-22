using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussionForum.Model
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string TopicTitle { get; set; }
        public string TopicDescription { get; set; }
        public string IsActive { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public int CreatedBy { get; set; }
        public int ForumId { get; set; }

    }
}