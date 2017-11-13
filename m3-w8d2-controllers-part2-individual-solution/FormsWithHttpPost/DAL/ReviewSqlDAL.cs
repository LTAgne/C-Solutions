using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        private readonly string connectionString;

        public ReviewSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Review> GetAllReviews()
        {
            List<Review> output = new List<Review>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM reviews", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        output.Add(new Review()
                        {
                            Id = Convert.ToInt32(reader["review_id"]),
                            Username = Convert.ToString(reader["username"]),
                            Rating = Convert.ToInt32(reader["rating"]),
                            Title = Convert.ToString(reader["review_title"]),
                            Message = Convert.ToString(reader["review_text"]),
                            ReviewDate = Convert.ToDateTime(reader["review_date"])
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

        public bool SaveReview(Review newReview)
        {            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO reviews VALUES (@username, @rating, @title, @message, getdate());", conn);
                    cmd.Parameters.AddWithValue("@username", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@title", newReview.Title);
                    cmd.Parameters.AddWithValue("@message", newReview.Message);

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