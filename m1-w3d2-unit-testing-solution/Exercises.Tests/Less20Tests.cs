using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        /*
         Return true if the given non-negative number is 1 or 2 less than a multiple of 20. So for example 38 
         and 39 return true, but 40 returns false. 
         (Hint: Think "mod".)
         less20(18) → true
         less20(19) → true
         less20(20) → false
         */

        [TestMethod]
        public void Within1LessTest_ExpectTrue()
        {
            //Arrange
            Less20 exercises = new Less20();

            //Assert
            Assert.AreEqual(true, exercises.IsLessThanMultipleOf20(19));
            Assert.AreEqual(false, exercises.IsLessThanMultipleOf20(21));
            Assert.AreEqual(true, exercises.IsLessThanMultipleOf20(39));
            Assert.AreEqual(false, exercises.IsLessThanMultipleOf20(41));
        }

        [TestMethod]
        public void Within2LessTest_ExpectTrue()
        {
            //Arrange
            Less20 exercises = new Less20();

            //Assert
            Assert.AreEqual(true, exercises.IsLessThanMultipleOf20(18));
            Assert.AreEqual(false, exercises.IsLessThanMultipleOf20(22));
            Assert.AreEqual(true, exercises.IsLessThanMultipleOf20(38));
            Assert.AreEqual(false, exercises.IsLessThanMultipleOf20(42));
        }

        [TestMethod]
        public void Within3Test_ExpectFalse()
        {
            //Arrange
            Less20 exercises = new Less20();

            //Assert
            Assert.AreEqual(false, exercises.IsLessThanMultipleOf20(17));
            Assert.AreEqual(false, exercises.IsLessThanMultipleOf20(23));
            Assert.AreEqual(false, exercises.IsLessThanMultipleOf20(3));
            Assert.AreEqual(false, exercises.IsLessThanMultipleOf20(37));
            Assert.AreEqual(false, exercises.IsLessThanMultipleOf20(43));
        }
    }
}
