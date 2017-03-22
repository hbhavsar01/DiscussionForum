using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text;

namespace DiscussionForum.DataAccess
{
    public   class deleterecords
    {
        public void DeleteRecords(StringCollection sc)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());

         //   conn = new SqlConnection(connectionString);

            StringBuilder sb = new StringBuilder(string.Empty);

            foreach (string item in sc)
            {

                const string sqlStatement = "DELETE FROM EditableGridView WHERE ID";

                sb.AppendFormat("{0}='{1}'; ", sqlStatement, item);

            }

            try
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

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