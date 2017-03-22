using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace DiscussionForum.DataAccess
{
    public class update
    {
        public void UPDATE(int id, string name, string isactive)
        {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
     
            
        string sql = "UPDATE EditableGridView SET NAME='" + name +      "',IsActive='" + isactive + "' WHERE ID=" + id + "";



        SqlCommand cmd = new SqlCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        //GridView1.EditIndex = -1;
        //FillGrid();
    }

        

    }
}


