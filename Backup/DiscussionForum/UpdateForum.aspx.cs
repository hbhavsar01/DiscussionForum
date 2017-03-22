using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.DataAccess;

namespace DiscussionForum
{
    public partial class UpdateForum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = DBHelper.GetData();
                GridView1.DataBind();


            }
        }

       
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
           GridView1.EditIndex = e.NewEditIndex;
           //bind();
           DataBind();

           // GridView1.DataBind();
           

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            GridView1.EditIndex = -1;

            DataBind();

        }

       



    }
}