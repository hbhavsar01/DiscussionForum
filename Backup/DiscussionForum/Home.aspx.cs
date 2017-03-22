using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.DataAccess;

namespace DiscussionForum
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ParentRepeater.DataSource = DBHelper.GetForumCategory();
                ParentRepeater.DataBind();
            }
        }

        protected void ParentRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Repeater childRepeater = e.Item.FindControl("ChildRepeater") as Repeater;
            //  int FCatId = int.Parse(DataBinder.Eval(e.Item.DataItem, "CategoryId").ToString());
            // childRepeater.DataSource = DBHelper.GetForumData(FCatId);

            

            System.Web.UI.WebControls.Label lbl = (System.Web.UI.WebControls.Label)e.Item.FindControl("FCName");
            string forumCat = lbl.Text;

            childRepeater.DataSource = DBHelper.GetForumbyName(forumCat);
            childRepeater.DataBind();


        }

       /* protected void forumselected(object sender, RepeaterItemEventArgs e)
        {
            //FInd button "FName"
            //Pass QueryString
             string forumName = ((LinkButton)e.Item.FindControl("FName")).Text;
            // forumName ="/View.aspx?forumName = '+forumName+'";
            Response.Redirect("/view.aspx?forumName ='+ forumName '");

        }*/

       
      
    }
}