using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace Exercises.Tests
{
    [TestClass]
    public class ExerciseTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void animalGroupName()
        {
            Assert.AreEqual("Tower", exercises.AnimalGroupName("giraffe"));
            Assert.AreEqual("unknown", exercises.AnimalGroupName(""));
            Assert.AreEqual("unknown", exercises.AnimalGroupName("walrus"));
            Assert.AreEqual("Crash", exercises.AnimalGroupName("Rhino"));
            Assert.AreEqual("Crash", exercises.AnimalGroupName("rhino"));
            Assert.AreEqual("unknown", exercises.AnimalGroupName("elephants"));
        }

        [TestMethod]
        public void isItOnSale()
        {
            Assert.AreEqual(0.20, exercises.IsItOnSale("kitchen4001"));
            Assert.AreEqual(0.00, exercises.IsItOnSale(""));
            Assert.AreEqual(0.15, exercises.IsItOnSale("GARAGE1070"));
            Assert.AreEqual(0.00, exercises.IsItOnSale("dungeon9999"));
        }

        [TestMethod]
        public void robPeterToPayPaul()
        {
            // No Such dictionary collection assert exists so we needed to write our own
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Peter", 1000 },
                {"Paul", 1099 }
            };
            Dictionary<string, int> actual = exercises.RobPeterToPayPaul(new Dictionary<string, int>()
            {
                {"Peter", 2000 },
                {"Paul", 99 }
            });

            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
                {"Peter", 2000 },
                {"Paul", 30000 }
            };
            actual = exercises.RobPeterToPayPaul(new Dictionary<string, int>()
            {
                {"Peter", 2000 },
                {"Paul", 30000 }
            });

            AssertCollections(expected, actual);
        }



        [TestMethod]
        public void peterPaulPartnership()
        {
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Peter", 37500 },
                {"Paul", 75000 },
                {"PeterPaulPartnership", 37500 }
            };
            Dictionary<string, int> actual = exercises.PeterPaulPartnership(new Dictionary<string, int>()
            {
                {"Peter", 50000 },
                {"Paul", 100000 }
            });

            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
                {"Peter", 3333 },
                {"Paul", 1234567890 }
            };

            actual = exercises.PeterPaulPartnership(new Dictionary<string, int>()
            {
                {"Peter", 3333 },
                {"Paul", 1234567890 }
            });

            AssertCollections(expected, actual);
        }

        [TestMethod]
        public void beginningAndEnding()
        {
            Dictionary<string, string> expected = new Dictionary<string, string>()
            {
                { "b", "g" },
                { "c", "e" }
            };
            Dictionary<string, string> actual = exercises.BeginningAndEnding(new string[] { "code", "bug" });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, string>()
            {
                { "m", "n" },
            };
            actual = exercises.BeginningAndEnding(new string[] { "man", "moon", "main" });
            AssertCollections(expected, actual);


            expected = new Dictionary<string, string>()
            {
                { "g","d" },
                { "m", "t" },
                { "n", "t" }
            };
            actual = exercises.BeginningAndEnding(new string[] { "muddy", "good", "moat", "good", "night" });
            AssertCollections(expected, actual);
        }

        [TestMethod]
        public void wordCount()
        {
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"ba", 2 },
                {"black", 1 },
                {"sheep", 1 }
            };
            Dictionary<string, int> actual = exercises.WordCount(new string[] { "ba", "ba", "black", "sheep" });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
                {"b", 2 },
                {"c", 1 },
                {"a", 2 }
            };
            actual = exercises.WordCount(new string[] { "a", "b", "a", "c", "b" });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
            };
            actual = exercises.WordCount(new string[] { });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
                {"b", 1 },
                {"c", 1 },
                {"a", 1 }
            };
            actual = exercises.WordCount(new string[] { "c", "b", "a" });
            AssertCollections(expected, actual);
        }



        [TestMethod]
        public void intCount()
        {
            Dictionary<int, int> expected = new Dictionary<int, int>()
            {
                {1, 2 },
                {44, 1 },
                {55, 1 },
                {63, 3 },
                {77, 1 },
                {99, 2 }
            };
            Dictionary<int, int> actual = exercises.IntCount(new int[] { 1, 99, 63, 1, 55, 77, 63, 99, 63, 44 });
            AssertCollections(expected, actual);

            expected = new Dictionary<int, int>()
            {
                {33, 4 },
                {106, 1 },
                {107, 3 }
            };
            actual = exercises.IntCount(new int[] { 107, 33, 107, 33, 33, 33, 106, 107 });
            AssertCollections(expected, actual);

            expected = new Dictionary<int, int>()
            {
            };
            actual = exercises.IntCount(new int[] { });
            AssertCollections(expected, actual);
        }

        [TestMethod]
        public void wordMultiple()
        {
            Dictionary<string, bool> expected = new Dictionary<string, bool>()
            {
                {"b", true },
                {"c", false },
                {"a", true }
            };
            Dictionary<string, bool> actual = exercises.WordMultiple(new string[] { "a", "b", "a", "c", "b" });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, bool>()
            {
                { "b", false },
                { "c", false },
                { "a", false }
            };
            actual = exercises.WordMultiple(new string[] { "c", "b", "a" });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, bool>()
            {
                { "c", true }
            };
            actual = exercises.WordMultiple(new string[] { "c", "c", "c", "c" });
            AssertCollections(expected, actual);

        }

        [TestMethod]
        public void consolidateInventory()
        {
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"SKU1", 100 },
                {"SKU2", 64 },
                {"SKU3", 44 },
                {"SKU4", 5 }
            };
            Dictionary<string, int> actual = exercises.ConsolidateInventory(new Dictionary<string, int>()
            {
                {"SKU1", 100 },
                {"SKU2", 53 },
                {"SKU3", 44 }
            }, new Dictionary<string, int>()
            {
                {"SKU2", 11 },
                {"SKU4", 5 }
            });
            AssertCollections(expected, actual);
        }

        [TestMethod]
        public void last2Revisited()
        {
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"hixxhi", 1 },
                {"xaxxaxaxx", 1 },
                {"axxxaaxx", 2 }
            };
            Dictionary<string, int> actual = exercises.Last2Revisted(new string[] { "hixxhi", "xaxxaxaxx", "axxxaaxx" });
            AssertCollections(expected, actual);
        }



        // No Such dictionary collection assert exists so we needed to write our own
        private void AssertCollections(Dictionary<string, int> expected, Dictionary<string, int> actual)
        {
            foreach (KeyValuePair<string, int> kvp in expected)
            {
                if (!actual.ContainsKey(kvp.Key))
                {
                    Assert.Fail();
                }
                Assert.AreEqual(kvp.Value, actual[kvp.Key]);
            }
        }

        private void AssertCollections(Dictionary<string, string> expected, Dictionary<string, string> actual)
        {
            foreach (KeyValuePair<string, string> kvp in expected)
            {
                if (!actual.ContainsKey(kvp.Key))
                {
                    Assert.Fail();
                }
                Assert.AreEqual(kvp.Value, actual[kvp.Key]);
            }
        }

        private void AssertCollections(Dictionary<string, bool> expected, Dictionary<string, bool> actual)
        {
            foreach (KeyValuePair<string, bool> kvp in expected)
            {
                if (!actual.ContainsKey(kvp.Key))
                {
                    Assert.Fail();
                }
                Assert.AreEqual(kvp.Value, actual[kvp.Key]);
            }
        }

        private void AssertCollections(Dictionary<int, int> expected, Dictionary<int, int> actual)
        {
            foreach (KeyValuePair<int, int> kvp in expected)
            {
                if (!actual.ContainsKey(kvp.Key))
                {
                    Assert.Fail();
                }
                Assert.AreEqual(kvp.Value, actual[kvp.Key]);
            }
        }

    }
}
