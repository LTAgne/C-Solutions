using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
    public class JobApplicationSqlDAL : IJobApplicationDAL
    {
        public readonly string connectionString;
        private const string Insert_Application = @"INSERT INTO job_applications VALUES 
                                (@first_name, @last_name, @state, @postal_code, @email,
                                 @current_employment_status, @last_employer, @last_employer_city, @last_employer_startdate, @last_employer_enddate,
                                 @do_background_check, @receive_emails, GETDATE());";

        public JobApplicationSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void SaveJobApplication(JobApplication newApplication)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Insert_Application, conn);
                    cmd.Parameters.AddWithValue("@first_name", newApplication.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", newApplication.LastName);
                    cmd.Parameters.AddWithValue("@state", newApplication.State);
                    cmd.Parameters.AddWithValue("@postal_code", newApplication.PostalCode);
                    cmd.Parameters.AddWithValue("@email", newApplication.Email);
                    cmd.Parameters.AddWithValue("@current_employment_status", newApplication.EmploymentStatus);

                    cmd.Parameters.AddWithValue("@last_employer", newApplication.LastEmployer);
                    cmd.Parameters.AddWithValue("@last_employer_city", newApplication.LastEmployerCity);
                    cmd.Parameters.AddWithValue("@last_employer_startdate", newApplication.LastEmployerStartDate);
                    cmd.Parameters.AddWithValue("@last_employer_enddate", newApplication.LastEmployerEndDate);

                    cmd.Parameters.AddWithValue("@do_background_check", newApplication.DoBackgroundCheck);
                    cmd.Parameters.AddWithValue("@receive_emails", newApplication.SendEmails);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}