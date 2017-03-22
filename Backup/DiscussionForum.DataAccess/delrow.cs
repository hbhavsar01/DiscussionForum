using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DiscussionForum.DataAccess
{
    public class delrow
    {
        public void  del(string id)
        {
             SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());

           //  SqlConnection connection = new SqlConnection(GetConnectionString());

             string sqlStatement = "DELETE FROM EditableGridView WHERE ID = @ID";

             try
             {

                 conn.Open();

                 SqlCommand cmd = new SqlCommand(sqlStatement, conn);

                 cmd.Parameters.AddWithValue("@ID", id);

                 cmd.CommandType = CommandType.Text;

                 cmd.ExecuteNonQuery();

             }

             catch (System.Data.SqlClient.SqlException ex)
             {

                 string msg = "Deletion Error:";

                 msg += ex.Message;

                 throw new Exception(msg);



             }

             finally
             {

                 conn.Close();

             }
            
        }
    }
}