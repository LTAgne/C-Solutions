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
    public class EmployeeSqlDALTests
    {
        private TransactionScope tran;        
        const string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ProjectDB;User ID=te_student;Password=techelevator1";

        private int testEmployeeId = 0;
        private int testEmployeeIdAssignedToProject = 0;
        private int testDepartmentId = 0;
        private int testProjectId = 0;


        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO department VALUES ('Test Department'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testDepartmentId = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand($"INSERT INTO employee VALUES ({testDepartmentId}, 'First Name', 'Last Name', 'Chief Tester', '02/02/2016', 'M', '02/03/2016'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testEmployeeId = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand($"INSERT INTO employee VALUES ({testDepartmentId}, 'Hard Working', 'John', 'Hard Worker', '02/02/2016', 'M', '02/03/2016'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testEmployeeIdAssignedToProject = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO project VALUES ('Project Name', '01/01/2016', '12/31/2016'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testProjectId = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand($"INSERT INTO project_employee VALUES ({testProjectId}, {testEmployeeIdAssignedToProject});", conn);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void GetAllEmployeesTest()
        {
            //Arrange
            EmployeeSqlDAL dal = new EmployeeSqlDAL(ConnectionString);

            //Act
            List<Employee> employees = dal.GetAllEmployees();

            //Assert
            Assert.IsNotNull(employees);
            Assert.IsTrue(employees.Count > 0);
            Employee testEmployee = employees.Where(e => e.EmployeeId == testEmployeeId).FirstOrDefault();
            Assert.IsNotNull(testEmployee);
            Assert.AreEqual("First Name", testEmployee.FirstName);
            Assert.AreEqual("Last Name", testEmployee.LastName);
            Assert.AreEqual(testDepartmentId, testEmployee.DepartmentId);
        }

        [TestMethod()]
        public void SearchTest()
        {
            //Arrange
            EmployeeSqlDAL dal = new EmployeeSqlDAL(ConnectionString);

            //Act
            List<Employee> employees = dal.Search("First Name", "Last Name");

            //Assert
            Assert.IsNotNull(employees);
            Assert.IsTrue(employees.Count > 0);
            Employee testEmployee = employees.Where(e => e.EmployeeId == testEmployeeId).FirstOrDefault();
            Assert.IsNotNull(testEmployee);
            Assert.AreEqual("First Name", testEmployee.FirstName);
            Assert.AreEqual("Last Name", testEmployee.LastName);
        }

        [TestMethod()]
        public void GetEmployeesWithoutProjectsTest()
        {
            //Arrange
            EmployeeSqlDAL dal = new EmployeeSqlDAL(ConnectionString);

            //Act
            List<Employee> employees = dal.GetEmployeesWithoutProjects();

            //Assert
            Assert.IsNotNull(employees);
            Assert.IsTrue(employees.Count > 0);
            Assert.IsNotNull(employees.Find(e => e.EmployeeId == testEmployeeId));
            Assert.IsNull(employees.Find(e => e.EmployeeId == testEmployeeIdAssignedToProject));
        }

        
    }
}