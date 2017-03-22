using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.DataAccess;
using System.Web.Security;

namespace DiscussionForum
{
    public partial class loginn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["username"] = txtuname.Text.ToString();

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
             
            int UserId = LoginAuthenticate.Authenticateuser(txtuname.Text, txtpasswd.Text);

            if (UserId != -1)
            {
                FormsAuthenticationTicket ticket1 = new FormsAuthenticationTicket(1, UserId.ToString(),
                    DateTime.Now, DateTime.Now.AddMinutes(30), false, "HR");
                HttpCookie cookie1 = new HttpCookie(FormsAuthentication.FormsCookieName,
                    FormsAuthentication.Encrypt(ticket1));
                Response.Cookies.Add(cookie1);
                Response.Redirect("Home.aspx");
            }
            else
            {
               // Response.Write("Invalid User");
                Response.Redirect("Invaliduser.aspx");
       

            }
      

        
        }
    }
}