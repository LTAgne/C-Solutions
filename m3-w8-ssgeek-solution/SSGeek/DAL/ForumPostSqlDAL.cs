using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
    public class ForumPostSqlDAL : IForumPostDAL
    {
        private const string SQL_GetPosts = "SELECT * FROM forum_post ORDER BY post_date DESC";
        private const string SQL_NewPost = "INSERT INTO forum_post VALUES (@username, @subject, @message, getdate());";
        private readonly string connectionString;

        public ForumPostSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<ForumPost> GetAllPosts()
        {
            List<ForumPost> output = new List<ForumPost>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetPosts, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        output.Add(new ForumPost()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Username = Convert.ToString(reader["username"]),
                            Subject = Convert.ToString(reader["subject"]),
                            Message = Convert.ToString(reader["message"]),
                            PostDate = Convert.ToDateTime(reader["post_date"])
                        });
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        public bool SaveNewPost(ForumPost post)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_NewPost, conn);
                    cmd.Parameters.AddWithValue("@username", post.Username);
                    cmd.Parameters.AddWithValue("@subject", post.Subject);
                    cmd.Parameters.AddWithValue("@message", post.Message);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}