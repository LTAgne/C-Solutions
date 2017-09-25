using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /// <summary>
    /// Summary description for KataPotterTests
    /// </summary>
    [TestClass]
    public class KataPotterTests
    {
        [TestMethod]
        public void BasicPurchaseScenarios()
        {

            // No Books
            Assert.AreEqual(0.0M, new KataPotter().GetCost(new int[] { }));

            // Individual Books
            Assert.AreEqual(8.0M, new KataPotter().GetCost(new int[] { 0 }));
            Assert.AreEqual(8.0M, new KataPotter().GetCost(new int[] { 1 }));
            Assert.AreEqual(8.0M, new KataPotter().GetCost(new int[] { 2 }));
            Assert.AreEqual(8.0M, new KataPotter().GetCost(new int[] { 3 }));
            Assert.AreEqual(8.0M, new KataPotter().GetCost(new int[] { 4 }));

            // Two or More of the Same
            Assert.AreEqual(8.0M * 2, new KataPotter().GetCost(new int[] { 0, 0 }));
            Assert.AreEqual(8.0M * 3, new KataPotter().GetCost(new int[] { 0, 0, 0 }));
        }

        [TestMethod]
        public void SimpleDiscounts()
        {
            Assert.AreEqual(8.0M * 2 * 0.95M, new KataPotter().GetCost(new int[] { 0, 1 }));
            Assert.AreEqual(8.0M * 3 * 0.90M, new KataPotter().GetCost(new int[] { 0, 1, 2 }));
            Assert.AreEqual(8.0M * 4 * 0.80M, new KataPotter().GetCost(new int[] { 0, 1, 2, 3 }));
            Assert.AreEqual(8.0M * 5 * 0.75M, new KataPotter().GetCost(new int[] { 0, 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void SeveralDiscounts()
        {
            Assert.AreEqual(8.0M + 8.0M * 2 * 0.95M, new KataPotter().GetCost(new int[] { 0, 0, 1 }));
            Assert.AreEqual(8.0M + 8.0M * 3 * 0.90M, new KataPotter().GetCost(new int[] { 0, 0, 1, 2 }));
            Assert.AreEqual(8.0M * 2 * 0.95M + 8.0M * 3 * 0.90M, new KataPotter().GetCost(new int[] { 0, 0, 1, 1, 2 }));
            Assert.AreEqual(8.0M * 4 * 0.80M + 8.0M * 2 * 0.95M, new KataPotter().GetCost(new int[] { 0, 0, 1, 2, 2, 3 }));
        }

        [TestMethod]
        public void ComplexDiscounts()
        {
            Assert.AreEqual(2 * (8.0M * 4 * 0.80M), new KataPotter().GetCost(new int[] { 0, 0, 1, 1, 2, 2, 3, 4 }));
            Assert.AreEqual((8.0M * 5 * 0.75M) + 3 * 8.0M, new KataPotter().GetCost(new int[] { 0, 1, 2, 3, 4, 1, 1, 1 })); //set of 5 + 3 sets of 1
            Assert.AreEqual(3 * (8.0M * 5 * 0.75M) + 2 * (8 * 4 * 0.8M),
                new KataPotter().GetCost(new int[] {
                    0, 0, 0, 0, 0,
                    1, 1, 1, 1, 1,
                    2, 2, 2, 2,
                    3, 3, 3, 3, 3,
                    4, 4, 4, 4}));
        }
    }
}
