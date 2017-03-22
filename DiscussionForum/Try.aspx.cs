using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.DataAccess;
using System.Data.SqlClient;
using System.Configuration;

namespace DiscussionForum
{
    public partial class Try : System.Web.UI.Page
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
            //DataBind();
            GridView1.DataSource = DBHelper.GetData();
            GridView1.DataBind();

        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.EditIndex = e.NewPageIndex;
            DataBind();

        }


        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            //DataBind();
            GridView1.DataSource = DBHelper.GetData();
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string  id = GridView1.Rows[e.RowIndex].Cells[0].Text;// get the id of the selected row
          // int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value).ToString();
         //  int id =Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            delrow d = new delrow();
            d.del(id);
            GridView1.DataSource = DBHelper.GetData();
            GridView1.DataBind();      

            

        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        int index = GridView1.EditIndex;
        GridViewRow row = GridView1.Rows[index];
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
        string name = ((TextBox)row.Cells[2].Controls[0]).Text.ToString().Trim();
        string isactive = ((TextBox)row.Cells[3].Controls[0]).Text.ToString().Trim();
        update u = new update();
        
      //  update u = new update();
        u.UPDATE(id,name,isactive);



        GridView1.EditIndex = -1;
        GridView1.DataSource = DBHelper.GetData();
        GridView1.DataBind();
//        FillGrid();
    

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdatedEventArgs e)
        {

        }

        




    }
}