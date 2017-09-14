using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        /*
         Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
         stringBits("Hello") → "Hlo"	
         stringBits("Hi") → "H"	
         stringBits("Heeololeo") → "Hello"	
         */
        [TestMethod]
        public void StringLength0_ExpectEmptyString()
        {
            //Assert
            StringBits exercises = new StringBits();

            //Arrange
            Assert.AreEqual("", exercises.GetBits(""));
        }

        [TestMethod]
        public void StringLength1_ExpectSameString()
        {
            //Assert
            StringBits exercises = new StringBits();

            //Arrange
            Assert.AreEqual("H", exercises.GetBits("H"));
        }

        [TestMethod]
        public void StringLength2OrMore_ExpectAlternateLetters()
        {
            //Assert
            StringBits exercises = new StringBits();

            //Arrange
            Assert.AreEqual("Js", exercises.GetBits("Josh"));
            Assert.AreEqual("Tc lvtr", exercises.GetBits("Tech Elevator"));

        }
    }
}
