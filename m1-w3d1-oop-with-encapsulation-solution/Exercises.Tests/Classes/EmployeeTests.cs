using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Individual.Exercises.Classes;
using System.Reflection;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Employee_HasRequiredMembers()
        {
            Type type = typeof(Employee);
            Employee employee = (Employee)Activator.CreateInstance(type, 1, "Jane", "Smith", 100000);        

            PropertyInfo prop = type.GetProperty("EmployeeId");
            PropertyValidator.ValidateReadOnly(prop, "EmployeeId", typeof(int));
            
            prop = type.GetProperty("FirstName");
            PropertyValidator.ValidateReadOnly(prop, "FirstName", typeof(string));            
            
            prop = type.GetProperty("LastName");
            PropertyValidator.ValidateReadWrite(prop, "LastName", typeof(string));
            
            prop = type.GetProperty("FullName");
            PropertyValidator.ValidateReadOnly(prop, "FullName", typeof(string));

            prop = type.GetProperty("Department");
            PropertyValidator.ValidateReadWrite(prop, "Department", typeof(string));

            prop = type.GetProperty("AnnualSalary");
            PropertyValidator.ValidateReadOnly(prop, "AnnualSalary", typeof(double));

            MethodInfo method = type.GetMethod("RaiseSalary");
            MethodValidator.ValidatePublicMethod(method, "RaiseSalary", typeof(void));            
        }

        [TestMethod]
        public void Employee_Constructor()
        {
            Type type = typeof(Employee);
            Employee employee = (Employee)Activator.CreateInstance(type, 1, "Jane", "Smith", 100000.00);

            PropertyInfo prop = type.GetProperty("EmployeeId");
            Assert.AreEqual(1, prop.GetValue(employee), "Passed 1 into constructor and expected EmployeeId property to hold 1");

            prop = type.GetProperty("FirstName");
            Assert.AreEqual("Jane", prop.GetValue(employee), "Passed Jane into constructor and expected FirstName property to hold Jane");

            prop = type.GetProperty("LastName");
            Assert.AreEqual("Smith", prop.GetValue(employee), "Passed Smith into constructor and expected LastName property to hold Smith");

            prop = type.GetProperty("AnnualSalary");
            Assert.AreEqual(100000.00, prop.GetValue(employee), "Passed 100000.00 into constructor and expected AnnualSalary property to hold 100000.00");            
        }

        [TestMethod]
        public void Employee_FullNameTest()
        {
            Type type = typeof(Employee);
            Employee employee = (Employee)Activator.CreateInstance(type, 1, "Jane", "Smith", 100000.00);

            PropertyInfo prop = type.GetProperty("FullName");
            Assert.AreEqual("Smith, Jane", prop.GetValue(employee), "Expected FullName to return calculated value of 'LastName, FirstName'");
        }

        [TestMethod]
        public void Employee_RaiseSalaryTest()
        {
            Type type = typeof(Employee);
            Employee employee = (Employee)Activator.CreateInstance(type, 1, "Jane", "Smith", 100000.00);

            MethodInfo method = type.GetMethod("RaiseSalary");
            method.Invoke(employee, new object[] { 5.5 });

            PropertyInfo prop = type.GetProperty("AnnualSalary");
            Assert.AreEqual(105500.00, prop.GetValue(employee), "Raised salary by 5.5%. Expected to go from 100000.00 to 105500.00");
        }


    }
}
