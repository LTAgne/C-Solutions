using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Individual.Exercises.Classes;
using System.Reflection;

namespace Exercises.Tests.Classes
{
    [TestClass]
    public class AirplaneTests
    {
        [TestMethod]
        public void Airplane_HasRequiredMembers()
        {
            Type type = typeof(Airplane);
            Airplane Airplane = (Airplane)Activator.CreateInstance(type, "ABC123", 2, 3);        

            PropertyInfo prop = type.GetProperty("PlaneNumber");
            PropertyValidator.ValidateReadOnly(prop, "PlaneNumber", typeof(string));
            
            prop = type.GetProperty("BookedFirstClassSeats");
            PropertyValidator.ValidateReadOnly(prop, "BookedFirstClassSeats", typeof(int));            
            
            prop = type.GetProperty("AvailableFirstClassSeats");
            PropertyValidator.ValidateReadOnly(prop, "AvailableFirstClassSeats", typeof(int));

            prop = type.GetProperty("TotalFirstClassSeats");
            PropertyValidator.ValidateReadOnly(prop, "TotalFirstClassSeats", typeof(int));


            prop = type.GetProperty("BookedCoachSeats");
            PropertyValidator.ValidateReadOnly(prop, "BookedCoachSeats", typeof(int));

            prop = type.GetProperty("AvailableCoachSeats");
            PropertyValidator.ValidateReadOnly(prop, "AvailableCoachSeats", typeof(int));

            prop = type.GetProperty("TotalCoachSeats");
            PropertyValidator.ValidateReadOnly(prop, "TotalCoachSeats", typeof(int));

            MethodInfo method = type.GetMethod("ReserveSeats");
            MethodValidator.ValidatePublicMethod(method, "ReserveSeats", typeof(bool));            
        }

        [TestMethod]
        public void Airplane_Constructor()
        {
            Type type = typeof(Airplane);
            Airplane airplane = (Airplane)Activator.CreateInstance(type, "ABC123", 2, 3);

            PropertyInfo prop = type.GetProperty("PlaneNumber");
            Assert.AreEqual("ABC123", prop.GetValue(airplane), "Passed ABC123 into constructor and expected PlaneNumber property to hold 1");

            prop = type.GetProperty("TotalFirstClassSeats");
            Assert.AreEqual(2, prop.GetValue(airplane), "Passed 2 into constructor and expected TotalFirstClassSeats property to return 2");

            prop = type.GetProperty("TotalCoachSeats");
            Assert.AreEqual(3, prop.GetValue(airplane), "Passed 3 into constructor and expected TotalCoachSeats property to return 3");

            prop = type.GetProperty("BookedFirstClassSeats");
            Assert.AreEqual(0, prop.GetValue(airplane), "New planes should initially have 0 booked first class seats.");

            prop = type.GetProperty("BookedCoachSeats");
            Assert.AreEqual(0, prop.GetValue(airplane), "New planes should initially have 0 booked coach seats.");
        }

        [TestMethod]
        public void Airplane_AvailableSeatsTest()
        {
            Type type = typeof(Airplane);
            Airplane airplane = (Airplane)Activator.CreateInstance(type, "ABC123", 2, 3);

            PropertyInfo prop = type.GetProperty("AvailableFirstClassSeats");
            Assert.AreEqual(2, prop.GetValue(airplane), "No seats have been booked for first class. There are 2 first class seats, 2 should be available.");

            prop = type.GetProperty("AvailableCoachSeats");
            Assert.AreEqual(3, prop.GetValue(airplane), "No seats have been booked for coach. There are 3 coach seats, 3 should be available.");
        }

        [TestMethod]
        public void Airplane_ReserveSeatsTest()
        {
            Type type = typeof(Airplane);
            Airplane airplane = (Airplane)Activator.CreateInstance(type, "ABC123", 2, 3);

            MethodInfo method = type.GetMethod("ReserveSeats");
            Assert.AreEqual(true, method.Invoke(airplane, new object[] { true, 1 }), "ReserveSeats should return true if a seat can be booked."); //first class seat
            Assert.AreEqual(true, method.Invoke(airplane, new object[] { false, 2 }), "ReserveSeats should return true if a seat can be booked."); //first class seat


            PropertyInfo prop = type.GetProperty("AvailableFirstClassSeats");
            Assert.AreEqual(1, prop.GetValue(airplane), "AvailableFirstClassSeats did not return the correct value. Total 2, Booked 1, Available 1");

            prop = type.GetProperty("BookedFirstClassSeats");
            Assert.AreEqual(1, prop.GetValue(airplane), "BookedFirstClassSeats did not return the correct value. Total 2, Booked 1, Available 1");        

            prop = type.GetProperty("AvailableCoachSeats");
            Assert.AreEqual(1, prop.GetValue(airplane), "AvailableCoachSeats did not return the correct value. Total 3, Booked 2, Available 1");

            prop = type.GetProperty("BookedCoachSeats");
            Assert.AreEqual(2, prop.GetValue(airplane), "BookedCoachSeats did not return the correct value. Total 3, Booked 2, Available 1");


            airplane = (Airplane)Activator.CreateInstance(type, "ABC123", 2, 3);
            
            Assert.AreEqual(false, method.Invoke(airplane, new object[] { true, 3 }), "Reserve should return false if a seat can be booked."); //first class seat
            Assert.AreEqual(false, method.Invoke(airplane, new object[] { false, 4 }), "Reserve should return false if a seat can be booked."); //first class seat


            prop = type.GetProperty("AvailableFirstClassSeats");
            Assert.AreEqual(2, prop.GetValue(airplane), "AvailableFirstClassSeats did not return the correct value. Total 2, Booked 0, Available 2");

            prop = type.GetProperty("AvailableCoachSeats");
            Assert.AreEqual(3, prop.GetValue(airplane), "AvailableCoachSeats did not return the correct value. Total 3, Booked 0, Available 3");


            prop = type.GetProperty("BookedFirstClassSeats");
            Assert.AreEqual(0, prop.GetValue(airplane), "BookedFirstClassSeats did not return the correct value. Total 2, Booked 0, Available 2");

            prop = type.GetProperty("BookedCoachSeats");
            Assert.AreEqual(0, prop.GetValue(airplane), "BookedCoachSeats did not return the correct value. Total 3, Booked 0, Available 3");

        }


    }
}
