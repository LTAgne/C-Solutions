using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Individual.Exercises.Classes;
using System.Reflection;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class FruitTreeTests
    {
        [TestMethod]
        public void FruitTree_HasRequiredMembers()
        {
            Type type = typeof(FruitTree);
            FruitTree tree = (FruitTree)Activator.CreateInstance(type, "Apple", 3);

            PropertyInfo[] properties = type.GetProperties();

            PropertyInfo prop = FindPropertyByName(properties, "TypeOfFruit");
            Assert.IsNotNull(prop, "You do not have the TypeOfFruit property");
            Assert.IsFalse(prop.CanWrite, "TypeOfFruit property needs a set accessor.");
            Assert.IsTrue(prop.CanRead, "TypeOfFruit property needs a get accessor.");
            Assert.AreEqual(typeof(string), prop.PropertyType, "TypeOfFruit should be a string");


            prop = FindPropertyByName(properties, "PiecesOfFruitLeft");
            Assert.IsNotNull(prop, "You do not have the PiecesOfFruitLeft property");
            Assert.IsFalse(prop.CanWrite, "PiecesOfFruitLeft property should not have a set accessor.");
            Assert.IsTrue(prop.CanRead, "PiecesOfFruitLeft property needs a get accessor.");
            Assert.AreEqual(typeof(int), prop.PropertyType, "PiecesOfFruitLeft should be an int");

            MethodInfo method = type.GetMethod("PickFruit");
            Assert.IsNotNull(method, "You do not have the PickFruit method");
            Assert.AreEqual(typeof(bool), method.ReturnType, "Your PickFruit method should return a bool");
            Assert.AreEqual(true, method.IsPublic, "PickFruit should be a public method");            
        }

        [TestMethod]
        public void FruitTree_Constructor()
        {
            Type type = typeof(FruitTree);
            FruitTree tree = (FruitTree)Activator.CreateInstance(type, "Apple", 3);

            PropertyInfo prop = FindPropertyByName(type.GetProperties(), "TypeOfFruit");
            Assert.AreEqual("Apple", prop.GetValue(tree), "Passed Apple into constructor and expected TypeOfFruit property to return Apple");

            prop = FindPropertyByName(type.GetProperties(), "PiecesOfFruitLeft");
            Assert.AreEqual(3, prop.GetValue(tree), "Passed 3 into constructor and expected PiecesOfFruitLeft property to return 3");
        }

        [TestMethod]
        public void FruitTree_PickFruitTests()
        {
            Type type = typeof(FruitTree);
            FruitTree tree = (FruitTree)Activator.CreateInstance(type, "Apple", 3);

            MethodInfo method = type.GetMethod("PickFruit");
            ParameterInfo[] parameters = method.GetParameters();
            Assert.AreEqual(1, parameters.Length, "PickFruit should only take 1 parameter");

            PropertyInfo prop = FindPropertyByName(type.GetProperties(), "PiecesOfFruitLeft");
            Assert.AreEqual(true, method.Invoke(tree, new object[] { 2 }), "PickFruit should return TRUE when pieces remain");
            Assert.AreEqual(1, prop.GetValue(tree), "Tree started with 3 pieces of fruit. 2 were picked, 1 should be remaining");            

            Assert.AreEqual(true, method.Invoke(tree, new object[] { 1 }), "PickFruit should return TRUE when pieces remain");
            Assert.AreEqual(0, prop.GetValue(tree), "Tree had 1 piece of fruit. 1 was picked, 0 should be remaining");

            Assert.AreEqual(false, method.Invoke(tree, new object[] { 1 }), "PickFruit should return FALSE when no pieces remain");
            Assert.AreEqual(0, prop.GetValue(tree), "Tree had 0 piece of fruit. 1 was not picked, 0 should be remaining");
        }

        private PropertyInfo FindPropertyByName(PropertyInfo[] properties, string name)
        {
            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].Name == name)
                {
                    return properties[i];
                }
            }

            return null;
        }
    }
}
