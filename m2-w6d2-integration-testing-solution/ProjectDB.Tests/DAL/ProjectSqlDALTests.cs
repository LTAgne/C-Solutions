using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectDB.DAL;
using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProjectDB.DAL.Tests
{
    [TestClass()]
    public class ProjectSqlDALTests
    {
        private TransactionScope tran;
        const string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ProjectDB;User ID=te_student;Password=techelevator1";
        private int testEmpId1 = 0;
        private int testEmpId2 = 0;
        private int testDepartmentId = 0;
        private int testProjectId = 0;

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO department VALUES ('Test Department'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testDepartmentId = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand($"INSERT INTO employee VALUES ({testDepartmentId}, 'First Name', 'Last Name', 'Chief Tester', '02/02/2016', 'M', '02/03/2016'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testEmpId1 = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand($"INSERT INTO employee VALUES ({testDepartmentId}, 'Hard Working', 'John', 'Hard Worker', '02/02/2016', 'M', '02/03/2016'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testEmpId2 = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO project VALUES ('Project Name', '01/01/2016', '12/31/2016'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testProjectId = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand($"INSERT INTO project_employee VALUES ({testProjectId}, {testEmpId2});", conn);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void GetAllProjectsTest()
        {
            //Arrange
            ProjectSqlDAL dal = new ProjectSqlDAL(ConnectionString);

            //Act
            List<Project> projects = dal.GetAllProjects();

            //Assert
            Assert.IsNotNull(projects);
            Assert.IsTrue(projects.Count > 0);
            Assert.IsNotNull(projects.Find(p => p.ProjectId == testProjectId));
        }

        [TestMethod()]
        public void AssignEmployeeToProjectTest()
        {
            //Arrange
            ProjectSqlDAL dal = new ProjectSqlDAL(ConnectionString);

            //Act
            bool result = dal.AssignEmployeeToProject(testProjectId, testEmpId1);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        [ExpectedException(typeof(SqlException))]
        public void AssignEmployeeToExistingProject()
        {
            //Arrange
            ProjectSqlDAL dal = new ProjectSqlDAL(ConnectionString);

            //Act
            bool result = dal.AssignEmployeeToProject(testProjectId, testEmpId2);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RemoveEmployeeFromProjectTest()
        {
            //Arrange
            ProjectSqlDAL dal = new ProjectSqlDAL(ConnectionString);

            //Act
            bool result = dal.RemoveEmployeeFromProject(testProjectId, testEmpId2);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CreateProjectTest()
        {
            //Arrange
            int originalCount = GetNumberOfProjects();
            ProjectSqlDAL dal = new ProjectSqlDAL(ConnectionString);
            Project newProj = new Project
            {
                Name = "New Project 2",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };

            //Act
            bool result = dal.CreateProject(newProj);

            //Assert
            Assert.IsTrue(result);
            Assert.AreEqual(originalCount + 1, GetNumberOfProjects());
        }

        private int GetNumberOfProjects()
        {
            int output = 0;

            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM project;", conn);
                output = (int)cmd.ExecuteScalar();
            }

            return output;
        }
    }
}