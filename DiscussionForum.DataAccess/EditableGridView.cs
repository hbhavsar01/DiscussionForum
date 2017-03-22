using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace DiscussionForum.DataAccess
{
    public class EditableGridView
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());

        public void DelGridRow(Label lbldeleteID)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete  EditableGridView where ID=" + lbldeleteID.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            ;
          //  DataBind();
        }
        public void UpdateGridRow(TextBox textname, TextBox textisactive, Label lbl)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update  EditableGridView set Name='" + textname.Text + "' , IsActive='" + textisactive.Text + "' where ID=" + lbl.Text + "", conn);

            cmd.ExecuteNonQuery();
            conn.Close();
           
        }
           
    }
}