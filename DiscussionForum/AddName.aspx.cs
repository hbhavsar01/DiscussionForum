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
    public partial class AddName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            EditGridView ed = new EditGridView();
            ed.Name = txtName.Text;
            ed.IsActive = txtisactive.Text;
            
          //  bool createUser = DBHelper.CreateUser(u);
          //  bool add = AddNam

            // bool Add = AddName.addname(a);
            //bool add= AddName.
          //  bool add = AddName.name(ed);

        }
    }
}