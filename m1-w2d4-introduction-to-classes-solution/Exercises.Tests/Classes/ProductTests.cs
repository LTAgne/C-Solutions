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
    public class ProductTests
    {
        [TestMethod]
        public void Product_CheckRequiredMembers()
        {
            Type type = typeof(Product);
            Product product = (Product)Activator.CreateInstance(type);

            FieldInfo fi = type.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(fi, "A field called name needs to exist");
            Assert.AreEqual(typeof(string), fi.FieldType, "The name field needs to be type: string");

            fi = type.GetField("price", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(fi, "A field called price needs to exist");
            Assert.AreEqual(typeof(decimal), fi.FieldType, "The price field needs to be type: decimal");
            
            fi = type.GetField("weightInOunces", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(fi, "A field called weightInOunces needs to exist");
            Assert.AreEqual(typeof(double), fi.FieldType, "The weightInOunces field needs to be type: double");

            PropertyInfo prop = type.GetProperty("Name");
            PropertyValidator.ValidateReadWrite(prop, "Name", typeof(string));

            prop = type.GetProperty("Price");
            PropertyValidator.ValidateReadWrite(prop, "Price", typeof(decimal));

            prop = type.GetProperty("WeightInOunces");
            PropertyValidator.ValidateReadWrite(prop, "WeightInOunces", typeof(double));


        }


    }
}
