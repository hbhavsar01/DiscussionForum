using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace DiscussionForum.DataAccess
{
    public class LoginAuthenticate
    {
        public static int Authenticateuser(string userName, string password)
        {
            int returnUserId = -1;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ForumData"].ToString();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "SP_AuthenticateUser";


            SqlParameter userParam = new SqlParameter("@Username", System.Data.SqlDbType.VarChar);
            SqlParameter passwordParm = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);
            userParam.Value = userName;
            passwordParm.Value = password;
            command.Parameters.Add(userParam);
            command.Parameters.Add(passwordParm);


            try
            {
                conn.Open();
                returnUserId = int.Parse(command.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }


            return returnUserId;

        }
    }
}