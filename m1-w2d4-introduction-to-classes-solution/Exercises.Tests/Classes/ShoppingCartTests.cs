using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechElevator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Exercises.Tests;

namespace TechElevator.Classes.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void ShoppingCart_RequiredMembers()
        {
            Type type = typeof(ShoppingCart);
            ShoppingCart cart = (ShoppingCart)Activator.CreateInstance(type);

            FieldInfo fi = type.GetField("totalNumberOfItems", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(fi, "Shopping cart needs a totalNumberOfItems variable.");
            Assert.AreEqual(typeof(int), fi.FieldType, "totalNumberOfItems should be type: int");

            fi = type.GetField("totalAmountOwed", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(fi, "Shopping cart needs a totalAmountOwed variable.");
            Assert.AreEqual(typeof(decimal), fi.FieldType, "totalAmountOwed should be type: double");

            PropertyInfo prop = type.GetProperty("TotalNumberOfItems");
            PropertyValidator.ValidateReadOnly(prop, "TotalNumberOfItems", typeof(int));

            prop = type.GetProperty("TotalAmountOwed");
            PropertyValidator.ValidateReadOnly(prop, "TotalAmountOwed", typeof(decimal));

            MethodInfo mi = type.GetMethod("GetAveragePricePerItem");
            Assert.IsNotNull(mi, "Shopping cart class needs the GetAveragePricePerItem method.");
            Assert.AreEqual(typeof(decimal), mi.ReturnType, "GetAveragePricePerItem() method needs to return type: double");
            Assert.AreEqual(0, mi.GetParameters().Length, "GetAveragePricePerItem() should have no parameters");

            mi = type.GetMethod("AddItems");
            Assert.IsNotNull(mi, "Shopping cart class needs the AddItems method.");
            Assert.AreEqual(typeof(void), mi.ReturnType, "AddItems() method needs to return type: void");
            Assert.AreEqual(2, mi.GetParameters().Length);

            mi = type.GetMethod("Empty");
            Assert.IsNotNull(mi, "Shopping cart class needs the Empty method.");
            Assert.AreEqual(typeof(void), mi.ReturnType, "Empty() method needs to return type: void");
            Assert.AreEqual(0, mi.GetParameters().Length);
        }


        [TestMethod()]
        public void ShoppingCart_DefaultCart()
        {
            Type type = typeof(ShoppingCart);
            ShoppingCart cart = (ShoppingCart)Activator.CreateInstance(type);

            PropertyInfo prop = type.GetProperty("TotalNumberOfItems");
            Assert.AreEqual(0, prop.GetValue(cart), "TotalNumberOfItems should be 0 for new carts.");

            prop = type.GetProperty("TotalAmountOwed");
            Assert.AreEqual(0.0M, prop.GetValue(cart), "TotalAmountOwed should be 0.0 for new carts.");
        }

        [TestMethod]
        public void ShoppingCart_GetAveragericePerItem()
        {
            Type type = typeof(ShoppingCart);
            ShoppingCart cart = (ShoppingCart)Activator.CreateInstance(type);
            MethodInfo mi = type.GetMethod("GetAveragePricePerItem");

            type.GetField("totalNumberOfItems", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(cart, 0);
            type.GetField("totalAmountOwed", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(cart, 0.0M);

            Assert.AreEqual(0.0M, mi.Invoke(cart, null), "The average price per item of an empty cart is 0.0");

            type.GetField("totalNumberOfItems", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(cart, 2);
            type.GetField("totalAmountOwed", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(cart, 5M);

            Assert.AreEqual(2.5M, mi.Invoke(cart, null), "The average price per item is totalAmountOwed / totalNumberOfItems");
        }

        

        [TestMethod()]
        public void ShoppingCart_AddItemTest()
        {
            Type type = typeof(ShoppingCart);
            ShoppingCart cart = (ShoppingCart)Activator.CreateInstance(type);
            MethodInfo mi = type.GetMethod("AddItems");

            //Reset the cart
            type.GetField("totalNumberOfItems", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(cart, 0);
            type.GetField("totalAmountOwed", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(cart, 0.0M);

            mi.Invoke(cart, new object[] { 2, 2.10M });

            Assert.AreEqual(2, type.GetProperty("TotalNumberOfItems").GetValue(cart), "AddItems should add numberOfItems to totalNumberOfItems");
            Assert.AreEqual(4.20M, type.GetProperty("TotalAmountOwed").GetValue(cart), "AddItems should add pricePerItem * numberOfItems to totalAmountOwed");

        }

        [TestMethod()]
        public void ShoppingCart_EmptyTest()
        {
            Type type = typeof(ShoppingCart);
            ShoppingCart cart = (ShoppingCart)Activator.CreateInstance(type);
            MethodInfo mi = type.GetMethod("Empty");

            //Reset the cart
            type.GetField("totalNumberOfItems", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(cart, 5);
            type.GetField("totalAmountOwed", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(cart, 10.0M);

            mi.Invoke(cart, null);

            Assert.AreEqual(0, type.GetProperty("TotalNumberOfItems").GetValue(cart), "Empty should reset totalNumberOfItems to 0");
            Assert.AreEqual(0.0M, type.GetProperty("TotalAmountOwed").GetValue(cart), "Empty should reset totalAmountOwed to 0.0");

        }
        
    }
}