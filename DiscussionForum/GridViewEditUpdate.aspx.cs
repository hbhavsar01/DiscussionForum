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
    public partial class GridViewEditUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView3.DataSource = DBHelper.GetData();
                GridView3.DataBind();
            }
        }

        
        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());

            GridViewRow row = (GridViewRow)GridView3.Rows[e.RowIndex];
            Label lbldeleteID = (Label)row.FindControl("lblid");
           
          //  EditableGridView ed = new EditableGridView();
           // ed.DelGridRow(lbldeleteID);
          //  ed.DelGridRow(lbldeleteID);
            EditableGridView ed = new EditableGridView();
            ed.DelGridRow(lbldeleteID);


          /*
            
             
             
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete  EditableGridView where ID=" + lbldeleteID.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            //DataBind();
           * */

           GridView3.DataSource = DBHelper.GetData();
            GridView3.DataBind();
             
             

        }

        protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView3.EditIndex = e.NewEditIndex;
          GridView3.DataSource = DBHelper.GetData();
            GridView3.DataBind();
            //DataBind();
           
        }

        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());

            GridViewRow row = (GridViewRow)GridView3.Rows[e.RowIndex];
            Label lbl = (Label)row.FindControl("lblid");
            TextBox textname = (TextBox)row.FindControl("txtname");
            TextBox textisactive = (TextBox)row.FindControl("txtisactive");

            GridView3.EditIndex = -1;

         /*   conn.Open();
            SqlCommand cmd = new SqlCommand("update  EditableGridView set Name='" + textname.Text + "' , IsActive='" + textisactive.Text + "' where ID=" + lbl.Text + "",conn);

            cmd.ExecuteNonQuery();
            conn.Close();
           // DataBind();*/

            EditableGridView ev = new EditableGridView();
            ev.UpdateGridRow(textname, textisactive, lbl);

           // e.UpdateGridRow(lbl, textname, textisactive);
            GridView3.DataSource = DBHelper.GetData();
            GridView3.DataBind();
          

        }

        protected void GridView3_RowCacelingEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridView3.EditIndex = -1;
           // DataBind();
            GridView3.DataSource = DBHelper.GetData();
            GridView3.DataBind();
          
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}