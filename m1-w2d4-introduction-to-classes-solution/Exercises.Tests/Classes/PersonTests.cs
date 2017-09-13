using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechElevator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Exercises.Tests.Classes
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod]
        public void Person_CheckRequiredMembers()
        {
            Type type = typeof(Person);
            Person person = (Person)Activator.CreateInstance(type);

            FieldInfo fi = type.GetField("firstName", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(fi, "A field called firstName needs to exist");
            Assert.AreEqual(typeof(string), fi.FieldType, "The firstName field needs to be type: string");

            fi = type.GetField("lastName", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(fi, "A field called lastName needs to exist");
            Assert.AreEqual(typeof(string), fi.FieldType, "The lastName field needs to be type: string");
            
            fi = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(fi, "A field called age needs to exist");
            Assert.AreEqual(typeof(int), fi.FieldType, "The age field needs to be type: int");

            PropertyInfo prop = type.GetProperty("FirstName");
            PropertyValidator.ValidateReadWrite(prop, "FirstName", typeof(string));

            prop = type.GetProperty("LastName");
            PropertyValidator.ValidateReadWrite(prop, "LastName", typeof(string));

            prop = type.GetProperty("Age");
            PropertyValidator.ValidateReadWrite(prop, "Age", typeof(int));

            MethodInfo mi = type.GetMethod("GetFullName");
            Assert.IsNotNull(mi, "A method called GetFullName needs to be included");
            Assert.AreEqual(typeof(string), mi.ReturnType, "The GetFullName() method needs to be type: string");

            mi = type.GetMethod("IsAdult");
            Assert.IsNotNull(mi, "A method called IsAdult needs to be included");
            Assert.AreEqual(typeof(bool), mi.ReturnType, "The IsAdult() method needs to be type: bool");
        }

        [TestMethod]
        public void Person_NameTests()
        {
            Type type = typeof(Person);
            Person person = (Person)Activator.CreateInstance(type);

            type.GetProperty("FirstName").SetValue(person, "John");
            type.GetProperty("LastName").SetValue(person, "Doe");

            MethodInfo mi = type.GetMethod("GetFullName");
            Assert.AreEqual("John Doe", mi.Invoke(person, null), "The GetFullName() method was expected to return 'John Doe' (firstname lastname)");            
        }

        [TestMethod]
        public void Person_IsAdultTests()
        {
            Type type = typeof(Person);
            Person person = (Person)Activator.CreateInstance(type);

            MethodInfo mi = type.GetMethod("IsAdult");

            type.GetProperty("Age").SetValue(person, 16);
            Assert.AreEqual(false, mi.Invoke(person, null), "IsAdult() should return false for 16 year old");
            
            type.GetProperty("Age").SetValue(person, 18);
            Assert.AreEqual(true, mi.Invoke(person, null), "IsAdult() should return false for 18 year old");

            type.GetProperty("Age").SetValue(person, 25);
            Assert.AreEqual(true, mi.Invoke(person, null), "IsAdult() should return false for 25 year old");
        }
    }
}
