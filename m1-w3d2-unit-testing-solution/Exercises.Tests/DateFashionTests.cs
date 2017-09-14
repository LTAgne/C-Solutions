using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        /*
        You and your date are trying to get a table at a restaurant. The parameter "you" is the stylishness
        of your clothes, in the range 0..10, and "date" is the stylishness of your date's clothes. The result
        getting the table is encoded as an int value with 0=no, 1=maybe, 2=yes. If either of you is very 
        stylish, 8 or more, then the result is 2 (yes). With the exception that if either of you has style of 
        2 or less, then the result is 0 (no). Otherwise the result is 1 (maybe).
        dateFashion(5, 10) → 2
        dateFashion(5, 2) → 0
        dateFashion(5, 5) → 1
        */

        [TestMethod]
        public void AtLeastOneDateNotStylish_DontGetTable()
        {
            //Arrange
            DateFashion exercises = new DateFashion();

            //Assert
            Assert.AreEqual(0, exercises.GetATable(2, 2));
            Assert.AreEqual(0, exercises.GetATable(0, 0));
            Assert.AreEqual(0, exercises.GetATable(2, 7));
            Assert.AreEqual(0, exercises.GetATable(2, 9));
        }

        [TestMethod]
        public void BothDatesStylish_MaybeGetTable()
        {
            //Arrange
            DateFashion exercises = new DateFashion();

            //Assert
            Assert.AreEqual(1, exercises.GetATable(3, 3));
            Assert.AreEqual(1, exercises.GetATable(7, 7));
            Assert.AreEqual(1, exercises.GetATable(3, 7));            
        }

        [TestMethod]
        public void EitherDateVeryStylish_AlwaysGetTable()
        {
            //Arrange
            DateFashion exercises = new DateFashion();

            //Assert
            Assert.AreEqual(2, exercises.GetATable(8, 3));
            Assert.AreEqual(2, exercises.GetATable(3, 8));            
        }


    }
}
