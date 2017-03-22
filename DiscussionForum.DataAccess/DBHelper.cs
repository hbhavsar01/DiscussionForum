using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DiscussionForum.Model;
using System.Configuration;
using System.Data;
using System.Collections.Specialized;
using DiscussionForum.Model.DTO;

namespace DiscussionForum.DataAccess
{
    public static class DBHelper
    {
        //public string connstring = @"Data Source=AMRIT-THINK\SQLEXPRESS;Initial Catalog=DiscussionForum;Integrated Security=SSPI;";
        //private List<ForumCategory> forumcategorys;
        public static List<User> getuserdata(string uname)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
            string sql = @"select * from Users where UserName = '" + uname + "';";
             
            conn.Open();
            List<User> u = new List<User>();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    User userdata = new User();
                    userdata.UserId = int.Parse(rdr["UserId"].ToString());
                    userdata.UserName = (rdr["UserName"].ToString());
                    userdata.FirstName = rdr["FirstName"].ToString();
                    userdata.LastName = rdr["LastName"].ToString();
                    userdata.DateJoin = DateTime.Parse(rdr["DateJoin"].ToString());
                    userdata.UserPassword = (rdr["UserPassword"].ToString());
                    userdata.email = (rdr["email"].ToString());
                    userdata.DOB = DateTime.Parse(rdr["DOB"].ToString());
                    userdata.IsActive = (rdr["IsActive"].ToString());
                    //userdata.Add(u);
                    u.Add(userdata);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return u;

           

        }

       
        public static List<User> GetUser()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
            //SqlConnection conn = new SqlConnection(connstring);

            //SqlConnection conn = new SqlConnection(connstring);

