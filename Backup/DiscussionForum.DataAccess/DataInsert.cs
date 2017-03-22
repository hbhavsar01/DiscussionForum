using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DiscussionForum.Model;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DiscussionForum
{
    public static class  DataInsert
    {
        public static bool Registeruser(User u)
        {
            bool register = false;                       
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ConnectionString);
            string sql = @"insert into Users(UserName,UserPassword,FirstName,LastName,DOB,DateJoin,Email,IsActive,UserTypeID)" +
                          " Values('" + u.UserName + "','" + u.UserPassword + "','" + u.FirstName + "','" + u.LastName + "','" + u.DOB + "','" + u.DateJoin + "','" + u.email + "','" + u.IsActive + "','" + u.UserTypeId + "');";
            SqlCommand cmd = new SqlCommand(sql,conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                register = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return register;          
        }
        public static bool PostTopic(Post p)
        {
            bool post = false;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ConnectionString);
            string sql = @"insert into Post(PostContent,IsActive,DateCreated,DateModified,CreatedBy,TopicId)" +
                          " Values('" + p.PostContent + "','" + p.IsActive + "','" + p.DateCreated + "','" + p.DateModified + "','" + p.CreatedBy + "','" + p.TopicId +"');";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                post = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return post;
        }
    }
}