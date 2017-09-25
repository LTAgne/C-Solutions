using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPrimeFactorsTests
    {
        [TestMethod]
        public void Factorize_Negative_1_Returns_Empty_Array_Test()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { }, kpf.Factorize(-1));
        }

        [TestMethod]
        public void Factorize_1_Returns_Empty_Array_Test()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { }, kpf.Factorize(1));
        }

        [TestMethod]
        public void Factorize_2_Returns_2_Test()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 2 }, kpf.Factorize(2));
        }

        [TestMethod]
        public void Factorize_3_Returns_3_Test()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 3 }, kpf.Factorize(3));
        }

        [TestMethod]
        public void Factorize_6_Returns_2_3_Test()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 2, 3 }, kpf.Factorize(6));
        }

        [TestMethod]
        public void Factorize_7_Returns_7_Test()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 7 }, kpf.Factorize(7));
        }

        [TestMethod]
        public void Factorize_8_Returns_2_2_2_Test()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 2, 2, 2 }, kpf.Factorize(8));
        }

        [TestMethod]
        public void Factorize_More_Prime_Numbers_Test()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 11 }, kpf.Factorize(11));
            CollectionAssert.AreEqual(new int[] { 13 }, kpf.Factorize(13));
            CollectionAssert.AreEqual(new int[] { 17 }, kpf.Factorize(17));
            CollectionAssert.AreEqual(new int[] { 193 }, kpf.Factorize(193));
            CollectionAssert.AreEqual(new int[] { 5209 }, kpf.Factorize(5209));
            CollectionAssert.AreEqual(new int[] { 7919 }, kpf.Factorize(7919));
        }

        [TestMethod]
        public void Factorize_More_Non_Prime_Numbers_Test()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 3, 7 }, kpf.Factorize(21));
            CollectionAssert.AreEqual(new int[] { 3, 3, 11 }, kpf.Factorize(99));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2, 2, 2, 2, 2 }, kpf.Factorize(256));
            CollectionAssert.AreEqual(new int[] { 2, 2, 7, 73 }, kpf.Factorize(2044));
            CollectionAssert.AreEqual(new int[] { 7, 11, 101 }, kpf.Factorize(7777));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }, kpf.Factorize(8192));
        }

    }
}
