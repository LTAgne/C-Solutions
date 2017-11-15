using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Critter.Web.Models.Data;
using System.Configuration;
using log4net;
using System.Data.SqlClient;

namespace Critter.Web.DataAccess
{
    public class UserSqlDAL : IUserDAL
    {
        private readonly string databaseConnectionString;                

        public UserSqlDAL(string connectionString)
        {
            databaseConnectionString = connectionString;
        }

        public bool ChangePassword(string username, string newPassword)
        {
            try
            {
                string sql = $"UPDATE app_user SET password = '{newPassword}' WHERE user_name = '{username}'";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public bool CreateUser(User newUser)
        {
            try
            {
                string sql = $"INSERT INTO app_user VALUES (@username, @password, @salt, @avatar);";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", newUser.Username);
                    cmd.Parameters.AddWithValue("@password", newUser.Password);
                    cmd.Parameters.AddWithValue("@salt", newUser.Salt);
                    cmd.Parameters.AddWithValue("@avatar", newUser.AvatarId);


                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
            }
            catch(SqlException ex)
            {
                throw;
            }            
        }

        public List<string> GetUsernames(string startsWith)
        {
            List<string> usernames = new List<string>();

            try
            {
                string sql = $"SELECT user_name FROM app_user WHERE user_name LIKE '{startsWith}%';";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        usernames.Add(Convert.ToString(reader["user_name"]));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return usernames;
        }

        public User GetUser(string username)
        {
            User user = null;

            try
            {
                string sql = $"SELECT TOP 1 * FROM app_user WHERE user_name = '{username}'";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user = new User
                        {
                            Username = Convert.ToString(reader["user_name"]),
                            Password = Convert.ToString(reader["password"]),
                            Salt = Convert.ToString(reader["salt"]),
                            AvatarId = Convert.ToInt32(reader["avatar_id"])
                        };
                    }

                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return user;
        }

        public User GetUser(string username, string password)
        {
            User user = null;

            try
            {
                string sql = $"SELECT TOP 1 * FROM app_user WHERE user_name = '{username}' AND password = '{password}'";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user = new User
                        {
                            Username = Convert.ToString(reader["user_name"]),
                            Password = Convert.ToString(reader["password"]),
                            Salt = Convert.ToString(reader["salt"]),
                            AvatarId = Convert.ToInt32(reader["avatar_id"])
                        };
                    }
                    
                }
            }
            catch(SqlException ex)
            {
                throw;
            }

            return user;
        }
    }
}
