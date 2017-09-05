using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod()]
        public void FirstLast6Test()
        {
           Assert.AreEqual(true, exercises.FirstLast6(new int[] { 1, 2, 6 }), "Input was [1, 2, 6]");
           Assert.AreEqual(true, exercises.FirstLast6(new int[] { 6, 1, 2, 3 }), "Input was [6, 1, 2, 3]");
           Assert.AreEqual(false, exercises.FirstLast6(new int[] { 13, 6, 1, 2, 3 }), "Input was [13, 6, 1, 2, 3]");
        }

        [TestMethod()]
        public void SameFirstLastTest()
        {
            Assert.AreEqual(false, exercises.SameFirstLast(new int[] { 1, 2, 3 }), "Input was [1, 2, 3]");
            Assert.AreEqual(true, exercises.SameFirstLast(new int[] { 1, 2, 3, 1 }), "Input was [1, 2, 3, 1]");
            Assert.AreEqual(true, exercises.SameFirstLast(new int[] { 1, 2, 1 }), "Input was [1, 2, 1]");
        }

        [TestMethod()]
        public void MakePiTest()
        {
            CollectionAssert.AreEqual(new int[] { 3, 1, 4 }, exercises.MakePi());            
        }

        [TestMethod()]
        public void CommonEndTest()
        {
            Assert.AreEqual(true, exercises.CommonEnd(new int[] { 1, 2, 3 }, new int[] { 7, 3 }), "Input was [1, 2, 3] and [7, 3]");
            Assert.AreEqual(false, exercises.CommonEnd(new int[] { 1, 2, 3 }, new int[] { 7, 3, 2 }), "Input was [1, 2, 3] and [7, 3, 2]");
            Assert.AreEqual(true, exercises.CommonEnd(new int[] { 1, 2, 3 }, new int[] { 1, 3 }), "Input was [1, 2, 3] and [1, 3]");
        }

        [TestMethod()]
        public void Sum3Test()
        {
            Assert.AreEqual(6, exercises.Sum3(new int[] { 1, 2, 3 }), "Input was [1, 2, 3]");
            Assert.AreEqual(18, exercises.Sum3(new int[] { 5, 11, 2 }), "Input was [5, 11, 2]");
            Assert.AreEqual(7, exercises.Sum3(new int[] { 7, 0, 0 }), "Input was [7, 0, 0]");
        }

        [TestMethod()]
        public void RotateLeft3Test()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3, 1 }, exercises.RotateLeft3(new int[] { 1, 2, 3 }), "Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 11, 9, 5 }, exercises.RotateLeft3(new int[] { 5, 11, 9 }), "Input was [5, 11, 9]");
            CollectionAssert.AreEqual(new int[] { 0, 0, 7 }, exercises.RotateLeft3(new int[] { 7, 0, 0 }), "Input was [7, 0, 0]");
        }

        [TestMethod()]
        public void Reverse3Test()
        {
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, exercises.Reverse3(new int[] { 1, 2, 3 }), "Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 9, 11, 5 }, exercises.Reverse3(new int[] { 5, 11, 9 }), "Input was [5, 11, 9]");
            CollectionAssert.AreEqual(new int[] { 0, 0, 7 }, exercises.Reverse3(new int[] { 7, 0, 0 }), "Input was [7, 0, 0]");
        }

        [TestMethod()]
        public void MaxEnd3Test()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MaxEnd3(new int[] { 1, 2, 3 }), "Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, exercises.MaxEnd3(new int[] { 11, 5, 9 }), "Input was [11, 5, 9]");
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MaxEnd3(new int[] { 2, 11, 3 }), "Input was [2, 11, 3]");
        }

        [TestMethod()]
        public void Sum2Test()
        {
            Assert.AreEqual(3, exercises.Sum2(new int[] { 1, 2, 3 }), "Input was [1, 2, 3]");
            Assert.AreEqual(2, exercises.Sum2(new int[] { 1, 1 }), "Input was [1, 1]");
            Assert.AreEqual(2, exercises.Sum2(new int[] { 1, 1, 1, 1 }), "Input was [1, 1, 1, 1]");
        }

        [TestMethod()]
        public void MiddleWayTest()
        {
            CollectionAssert.AreEqual(new int[] { 2, 5 }, exercises.MiddleWay(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }), "Input was [1, 2, 3] and [4, 5, 6]");
            CollectionAssert.AreEqual(new int[] { 7, 8 }, exercises.MiddleWay(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 }), "Input was [7, 7, 7] and [3, 8, 0]");
            CollectionAssert.AreEqual(new int[] { 2, 4 }, exercises.MiddleWay(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }), "Input was [5, 2, 9] and [1, 4, 5]");
        }

        [TestMethod()]
        public void CountEvensTest()
        {
            Assert.AreEqual(3, exercises.CountEvens(new int[] { 2, 1, 2, 3, 4 }), "Input was [2, 1, 2, 3, 4]");
            Assert.AreEqual(3, exercises.CountEvens(new int[] { 2, 2, 0 }), "Input was [2, 2, 0]");
            Assert.AreEqual(0, exercises.CountEvens(new int[] { 1, 3, 5 }), "Input was [1, 3, 5]");
        }

        [TestMethod()]
        public void Sum13Test()
        {
            Assert.AreEqual(6, exercises.Sum13(new int[] { 1, 2, 2, 1 }), "Input was [1, 2, 2, 1]");
            Assert.AreEqual(2, exercises.Sum13(new int[] { 1, 1 }), "Input was [1, 1]");
            Assert.AreEqual(6, exercises.Sum13(new int[] { 1, 2, 2, 1, 13 }), "Input was [1, 2, 2, 1, 13]");
        }

        [TestMethod()]
        public void Has22Test()
        {
            Assert.AreEqual(true, exercises.Has22(new int[] { 1, 2, 2 }), "Input was [1, 2, 2]");
            Assert.AreEqual(false, exercises.Has22(new int[] { 1, 2, 1, 2 }), "Input was [1, 2, 1, 2]");
            Assert.AreEqual(false, exercises.Has22(new int[] { 2, 1, 2 }), "Input was [2, 1, 2]");
        }

        [TestMethod()]
        public void Lucky13Test()
        {
            Assert.AreEqual(true, exercises.Lucky13(new int[] { 0, 2, 4 }), "Input was [0, 2, 4]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 1, 2, 3 }), "Input was [1, 2, 3]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 1, 2, 4 }), "Input was [1, 2, 4]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 5, 2, 3 }), "Input was [5, 2, 3]");

        }

        [TestMethod()]
        public void Sum28Test()
        {
            Assert.AreEqual(true, exercises.Sum28(new int[] { 2, 3, 2, 2, 4, 2 }), "Input was [2, 3, 2, 2, 4, 2]");
            Assert.AreEqual(false, exercises.Sum28(new int[] { 2, 3, 2, 2, 4, 2, 2 }), "Input was [2, 3, 2, 2, 4, 2, 2]");
            Assert.AreEqual(false, exercises.Sum28(new int[] { 1, 2, 3, 4 }), "Input was [1, 2, 3, 4]");
        }
    }
}