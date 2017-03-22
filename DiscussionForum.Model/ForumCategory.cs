using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussionForum.Model
{
    public class ForumCategory
    {
        public int CategoryId { get; set; }
        public string ForumCatName { get; set; }
        public string IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

    }
}