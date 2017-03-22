using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussionForum.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateJoin { get; set; }
        public string email { get; set; }
        public string IsActive { get; set; }
        public int UserTypeId { get; set; }
       
    }
}