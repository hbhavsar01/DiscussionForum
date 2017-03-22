using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.Model;
using DiscussionForum.DataAccess;

namespace DiscussionForum
{
    public partial class AddTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void btnsbmit_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.TopicTitle = txttopic.Text;
            topic.TopicDescription = contentTB.Text;
            topic.IsActive = "false";
            topic.DateCreated = DateTime.Now.ToString();
            topic.DateModified = DateTime.Now.ToString();
            topic.CreatedBy = 2;

         //   TopicPost tp = new TopicPost();
         //   tp.PostTopic(topic);




        }

       
    }
}