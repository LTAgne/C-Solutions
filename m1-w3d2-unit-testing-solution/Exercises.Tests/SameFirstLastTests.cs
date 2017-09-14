using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        /*
         Given an array of ints, return true if the array is length 1 or more, and the first element and
         the last element are equal.
         sameFirstLast([1, 2, 3]) → false
         sameFirstLast([1, 2, 3, 1]) → true
         sameFirstLast([1, 2, 1]) → true
         */

        [TestMethod]
        public void ArrayLength0_ExpectFalse()
        {
            //Arrange
            SameFirstLast exercises = new SameFirstLast();

            //Assert
            Assert.AreEqual(false, exercises.IsItTheSame(new int[] { }));
        }

        [TestMethod]
        public void ArrayLength1_ExpectTrue()
        {
            //Arrange
            SameFirstLast exercises = new SameFirstLast();

            //Assert
            Assert.AreEqual(true, exercises.IsItTheSame(new int[] { 1 }));
        }

        [TestMethod]
        public void ArrayLength2OrMore()
        {
            //Arrange
            SameFirstLast exercises = new SameFirstLast();

            //Assert
            Assert.AreEqual(true, exercises.IsItTheSame(new int[] { 1, 1 }));
            Assert.AreEqual(true, exercises.IsItTheSame(new int[] { 1, 3, 1 }));
            Assert.AreEqual(false, exercises.IsItTheSame(new int[] { 1, 3 }));
            Assert.AreEqual(false, exercises.IsItTheSame(new int[] { 1, 3, 3 }));

        }





    }
}
