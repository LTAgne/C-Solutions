using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises
{
    [TestClass]
    public class ExerciseTests
    {


        Exercises exercises = new Exercises();

        /*
         array2List( {"Apple", "Orange", "Banana"} )  ->  ["Apple", "Orange", "Banana"]
         array2List( {"Red", "Orange", "Yellow"} )  ->  ["Red", "Orange", "Yellow"]
         array2List( {"Left", "Right", "Forward", "Back"} )  ->  ["Left", "Right", "Forward", "Back"] 
         */
        [TestMethod]
        public void array2List()
        {
            CollectionAssert.AreEqual(new List<string>() { "Apple", "Orange", "Banana" }, exercises.Array2List(new string[] { "Apple", "Orange", "Banana" }));
            CollectionAssert.AreEqual(new List<string>() { "Red", "Orange", "Yellow" }, exercises.Array2List(new string[] { "Red", "Orange", "Yellow" }));
            CollectionAssert.AreEqual(new List<string>() { "Left", "Right", "Forward", "Back" }, exercises.Array2List(new string[] { "Left", "Right", "Forward", "Back" }));
        }

        /*
         Given a list of Strings, return an array containing the same Strings in the same order 
         list2Array( ["Apple", "Orange", "Banana"] )  ->  {"Apple", "Orange", "Banana"}
         list2Array( ["Red", "Orange", "Yellow"] )  ->  {"Red", "Orange", "Yellow"}
         list2Array( ["Left", "Right", "Forward", "Back"] )  ->  {"Left", "Right", "Forward", "Back"}
         */
        [TestMethod]
        public void list2Array()
        {
            CollectionAssert.AreEqual(new string[] { "Apple", "Orange", "Banana" }, exercises.List2Array(new List<string> { "Apple", "Orange", "Banana" }));
            CollectionAssert.AreEqual(new string[] { "Red", "Orange", "Yellow" }, exercises.List2Array(new List<string> { "Red", "Orange", "Yellow" }));
            CollectionAssert.AreEqual(new string[] { "Left", "Right", "Forward", "Back" }, exercises.List2Array(new List<string> { "Left", "Right", "Forward", "Back" }));
        }

        /*
         Given an array of Strings, return a List containing the same Strings in the same order 
         except for any words that contain exactly 4 characters.
         no4LetterWords( {"Train", "Boat", "Car"} )  ->  ["Train", "Car"]
         no4LetterWords( {"Red", "White", "Blue"} )  ->  ["Red", "White"]
         no4LetterWords( {"Jack", "Jill", "Jane", "John", "Jim"} )  ->  ["Jim"]
         */
        [TestMethod]
        public void no4LetterWords()
        {
            CollectionAssert.AreEqual(new List<string>() { "Train", "Car"  }, exercises.No4LetterWords(new string[] { "Train", "Boat", "Car" }));
            CollectionAssert.AreEqual(new List<string>() { "Red", "White" }, exercises.No4LetterWords(new string[] { "Red", "White", "Blue" }));
            CollectionAssert.AreEqual(new List<string>() { "Jim" }, exercises.No4LetterWords(new string[] { "Jack", "Jill", "Jane", "John", "Jim" }));
        }

        [TestMethod]
        /*
        Given a List of string, return a new list in reverse order of the original. One obvious solution is to
        simply loop through the original list in reverse order, but see if you can come up with an alternative
        solution. (Hint: Think LIFO (i.e. stack))
        reverseList( ["purple", "green", "blue", "yellow", "green" ])  -> ["green", "yellow", "blue", "green", "purple" ]
        reverseList( ["jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way"} )
           -> ["way", "the", "all", "jingle", "bells", "jingle", "bells", "jingle"]
        */
        public void reverseList()
        {
            CollectionAssert.AreEqual(new List<string>() { "green", "yellow", "blue", "green", "purple" }, exercises.ReverseList(new List<string>() { "purple", "green", "blue", "yellow", "green" }));
            CollectionAssert.AreEqual(new List<string>() { "way", "the", "all", "jingle", "bells", "jingle", "bells", "jingle" }, exercises.ReverseList(new List<string>() { "jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way" }));
        }

        /*
         Given an array of ints, divide each int by 2, and return an List of Doubles.
         arrayInt2ListDouble( {5, 8, 11, 200, 97} ) -> [2.5, 4.0, 5.5, 100, 48.5]
         arrayInt2ListDouble( {745, 23, 44, 9017, 6} ) -> [372.5, 11.5, 22, 4508.5, 3]
         arrayInt2ListDouble( {84, 99, 3285, 13, 877} ) -> [42, 49.5, 1642.5, 6.5, 438.5]
         */
        [TestMethod]
        public void arrayInt2ListDouble()
        {
            CollectionAssert.AreEqual(new List<double>() { 2.5, 4.0, 5.5, 100, 48.5 }, exercises.ArrayInt2ListDouble(new int[] { 5, 8, 11, 200, 97 }));
            CollectionAssert.AreEqual(new List<double>() { 372.5, 11.5, 22, 4508.5, 3 }, exercises.ArrayInt2ListDouble(new int[] { 745, 23, 44, 9017, 6 }));
            CollectionAssert.AreEqual(new List<double>() { 42, 49.5, 1642.5, 6.5, 438.5 }, exercises.ArrayInt2ListDouble(new int[] { 84, 99, 3285, 13, 877 }));
        }

        /*
         Given a List of Integers, return the largest value.
         findLargest( [11, 200, 43, 84, 9917, 4321, 1, 33333, 8997] ) -> 33333
         findLargest( [987, 1234, 9381, 731, 43718, 8932] ) -> 43718
         findLargest( [34070, 1380, 81238, 7782, 234, 64362, 627] ) -> 81238
         */
        [TestMethod]
        public void findLargest()
        {
            Assert.AreEqual(33333, exercises.FindLargest(new List<int>() { 11, 200, 43, 84, 9917, 4321, 1, 33333, 8997 }));
            Assert.AreEqual(43718, exercises.FindLargest(new List<int>() { 987, 1234, 9381, 731, 43718, 8932 }));
            Assert.AreEqual(81238, exercises.FindLargest(new List<int>() { 34070, 1380, 81238, 7782, 234, 64362, 627 }));
        }

        /*
         Given an array of Integers, return a List of Integers containing just the odd values.
         oddOnly( {112, 201, 774, 92, 9, 83, 41872} ) -> [201, 9, 83]
         oddOnly( {1143, 555, 7, 1772, 9953, 643} ) -> [1143, 555, 7, 9953, 643]
         oddOnly( {734, 233, 782, 811, 3, 9999} ) -> [233, 811, 3, 9999]  
         */
        [TestMethod]
        public void oddOnly()
        {
            CollectionAssert.AreEqual(new List<int>() { 201, 9, 83 }, exercises.OddOnly(new int[] { 112, 201, 774, 92, 9, 83, 41872 }));
            CollectionAssert.AreEqual(new List<int>() { 1143, 555, 7, 9953, 643 }, exercises.OddOnly(new int[] { 1143, 555, 7, 1772, 9953, 643 }));
            CollectionAssert.AreEqual(new List<int>() { 233, 811, 3, 9999 }, exercises.OddOnly(new int[] { 734, 233, 782, 811, 3, 9999 }));
        }

        /* 
         Given a List of Integers, and an int value, return true if the int value appears two or more times in 
         the list.
         foundIntTwice( [5, 7, 9, 5, 11], 5 ) -> true
         foundIntTwice( [6, 8, 10, 11, 13], 8 -> false
         foundIntTwice( [9, 23, 44, 2, 88, 44], 44) -> true
         */
        [TestMethod]
        public void foundIntTwice()
        {
            Assert.AreEqual(true, exercises.FoundIntTwice(new List<int>() { 5, 7, 9, 5, 11 }, 5));
            Assert.AreEqual(false, exercises.FoundIntTwice(new List<int>() { 6, 8, 10, 11, 13 }, 8));
            Assert.AreEqual(true, exercises.FoundIntTwice(new List<int>() { 9, 23, 44, 2, 88, 44 }, 44));
        }

        /*
         Given an array of Integers, return a List that contains strings.  except any multiple of 3
         should be replaced by the String "Fizz", any multiple of 5 should be replaced by the String "Buzz",
         and any multiple of both 3 and 5 should be replaced by the String "FizzBuzz"
         fizzBuzzList( {1, 2, 3} )  ->  ["1", "2", "Fizz"]
         fizzBuzzList( {4, 5, 6} )  ->  ["4", "Buzz", "Fizz"]
         fizzBuzzList( {7, 8, 9, 10, 11, 12, 13, 14, 15} )  ->  ["7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]
         */
        [TestMethod]
        public void fizzBuzzList()
        {
            CollectionAssert.AreEqual(new List<string>() { "1", "2", "Fizz" }, exercises.FizzBuzzList(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new List<string>() { "4", "Buzz", "Fizz" }, exercises.FizzBuzzList(new int[] { 4, 5, 6 }));
            CollectionAssert.AreEqual(new List<string>() { "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, exercises.FizzBuzzList(new int[] { 7, 8, 9, 10, 11, 12, 13, 14, 15 }));
        }

        /*
         distinctValues( ["red", "yellow", "green", "yellow", "blue", "green", "purple"] ) -> ["red", "yellow", "green", "blue", "purple"]
         distinctValues( ["jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way"] ) -> ["jingle", "bells", "all", "the", "way"]
         */
        [TestMethod]
        public void distinctValues()
        {
            CollectionAssert.AllItemsAreUnique(exercises.DistinctValues(new List<string>() { "red", "yellow", "green", "yellow", "blue", "green", "purple" }));
            CollectionAssert.AllItemsAreUnique(exercises.DistinctValues(new List<string>() { "jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way" }));
        }

        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        interleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        interleaveLists( [7, 1, 3], [2, 5, 7, 9] )  ->  [7, 2, 1, 5, 3, 7, 9]
        interleaveLists( [1, 2, 5, 8], [4, 5, 6] )  ->  [1, 4, 2, 5, 5, 6, 8]

        */
        [TestMethod]
        public void interleaveLists()
        {
            CollectionAssert.AreEqual(new List<int>() { 1, 4, 2, 5, 3, 6 }, exercises.InterleaveLists(new List<int>() { 1, 2, 3 }, new List<int>() { 4, 5, 6 }));
            CollectionAssert.AreEqual(new List<int>() { 7, 2, 1, 5, 3, 7, 9 }, exercises.InterleaveLists(new List<int>() { 7, 1, 3 }, new List<int>() { 2, 5, 7, 9 }));
            CollectionAssert.AreEqual(new List<int>() { 1, 4, 2, 5, 5, 6, 8 }, exercises.InterleaveLists(new List<int>() { 1, 2, 5, 8 }, new List<int>() { 4, 5, 6 }));
        }

        /*
         Given a list of Integers representing seat numbers, group them into ranges 1-10, 11-20, and 21-30.
         (Any seat number less than 1, or greater than 30 is invalid, and can be ignored.) Preserve the order
         in which the seat number entered their associated group. Return a list of the grouped Integers 1-10,
         11-20, and 21-30. (Hint: Think multiple queues)
         boardingGate( [1, 13, 43, 22, 8, 11, 30, 2, 4, 14, 21] ) -> [1, 8, 2, 4, 13, 11, 14, 22, 30, 21]
         boardingGate( [29, 19, 9, 21, 11, 1, 0, 25, 15, 5, 31] ) -> [9, 1, 5, 19, 11, 15, 29, 21, 25]
         boardingGate( [0, -1, 44, 31, 17, 7, 27, 16, 26, 6] ) -> [7, 6, 17, 16, 27, 26]
         */
        [TestMethod]
        public void boardingGate()
        {
            CollectionAssert.AreEqual(new List<int>() { 1, 8, 2, 4, 13, 11, 14, 22, 30, 21 }, 
                exercises.BoardingGate(new List<int>() { 1, 13, 43, 22, 8, 11, 30, 2, 4, 14, 21 }));
            CollectionAssert.AreEqual(new List<int>() { 9, 1, 5, 19, 11, 15, 29, 21, 25 }, exercises.BoardingGate(new List<int>() { 29, 19, 9, 21, 11, 1, 0, 25, 15, 5, 31 }));
            CollectionAssert.AreEqual(new List<int>() { 7, 6, 17, 16, 27, 26 }, exercises.BoardingGate(new List<int>() { 0, -1, 44, 31, 17, 7, 27, 16, 26, 6 }));

        }

    }
}
