using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using DiscussionForum.Model;

namespace DiscussionForum.DataAccess
{
    public  static class TopicPost
    {
        public static bool PostTopic(Topic topic)
        {
            bool topicadded = false;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());

            string sql = " insert into Topic(TopicTitle, TopicDescription,IsActive, DateCreated,DateModified, CreatedBy,ForumId)" +
                           "values('" + topic.TopicTitle + "','" + topic.TopicDescription + "','" + topic.IsActive + "', '" + topic.DateCreated + "','" + topic.DateModified + "','" + topic.CreatedBy +"','" + topic.ForumId + "')";

            SqlCommand cmd = new SqlCommand(sql, conn);
               
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                topicadded = true;
            }
            catch { }
            finally { conn.Close(); }
            return topicadded;

        }
    }
}