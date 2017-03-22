using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussionForum.Model
{
    public class Forum
    {
        public int ForumId { get; set; }
        public string ForumName { get; set; }
        public string IsActive { get; set; }
        public string DateCreated { get; set; }
        public int CreatedBy { get; set; }
        public int ForumCategoryId { get; set; }

    }
}