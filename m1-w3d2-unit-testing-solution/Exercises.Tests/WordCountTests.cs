using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        /*
       * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
       * number of times that string appears in the array.
       * 
       * ** A CLASSIC **
       * 
       * wordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
       * wordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
       * wordCount([]) → {}
       * wordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
       * 
       */
        [TestMethod]
        public void EmptySetTest_ExpectEmptySet()
        {
            //Arrange
            WordCount exercises = new WordCount();

            //Assert
            CollectionAssert.AreEqual(new Dictionary<string, int>(), exercises.GetCount(new string[] { }));
        }

        [TestMethod]
        public void UniqueTest_Expect1Each()
        {
            //Arrange
            WordCount exercises = new WordCount();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                { "Josh", 1 },
                { "David", 1 },
                { "Casey", 1 },
                { "Craig", 1 }
            };

            //Assert
            CollectionAssert.AreEqual(expected, exercises.GetCount(new string[] { "Josh", "David", "Casey", "Craig" }));
        }

        [TestMethod]
        public void RepeatingTest()
        {
            //Arrange
            WordCount exercises = new WordCount();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                { "Josh", 4  },
            };

            //Assert
            CollectionAssert.AreEqual(expected, exercises.GetCount(new string[] { "Josh", "Josh", "Josh", "Josh" }));
        }

        [TestMethod]
        public void WordNotProvidedTests()
        {
            //Arrange
            WordCount exercises = new WordCount();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                { "Josh", 4  },
            };

            //Assert
            CollectionAssert.AreNotEqual(expected, exercises.GetCount(new string[] { "Craig", "Craig", "Craig", "Craig" }));
        }
    }
}
