using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.DataAccess;
using DiscussionForum.Model;

namespace DiscussionForum
{
    public partial class AddNewTopic : System.Web.UI.Page
    {
        string forum;
        int findForumId = 0;
     

        public void Page_Load(object sender, EventArgs e)
        {
           // forum = Request.QueryString["ForumName"];
            forum = Session["forum"].ToString();
            
                       

          //  if (!IsPostBack)
            //{
                
                findForumId = DBHelper.GetforumId(forum);
            //}
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.TopicTitle = txtSub.Text;
            topic.TopicDescription = txtDescription.Text;
            topic.IsActive = "false";
            topic.DateCreated = DateTime.Now.ToString();
            topic.DateModified = DateTime.Now.ToString();
            topic.CreatedBy = 2;
            topic.ForumId = findForumId;

            bool createtopic = TopicPost.PostTopic(topic);
            Response.Redirect("TopicPostConformation.aspx");


        }
    }
}