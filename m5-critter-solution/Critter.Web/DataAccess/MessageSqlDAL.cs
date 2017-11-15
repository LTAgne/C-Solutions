using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Critter.Web.Models.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Critter.Web.DataAccess
{
    public class MessageSqlDAL : IMessageDAL
    {
        private readonly string databaseConnectionString;


        
        public MessageSqlDAL(string connectionString)
        {
            databaseConnectionString = connectionString;
        }


        /// <summary>
        /// Creates a new message
        /// </summary>
        public bool CreateMessage(Message message)
        {
            try
            {
                // Insert sql for no recipient
                string sql = $"INSERT INTO message (sender_name, private, receiver_name, message_text, create_date) VALUES (@sender, @private, @receiver, @text, @createdate);";                  

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@sender", message.Sender);
                    cmd.Parameters.AddWithValue("@private", message.IsPrivate);
                    if(message.IsPrivate)
                    {
                        cmd.Parameters.AddWithValue("@receiver", message.Recipient);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@receiver", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@text", message.MessageText);
                    cmd.Parameters.AddWithValue("@createdate", DateTime.UtcNow);

                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }

            }
            catch (SqlException ex)
            {
                throw;
            }
        }


        public void DeleteMessage(int messageId)
        {
            try
            {
                string sql = $"DELETE FROM message WHERE message_id = " + messageId;

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int result = cmd.ExecuteNonQuery();                    
                }

            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public List<Message> GetAllSentMessageForUser(string username)
        {
            List<Message> output = new List<Message>();

            try
            {
                string sql = $"SELECT * FROM message WHERE sender_name = '{username}' ORDER BY create_date DESC";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        output.Add(CreateMessage(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        public List<Conversation> GetConversations(string forUser, DateTime sinceDate)
        {
            List<Conversation> output = new List<Conversation>();

            try
            {
                // We use a UNION query to bring together the results of two different queries.
                string sql = $"SELECT DISTINCT(receiver_name) FROM message WHERE sender_name = '{forUser}' AND private = 1 AND create_date > '{sinceDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff")}' UNION SELECT DISTINCT(sender_name) FROM message WHERE receiver_name = '{forUser}' AND private = 1 AND create_date > '{sinceDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff")}'";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Conversation c = new Conversation()
                        {
                            ForUser = forUser,
                            WithUser = Convert.ToString(reader["receiver_name"]),
                        };

                        c.Messages = GetMessageThread(c.ForUser, c.WithUser, conn);

                        output.Add(c);
                    }
                }

                //Descending sort by latest message
                output.Sort((c1, c2) => -1 * c1.Messages[0].CreatedDate.CompareTo(c2.Messages[0].CreatedDate));
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        /// <summary>
        /// Get all private conversation threads for a given user.
        /// </summary>        
        public List<Conversation> GetConversations(string forUser)
        {
            List<Conversation> output = new List<Conversation>();

            try
            {
                // We use a UNION query to bring together the results of two different queries.
                string sql = $"SELECT DISTINCT(receiver_name) FROM message WHERE sender_name = '{forUser}' AND private = 1 UNION SELECT DISTINCT(sender_name) FROM message WHERE receiver_name = '{forUser}' AND private = 1";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Conversation c = new Conversation()
                        {
                            ForUser = forUser,
                            WithUser = Convert.ToString(reader["receiver_name"]),                            
                        };

                        c.Messages = GetMessageThread(c.ForUser, c.WithUser, conn);

                        output.Add(c);
                    }
                }

                //Descending sort by latest message
                output.Sort((c1,c2) => -1 * c1.Messages[0].CreatedDate.CompareTo(c2.Messages[0].CreatedDate) );
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        public Conversation GetConversations(string forUser, string withUser, DateTime sinceDate)
        {
            Conversation output = new Conversation()
            {
                ForUser = forUser,
                WithUser = withUser
            };

            try
            {
                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    output.Messages = GetMessageThread(forUser, withUser, sinceDate, conn);
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        /// <summary>
        /// Get a conversation thread between two users.
        /// </summary>        
        public Conversation GetConversations(string forUser, string withUser)
        {
            Conversation output = new Conversation()
            {
                ForUser = forUser,
                WithUser = withUser
            };

            try
            {                
                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    output.Messages = GetMessageThread(forUser, withUser, conn);
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        
        private List<Message> GetMessageThread(string forUser, string withUser, DateTime sinceDate, SqlConnection conn)
        {
            List<Message> output = new List<Message>();

            string sql = $"SELECT * FROM message WHERE ((sender_name = '{forUser}' and receiver_name = '{withUser}') OR (sender_name = '{withUser}' and receiver_name = '{forUser}')) AND create_date > '{sinceDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff")}' ORDER BY create_date DESC";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                output.Add(CreateMessage(reader));
            }

            return output;
        }

        private List<Message> GetMessageThread(string forUser, string withUser, SqlConnection conn)
        {
            List<Message> output = new List<Message>();

            string sql = $"SELECT * FROM message WHERE (sender_name = '{forUser}' and receiver_name = '{withUser}') OR (sender_name = '{withUser}' and receiver_name = '{forUser}') ORDER BY create_date DESC";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                output.Add(CreateMessage(reader));
            }

            return output;
        }

        /// <summary>
        /// Gets a specific message by id
        /// </summary>        
        public Message GetMessage(int messageId)
        {
            Message output = null;

            try
            {
                string sql = "SELECT TOP 1 * FROM message WHERE message_id = " + messageId;

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        output = CreateMessage(reader);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        /// <summary>
        /// Gets private messages that the specified user has received
        /// </summary>                
        public List<Message> GetPrivateMessagesForUser(string username)
        {
            List<Message> output = new List<Message>();

            try
            {
                string sql = $"SELECT * FROM message WHERE receiver_name = '{username}' ORDER BY create_date DESC";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        output.Add(CreateMessage(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }


        public List<Message> GetPublicMessages(DateTime sinceDate)
        {
            List<Message> output = new List<Message>();

            try
            {
                string sql = $"SELECT * FROM message WHERE private=0 AND create_date > '{sinceDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff")}' ORDER BY create_date DESC";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        output.Add(CreateMessage(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        /// <summary>
        /// Returns most recent public messages.
        /// </summary>        
        /// <param name="numberOfMessagesToLimit">Number of messages to limit in output</param>
        public List<Message> GetPublicMessages(int numberOfMessagesToLimit)
        {
            List<Message> output = new List<Message>();

            try
            {
                string sql = $"SELECT TOP {numberOfMessagesToLimit} * FROM message WHERE private=0 ORDER BY create_date DESC";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        output.Add(CreateMessage(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        /// <summary>
        /// Retrieves public messages sent by a specific user.
        /// </summary>        
        public List<Message> SearchMessagesBySender(string username, DateTime sinceDate)
        {
            List<Message> output = new List<Message>();

            try
            {
                string sql;
                if (sinceDate == DateTime.MinValue)
                {
                    sql = $"SELECT * FROM message WHERE sender_name = '{username}' AND private = 0 ORDER BY create_date DESC";
                }
                else
                {
                    sql = $"SELECT * FROM message WHERE sender_name = '{username}' AND create_date > '{sinceDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff")}' AND private = 0 ORDER BY create_date DESC";
                }

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        output.Add(CreateMessage(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        /// <summary>
        /// Retrieves any messages that have the messageText included in it
        /// </summary>        
        public List<Message> SearchMessagesByText(string messageText)
        {
            List<Message> output = new List<Message>();

            try
            {
                string sql = $"SELECT * FROM message WHERE message_text LIKE '%{messageText}%' AND private = 0 ORDER BY create_date DESC";

                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        output.Add(CreateMessage(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        /// <summary>
        /// Creates a Message object form a SqlDataReader that used SELECT *
        /// </summary>                
        private Message CreateMessage(SqlDataReader reader)
        {
            return new Message
            {
                MessageId = Convert.ToInt32(reader["message_id"]),
                Sender = Convert.ToString(reader["sender_name"]),
                IsPrivate = Convert.ToBoolean(reader["private"]),
                Recipient = Convert.ToString(reader["receiver_name"]),
                MessageText = Convert.ToString(reader["message_text"]),
                CreatedDate = DateTime.SpecifyKind(Convert.ToDateTime(reader["create_date"]), DateTimeKind.Utc)
            };
        }

        
    }
}