            string sql = @"Select * from Users";
            conn.Open();
            List<User> user = new List<User>();


            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    User u = new User();
                    u.UserId = int.Parse(rdr["UserId"].ToString());
                    u.UserName = (rdr["UserName"].ToString());
                    u.UserPassword = (rdr["UserPassword"].ToString());
                    u.email = (rdr["email"].ToString());
                    u.DOB = DateTime.Parse(rdr["DOB"].ToString());
                    u.IsActive = (rdr["IsActive"].ToString());
                    user.Add(u);
                }
                
            }
            catch { }
            finally { conn.Close(); }
            return user;
        }

        public static List<Topic> GetTopic()
        {
          //  SqlConnection conn = new SqlConnection(connstring);
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());



            string sql = @"select * from Topic";
            List<Topic> topics = new List<Topic>();


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                
                while (rdr.Read())
                {
                    Topic topic = new Topic();
                    topic.TopicId = Convert.ToInt32(rdr["TopicId"].ToString());
                    topic.TopicTitle = (rdr["TopicTitle"].ToString());
                    topic.TopicDescription = (rdr["TopicDescription"].ToString());
                    topic.IsActive = (rdr["IsActive"].ToString());
                    topic.DateCreated = (rdr["DateCreated"].ToString());
                    topic.DateModified = (rdr["DateModified"].ToString());
                    topic.CreatedBy = Convert.ToInt32(rdr["CreatedBy"].ToString());
                    topics.Add(topic);
                    
                }
             }
            catch{ }
            finally
            {
                conn.Close();
            }
            return topics;

        }

        public static List<Post> GetReply()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
            string sql = @"select * from Post";
            List<Post> reply = new List<Post>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Post r = new Post();
                    r.PostId = int.Parse(rdr["Post"].ToString());
                    r.PostContent = rdr["PostContent"].ToString();
                    r.IsActive = rdr["IsActive"].ToString();
                    r.DateCreated = DateTime.Parse(rdr["DateCreated"].ToString());
                    r.DateModified = DateTime.Parse(rdr["DateModified"].ToString());
                    r.CreatedBy = int.Parse(rdr["CreatedBy"].ToString());
                    reply.Add(r);


                }
            }
            catch { }
            finally { conn.Close(); }
            return reply;

        }

        public static List<ForumCategory> GetForumCategory()
        {
         
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
            

            string sql = @"select * from ForumCategory";
            List<ForumCategory> forumcategory = new List<ForumCategory>();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ForumCategory fc = new ForumCategory();
                    fc.CategoryId = int.Parse(rdr["CategoryId"].ToString());
                    fc.ForumCatName = (rdr["Name"].ToString());
                    fc.IsActive = (rdr["IsActive"].ToString());
                    fc.DateCreated = DateTime.Parse(rdr["DateCreated"].ToString());
                    fc.CreatedBy = (rdr["CreatedBy"].ToString());
                    forumcategory.Add(fc);


                }

            }
            catch { }
            finally { conn.Close(); }
            return forumcategory;
        }
        public static List<Forum> GetForum()
        {
           // SqlConnection conn = new SqlConnection(connstring);
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());

            string sql = @"select * from Forum";
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

            catch {}
            finally { conn.Close(); }
            return forum;

        }
        public static List<EditGridView> GetData()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());

            string sql = @"select * from EditableGridView";
            List<EditGridView> editgridview = new List<EditGridView>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EditGridView ed = new EditGridView();
                    ed.Id = int.Parse(rdr["ID"].ToString());
                    ed.Name = (rdr["Name"].ToString());
                    ed.IsActive = rdr["IsActive"].ToString();
                    editgridview.Add(ed);

                }


            }

            catch { }
            finally { conn.Close(); }
            return editgridview;


        }
        public static List<Forum> DisplaySubList(int forumcat_id)
        {
            // SqlConnection conn = new SqlConnection(connstring);
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());

            string sql = @"select * from Forum  where CategoryId = " + forumcat_id + "";
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

        public static List<ForumDTO> GetForumbyName(string forumCat)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
          //  string sql =@"select * from Forum where CategoryID = " + id +"";
            List<ForumDTO> forumbyname = new List<ForumDTO>();
          
            

         /*   string sql= @"select  FC.CategoryId, F.ForumId, F.Name, T.TopicDescription,s.NumberofTopics,"
                            + "ISNULL(test.NumberOfPost,0)As  NumberofPostfrom  ForumCategory FC inner join Forum F"
                                +"on F.CategoryId = FC.CategoryId inner join Topic T on T.ForumId = F.ForumId"
                                    +"inner join (select ForumId,COUNT(TopicId) as NumberofTopics from Topic group by ForumId)as s"
                                        +"on s.ForumId = F.ForumId left join (select TopicId, COUNT(PostId)as NumberOfPost from Post"
                                            + "group by TopicId )as test on test.TopicId = T.TopicId where FC.Name = '" + forumCat + "';";  */
  
          //  string sql =@"select  FC.CategoryId, F.ForumId, F.Name, T.TopicDescription,s.NumberofTopics,ISNULL(test.NumberOfPost,0)As  NumberofPost from  ForumCategory FC inner join Forum F on F.CategoryId = FC.CategoryId inner join Topic T on T.ForumId = F.ForumId inner join (select ForumId,COUNT(TopicId) as NumberofTopics from Topic group by ForumId)as s on s.ForumId = F.ForumId left join (select TopicId, COUNT(PostId)as NumberOfPost from Post group by TopicId )as test on test.TopicId = T.TopicId where FC.Name = '" + forumCat + "';";
            string sql = @"select distinct F.Name,F.CategoryId,S.ForumId,temp.TopicDescription,S.NumberOfTopics,ISNULL(temp.NumberOfPosts,0)as NumberOfPost from ForumCategory FC inner join Forum F on F.CategoryId = FC.CategoryId inner join(select T.ForumId, COUNT(T.TopicId)as NumberOfTopics from Topic T group by T.ForumId)as S on S.ForumId = F.ForumId left join(select T.TopicId,T.ForumId,T.TopicDescription,COUNT(P.PostId)as NumberOfPosts from  Topic T inner join Post P on P.TopicId= T.TopicId Group By T.TopicId,T.ForumId,T.TopicDescription )as temp on temp.ForumId = S.ForumId where FC.Name = '" + forumCat + "';";


            

                          
         
            
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ForumDTO fn = new ForumDTO();
                    fn.ForumName = rdr["Name"].ToString();
                    fn.CategoryId = int.Parse(rdr["CategoryId"].ToString());
                    fn.ForumId=int.Parse(rdr["ForumId"].ToString());
                    fn.Description = rdr["TopicDescription"].ToString();
                    fn.NumberOfTopics = int.Parse(rdr["NumberofTopics"].ToString());
                    fn.NumberOfPosts = int.Parse(rdr["NumberofPost"].ToString());

                    forumbyname.Add(fn);
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return forumbyname;
        }

        public static List<TopicDTO> GetTopicData(string forumName)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
            List<TopicDTO> topicname = new List<TopicDTO>();
           // string sql = @"select  S.ForumId,temp.TopicId,temp.TopicTitle,ISNULL(temp.NumberOfPosts,0)as NumberOfReplies,(UT.Type) as Author from ForumCategory FC inner join Forum F on F.CategoryId = FC.CategoryId inner join(select T.ForumId,COUNT(T.TopicId)as NumberOfTopics from Topic T group by T.ForumId)as S on S.ForumId = F.ForumId left join(select T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy,COUNT(P.PostId)as NumberOfPosts from  Topic T inner join Post P on P.TopicId= T.TopicId Group By T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy )as temp on temp.ForumId = S.ForumId inner join Users U on U.UserTypeID = temp.CreatedBy inner join UserType UT on UT.UserTypeID = U.UserTypeID where F.Name='" + forumName + "';";
            string sql =@"select F.ForumId,T.TopicId,T.TopicTitle,temp.NumberOfPosts,U.UserName as Author from Forum F inner join Topic T on T.ForumId = F.ForumId inner join(select T.TopicId,COUNT(P.PostId)as NumberOfPosts from  Topic T left join Post P on P.TopicId= T.TopicId Group By T.TopicId)as temp on temp.TopicId = T.TopicId inner join Users U on T.CreatedBy = U.UserId where F.Name = '" + forumName + "';";



            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    TopicDTO t = new TopicDTO();
                    t.ForumId = int.Parse(rdr["ForumId"].ToString());
                    t.TopicId = int.Parse(rdr["TopicId"].ToString());
                    t.Title = (rdr["TopicTitle"].ToString());
                    t.NumberOfPosts = int.Parse(rdr["NumberOfPosts"].ToString());
                    t.Author=rdr["Author"].ToString();
                    topicname.Add(t);
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return topicname;
        }

        public static List<TopicDescriptionDTO> GetTopicDescription(string topic)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
            List<TopicDescriptionDTO> topicname = new List<TopicDescriptionDTO>();
            //string sql = @"select distinct S.ForumId,temp.TopicId,temp.TopicTitle,ISNULL(temp.NumberOfPosts,0)as NumberOfReplies,(UT.Type) as Author from ForumCategory FC inner join Forum F on F.CategoryId = FC.CategoryId inner join(select T.ForumId,COUNT(T.TopicId)as NumberOfTopics from Topic T group by T.ForumId)as S on S.ForumId = F.ForumId left join(select T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy,COUNT(P.PostId)as NumberOfPosts from  Topic T inner join Post P on P.TopicId= T.TopicId Group By T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy )as temp on temp.ForumId = S.ForumId inner join Users U on U.UserTypeID = temp.CreatedBy inner join UserType UT on UT.UserTypeID = U.UserTypeID where F.Name='" + forumName + "';";
            string sql = @"select distinct temp.TopicDescription  from ForumCategory FC inner join Forum F on F.CategoryId = FC.CategoryId inner join(select T.ForumId,COUNT(T.TopicId)as NumberOfTopics from Topic T group by T.ForumId)as S on S.ForumId = F.ForumId left join(select T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy,COUNT(P.PostId)as NumberOfPosts from  Topic T inner join Post P on P.TopicId= T.TopicId Group By T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy )as temp on temp.ForumId = S.ForumId inner join Users U on U.UserTypeID = temp.CreatedBy inner join UserType UT on UT.UserTypeID = U.UserTypeID where temp.TopicTitle='" + topic + "';";



            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    TopicDescriptionDTO t = new TopicDescriptionDTO();
                    t.Description = rdr["TopicDescription"].ToString();
                    
                  //  t.ForumId = int.Parse(rdr["ForumId"].ToString());
                   // t.TopicId = int.Parse(rdr["TopicId"].ToString());
                    //t.Title = (rdr["TopicTitle"].ToString());
                    //t.NumberOfPosts = int.Parse(rdr["NumberOfReplies"].ToString());
                    //t.Author = rdr["Author"].ToString();
                    topicname.Add(t);
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return topicname;
        }


        public static List<PostContentDTO> GetPostContent(string topic)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
            List<PostContentDTO> topicname = new List<PostContentDTO>();
            //string sql = @"select distinct S.ForumId,temp.TopicId,temp.TopicTitle,ISNULL(temp.NumberOfPosts,0)as NumberOfReplies,(UT.Type) as Author from ForumCategory FC inner join Forum F on F.CategoryId = FC.CategoryId inner join(select T.ForumId,COUNT(T.TopicId)as NumberOfTopics from Topic T group by T.ForumId)as S on S.ForumId = F.ForumId left join(select T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy,COUNT(P.PostId)as NumberOfPosts from  Topic T inner join Post P on P.TopicId= T.TopicId Group By T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy )as temp on temp.ForumId = S.ForumId inner join Users U on U.UserTypeID = temp.CreatedBy inner join UserType UT on UT.UserTypeID = U.UserTypeID where F.Name='" + forumName + "';";
           // string sql = @"select distinct temp.TopicDescription  from ForumCategory FC inner join Forum F on F.CategoryId = FC.CategoryId inner join(select T.ForumId,COUNT(T.TopicId)as NumberOfTopics from Topic T group by T.ForumId)as S on S.ForumId = F.ForumId left join(select T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy,COUNT(P.PostId)as NumberOfPosts from  Topic T inner join Post P on P.TopicId= T.TopicId Group By T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy )as temp on temp.ForumId = S.ForumId inner join Users U on U.UserTypeID = temp.CreatedBy inner join UserType UT on UT.UserTypeID = U.UserTypeID where temp.TopicTitle='" + topic + "';";
            string sql=@"select  distinct temp.PostContent from ForumCategory FC inner join Forum F on F.CategoryId = FC.CategoryId inner join(select T.ForumId,COUNT(T.TopicId)as NumberOfTopics from Topic T group by T.ForumId)as S on S.ForumId = F.ForumId left join(select T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy,P.PostContent, COUNT(P.PostId)as NumberOfPosts from  Topic T inner join Post P on P.TopicId= T.TopicId  Group By T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy,P.PostContent )as  temp on temp.ForumId = S.ForumId inner join Users U on U.UserTypeID = temp.CreatedBy   inner join UserType UT on UT.UserTypeID = U.UserTypeID where   temp.TopicTitle='" + topic + "';";  



            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    PostContentDTO t = new PostContentDTO();
                    t.Postcontent = rdr["PostContent"].ToString();

                    //  t.ForumId = int.Parse(rdr["ForumId"].ToString());
                    // t.TopicId = int.Parse(rdr["TopicId"].ToString());
                    //t.Title = (rdr["TopicTitle"].ToString());
                    //t.NumberOfPosts = int.Parse(rdr["NumberOfReplies"].ToString());
                    //t.Author = rdr["Author"].ToString();
                    topicname.Add(t);
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return topicname;
        }



        public static int GetforumId(string forumName)
        {
            int forumId =0;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
           // string sql = @"select ForumId from Forum where Name =" + forumName + " ";
            string sql = @"select ForumId from Forum where Name ='" + forumName + "';";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    forumId= int.Parse(rdr[0].ToString());
                    
                }
                
            }
            catch(Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return forumId;
               
        }


        public static int GetTopicId(string topicTitle)
        {
            int topicId = 0;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());
            string sql = @"select distinct temp.TopicId  from ForumCategory FC inner join Forum F on F.CategoryId = FC.CategoryId inner join(select T.ForumId,COUNT(T.TopicId)as NumberOfTopics from Topic T group by T.ForumId)as S on S.ForumId = F.ForumId left join(select T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy,COUNT(P.PostId)as NumberOfPosts from  Topic T inner join Post P on P.TopicId= T.TopicId Group By T.TopicId,T.ForumId,T.TopicDescription,T.TopicTitle,P.CreatedBy )as temp on temp.ForumId = S.ForumId inner join Users U on U.UserTypeID = temp.CreatedBy inner join UserType UT on UT.UserTypeID = U.UserTypeID where temp.TopicTitle='" + topicTitle + "';";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    topicId = int.Parse(rdr[0].ToString());

                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return topicId;

        }




        public static List<ForumDTO> GetForumData(int forumCatId)
        {
            // SqlConnection conn = new SqlConnection(connstring);
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumData"].ToString());


            /*string sql = @"select  FC.CategoryId, F.ForumId, F.Name, T.TopicDescription,s.NumberofTopics,ISNULL(test.NumberOfPost,0)As  NumberofPost  from  ForumCategory FC inner join"
                            + "Forum F on F.CategoryId = FC.CategoryId inner join"
                            + "Topic T on T.ForumId = F.ForumId inner join"
                            + "((select ForumId,COUNT(TopicId) as NumberofTopics from Topic group by ForumId)as s on s.ForumId = F.ForumId left join"
                            + "(select TopicId, COUNT(PostId)as NumberOfPost from Post group by TopicId )as test"
                            + "on test.TopicId = T.TopicId where FC.CategoryId = ' "+ forumCatId +"'; ";    */


            string sql = @"select  FC.CategoryId, F.ForumId, F.Name, T.TopicDescription,s.NumberofTopics,ISNULL(test.NumberOfPost,0)As  NumberofPost"
                         + "from  ForumCategory FC inner join Forum F on F.CategoryId = FC.CategoryId inner join Topic T"
                            + "on T.ForumId = F.ForumId inner join (select ForumId,COUNT(TopicId) as NumberofTopics from Topic group by ForumId)as s"
                                + "on s.ForumId = F.ForumId left join (select TopicId, COUNT(PostId)as NumberOfPost from Post group by TopicId )as test"
                                     + "on test.TopicId = T.TopicId where FC.CategoryId = " + forumCatId + "";                                 
         
            List<ForumDTO> forum = new List<ForumDTO>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ForumDTO f = new ForumDTO();
                    f.CategoryId = int.Parse(rdr["CategoryID"].ToString());
                    f.ForumId = int.Parse(rdr["ForumID"].ToString());
                    f.ForumName = (rdr["Name"].ToString());
                //    f.Description=rdr["Description"].ToString();
                    f.NumberOfTopics =int.Parse(rdr["NumberOfTopics"].ToString());
                   // f.NumberOfReplies = (rdr["NumberOfReplies"].ToString());
                    forum.Add(f);

                }


            }

            catch { }
            finally { conn.Close(); }
            return forum;

        }
       
       

    }
}