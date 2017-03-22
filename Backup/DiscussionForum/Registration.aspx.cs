using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.Model;
using DiscussionForum.DataAccess;
using System.Web.Security;

namespace DiscussionForum
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.UserName = txtUsername.Text;
            u.UserPassword = txtPassword.Text;
            u.FirstName = txtFName.Text;
            u.LastName = txtLName.Text;
            u.DOB = Convert.ToDateTime(txtDOB.Text);
           // u.DOB = CalDOB.SelectedDate;
            u.DateJoin = DateTime.Now;
            u.email = txtEmail.Text;
            u.IsActive = "2";
            u.UserTypeId = 2;


            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
			            
            MembershipCreateStatus status = MembershipCreateStatus.DuplicateUserName;
            try
            {
                MembershipUser user = Membership.CreateUser(userName, passWord, txtEmail.Text, "n/a", "n/a", true, out status);
              /*  if (status == MembershipCreateStatus.Success)
                {
                    FormsAuthenticationTicket ticket1 = new FormsAuthenticationTicket(u.UserName, false, 30);
                    HttpCookie cookie1 = new HttpCookie(FormsAuthentication.FormsCookieName,
                    FormsAuthentication.Encrypt(ticket1));
                    Response.Cookies.Add(cookie1);
                    bool regis = DataInsert.Registeruser(u);
                    Response.Redirect("default1.aspx");

                }*/
                if (user == null)
                {
                    msg.Text = GetErrorMessage(status);
    
                }
                else
                {

                    bool regis = DataInsert.Registeruser(u);
                    Response.Redirect("AccountCreated.aspx");

                }
            }
            catch (Exception ex)
            {
                var x = ex;
                msg.Text = "An exception occurred creating the user.";

            }
           
            
        }

       protected void txtCalender_SelectionChanged(object sender, EventArgs e)
        {
            txtDOB.Text = txtCalender.SelectedDate.ToShortDateString();

       
        }
        public string GetErrorMessage(MembershipCreateStatus status)
        {
            switch (status)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Username already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A username for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtDOB.Text = "";
            txtDatejoin.Text = "";
            txtEmail.Text = "";

        }
    }
}