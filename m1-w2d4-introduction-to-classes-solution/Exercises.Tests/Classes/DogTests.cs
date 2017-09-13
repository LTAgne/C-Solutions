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
    public class DogTests
    {
        [TestMethod]
        public void Dog_RequiredMemberTests()
        {
            Type type = typeof(Dog);
            Dog dog = (Dog)Activator.CreateInstance(type);

            FieldInfo fi = type.GetField("isSleeping", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(fi, "Dog class needs the isSleeping variable.");
            Assert.AreEqual(typeof(bool), fi.FieldType, "isSleeping should be type: bool");

            PropertyInfo prop = type.GetProperty("IsSleeping");
            PropertyValidator.ValidateReadOnly(prop, "IsSleeping", typeof(bool));

            MethodInfo mi = type.GetMethod("MakeSound");
            Assert.IsNotNull(mi, "Dog class needs the MakeSound method.");
            Assert.AreEqual(typeof(string), mi.ReturnType, "MakeSound() method needs to return type: string");

            mi = type.GetMethod("Sleep");
            Assert.IsNotNull(mi, "Dog class needs the Sleep() method.");
            Assert.AreEqual(typeof(void), mi.ReturnType, "Sleep() method needs to return type: void");

            mi = type.GetMethod("WakeUp");
            Assert.IsNotNull(mi, "Dog class needs the WakeUp() method.");
            Assert.AreEqual(typeof(void), mi.ReturnType, "WakeUp() method needs to return type: void");
        }

        [TestMethod()]
        public void Dog_DefaultTest()
        {
            Type type = typeof(Dog);
            Dog dog = (Dog)Activator.CreateInstance(type);

            FieldInfo fi = type.GetField("isSleeping", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.AreEqual(false, fi.GetValue(dog), "New dogs should be awake by default");
        }

        [TestMethod()]
        public void Dog_MakeSound()
        {
            Type type = typeof(Dog);
            Dog dog = (Dog)Activator.CreateInstance(type);

            MethodInfo mi = type.GetMethod("MakeSound");
            Assert.AreEqual("woof!", mi.Invoke(dog, null), "The dog should say \"woof!\" when awake.");

            type.GetField("isSleeping", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(dog, true);

            Assert.AreEqual("Zzzzz...", mi.Invoke(dog, null), "The dog should say \"Zzzzz...\" when asleep.");
        }

        [TestMethod]
        public void Dog_SleepTest()
        {
            Type type = typeof(Dog);
            Dog dog = (Dog)Activator.CreateInstance(type);

            type.GetMethod("Sleep").Invoke(dog, null);

            Assert.AreEqual(true, type.GetProperty("IsSleeping").GetValue(dog), "The dog should be sleeping after Sleep() is called.");

        }

        

        [TestMethod()]
        public void Dog_WakeUpTest()
        {
            Type type = typeof(Dog);
            Dog dog = (Dog)Activator.CreateInstance(type);

            type.GetField("isSleeping", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(dog, true);

            type.GetMethod("WakeUp").Invoke(dog, null);

            Assert.AreEqual(false, type.GetProperty("IsSleeping").GetValue(dog), "The dog should be awake after WakeUp() is called.");
        }
    }
}