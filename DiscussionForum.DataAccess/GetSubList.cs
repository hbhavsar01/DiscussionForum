using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using DiscussionForum.Model;

namespace DiscussionForum.DataAccess
{
    public  class GetSubList
    {
        
        public  List<Forum> DisplaySubList(int ID)
        {
            // SqlConnection conn = new SqlConnection(connstring);
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());

            string sql = @"select * from Forum CategoryId = " + ID + "";
            List<Forum> forum = new List<Forum>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Forum f = new Forum();
                    f.ForumId = int.Parse(rdr["ForumID"].ToString());
                    f.ForumName = (rdr["Name"].ToString());
                    f.IsActive = (rdr["IsActive"].ToString());
                    f.DateCreated = (rdr["DateCreated"].ToString());
                    f.CreatedBy = int.Parse(rdr["CreatedBy"].ToString());
                    //   f.CreatedBy = rdr["CreatedBy"].ToString();
                    // f.ForumCategoryId = Convert.ToInt32(rdr["ForumCategoryId"].ToString());
                    //  f.ForumCategoryId = int.Parse(rdr["ForumCategoryId"].ToString());
                    forum.Add(f);

                }


            }

            catch { }
            finally { conn.Close(); }
            return forum;

        }
       

    }
}