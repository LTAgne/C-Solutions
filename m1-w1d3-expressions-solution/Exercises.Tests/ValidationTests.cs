using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class ValidationTests
    {
        private Exercises exercises = new Exercises();

        /*
	     sleepIn(false, false) → true
	     sleepIn(true, false) → false
	     sleepIn(false, true) → true
	    */
        [TestMethod]
        public void SleepIn()
        {
            Assert.AreEqual(true, exercises.SleepIn(false, false), "Input: SleepIn (false, false)");
            Assert.AreEqual(false, exercises.SleepIn(true, false), "Input: SleepIn (true, false)");
            Assert.AreEqual(true, exercises.SleepIn(false, true), "Input: SleepIn (false, true)");
        }

        /*
         monkeyTrouble(true, true) → true
         monkeyTrouble(false, false) → true
         monkeyTrouble(true, false) → false
         */
        [TestMethod]
        public void MonkeyTrouble()
        {
            Assert.AreEqual(true, exercises.MonkeyTrouble(true, true), "Input: MonkeyTrouble (true, true)");
            Assert.AreEqual(true, exercises.MonkeyTrouble(false, false), "Input: MonkeyTrouble (false, false)");
            Assert.AreEqual(false, exercises.MonkeyTrouble(true, false), "Input: MonkeyTrouble (true, false)");
        }

        /*
         sumDouble(1, 2) → 3
         sumDouble(3, 2) → 5
         sumDouble(2, 2) → 8
         */
        [TestMethod]
        public void SumDouble()
        {
            Assert.AreEqual(3, exercises.SumDouble(1, 2), "Input: SumDouble (1, 2)");
            Assert.AreEqual(5, exercises.SumDouble(3, 2), "Input: SumDouble (3, 2)");
            Assert.AreEqual(8, exercises.SumDouble(2, 2), "Input: SumDouble (2, 2)");
        }

        /*
         diff21(19) → 2
         diff21(10) → 11
         diff21(21) → 0
         */
        [TestMethod]
        public void Diff21()
        {
            Assert.AreEqual(2, exercises.Diff21(19), "Input: Diff21 (19)");
            Assert.AreEqual(11, exercises.Diff21(10), "Input: Diff21 (10)");
            Assert.AreEqual(0, exercises.Diff21(21), "Input: Diff21 (21)");
        }

        /*
         parrotTrouble(true, 6) → true
         parrotTrouble(true, 7) → false
         parrotTrouble(false, 6) → false
         */
        [TestMethod]
        public void ParrotTrouble()
        {
            Assert.AreEqual(true, exercises.ParrotTrouble(true, 6), "Input: ParrotTrouble (true, 6)");
            Assert.AreEqual(false, exercises.ParrotTrouble(true, 7), "Input: ParrotTrouble (true, 7)");
            Assert.AreEqual(false, exercises.ParrotTrouble(false, 6), "Input: ParrotTrouble (false, 6)");
        }

        /*
         makes10(9, 10) → true
         makes10(9, 9) → false
         makes10(1, 9) → true
         */
        [TestMethod]
        public void Makes10()
        {
            Assert.AreEqual(true, exercises.Makes10(9, 10), "Input: Makes10 (9, 10)");
            Assert.AreEqual(false, exercises.Makes10(9, 9), "Input: Makes10 (9, 9)");
            Assert.AreEqual(true, exercises.Makes10(1, 9), "Input: Makes10 (1, 9)");
        }

        /*
         posNeg(1, -1, false) → true
         posNeg(-1, 1, false) → true
         posNeg(-4, -5, true) → true
         */
        [TestMethod]
        public void PosNeg()
        {
            Assert.AreEqual(true, exercises.PosNeg(1, -1, false), "Input: PosNeg (1, -1, false)");
            Assert.AreEqual(true, exercises.PosNeg(-1, 1, false), "Input: PosNeg (-1, 1, false)");
            Assert.AreEqual(true, exercises.PosNeg(-4, -5, true), "Input: PosNeg (-4, -5, true)");
        }

        /*
         or35(3) → true
         or35(10) → true
         or35(8) → false
         */
        [TestMethod]
        public void Or35()
        {
            Assert.AreEqual(true, exercises.Or35(3), "Input: Or35 (3)");
            Assert.AreEqual(true, exercises.Or35(10), "Input: Or35 (10)");
            Assert.AreEqual(false, exercises.Or35(8), "Input: Or35 (8)");
        }

        /*
         icyHot(120, -1) → true
         icyHot(-1, 120) → true
         icyHot(2, 120) → false
         */
        [TestMethod]
        public void IcyHot()
        {
            Assert.AreEqual(true, exercises.IcyHot(120, -1), "Input: IcyHot (120, -1)");
            Assert.AreEqual(true, exercises.IcyHot(-1, 120), "Input: IcyHot (-1, 120)");
            Assert.AreEqual(false, exercises.IcyHot(2, 120), "Input: IcyHot (2, 120)");
        }

        /*
         in1020(12, 99) → true
         in1020(21, 12) → true
         in1020(8, 99) → false
         */
        [TestMethod]
        public void In1020()
        {
            Assert.AreEqual(true, exercises.In1020(12, 99), "Input: In1020 (12, 99)");
            Assert.AreEqual(true, exercises.In1020(21, 12), "Input: In1020 (21, 12)");
            Assert.AreEqual(false, exercises.In1020(8, 99), "Input: In1020 (8, 99)");
        }

        /*
         hasTeen(13, 20, 10) → true
         hasTeen(20, 19, 10) → true
         hasTeen(20, 10, 13) → true
         */
        [TestMethod]
        public void HasTeen()
        {
            Assert.AreEqual(true, exercises.HasTeen(13, 20, 10), "Input: HasTeen (13, 20, 10)");
            Assert.AreEqual(true, exercises.HasTeen(20, 19, 10), "Input: HasTeen (20, 19, 10)");
            Assert.AreEqual(true, exercises.HasTeen(20, 10, 13), "Input: HasTeen (20, 10, 13)");
        }

        /*
         loneTeen(13, 99) → true
         loneTeen(21, 19) → true
         loneTeen(13, 13) → false
         */
        [TestMethod]
        public void LoneTeen()
        {
            Assert.AreEqual(true, exercises.LoneTeen(13, 99), "Input: LoneTeen (13, 99)");
            Assert.AreEqual(true, exercises.LoneTeen(21, 19), "Input: LoneTeen (21, 19)");
            Assert.AreEqual(false, exercises.LoneTeen(13, 13), "Input: LoneTeen (13, 13)");
        }

        /*
         intMax(1, 2, 3) → 3
         intMax(1, 3, 2) → 3
         intMax(3, 2, 1) → 3
         */
        [TestMethod]
        public void IntMax()
        {
            Assert.AreEqual(3, exercises.IntMax(1, 2, 3), "Input: IntMax (1, 2, 3)");
            Assert.AreEqual(3, exercises.IntMax(1, 3, 2), "Input: IntMax (1, 3, 2)");
            Assert.AreEqual(3, exercises.IntMax(3, 2, 1), "Input: IntMax (3, 2, 1)");
        }

        /*
         in3050(30, 31) → true
         in3050(30, 41) → false
         in3050(40, 50) → true
         */
        [TestMethod]
        public void In3050()
        {
            Assert.AreEqual(true, exercises.In3050(30, 31), "Input: In3050 (30, 31)");
            Assert.AreEqual(false, exercises.In3050(30, 41), "Input: In3050 (30, 41)");
            Assert.AreEqual(true, exercises.In3050(40, 50), "Input: In3050 (40, 50)");
        }

        /*
         max1020(11, 19) → 19
         max1020(19, 11) → 19
         max1020(11, 9) → 11
         */
        [TestMethod]
        public void Max1020()
        {
            Assert.AreEqual(19, exercises.Max1020(11, 19), "Input: Max1020 (11, 19)");
            Assert.AreEqual(19, exercises.Max1020(19, 11), "Input: Max1020 (19, 11)");
            Assert.AreEqual(11, exercises.Max1020(11, 9), "Input: Max1020 (11, 9)");
        }

        /*
         cigarParty(30, false) → false
         cigarParty(50, false) → true
         cigarParty(70, true) → true
         */
        [TestMethod]
        public void CigarParty()
        {
            Assert.AreEqual(false, exercises.CigarParty(30, false), "Input: CigarParty (30, false)");
            Assert.AreEqual(true, exercises.CigarParty(50, false), "Input: CigarParty (50, false)");
            Assert.AreEqual(true, exercises.CigarParty(70, true), "Input: CigarParty (70, true)");
        }

        /*
         dateFashion(5, 10) → 2
         dateFashion(5, 2) → 0
         dateFashion(5, 5) → 1
         */
        [TestMethod]
        public void DateFashion()
        {
            Assert.AreEqual(2, exercises.DateFashion(5, 10), "Input: DateFashion (5, 10)");
            Assert.AreEqual(0, exercises.DateFashion(5, 2), "Input: DateFashion (5, 2)");
            Assert.AreEqual(1, exercises.DateFashion(5, 5), "Input: DateFashion (5, 5)");
        }

        /*
         squirrelPlay(70, false) → true
         squirrelPlay(95, false) → false
         squirrelPlay(95, true) → true
         */
        [TestMethod]
        public void SquirrelPlay()
        {
            Assert.AreEqual(true, exercises.SquirrelPlay(70, false), "Input: SquirrelPlay (70, false)");
            Assert.AreEqual(false, exercises.SquirrelPlay(95, false), "Input: SquirrelPlay (95, false)");
            Assert.AreEqual(true, exercises.SquirrelPlay(95, true), "Input: SquirrelPlay (95, true)");
        }

        /*
         caughtSpeeding(60, false) → 0
         caughtSpeeding(65, false) → 1
         caughtSpeeding(65, true) → 0
         */
        [TestMethod]
        public void CaughtSpeeding()
        {
            Assert.AreEqual(0, exercises.CaughtSpeeding(60, false), "Input: CaughtSpeeding (60, false)");
            Assert.AreEqual(1, exercises.CaughtSpeeding(65, false), "Input: CaughtSpeeding (65, false)");
            Assert.AreEqual(0, exercises.CaughtSpeeding(65, true), "Input: CaughtSpeeding (65, true)");

        }

        /*
         sortaSum(3, 4) → 7
         sortaSum(9, 4) → 20
         sortaSum(10, 11) → 21
         */
        [TestMethod]
        public void SortaSum()
        {
            Assert.AreEqual(7, exercises.SortaSum(3, 4), "Input: SortaSum (3, 4)");
            Assert.AreEqual(20, exercises.SortaSum(9, 4), "Input: SortaSum (9, 4)");
            Assert.AreEqual(21, exercises.SortaSum(10, 11), "Input: SortaSum (10, 11)");
        }

        /*
         alarmClock(1, false) → "7:00"
         alarmClock(5, false) → "7:00"
         alarmClock(0, false) → "10:00"
         */
        [TestMethod]
        public void AlarmClock()
        {
            Assert.AreEqual("7:00", exercises.AlarmClock(1, false), "Input: AlarmClock (1, false)");
            Assert.AreEqual("7:00", exercises.AlarmClock(5, false), "Input: AlarmClock (5, false)");
            Assert.AreEqual("10:00", exercises.AlarmClock(0, false), "Input: AlarmClock (0, false)");
        }

        /*
         in1To10(5, false) → true
         in1To10(11, false) → false
         in1To10(11, true) → true
         */
        [TestMethod]
        public void In1To10()
        {
            Assert.AreEqual(true, exercises.In1To10(5, false), "Input: In1To10 (5, false)");
            Assert.AreEqual(false, exercises.In1To10(11, false), "Input: In1To10 (11, false)");
            Assert.AreEqual(true, exercises.In1To10(11, true), "Input: In1To10 (11, true)");
        }

        /*
         specialEleven(22) → true
         specialEleven(23) → true
         specialEleven(24) → false
         */
        [TestMethod]
        public void SpecialEleven()
        {
            Assert.AreEqual(true, exercises.SpecialEleven(22), "Input: SpecialEleven (22)");
            Assert.AreEqual(true, exercises.SpecialEleven(23), "Input: SpecialEleven (23)");
            Assert.AreEqual(false, exercises.SpecialEleven(24), "Input: SpecialEleven (24)");
        }

        /*
         more20(20) → false
         more20(21) → true
         more20(22) → true
         */
        [TestMethod]
        public void More20()
        {
            Assert.AreEqual(false, exercises.More20(20), "Input: More20 (20)");
            Assert.AreEqual(true, exercises.More20(21), "Input: More20 (21)");
            Assert.AreEqual(true, exercises.More20(22), "Input: More20 (22)");
        }

        /*
         old35(3) → true
         old35(10) → true
         old35(15) → false
         */
        [TestMethod]
        public void Old35()
        {
            Assert.AreEqual(true, exercises.Old35(3), "Input: More20 (3)");
            Assert.AreEqual(true, exercises.Old35(10), "Input: More20 (10)");
            Assert.AreEqual(false, exercises.Old35(15), "Input: More20 (15)");
        }

        /*
         less20(18) → true
         less20(19) → true
         less20(20) → false
         */
        [TestMethod]
        public void Less20()
        {
            Assert.AreEqual(true, exercises.Less20(18), "Input: Less20 (18)");
            Assert.AreEqual(true, exercises.Less20(19), "Input: Less20 (19)");
            Assert.AreEqual(false, exercises.Less20(20), "Input: Less20 (20)");
        }

        /*
         nearTen(12) → true
         nearTen(17) → false
         nearTen(19) → true
         */
        [TestMethod]
        public void NearTen()
        {
            Assert.AreEqual(true, exercises.NearTen(12), "Input: NearTen (12)");
            Assert.AreEqual(false, exercises.NearTen(17), "Input: NearTen (17)");
            Assert.AreEqual(true, exercises.NearTen(19), "Input: NearTen (19)");
        }

        /*
         teenSum(3, 4) → 7
         teenSum(10, 13) → 19
         teenSum(13, 2) → 19
         */
        [TestMethod]
        public void TeenSum()
        {
            Assert.AreEqual(7, exercises.TeenSum(3, 4), "Input: TeenSum (12)");
            Assert.AreEqual(19, exercises.TeenSum(10, 13), "Input: TeenSum (12)");
            Assert.AreEqual(19, exercises.TeenSum(13, 2), "Input: TeenSum (12)");
        }

        /*
         answerCell(false, false, false) → true
         answerCell(false, false, true) → false
         answerCell(true, false, false) → false
         */
        [TestMethod]
        public void AnswerCell()
        {
            Assert.AreEqual(true, exercises.AnswerCell(false, false, false), "Input: AnswerCell (false, false, false)");
            Assert.AreEqual(false, exercises.AnswerCell(false, false, true), "Input: AnswerCell (false, false, true)");
            Assert.AreEqual(false, exercises.AnswerCell(true, false, false), "Input: AnswerCell (true, false, false)");
        }

        /*
         teaParty(6, 8) → 1
         teaParty(3, 8) → 0
         teaParty(20, 6) → 2
         */
        [TestMethod]
        public void TeaParty()
        {
            Assert.AreEqual(1, exercises.TeaParty(6, 8), "Input: TeaParty (6, 8)");
            Assert.AreEqual(0, exercises.TeaParty(3, 8), "Input: TeaParty (3, 8)");
            Assert.AreEqual(2, exercises.TeaParty(20, 6), "Input: TeaParty (20, 6)");

        }

        /*
         twoAsOne(1, 2, 3) → true
         twoAsOne(3, 1, 2) → true
         twoAsOne(3, 2, 2) → false
         */
        [TestMethod]
        public void TwoAsOne()
        {
            Assert.AreEqual(true, exercises.TwoAsOne(1, 2, 3), "Input: TwoAsOne (1, 2, 3)");
            Assert.AreEqual(true, exercises.TwoAsOne(3, 1, 2), "Input: TwoAsOne (3, 1, 2)");
            Assert.AreEqual(false, exercises.TwoAsOne(3, 2, 2), "Input: TwoAsOne (3, 2, 2)");
        }

        /*
         inOrder(1, 2, 4, false) → true
         inOrder(1, 2, 1, false) → false
         inOrder(1, 1, 2, true) → true
         */
        [TestMethod]
        public void InOrder()
        {
            Assert.AreEqual(true, exercises.InOrder(1, 2, 4, false), "Input: InOrder (1, 2, 4, false)");
            Assert.AreEqual(false, exercises.InOrder(1, 2, 1, false), "Input: InOrder (1, 2, 1, false)");
            Assert.AreEqual(true, exercises.InOrder(1, 1, 2, true), "Input: InOrder (1, 1, 2, true)");
        }

        /*
         inOrderEqual(2, 5, 11, false) → true
         inOrderEqual(5, 7, 6, false) → false
         inOrderEqual(5, 5, 7, true) → true
         */
        [TestMethod]
        public void InOrderEqual()
        {
            Assert.AreEqual(true, exercises.InOrderEqual(2, 5, 11, false), "Input: InOrderEqual (2, 5, 11, false)");
            Assert.AreEqual(false, exercises.InOrderEqual(5, 7, 6, false), "Input: InOrderEqual (5, 7, 6, false)");
            Assert.AreEqual(true, exercises.InOrderEqual(5, 5, 7, true), "Input: InOrderEqual (5, 5, 7, true)");
        }


        /*
         loneSum(1, 2, 3) → 6
         loneSum(3, 2, 3) → 2
         loneSum(3, 3, 3) → 0
         */
        [TestMethod]
        public void LoneSum()
        {
            Assert.AreEqual(6, exercises.LoneSum(1, 2, 3), "Input: LoneSum (1, 2, 3)");
            Assert.AreEqual(2, exercises.LoneSum(3, 2, 3), "Input: LoneSum (3, 2, 3)");
            Assert.AreEqual(0, exercises.LoneSum(3, 3, 3), "Input: LoneSum (3, 3, 3)");
        }

        /*
         luckySum(1, 2, 3) → 6
         luckySum(1, 2, 13) → 3
         luckySum(1, 13, 3) → 1
         luckySum(13, 1, 3) → 3
         luckySum(13, 13, 3) → 0
         */
        [TestMethod]
        public void LuckySum()
        {
            Assert.AreEqual(6, exercises.LuckySum(1, 2, 3), "Input: LuckySum (1, 2, 3)");
            Assert.AreEqual(3, exercises.LuckySum(1, 2, 13), "Input: LuckySum (1, 2, 13)");
            Assert.AreEqual(1, exercises.LuckySum(1, 13, 3), "Input: LuckySum (1, 13, 3)");
            Assert.AreEqual(3, exercises.LuckySum(13, 1, 3), "Input: LuckySum (13, 1, 3)");
            Assert.AreEqual(0, exercises.LuckySum(13, 13, 3), "Input: LuckySum (13, 13, 3)");
            Assert.AreEqual(0, exercises.LuckySum(13, 13, 13), "Input: LuckySum (13, 13, 13)");
        }

    }
}
