using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.DataAccess;
using DiscussionForum.Model;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DiscussionForum
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
        {

           // DBHelper hp = new DBHelper();
           // GridView1.DataSource = DBHelper.GetUser();
                

           //GridView1.DataBind ();
           /* SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
            string sql = @"select Name from ForumCategory";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);*/

           // DropDownList1.DataSource = DBHelper.DropDownList();
            //DropDownList1.DataTextField = "Name";
            //DropDownList1.DataBind();
          
                /*
            DropDownList1.DataSource = DBHelper.GetForumCategory();
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataBind();
                */

            
         
         }



        
    }

        protected void Createbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddForum.aspx");

        }

        protected void Updatebtn_Click(object sender, EventArgs e)
        {


            //Response.Redirect("UpdateForum.aspx");
            Response.Redirect("GridViewEditUpdate.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Deletebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteRecord.aspx");
        }

        }
    }
