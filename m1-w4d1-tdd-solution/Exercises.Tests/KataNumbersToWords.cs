using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataNumbersToWordsTests
    {
        [TestMethod]
        public void NumberToWords_Less_Than_20()
        {
            KataNumbersToWords kntw = new KataNumbersToWords();
            Assert.AreEqual("one", kntw.NumberToWords(1));
            Assert.AreEqual("two", kntw.NumberToWords(2));
            Assert.AreEqual("nine", kntw.NumberToWords(9));
            Assert.AreEqual("ten", kntw.NumberToWords(10));
            Assert.AreEqual("fourteen", kntw.NumberToWords(14));
            Assert.AreEqual("nineteen", kntw.NumberToWords(19));
        }

        [TestMethod]
        public void NumberToWords_Between_20_And_99()
        {
            KataNumbersToWords kntw = new KataNumbersToWords();
            Assert.AreEqual("twenty", kntw.NumberToWords(20));
            Assert.AreEqual("twenty one", kntw.NumberToWords(21));
            Assert.AreEqual("fifty two", kntw.NumberToWords(52));
            Assert.AreEqual("ninety eight", kntw.NumberToWords(98));
            Assert.AreEqual("ninety nine", kntw.NumberToWords(99));
        }

        [TestMethod]
        public void NumberToWords_Between_100_And_999()
        {
            KataNumbersToWords kntw = new KataNumbersToWords();
            Assert.AreEqual("one hundred", kntw.NumberToWords(100));
            Assert.AreEqual("one hundred one", kntw.NumberToWords(101));
            Assert.AreEqual("five hundred fifty two", kntw.NumberToWords(552));
            Assert.AreEqual("nine hundred ninety nine", kntw.NumberToWords(999));
        }

        [TestMethod]
        public void NumberToWords_Over_1000()
        {
            KataNumbersToWords kntw = new KataNumbersToWords();
            Assert.AreEqual("one hundred twenty five thousand seven hundred ninety three", kntw.NumberToWords(125793));
            Assert.AreEqual("one million", kntw.NumberToWords(1000000));
            Assert.AreEqual("seven hundred million", kntw.NumberToWords(700000000));
            Assert.AreEqual("nine hundred eighty seven million six hundred fifty four thousand three hundred twenty one", kntw.NumberToWords(987654321));
            Assert.AreEqual("nine hundred ninety nine million nine hundred ninety nine thousand nine hundred ninety nine", kntw.NumberToWords(999999999));
        }

        [TestMethod]
        public void NumberToWords_Testing_0()
        {
            KataNumbersToWords kntw = new KataNumbersToWords();
            Assert.AreEqual("zero", kntw.NumberToWords(0));
        }

        [TestMethod]
        public void WordsToNumber_Single_Word()
        {
            KataNumbersToWords kntw = new KataNumbersToWords();
            Assert.AreEqual(1, kntw.WordsToNumber("one"));
            Assert.AreEqual(2, kntw.WordsToNumber("Two"));
            Assert.AreEqual(9, kntw.WordsToNumber("nine"));
            Assert.AreEqual(10, kntw.WordsToNumber("Ten"));
            Assert.AreEqual(14, kntw.WordsToNumber("fourteen"));
            Assert.AreEqual(19, kntw.WordsToNumber("Nineteen"));
            Assert.AreEqual(20, kntw.WordsToNumber("twenty"));
            Assert.AreEqual(70, kntw.WordsToNumber("Seventy"));
            Assert.AreEqual(90, kntw.WordsToNumber("ninety"));
        }

        [TestMethod]
        public void WordsToNumber_Two_Words()
        {
            KataNumbersToWords kntw = new KataNumbersToWords();
            Assert.AreEqual(21, kntw.WordsToNumber("Twenty one"));
            Assert.AreEqual(25, kntw.WordsToNumber("twenty Five"));
            Assert.AreEqual(66, kntw.WordsToNumber("Sixty Six"));
            Assert.AreEqual(77, kntw.WordsToNumber("seventy seven"));
        }

        [TestMethod]
        public void WordsToNumber_Three_Words()
        {
            KataNumbersToWords kntw = new KataNumbersToWords();
            Assert.AreEqual(550, kntw.WordsToNumber("five Hundred fifty"));
            Assert.AreEqual(101, kntw.WordsToNumber("One hundred One"));
            Assert.AreEqual(2012, kntw.WordsToNumber("two thousand twelve"));
            Assert.AreEqual(3000013, kntw.WordsToNumber("THREE MILLION ThIrTeEn"));
            Assert.AreEqual(700000000, kntw.WordsToNumber("seven hundred million"));
        }

        [TestMethod]
        public void WordsToNumber_Many_Words()
        {
            KataNumbersToWords kntw = new KataNumbersToWords();
            Assert.AreEqual(125793, kntw.WordsToNumber("one hundred twenty five thousand seven hundred ninety three"));
            Assert.AreEqual(987654321, kntw.WordsToNumber("nine hundred eighty seven million six hundred fifty four thousand three hundred twenty one"));
            Assert.AreEqual(999999999, kntw.WordsToNumber("nine hundred ninety nine million nine hundred ninety nine thousand nine hundred ninety nine"));
        }

    }
}
