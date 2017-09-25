using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class KataFizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_0_Test()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("", kfb.fizzBuzz(0));
        }

        [TestMethod]
        public void FizzBuzz_101_Test()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("", kfb.fizzBuzz(101));
        }

        [TestMethod]
        public void FizzBuzz_Obvious_Cases_Test()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("Fizz", kfb.fizzBuzz(3));
            Assert.AreEqual("Buzz", kfb.fizzBuzz(5));
            Assert.AreEqual("Fizz", kfb.fizzBuzz(6));
            Assert.AreEqual("Fizz", kfb.fizzBuzz(9));
            Assert.AreEqual("FizzBuzz", kfb.fizzBuzz(15));
            Assert.AreEqual("FizzBuzz", kfb.fizzBuzz(45));
        }

        [TestMethod]
        public void FizzBuzz_Non_Fizzy_Buzzy_Numbers_Test()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("2", kfb.fizzBuzz(2));
            Assert.AreEqual("7", kfb.fizzBuzz(7));
            Assert.AreEqual("17", kfb.fizzBuzz(17));
            Assert.AreEqual("Fizz", kfb.fizzBuzz(34)); //Step 2: 34 contains a 3, so is now Fizz, not 34
            Assert.AreEqual("Buzz", kfb.fizzBuzz(53)); //Step 2: 53 contains a 5 and 3, but 5 is checked first, so Buzz
            Assert.AreEqual("86", kfb.fizzBuzz(86));
        }
    }
}
