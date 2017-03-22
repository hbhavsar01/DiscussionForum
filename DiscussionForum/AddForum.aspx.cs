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
    public partial class AddForum : System.Web.UI.Page
    {
        public int forumcat_id;
        public int forumid;

        public void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                DropDownList1.DataSource = DBHelper.GetForumCategory();
                // DropDownList1.DataTextField = "CategoryId";
                // DropDownList1.DataTextField = "Name";
                DropDownList1.DataBind();
            }
               
               
        }
        public void SelectedIndexChange_forumcategory(object sender, EventArgs e)
        {
            forumcat_id =int.Parse( DropDownList1.SelectedItem.Value);
            DropDownList2.DataSource = DBHelper.DisplaySubList(forumcat_id);
         //   DropDownList2.DataTextField = "Name";
            DropDownList2.DataBind();
            
       }

        public void SelectedIndexChange_forum(object sender, EventArgs e)
        {
             forumid = int.Parse(DropDownList2.SelectedItem.Value);
           
          /* Topic topic = new Topic();
            topic.TopicTitle = txttopic.Text;
            topic.TopicDescription = contentTB.Text;
            topic.IsActive = "false";
            topic.DateCreated = DateTime.Now.ToString();
            topic.DateModified = DateTime.Now.ToString();
            topic.CreatedBy = 2;
            topic.ForumId = forumid;

            TopicPost tp = new TopicPost();
            bool createtopic = tp.PostTopic(topic);
       */
            
        }

        public void btnsbmit_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.TopicTitle = txttopic.Text;
            topic.TopicDescription = contentTB.Text;
            topic.IsActive = "false";
            topic.DateCreated = DateTime.Now.ToString();
            topic.DateModified = DateTime.Now.ToString();
            topic.CreatedBy = 2;
            topic.ForumId = forumid;

          //  TopicPost tp = new TopicPost();
            bool createtopic = TopicPost.PostTopic(topic);

            Response.Redirect("sucessmessage.aspx");
        }

        protected void txttopic_TextChanged(object sender, EventArgs e)
        {

        }


       
    }
}