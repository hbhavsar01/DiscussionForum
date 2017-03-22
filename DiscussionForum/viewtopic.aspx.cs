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
    public partial class viewtopic : System.Web.UI.Page
    {
        string topic;
        int topicID;
        public  void Page_Load(object sender, EventArgs e)
        {
             topic = Request.QueryString["topicTitle"];
             topicID = DBHelper.GetTopicId(topic);
            
            if (!IsPostBack)
            {
                GetDescriptionRepeater.DataSource = DBHelper.GetTopicDescription(topic);
                GetDescriptionRepeater.DataBind();

                ShowPosts.DataSource = DBHelper.GetPostContent(topic);
                ShowPosts.DataBind();

                
            }

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Post p = new Post();
            p.PostContent = txtReply.Text;
            p.IsActive = "true";
            p.DateCreated = DateTime.Now;
            p.DateModified = DateTime.Now;
            p.CreatedBy = 2;
            p.TopicId = topicID;

            bool post = DataInsert.PostTopic(p);

            Response.Redirect("PostSubmitConformation.aspx");
           

        }

    }
       
}