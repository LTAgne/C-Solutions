using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.DAL
{
    public class ProjectSqlDAL
    {
        private string connectionString;
        private const string SQL_AllProjects = "SELECT * FROM project;";
        private const string SQL_AssignEmployee = "INSERT INTO project_employee VALUES (@projectId, @employeeId);";
        private const string SQL_RemoveEmployee = "DELETE FROM project_employee WHERE project_id = @projectId AND employee_id = @employeeId;";
        private const string SQL_CreateProject = "INSERT INTO project VALUES (@name, @fromdate, @todate);";

        // Single Parameter Constructor
        public ProjectSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Project> GetAllProjects()
        {
            List<Project> output = new List<Project>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_AllProjects, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Project p = GetProjectFromReader(reader);
                        output.Add(p);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

        private Project GetProjectFromReader(SqlDataReader reader)
        {
            Project p = new Project();
            p.ProjectId = Convert.ToInt32(reader["project_id"]);
            p.Name = Convert.ToString(reader["name"]);
            p.StartDate = Convert.ToDateTime(reader["from_date"]);
            p.EndDate = Convert.ToDateTime(reader["to_date"]);

            return p;
        }

        public bool AssignEmployeeToProject(int projectId, int employeeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_AssignEmployee, conn);
                    cmd.Parameters.AddWithValue("@projectId", projectId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public bool RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_RemoveEmployee, conn);
                    cmd.Parameters.AddWithValue("@projectId", projectId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public bool CreateProject(Project newProject)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_CreateProject, conn);
                    cmd.Parameters.AddWithValue("@name", newProject.Name);
                    cmd.Parameters.AddWithValue("@fromdate", newProject.StartDate);
                    cmd.Parameters.AddWithValue("@todate", newProject.EndDate);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

    }
}
