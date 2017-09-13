using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Individual.Exercises.Classes;
using System.Reflection;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class TelevisionTests
    {
        [TestMethod]
        public void Television_HasRequiredMembers()
        {
            Type type = typeof(Television);
            Television tv = (Television)Activator.CreateInstance(type);

            PropertyInfo prop = type.GetProperty("IsOn");
            PropertyValidator.ValidateReadOnly(prop, "IsOn", typeof(bool));

            prop = type.GetProperty("CurrentChannel");
            PropertyValidator.ValidateReadOnly(prop, "CurrentChannel", typeof(int));

            prop = type.GetProperty("CurrentVolume");
            PropertyValidator.ValidateReadOnly(prop, "CurrentVolume", typeof(int));

            MethodInfo method = type.GetMethod("TurnOff");
            MethodValidator.ValidatePublicMethod(method, "TurnOff", typeof(void));

            method = type.GetMethod("TurnOn");
            MethodValidator.ValidatePublicMethod(method, "TurnOn", typeof(void));

            method = type.GetMethod("ChangeChannel");
            MethodValidator.ValidatePublicMethod(method, "ChangeChannel", typeof(void));
            Assert.AreEqual(1, method.GetParameters().Length, "ChangeChannel should accept 1 parameter");

            method = type.GetMethod("ChannelUp");
            MethodValidator.ValidatePublicMethod(method, "ChannelUp", typeof(void));

            method = type.GetMethod("ChannelDown");
            MethodValidator.ValidatePublicMethod(method, "ChannelDown", typeof(void));

            method = type.GetMethod("RaiseVolume");
            MethodValidator.ValidatePublicMethod(method, "RaiseVolume", typeof(void));

            method = type.GetMethod("LowerVolume");
            MethodValidator.ValidatePublicMethod(method, "LowerVolume", typeof(void));
        }

        [TestMethod]
        public void Television_Constructor()
        {
            Type type = typeof(Television);
            Television tv = (Television)Activator.CreateInstance(type);

            PropertyInfo prop = type.GetProperty("IsOn");
            Assert.AreEqual(false, prop.GetValue(tv), "New TVs should be turned off by default.");

            prop = type.GetProperty("CurrentChannel");
            Assert.AreEqual(3, prop.GetValue(tv), "New TVs should have the CurrentChannel set to 3 by default.");

            prop = type.GetProperty("CurrentVolume");
            Assert.AreEqual(2, prop.GetValue(tv), "New TVs should have the CurrentVolume set to 2 by default.");
        }

        [TestMethod]
        public void Television_TurnOnOffTests()
        {
            Type type = typeof(Television);
            Television tv = (Television)Activator.CreateInstance(type);

            // Turn it on
            type.GetMethod("TurnOn").Invoke(tv, null);

            Assert.AreEqual(true, type.GetProperty("IsOn").GetValue(tv), "The TV was turned on. IsOn should now be true.");
            Assert.AreEqual(3, type.GetProperty("CurrentChannel").GetValue(tv), "The TV was turned on. CurrentChannel should now be 3.");
            Assert.AreEqual(2, type.GetProperty("CurrentVolume").GetValue(tv), "The TV was turned on. CurrentVolume should now be 2.");


            // Turn if off
            type.GetMethod("TurnOff").Invoke(tv, null);

            Assert.AreEqual(false, type.GetProperty("IsOn").GetValue(tv), "The TV was turned off. IsOn should now be false.");
        }

        [TestMethod]
        public void Television_ChangeChannelTests()
        {
            Type type = typeof(Television);
            Television tv = (Television)Activator.CreateInstance(type);

            // Change Channel before Turning On
            type.GetMethod("ChangeChannel").Invoke(tv, new object[] { 5 });

            Assert.AreEqual(3, type.GetProperty("CurrentChannel").GetValue(tv), "The TV was not turned on. CurrentChannel should not have changed.");

            // Turn it on and change it
            type.GetMethod("TurnOn").Invoke(tv, null);
            type.GetMethod("ChangeChannel").Invoke(tv, new object[] { 5 });

            Assert.AreEqual(5, type.GetProperty("CurrentChannel").GetValue(tv), "The Channel was Changed to . CurrentChannel should now be 3.");
        }

        [TestMethod]
        public void Television_ChannelUpTests()
        {
            Type type = typeof(Television);
            Television tv = (Television)Activator.CreateInstance(type);

            // Change Channel before Turning On
            type.GetMethod("ChannelUp").Invoke(tv, null);

            Assert.AreEqual(3, type.GetProperty("CurrentChannel").GetValue(tv), "ChannelUp should only change if the TV has been turned on.");

            type.GetMethod("TurnOn").Invoke(tv, null);
            type.GetMethod("ChannelUp").Invoke(tv, null);

            Assert.AreEqual(4, type.GetProperty("CurrentChannel").GetValue(tv), "ChannelUp should have incremented CurrentChannel by 1.");

            type.GetMethod("ChannelUp").Invoke(tv, null);

            Assert.AreEqual(5, type.GetProperty("CurrentChannel").GetValue(tv), "ChannelUp should have incremented CurrentChannel by 1.");                                               
        }

        [TestMethod]
        public void Television_ChannelUpPast18Tests()
        {
            Type type = typeof(Television);
            Television tv = (Television)Activator.CreateInstance(type);

            type.GetMethod("TurnOn").Invoke(tv, null);
            type.GetMethod("ChangeChannel").Invoke(tv, new object[] { 17 });

            type.GetMethod("ChannelUp").Invoke(tv, null);
            Assert.AreEqual(18, type.GetProperty("CurrentChannel").GetValue(tv), "ChannelUp should have incremented CurrentChannel by 1.");

            type.GetMethod("ChannelUp").Invoke(tv, null);
            Assert.AreEqual(3, type.GetProperty("CurrentChannel").GetValue(tv), "ChannelUp should not let CurrentChannel go past 18. Reset to 3.");
        }

        [TestMethod]
        public void Television_ChannelDownTests()
        {
            Type type = typeof(Television);
            Television tv = (Television)Activator.CreateInstance(type);

            // Change Channel before Turning On
            type.GetMethod("ChannelDown").Invoke(tv, null);

            Assert.AreEqual(3, type.GetProperty("CurrentChannel").GetValue(tv), "ChannelDown should only change if the TV has been turned on.");

            type.GetMethod("TurnOn").Invoke(tv, null);
            type.GetMethod("ChangeChannel").Invoke(tv, new object[] { 5 });
            type.GetMethod("ChannelDown").Invoke(tv, null);

            Assert.AreEqual(4, type.GetProperty("CurrentChannel").GetValue(tv), "ChannelDown should have decremented CurrentChannel by 1.");

            type.GetMethod("ChannelDown").Invoke(tv, null);

            Assert.AreEqual(3, type.GetProperty("CurrentChannel").GetValue(tv), "ChannelDown should have decremented CurrentChannel by 1.");
        }

        [TestMethod]
        public void Television_ChannelDownPast18Tests()
        {
            Type type = typeof(Television);
            Television tv = (Television)Activator.CreateInstance(type);

            type.GetMethod("TurnOn").Invoke(tv, null);
            type.GetMethod("ChangeChannel").Invoke(tv, new object[] { 4 });

            type.GetMethod("ChannelDown").Invoke(tv, null);
            Assert.AreEqual(3, type.GetProperty("CurrentChannel").GetValue(tv), "ChannelDown should have incremented CurrentChannel by 1.");

            type.GetMethod("ChannelDown").Invoke(tv, null);
            Assert.AreEqual(18, type.GetProperty("CurrentChannel").GetValue(tv), "ChannelDown should not let CurrentChannel go past 18. Reset to 3.");
        }

        [TestMethod]
        public void Television_VolumeTests()
        {
            Type type = typeof(Television);
            Television tv = (Television)Activator.CreateInstance(type);

            type.GetMethod("RaiseVolume").Invoke(tv, null);

            Assert.AreEqual(2, type.GetProperty("CurrentVolume").GetValue(tv), "CurrentVolume should only be increased if the TV is on.");

            type.GetMethod("TurnOn").Invoke(tv, null);
            type.GetMethod("RaiseVolume").Invoke(tv, null);

            Assert.AreEqual(3, type.GetProperty("CurrentVolume").GetValue(tv), "RaiseVolume should have incremented CurrentVolume by 1.");

            type.GetMethod("LowerVolume").Invoke(tv, null);
            Assert.AreEqual(2, type.GetProperty("CurrentVolume").GetValue(tv), "LowerVolume should have decremented CurrentVolume by 1.");


            type.GetMethod("LowerVolume").Invoke(tv, null);
            Assert.AreEqual(1, type.GetProperty("CurrentVolume").GetValue(tv), "LowerVolume should have decremented CurrentVolume by 1.");


            type.GetMethod("LowerVolume").Invoke(tv, null);
            Assert.AreEqual(0, type.GetProperty("CurrentVolume").GetValue(tv), "LowerVolume should have decremented CurrentVolume by 1.");


            type.GetMethod("LowerVolume").Invoke(tv, null);
            Assert.AreEqual(0, type.GetProperty("CurrentVolume").GetValue(tv), "LowerVolume should not let CurrentVolume go below 0.");
        }

    }
}
