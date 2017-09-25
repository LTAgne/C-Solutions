using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        [TestMethod]
        public void ArabicToRoman_Arabic_Number_Greater_Than_3999()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("", krn.ArabicToRoman(4000));
        }

        [TestMethod]
        public void ArabicToRoman_Single_Letter_Roman_Numerals()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("I", krn.ArabicToRoman(1));
            Assert.AreEqual("V", krn.ArabicToRoman(5));
            Assert.AreEqual("X", krn.ArabicToRoman(10));
            Assert.AreEqual("L", krn.ArabicToRoman(50));
            Assert.AreEqual("C", krn.ArabicToRoman(100));
            Assert.AreEqual("D", krn.ArabicToRoman(500));
            Assert.AreEqual("M", krn.ArabicToRoman(1000));
        }

        [TestMethod]
        public void ArabicToRoman_Double_Letter_Roman_Numerals()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("II", krn.ArabicToRoman(2));
            Assert.AreEqual("IV", krn.ArabicToRoman(4));
            Assert.AreEqual("VI", krn.ArabicToRoman(6));
            Assert.AreEqual("IX", krn.ArabicToRoman(9));
            Assert.AreEqual("XI", krn.ArabicToRoman(11));
            Assert.AreEqual("XX", krn.ArabicToRoman(20));
            Assert.AreEqual("XL", krn.ArabicToRoman(40));
            Assert.AreEqual("LX", krn.ArabicToRoman(60));
            Assert.AreEqual("XC", krn.ArabicToRoman(90));
            Assert.AreEqual("CX", krn.ArabicToRoman(110));
            Assert.AreEqual("CC", krn.ArabicToRoman(200));
            Assert.AreEqual("CD", krn.ArabicToRoman(400));
            Assert.AreEqual("DC", krn.ArabicToRoman(600));
            Assert.AreEqual("CM", krn.ArabicToRoman(900));
            Assert.AreEqual("MC", krn.ArabicToRoman(1100));
            Assert.AreEqual("MM", krn.ArabicToRoman(2000));
        }

        [TestMethod]
        public void ArabicToRoman_Triple_Letter_Roman_Numerals()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("III", krn.ArabicToRoman(3));
            Assert.AreEqual("VII", krn.ArabicToRoman(7));
            Assert.AreEqual("XXX", krn.ArabicToRoman(30));
            Assert.AreEqual("LXX", krn.ArabicToRoman(70));
            Assert.AreEqual("CCC", krn.ArabicToRoman(300));
            Assert.AreEqual("DCC", krn.ArabicToRoman(700));
            Assert.AreEqual("MMM", krn.ArabicToRoman(3000));
        }

        [TestMethod]
        public void ArabicToRoman_Quadruple_Letter_Roman_Numerals()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("VIII", krn.ArabicToRoman(8));
            Assert.AreEqual("LXXX", krn.ArabicToRoman(80));
            Assert.AreEqual("DCCC", krn.ArabicToRoman(800));
        }

        [TestMethod]
        public void ArabicToRoman_Assorted()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("MCCLIII", krn.ArabicToRoman(1253));
            Assert.AreEqual("DCCXXIV", krn.ArabicToRoman(724));
            Assert.AreEqual("MMCMXCIX", krn.ArabicToRoman(2999));
            Assert.AreEqual("III", krn.ArabicToRoman(3));
            Assert.AreEqual("LXVII", krn.ArabicToRoman(67));
            Assert.AreEqual("MMMCMXCIX", krn.ArabicToRoman(3999));
        }

        // Step 2: Tests for the new RomanToArabic method
        [TestMethod]
        public void RomanToArabic_Single_Letter_Roman_Numerals()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual(1, krn.RomanToArabic("I"));
            Assert.AreEqual(5, krn.RomanToArabic("V"));
            Assert.AreEqual(10, krn.RomanToArabic("X"));
            Assert.AreEqual(50, krn.RomanToArabic("L"));
            Assert.AreEqual(100, krn.RomanToArabic("C"));
            Assert.AreEqual(500, krn.RomanToArabic("D"));
            Assert.AreEqual(1000, krn.RomanToArabic("M"));
        }

        [TestMethod]
    	public void RomanToArabic_Double_Letter_Roman_Numerals() {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual(2, krn.RomanToArabic("II"));
            Assert.AreEqual(4, krn.RomanToArabic("IV"));
            Assert.AreEqual(6, krn.RomanToArabic("VI"));
            Assert.AreEqual(9, krn.RomanToArabic("IX"));
            Assert.AreEqual(11, krn.RomanToArabic("XI"));
            Assert.AreEqual(20, krn.RomanToArabic("XX"));
            Assert.AreEqual(40, krn.RomanToArabic("XL"));
            Assert.AreEqual(60, krn.RomanToArabic("LX"));
            Assert.AreEqual(90, krn.RomanToArabic("XC"));
            Assert.AreEqual(110, krn.RomanToArabic("CX"));
            Assert.AreEqual(200, krn.RomanToArabic("CC"));
            Assert.AreEqual(400, krn.RomanToArabic("CD"));
            Assert.AreEqual(600, krn.RomanToArabic("DC"));
            Assert.AreEqual(900, krn.RomanToArabic("CM"));
            Assert.AreEqual(1100, krn.RomanToArabic("MC"));
            Assert.AreEqual(2000, krn.RomanToArabic("MM"));
        }

        [TestMethod]
        public void RomanToArabic_Triple_Letter_Roman_Numerals()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual(3, krn.RomanToArabic("III"));
            Assert.AreEqual(7, krn.RomanToArabic("VII"));
            Assert.AreEqual(30, krn.RomanToArabic("XXX"));
            Assert.AreEqual(70, krn.RomanToArabic("LXX"));
            Assert.AreEqual(300, krn.RomanToArabic("CCC"));
            Assert.AreEqual(700, krn.RomanToArabic("DCC"));
            Assert.AreEqual(3000, krn.RomanToArabic("MMM"));
        }

        [TestMethod]
        public void RomanToArabic_Quadruple_Letter_Roman_Numerals()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual(8, krn.RomanToArabic("VIII"));
            Assert.AreEqual(80, krn.RomanToArabic("LXXX"));
            Assert.AreEqual(800, krn.RomanToArabic("DCCC"));
        }

        [TestMethod]
        public void RomanToArabic_Various_Roman_Numerals()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual(1253, krn.RomanToArabic("MCCLIII"));
            Assert.AreEqual(724, krn.RomanToArabic("DCCXXIV"));
            Assert.AreEqual(2999, krn.RomanToArabic("MMCMXCIX"));
            Assert.AreEqual(3, krn.RomanToArabic("III"));
            Assert.AreEqual(67, krn.RomanToArabic("LXVII"));
        }

    }
}
