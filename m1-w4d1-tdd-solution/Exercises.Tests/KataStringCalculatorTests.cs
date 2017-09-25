using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataStringCalculatorTests
    {
        [TestMethod]
        public void StringCalculator_Step_1()
        {
            KataStringCalculator ksc = new KataStringCalculator();
            Assert.AreEqual(0, ksc.Add(""));                            // Empty
            Assert.AreEqual(86834, ksc.Add("86834"));                   // One number
            Assert.AreEqual(12475768, ksc.Add("86834,12388934"));       // Two numbers
            Assert.AreEqual(12475769, ksc.Add("86834,12388934,1"));     // Three numbers
            Assert.AreEqual(12475770, ksc.Add("86834,12388934,1,1"));          // Four numbers, oops!
        }

        [TestMethod]
        public void StringCalculator_Step_2()
        {
            KataStringCalculator ksc = new KataStringCalculator();
            Assert.AreEqual(12475770, ksc.Add("86834,12388934,1,1"));   // Step 2, unlimited
            Assert.AreEqual(55, ksc.Add("1,2,3,4,5,6,7,8,9,10"));       // Step 2, unlimited
        }

        [TestMethod]
        public void StringCalculator_Step_3()
        {
            KataStringCalculator ksc = new KataStringCalculator();
            Assert.AreEqual(12475770, ksc.Add("86834\n12388934,1\n1")); // Step 3, 2 newline
            Assert.AreEqual(12475770, ksc.Add("86834,12388934\n1,1"));  // Step 3, 1 newline
            Assert.AreEqual(12475770, ksc.Add("86834\n12388934\n1\n1"));// Step 3, 3 newline
        }

        [TestMethod]
        public void StringCalculator_Step_4()
        {
            KataStringCalculator ksc = new KataStringCalculator();
            Assert.AreEqual(10, ksc.Add("//!\n1!2!3!4"));   //Step 4, ! delimiter
            Assert.AreEqual(10, ksc.Add("//!\n1\n2!3\n4")); //Step 4, ! delimiter, mixed
        }

    }
}
