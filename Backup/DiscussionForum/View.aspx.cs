using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.DataAccess;

namespace DiscussionForum
{
    public partial class View : System.Web.UI.Page
    {
        string forumName;
        protected void Page_Load(object sender, EventArgs e)
        {
            forumName = Request.QueryString["ForumName"];
           
            Session["forum"] = forumName;

            if (!IsPostBack)
            {
                TitleLable.Text = forumName;
                ShowAddTopicByForumName.DataSource = DBHelper.GetTopicData(forumName);
                ShowAddTopicByForumName.DataBind();
            }
        }

        protected void NewTopic_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AddNewTopic.aspx?ForumName =" + forumName);
            
        }
    }
}