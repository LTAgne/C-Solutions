using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        /*
         Given an array of ints, return true if the array contains no 1's and no 3's.
         GetLucky([0, 2, 4]) → true
         GetLucky([1, 2, 3]) → false
         GetLucky([1, 2, 4]) → false
         */

        [TestMethod]
        public void ArrayWithNo1sOr0s_ExpectTrue()
        {
            //Arrange
            Lucky13 lucky = new Lucky13();

            //Assert
            Assert.AreEqual(true, lucky.GetLucky(new int[] { 0, 2, 4}));
            Assert.AreEqual(true, lucky.GetLucky(new int[] { }));
        }

        [TestMethod]
        public void ArrayWithAll1sOr0s_ExpectFalse()
        {
            //Arrange
            Lucky13 lucky = new Lucky13();

            //Assert
            Assert.AreEqual(false, lucky.GetLucky(new int[] { 1, 1, 1 }));
            Assert.AreEqual(false, lucky.GetLucky(new int[] { 3, 3, 3 }));
            Assert.AreEqual(false, lucky.GetLucky(new int[] { 1, 3 }));
        }
    }
}
