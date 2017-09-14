using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        [TestMethod]
        public void ProvideKnownAnimalName_ExpectKnownHerdName()
        {
            //Arrange
            AnimalGroupName animalGroup = new AnimalGroupName();            

            //Act
            string herdName = animalGroup.GetHerd("giraffe");

            //Assert
            Assert.AreEqual("Tower", herdName);
        }

        [TestMethod]
        public void ProvideKnownAnimalName_CrazyCase_ExpectKnownHerdName()
        {
            //Arrange
            AnimalGroupName animalGroup = new AnimalGroupName();

            //Act
            string herdName = animalGroup.GetHerd("GiRAffe");

            //Assert
            Assert.AreEqual("Tower", herdName);
        }

        [TestMethod]
        public void ProvideUnknownAnimalName_ExpectUnknownHerdName()
        {
            //Arrange
            AnimalGroupName animalGroup = new AnimalGroupName();

            //Act
            string herdName = animalGroup.GetHerd("");
            string herdName2 = animalGroup.GetHerd("elephants");

            //Assert
            Assert.AreEqual("unknown", herdName);
            Assert.AreEqual("unknown", herdName2);
        }
    }
}
