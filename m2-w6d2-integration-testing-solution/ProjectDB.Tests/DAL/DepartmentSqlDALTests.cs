using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.SqlClient;
using ProjectDB.Models;

namespace ProjectDB.DAL.Tests
{
    [TestClass()]
    public class DepartmentSqlDALTests
    {
        const string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ProjectDB;User ID=te_student;Password=techelevator1";

        private TransactionScope tran;
        private int departmentId = 0;


        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                //Create a new test department
                SqlCommand cmd = new SqlCommand("INSERT INTO department VALUES('Test Department'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                departmentId = (int)cmd.ExecuteScalar();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }


        [TestMethod()]
        public void GetDepartmentsTest()
        {
            //Arrange
            DepartmentSqlDAL dal = new DepartmentSqlDAL(ConnectionString);

            //Act
            List<Department> result = dal.GetDepartments();

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
            Assert.AreEqual(1, result.Where(d => d.Id == departmentId).Count());
        }

        [TestMethod()]
        public void CreateDepartmentTest()
        {
            //Arrange
            int originalCount = GetCountOfDepartments();
            Department newDept = new Department
            {
                Name = "New Test Department"
            };
            DepartmentSqlDAL dal = new DepartmentSqlDAL(ConnectionString);

            //Act
            bool result = dal.CreateDepartment(newDept);

            //Assert   
            Assert.IsTrue(result);
            Assert.AreEqual(originalCount + 1, GetCountOfDepartments());
        }

        [TestMethod()]
        public void UpdateDepartmentTest()
        {
            //Arrange
            Department updatedDept = new Department
            {
                Id = departmentId,
                Name = "Updated Department"
            };
            DepartmentSqlDAL dal = new DepartmentSqlDAL(ConnectionString);

            //Act
            bool result = dal.UpdateDepartment(updatedDept);

            //Assert
            Assert.IsTrue(result);
        }


        private int GetCountOfDepartments()
        {
            int counts = 0;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                //Create a new test department
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from department", conn);
                counts = (int)cmd.ExecuteScalar();
            }

            return counts;
        }

        
    }
}