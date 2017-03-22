using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.DataAccess;
using System.Web.Security;

namespace DiscussionForum.UserCtrl
{
    public partial class MenuBar : System.Web.UI.UserControl
    {
        string username ="";
        public void Page_Load(object sender, EventArgs e)
        {
            lbldisplay.Text = Session["username"].ToString();
            username = Session["username"].ToString();

          

        }

      
        public void lnkprofile_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx?uname=" + username);
            

        }

        protected void lnklogout_Click(object sender, EventArgs e)
        {
           Session.Abandon();
           FormsAuthentication.SignOut();
           Response.Redirect("loginn.aspx");              

        }
    }
}