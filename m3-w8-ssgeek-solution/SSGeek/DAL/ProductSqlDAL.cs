using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
    public class ProductSqlDAL : IProductDAL
    {
        public readonly string connectionString;

        public ProductSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Product GetProduct(int id)
        {
            Product output = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM products WHERE product_id = @productID", conn);
                    cmd.Parameters.AddWithValue("@productID", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        output = CreateProduct(reader);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }
       
        public List<Product> GetProducts()
        {
            List<Product> output = new List<Product>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM products;", conn);                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        output.Add(CreateProduct(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        private Product CreateProduct(SqlDataReader reader)
        {
            return new Product
            {
                ProductId = Convert.ToInt32(reader["product_id"]),
                Name = Convert.ToString(reader["name"]),
                Description = Convert.ToString(reader["description"]),
                Price = Convert.ToDouble(reader["price"]),
                ImageName = Convert.ToString(reader["image_name"])
            };
        }
    }
}