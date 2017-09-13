using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Individual.Exercises.Classes;
using System.Reflection;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class ElevatorTests
    {
        [TestMethod]
        public void Elevator_HasRequiredMembers()
        {
            Type type = typeof(Elevator);
            Elevator elevator = (Elevator)Activator.CreateInstance(type, 3);

            PropertyInfo prop = type.GetProperty("CurrentLevel");
            PropertyValidator.ValidateReadOnly(prop, "CurrentLevel", typeof(int));

            prop = type.GetProperty("NumberOfLevels");
            PropertyValidator.ValidateReadOnly(prop, "NumberOfLevels", typeof(int));

            prop = type.GetProperty("DoorIsOpen");
            PropertyValidator.ValidateReadOnly(prop, "DoorIsOpen", typeof(bool));

            MethodInfo method = type.GetMethod("OpenDoor");
            MethodValidator.ValidatePublicMethod(method, "OpenDoor", typeof(void));

            method = type.GetMethod("CloseDoor");
            MethodValidator.ValidatePublicMethod(method, "CloseDoor", typeof(void));

            method = type.GetMethod("GoUp");
            MethodValidator.ValidatePublicMethod(method, "GoUp", typeof(void));
            Assert.AreEqual(1, method.GetParameters().Length, "GoUp should accept 1 parameter");

            method = type.GetMethod("GoDown");
            MethodValidator.ValidatePublicMethod(method, "GoDown", typeof(void));
            Assert.AreEqual(1, method.GetParameters().Length, "GoDown should accept 1 parameter");          
        }

        [TestMethod]
        public void Elevator_Constructor()
        {
            Type type = typeof(Elevator);
            Elevator elevator = (Elevator)Activator.CreateInstance(type, 3);

            Assert.AreEqual(1, type.GetProperty("CurrentLevel").GetValue(elevator), "CurrentLevel for new Elevators should return 1.");
            Assert.AreEqual(3, type.GetProperty("NumberOfLevels").GetValue(elevator), "NumberOfLevels should be equal to the argument passed into the Constructor");
            Assert.AreEqual(false, type.GetProperty("DoorIsOpen").GetValue(elevator), "The door should be closed for new elevators");
        }

        [TestMethod]
        public void Elevator_OpenDoorTests()
        {
            Type type = typeof(Elevator);
            Elevator elevator = (Elevator)Activator.CreateInstance(type, 3);

            type.GetMethod("OpenDoor").Invoke(elevator, null);

            Assert.AreEqual(true, type.GetProperty("DoorIsOpen").GetValue(elevator), "The door should be open after calling OpenDoor");

            type.GetMethod("CloseDoor").Invoke(elevator, null);

            Assert.AreEqual(false, type.GetProperty("DoorIsOpen").GetValue(elevator), "The door should be closed after calling CloseDoor");
        }

        

        [TestMethod]
        public void Elevator_MoveUpAndDownTests()
        {
            Type type = typeof(Elevator);
            Elevator elevator = (Elevator)Activator.CreateInstance(type, 3);
            

            type.GetMethod("GoUp").Invoke(elevator, new object[] { 2 });
            Assert.AreEqual(2, type.GetProperty("CurrentLevel").GetValue(elevator), "The elevator should go up to the floor that it was directed to.");

            type.GetMethod("OpenDoor").Invoke(elevator, null);
            type.GetMethod("GoUp").Invoke(elevator, new object[] { 3 });
            Assert.AreEqual(2, type.GetProperty("CurrentLevel").GetValue(elevator), "The elevator should remain on its current floor if the door is open.");
            type.GetMethod("CloseDoor").Invoke(elevator, null);

            type.GetMethod("GoUp").Invoke(elevator, new object[] { 3 });
            Assert.AreEqual(3, type.GetProperty("CurrentLevel").GetValue(elevator), "The elevator should go up to the floor that it was directed to.");

            type.GetMethod("GoUp").Invoke(elevator, new object[] { 4 });
            Assert.AreEqual(3, type.GetProperty("CurrentLevel").GetValue(elevator), "The elevator should not go past its last floor.");

            type.GetMethod("GoUp").Invoke(elevator, new object[] { 1 });
            Assert.AreEqual(3, type.GetProperty("CurrentLevel").GetValue(elevator), "The elevator should only go up if the desired floor is greater than the current floor.");


            type.GetMethod("GoDown").Invoke(elevator, new object[] { 2 });
            Assert.AreEqual(2, type.GetProperty("CurrentLevel").GetValue(elevator), "The elevator should go down to the floor that it was directed to.");

            type.GetMethod("OpenDoor").Invoke(elevator, null);
            type.GetMethod("GoDown").Invoke(elevator, new object[] { 1 });
            Assert.AreEqual(2, type.GetProperty("CurrentLevel").GetValue(elevator), "The elevator should remain on its current floor if the door is open.");
            type.GetMethod("CloseDoor").Invoke(elevator, null);

            type.GetMethod("GoDown").Invoke(elevator, new object[] { 1 });
            Assert.AreEqual(1, type.GetProperty("CurrentLevel").GetValue(elevator), "The elevator should go down to the floor that it was directed to.");

            type.GetMethod("GoDown").Invoke(elevator, new object[] { -1 });
            Assert.AreEqual(1, type.GetProperty("CurrentLevel").GetValue(elevator), "The elevator should not go below floor 1.");

            type.GetMethod("GoDown").Invoke(elevator, new object[] { 3 });
            Assert.AreEqual(1, type.GetProperty("CurrentLevel").GetValue(elevator), "The elevator should only go down if the desired floor is less than the current floor.");

        }

    }
}
