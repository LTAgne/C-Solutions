using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace ExcerciseTests
{
    [TestClass]
    public class StringTests
    {
        StringExercises exercises = new StringExercises();

        [TestMethod]
        public void helloName()
        {
            assertEquals("Input: helloName(\"Bob\")", "Hello Bob!", exercises.HelloName("Bob"));
            assertEquals("Input: helloName(\"Alice\")", "Hello Alice!", exercises.HelloName("Alice"));
            assertEquals("Input: helloName(\"X\")", "Hello X!", exercises.HelloName("X"));
            assertEquals("Input: helloName(\"Dolly\")", "Hello Dolly!", exercises.HelloName("Dolly"));
            assertEquals("Input: helloName(\"Alpha\")", "Hello Alpha!", exercises.HelloName("Alpha"));
            assertEquals("Input: helloName(\"Omega\")", "Hello Omega!", exercises.HelloName("Omega"));
            assertEquals("Input: helloName(\"Goodbye\")", "Hello Goodbye!", exercises.HelloName("Goodbye"));
            assertEquals("Input: helloName(\"ho ho ho\")", "Hello ho ho ho!", exercises.HelloName("ho ho ho"));
            assertEquals("Input: helloName(\"xyz\")", "Hello xyz!", exercises.HelloName("xyz"));
            assertEquals("Input: helloName(\"Hello\")", "Hello Hello!", exercises.HelloName("Hello"));
        }

        [TestMethod]
        public void makeAbba()
        {
            assertEquals("Input: makeAbba(\"Hi\", \"Bye\")", "HiByeByeHi", exercises.MakeAbba("Hi", "Bye"));
            assertEquals("Input: makeAbba(\"Yo\", \"Alice\")", "YoAliceAliceYo", exercises.MakeAbba("Yo", "Alice"));
            assertEquals("Input: makeAbba(\"What\", \"Up\")", "WhatUpUpWhat", exercises.MakeAbba("What", "Up"));
            assertEquals("Input: makeAbba(\"aaa\", \"bbb\")", "aaabbbbbbaaa", exercises.MakeAbba("aaa", "bbb"));
            assertEquals("Input: makeAbba(\"x\", \"y\")", "xyyx", exercises.MakeAbba("x", "y"));
            assertEquals("Input: makeAbba(\"x\", \"\")", "xx", exercises.MakeAbba("x", ""));
            assertEquals("Input: makeAbba(\"\", \"y\")", "yy", exercises.MakeAbba("", "y"));
            assertEquals("Input: makeAbba(\"Bo\", \"Ya\")", "BoYaYaBo", exercises.MakeAbba("Bo", "Ya"));
            assertEquals("Input: makeAbba(\"Ya\", \"Ya\")", "YaYaYaYa", exercises.MakeAbba("Ya", "Ya"));
        }

        [TestMethod]
        public void makeTags()
        {
            assertEquals("Input: makeTags(\"i\", \"Yay\")", "<i>Yay</i>", exercises.MakeTags("i", "Yay"));
            assertEquals("Input: makeTags(\"i\", \"Hello\")", "<i>Hello</i>", exercises.MakeTags("i", "Hello"));
            assertEquals("Input: makeTags(\"cite\", \"Yay\")", "<cite>Yay</cite>", exercises.MakeTags("cite", "Yay"));
            assertEquals("Input: makeTags(\"address\", \"here\")", "<address>here</address>", exercises.MakeTags("address", "here"));
            assertEquals("Input: makeTags(\"body\", \"Heart\")", "<body>Heart</body>", exercises.MakeTags("body", "Heart"));
            assertEquals("Input: makeTags(\"i\", \"i\")", "<i>i</i>", exercises.MakeTags("i", "i"));
            assertEquals("Input: makeTags(\"i\", \"\")", "<i></i>", exercises.MakeTags("i", ""));
        }

        [TestMethod]
        public void makeOutWord()
        {
            assertEquals("Input: makeOutWord(\"<<>>\", \"Yay\")", "<<Yay>>", exercises.MakeOutWord("<<>>", "Yay"));
            assertEquals("Input: makeOutWord(\"<<>>\", \"WooHoo\")", "<<WooHoo>>", exercises.MakeOutWord("<<>>", "WooHoo"));
            assertEquals("Input: makeOutWord(\"[[]]\", \"word\")", "[[word]]", exercises.MakeOutWord("[[]]", "word"));
            assertEquals("Input: makeOutWord(\"HHoo\", \"Hello\")", "HHHellooo", exercises.MakeOutWord("HHoo", "Hello"));
            assertEquals("Input: makeOutWord(\"abyz\", \"YAY\")", "abYAYyz", exercises.MakeOutWord("abyz", "YAY"));
        }

        [TestMethod]
        public void extraEnd()
        {
            assertEquals("Input: extraEnd(\"Hello\")", "lololo", exercises.ExtraEnd("Hello"));
            assertEquals("Input: extraEnd(\"ab\")", "ababab", exercises.ExtraEnd("ab"));
            assertEquals("Input: extraEnd(\"Hi\")", "HiHiHi", exercises.ExtraEnd("Hi"));
            assertEquals("Input: extraEnd(\"Candy\")", "dydydy", exercises.ExtraEnd("Candy"));
            assertEquals("Input: extraEnd(\"Code\")", "dedede", exercises.ExtraEnd("Code"));
        }

        [TestMethod]
        public void firstTwo()
        {
            assertEquals("Input: firstTwo(\"Hello\")", "He", exercises.FirstTwo("Hello"));
            assertEquals("Input: firstTwo(\"abcdefg\")", "ab", exercises.FirstTwo("abcdefg"));
            assertEquals("Input: firstTwo(\"ab\")", "ab", exercises.FirstTwo("ab"));
            assertEquals("Input: firstTwo(\"a\")", "a", exercises.FirstTwo("a"));
            assertEquals("Input: firstTwo(\"\")", "", exercises.FirstTwo(""));
            assertEquals("Input: firstTwo(\"Kitten\")", "Ki", exercises.FirstTwo("Kitten"));
            assertEquals("Input: firstTwo(\"hi\")", "hi", exercises.FirstTwo("hi"));
            assertEquals("Input: firstTwo(\"hiya\")", "hi", exercises.FirstTwo("hiya"));
        }

        [TestMethod]
        public void firstHalf()
        {
            assertEquals("Input: firstHalf(\"WooHoo\")", "Woo", exercises.FirstHalf("WooHoo"));
            assertEquals("Input: firstHalf(\"HelloThere\")", "Hello", exercises.FirstHalf("HelloThere"));
            assertEquals("Input: firstHalf(\"abcdef\")", "abc", exercises.FirstHalf("abcdef"));
            assertEquals("Input: firstHalf(\"ab\")", "a", exercises.FirstHalf("ab"));
            assertEquals("Input: firstHalf(\"\")", "", exercises.FirstHalf(""));
            assertEquals("Input: firstHalf(\"0123456789\")", "01234", exercises.FirstHalf("0123456789"));
            assertEquals("Input: firstHalf(\"kitten\")", "kit", exercises.FirstHalf("kitten"));
        }

        [TestMethod]
        public void withoutEnd()
        {
            assertEquals("Input: withoutEnd(\"Hello\")", "ell", exercises.WithoutEnd("Hello"));
            assertEquals("Input: withoutEnd(\"java\")", "av", exercises.WithoutEnd("java"));
            assertEquals("Input: withoutEnd(\"coding\")", "odin", exercises.WithoutEnd("coding"));
            assertEquals("Input: withoutEnd(\"code\")", "od", exercises.WithoutEnd("code"));
            assertEquals("Input: withoutEnd(\"Chocolate!\")", "hocolate", exercises.WithoutEnd("Chocolate!"));
            assertEquals("Input: withoutEnd(\"coding\")", "odin", exercises.WithoutEnd("coding"));
            assertEquals("Input: withoutEnd(\"kitten\")", "itte", exercises.WithoutEnd("kitten"));
            assertEquals("Input: withoutEnd(\"woohoo\")", "ooho", exercises.WithoutEnd("woohoo"));
        }

        [TestMethod]
        public void comboString()
        {
            assertEquals("Input: comboString(\"Hello\", \"hi\")", "hiHellohi", exercises.ComboString("Hello", "hi"));
            assertEquals("Input: comboString(\"hi\", \"Hello\")", "hiHellohi", exercises.ComboString("hi", "Hello"));
            assertEquals("Input: comboString(\"aaa\", \"b\")", "baaab", exercises.ComboString("aaa", "b"));
            assertEquals("Input: comboString(\"b\", \"aaa\")", "baaab", exercises.ComboString("b", "aaa"));
            assertEquals("Input: comboString(\"aaa\", \"\")", "aaa", exercises.ComboString("aaa", ""));
            assertEquals("Input: comboString(\"\", \"bb\")", "bb", exercises.ComboString("", "bb"));
            assertEquals("Input: comboString(\"aaa\", \"1234\")", "aaa1234aaa", exercises.ComboString("aaa", "1234"));
            assertEquals("Input: comboString(\"aaa\", \"bb\")", "bbaaabb", exercises.ComboString("aaa", "bb"));
            assertEquals("Input: comboString(\"a\", \"bb\")", "abba", exercises.ComboString("a", "bb"));
            assertEquals("Input: comboString(\"bb\", \"a\")", "abba", exercises.ComboString("bb", "a"));
            assertEquals("Input: comboString(\"xyz\", \"ab\")", "abxyzab", exercises.ComboString("xyz", "ab"));
        }

        [TestMethod]
        public void nonStart()
        {
            assertEquals("Input: nonStart(\"Hello\", \"There\")", "ellohere", exercises.NonStart("Hello", "There"));
            assertEquals("Input: nonStart(\"java\", \"code\")", "avaode", exercises.NonStart("java", "code"));
            assertEquals("Input: nonStart(\"shotl\", \"java\")", "hotlava", exercises.NonStart("shotl", "java"));
            assertEquals("Input: nonStart(\"ab\", \"xy\")", "by", exercises.NonStart("ab", "xy"));
            assertEquals("Input: nonStart(\"ab\", \"x\")", "b", exercises.NonStart("ab", "x"));
            assertEquals("Input: nonStart(\"x\", \"ac\")", "c", exercises.NonStart("x", "ac"));
            assertEquals("Input: nonStart(\"a\", \"x\")", "", exercises.NonStart("a", "x"));
            assertEquals("Input: nonStart(\"kit\", \"kat\")", "itat", exercises.NonStart("kit", "kat"));
            assertEquals("Input: nonStart(\"mart\", \"dart\")", "artart", exercises.NonStart("mart", "dart"));
        }

        [TestMethod]
        public void left2()
        {
            assertEquals("Input: left2(\"Hello\")", "lloHe", exercises.Left2("Hello"));
            assertEquals("Input: left2(\"java\")", "vaja", exercises.Left2("java"));
            assertEquals("Input: left2(\"Hi\")", "Hi", exercises.Left2("Hi"));
            assertEquals("Input: left2(\"code\")", "deco", exercises.Left2("code"));
            assertEquals("Input: left2(\"cat\")", "tca", exercises.Left2("cat"));
            assertEquals("Input: left2(\"12345\")", "34512", exercises.Left2("12345"));
            assertEquals("Input: left2(\"Chocolate\")", "ocolateCh", exercises.Left2("Chocolate"));
            assertEquals("Input: left2(\"bricks\")", "icksbr", exercises.Left2("bricks"));
        }

        [TestMethod]
        public void right2()
        {
            assertEquals("Input: right2(\"Hello\")", "loHel", exercises.Right2("Hello"));
            assertEquals("Input: right2(\"java\")", "vaja", exercises.Right2("java"));
            assertEquals("Input: right2(\"Hi\")", "Hi", exercises.Right2("Hi"));
            assertEquals("Input: right2(\"code\")", "deco", exercises.Right2("code"));
            assertEquals("Input: right2(\"cat\")", "atc", exercises.Right2("cat"));
            assertEquals("Input: right2(\"12345\")", "45123", exercises.Right2("12345"));
        }

        [TestMethod]
        public void theEnd()
        {
            assertEquals("Input: theEnd(\"Hello\", true)", "H", exercises.TheEnd("Hello", true));
            assertEquals("Input: theEnd(\"Hello\", false)", "o", exercises.TheEnd("Hello", false));
            assertEquals("Input: theEnd(\"oh\", true)", "o", exercises.TheEnd("oh", true));
            assertEquals("Input: theEnd(\"oh\", false)", "h", exercises.TheEnd("oh", false));
            assertEquals("Input: theEnd(\"x\", true)", "x", exercises.TheEnd("x", true));
            assertEquals("Input: theEnd(\"x\", false)", "x", exercises.TheEnd("x", false));
            assertEquals("Input: theEnd(\"java\", true)", "j", exercises.TheEnd("java", true));
            assertEquals("Input: theEnd(\"chocolate\", false)", "e", exercises.TheEnd("chocolate", false));
            assertEquals("Input: theEnd(\"1234\", true)", "1", exercises.TheEnd("1234", true));
            assertEquals("Input: theEnd(\"code\", false)", "e", exercises.TheEnd("code", false));
        }

        [TestMethod]
        public void withouEnd2()
        {
            assertEquals("Input:withouEnd2(\"Hello\") ", "ell", exercises.WithouEnd2("Hello"));
            assertEquals("Input: withouEnd2(\"abc\")", "b", exercises.WithouEnd2("abc"));
            assertEquals("Input: withouEnd2(\"ab\")", "", exercises.WithouEnd2("ab"));
            assertEquals("Input: withouEnd2(\"a\")", "", exercises.WithouEnd2("a"));
            assertEquals("Input: withouEnd2(\"\"))", "", exercises.WithouEnd2(""));
            assertEquals("Input: withouEnd2(\"coldy\")", "old", exercises.WithouEnd2("coldy"));
            assertEquals("Input: withouEnd2(\"java code\")", "ava cod", exercises.WithouEnd2("java code"));
        }

        [TestMethod]
        public void middleTwo()
        {
            assertEquals("Input: middleTwo(\"string\")", "ri", exercises.MiddleTwo("string"));
            assertEquals("Input: middleTwo(\"code\")", "od", exercises.MiddleTwo("code"));
            assertEquals("Input: middleTwo(\"Practice\")", "ct", exercises.MiddleTwo("Practice"));
            assertEquals("Input: middleTwo(\"ab\")", "ab", exercises.MiddleTwo("ab"));
            assertEquals("Input: middleTwo(\"0123456789\")", "45", exercises.MiddleTwo("0123456789"));
        }

        [TestMethod]
        public void endsLy()
        {
            assertEquals("Input: endsLy(\"oddly\")", true, exercises.EndsLy("oddly"));
            assertEquals("Input: endsLy(\"y\")", false, exercises.EndsLy("y"));
            assertEquals("Input: endsLy(\"oddy\")", false, exercises.EndsLy("oddy"));
            assertEquals("Input: endsLy(\"oddl\")", false, exercises.EndsLy("oddl"));
            assertEquals("Input: endsLy(\"olydd\")", false, exercises.EndsLy("olydd"));
            assertEquals("Input: endsLy(\"ly\")", true, exercises.EndsLy("ly"));
            assertEquals("Input: endsLy(\"\")", false, exercises.EndsLy(""));
            assertEquals("Input: endsLy(\"falsey\")", false, exercises.EndsLy("falsey"));
            assertEquals("Input: endsLy(\"evenly\")", true, exercises.EndsLy("evenly"));
        }

        [TestMethod]
        public void nTwice()
        {
            assertEquals("Input: nTwice(\"Hello\", 2)", "Helo", exercises.NTwice("Hello", 2));
            assertEquals("Input: nTwice(\"Chocolate\", 3)", "Choate", exercises.NTwice("Chocolate", 3));
            assertEquals("Input: nTwice(\"Chocolate\", 1)", "Ce", exercises.NTwice("Chocolate", 1));
            assertEquals("Input: Twice(\"Chocolate\", 0)", "", exercises.NTwice("Chocolate", 0));
            assertEquals("Input: nTwice(\"Hello\", 4)", "Hellello", exercises.NTwice("Hello", 4));
            assertEquals("Input: nTwice(\"Code\", 4)", "CodeCode", exercises.NTwice("Code", 4));
            assertEquals("Input: nTwice(\"Code\", 2)", "Code", exercises.NTwice("Code", 2));
        }

        [TestMethod]
        public void twoChar()
        {
            assertEquals("Input: twoChar(\"java\", 0)", "ja", exercises.TwoChar("java", 0));
            assertEquals("Input: twoChar(\"java\", 2)", "va", exercises.TwoChar("java", 2));
            assertEquals("Input: twoChar(\"java\", 3)", "ja", exercises.TwoChar("java", 3));
            assertEquals("Input: twoChar(\"java\", 4)", "ja", exercises.TwoChar("java", 4));
            assertEquals("Input: twoChar(\"java\", -1)", "ja", exercises.TwoChar("java", -1));
            assertEquals("Input: twoChar(\"Hello\", 0)", "He", exercises.TwoChar("Hello", 0));
            assertEquals("Input: twoChar(\"Hello\", 1)", "el", exercises.TwoChar("Hello", 1));
            assertEquals("Input: twoChar(\"Hello\", 99)", "He", exercises.TwoChar("Hello", 99));
            assertEquals("Input: twoChar(\"Hello\", 3)", "lo", exercises.TwoChar("Hello", 3));
            assertEquals("Input: twoChar(\"Hello\", 4)", "He", exercises.TwoChar("Hello", 4));
            assertEquals("Input: twoChar(\"Hello\", 5)", "He", exercises.TwoChar("Hello", 5));
            assertEquals("Input: twoChar(\"Hello\", -7)", "He", exercises.TwoChar("Hello", -7));
            assertEquals("Input: twoChar(\"Hello\", 6)", "He", exercises.TwoChar("Hello", 6));
            assertEquals("Input: twoChar(\"Hello\", -1)", "He", exercises.TwoChar("Hello", -1));
            assertEquals("Input: twoChar(\"yay\", 0)", "ya", exercises.TwoChar("yay", 0));
        }

        [TestMethod]
        public void middleThree()
        {
            assertEquals("Input: middleThree(\"Candy\")", "and", exercises.MiddleThree("Candy"));
            assertEquals("Input: middleThree(\"and\")", "and", exercises.MiddleThree("and"));
            assertEquals("Input: middleThree(\"solving\")", "lvi", exercises.MiddleThree("solving"));
            assertEquals("Input: middleThree(\"Hi yet Hi\")", "yet", exercises.MiddleThree("Hi yet Hi"));
            assertEquals("Input: middleThree(\"java yet java\")", "yet", exercises.MiddleThree("java yet java"));
            assertEquals("Input: middleThree(\"Chocolate\")", "col", exercises.MiddleThree("Chocolate"));
            assertEquals("Input: middleThree(\"XabcxyzabcX\")", "xyz", exercises.MiddleThree("XabcxyzabcX"));
        }

        [TestMethod]
        public void hasBad()
        {
            assertEquals("Input: hasBad(\"badxx\")", true, exercises.HasBad("badxx"));
            assertEquals("Input: hasBad(\"xbadxx\")", true, exercises.HasBad("xbadxx"));
            assertEquals("Input: hasBad(\"xxbadxx\")", false, exercises.HasBad("xxbadxx"));
            assertEquals("Input: hasBad(\"code\")", false, exercises.HasBad("code"));
            assertEquals("Input: hasBad(\"bad\")", true, exercises.HasBad("bad"));
            assertEquals("Input: hasBad(\"ba\")", false, exercises.HasBad("ba"));
            assertEquals("Input: hasBad(\"xba\")", false, exercises.HasBad("xba"));
            assertEquals("Input: hasBad(\"xbad\")", true, exercises.HasBad("xbad"));
            assertEquals("Input: hasBad(\"\")", false, exercises.HasBad(""));
            assertEquals("Input: hasBad(\"badyy\")", true, exercises.HasBad("badyy"));
        }

        [TestMethod]
        public void stringTimes()
        {
            assertEquals("Input: stringTimes(\"Hi\", 2)", "HiHi", exercises.StringTimes("Hi", 2));
            assertEquals("Input: stringTimes(\"Hi\", 3)", "HiHiHi", exercises.StringTimes("Hi", 3));
            assertEquals("Input: stringTimes(\"Hi\", 1)", "Hi", exercises.StringTimes("Hi", 1));
            assertEquals("Input: stringTimes(\"Hi\", 0)", "", exercises.StringTimes("Hi", 0));
            assertEquals("Input: stringTimes(\"Hi\", 5)", "HiHiHiHiHi", exercises.StringTimes("Hi", 5));
            assertEquals("Input: stringTimes(\"Oh Boy!\", 2)", "Oh Boy!Oh Boy!", exercises.StringTimes("Oh Boy!", 2));
            assertEquals("Input: stringTimes(\"x\", 4)", "xxxx", exercises.StringTimes("x", 4));
            assertEquals("Input: stringTimes(\"\", 4)", "", exercises.StringTimes("", 4));
            assertEquals("Input: stringTimes(\"code\", 2)", "codecode", exercises.StringTimes("code", 2));
            assertEquals("Input: stringTimes(\"code\", 3)", "codecodecode", exercises.StringTimes("code", 3));
        }

        [TestMethod]
        public void frontTimes()
        {
            assertEquals("Input: frontTimes(\"Chocolate\", 2)", "ChoCho", exercises.FrontTimes("Chocolate", 2));
            assertEquals("Input: frontTimes(\"Chocolate\", 3)", "ChoChoCho", exercises.FrontTimes("Chocolate", 3));
            assertEquals("Input: frontTimes(\"Abc\", 3)", "AbcAbcAbc", exercises.FrontTimes("Abc", 3));
            assertEquals("Input: frontTimes(\"Ab\", 4)", "AbAbAbAb", exercises.FrontTimes("Ab", 4));
            assertEquals("Input: frontTimes(\"A\", 4)", "AAAA", exercises.FrontTimes("A", 4));
            assertEquals("Input: frontTimes(\"\", 4)", "", exercises.FrontTimes("", 4));
            assertEquals("Input: frontTimes(\"Abc\", 0)", "", exercises.FrontTimes("Abc", 0));
        }

        [TestMethod]
        public void countXX()
        {
            assertEquals("Input: countXX(\"abcxx\")", 1, exercises.CountXX("abcxx"));
            assertEquals("Input: countXX(\"xxx\")", 2, exercises.CountXX("xxx"));
            assertEquals("Input: countXX(\"xxxx\")", 3, exercises.CountXX("xxxx"));
            assertEquals("Input: countXX(\"\")", 0, exercises.CountXX(""));
            assertEquals("Input: countXX(\"Hello there\")", 0, exercises.CountXX("Hello there"));
            assertEquals("Input: countXX(\"Hexxo thxxe\")", 2, exercises.CountXX("Hexxo thxxe"));
            assertEquals("Input: countXX(\"\")", 0, exercises.CountXX(""));
            assertEquals("Input: countXX(\"Kittens\")", 0, exercises.CountXX("Kittens"));
            assertEquals("Input: countXX(\"Kittensxxx\")", 2, exercises.CountXX("Kittensxxx"));
        }

        [TestMethod]
        public void doubleX()
        {
            assertEquals("Input: doubleX(\"axxbb\")", true, exercises.DoubleX("axxbb"));
            assertEquals("Input: doubleX(\"axaxax\")", false, exercises.DoubleX("axaxax"));
            assertEquals("Input: doubleX(\"xxxxx\")", true, exercises.DoubleX("xxxxx"));
            assertEquals("Input: doubleX(\"xaxxx\")", false, exercises.DoubleX("xaxxx"));
            assertEquals("Input: doubleX(\"aaaax\")", false, exercises.DoubleX("aaaax"));
            assertEquals("Input: doubleX(\"\")", false, exercises.DoubleX(""));
            assertEquals("Input: doubleX(\"abc\")", false, exercises.DoubleX("abc"));
            assertEquals("Input: doubleX(\"x\")", false, exercises.DoubleX("x"));
            assertEquals("Input: doubleX(\"xx\")", true, exercises.DoubleX("xx"));
            assertEquals("Input: doubleX(\"xax\")", false, exercises.DoubleX("xax"));
            assertEquals("Input: doubleX(\"xaxx\")", false, exercises.DoubleX("xaxx"));
        }

        [TestMethod]
        public void stringBits()
        {
            assertEquals("Input: stringBits(\"Hello\")", "Hlo", exercises.StringBits("Hello"));
            assertEquals("Input: stringBits(\"Hi\")", "H", exercises.StringBits("Hi"));
            assertEquals("Input: stringBits(\"Heeololeo\")", "Hello", exercises.StringBits("Heeololeo"));
            assertEquals("Input: stringBits(\"HiHiHi\")", "HHH", exercises.StringBits("HiHiHi"));
            assertEquals("Input: stringBits(\"\")", "", exercises.StringBits(""));
            assertEquals("Input: stringBits(\"Greetings\")", "Getns", exercises.StringBits("Greetings"));
            assertEquals("Input: stringBits(\"Chocoate\")", "Coot", exercises.StringBits("Chocoate"));
            assertEquals("Input: stringBits(\"pi\")", "p", exercises.StringBits("pi"));
            assertEquals("Input: stringBits(\"Hello Kitten\")", "HloKte", exercises.StringBits("Hello Kitten"));
            assertEquals("Input: stringBits(\"hxaxpxpxy\")", "happy", exercises.StringBits("hxaxpxpxy"));
        }

        [TestMethod]
        public void stringSplosion()
        {
            assertEquals("Input: stringSplosion(\"Code\")", "CCoCodCode", exercises.StringSplosion("Code"));
            assertEquals("Input: stringSplosion(\"abc\")", "aababc", exercises.StringSplosion("abc"));
            assertEquals("Input: stringSplosion(\"abc\")", "aab", exercises.StringSplosion("ab"));
            assertEquals("Input: stringSplosion(\"x\")", "x", exercises.StringSplosion("x"));
            assertEquals("Input: stringSplosion(\"fade\")", "ffafadfade", exercises.StringSplosion("fade"));
            assertEquals("Input: stringSplosion(\"There\")", "TThTheTherThere", exercises.StringSplosion("There"));
            assertEquals("Input: stringSplosion(\"Kitten\")", "KKiKitKittKitteKitten", exercises.StringSplosion("Kitten"));
            assertEquals("Input: stringSplosion(\"Bye\")", "BByBye", exercises.StringSplosion("Bye"));
            assertEquals("Input: stringSplosion(\"Good\")", "GGoGooGood", exercises.StringSplosion("Good"));
            assertEquals("Input: stringSplosion(\"Bad\")", "BBaBad", exercises.StringSplosion("Bad"));
        }

        [TestMethod]
        public void last2()
        {
            assertEquals("Input: last2(\"hixxhi\")", 1, exercises.Last2("hixxhi"));
            assertEquals("Input: last2(\"xaxxaxaxx\")", 1, exercises.Last2("xaxxaxaxx"));
            assertEquals("Input: last2(\"axxxaaxx\")", 2, exercises.Last2("axxxaaxx"));
            assertEquals("Input: last2(\"xxaxxaxxaxx\")", 3, exercises.Last2("xxaxxaxxaxx"));
            assertEquals("Input: last2(\"xaxaxaxx\")", 0, exercises.Last2("xaxaxaxx"));
            assertEquals("Input: last2(\"xxxx\")", 2, exercises.Last2("xxxx"));
            assertEquals("Input: last2(\"13121312\")", 1, exercises.Last2("13121312"));
            assertEquals("Input: last2(\"11212\")", 1, exercises.Last2("11212"));
            assertEquals("Input: last2(\"13121311\")", 0, exercises.Last2("13121311"));
            assertEquals("Input: last2(\"1717171\")", 2, exercises.Last2("1717171"));
            assertEquals("Input: last2(\"hi\")", 0, exercises.Last2("hi"));
            assertEquals("Input: last2(\"h\")", 0, exercises.Last2("h"));
            assertEquals("Input: last2(\"\")", 0, exercises.Last2(""));
        }

        [TestMethod]
        public void stringX()
        {
            assertEquals("Input: stringX(\"xxHxix\")", "xHix", exercises.StringX("xxHxix"));
            assertEquals("Input: stringX(\"abxxxcd\")", "abcd", exercises.StringX("abxxxcd"));
            assertEquals("Input: stringX(\"xabxxxcdx\")", "xabcdx", exercises.StringX("xabxxxcdx"));
            assertEquals("Input: stringX(\"xKittenx\")", "xKittenx", exercises.StringX("xKittenx"));
            assertEquals("Input: stringX(\"Hello\")", "Hello", exercises.StringX("Hello"));
            assertEquals("Input: stringX(\"xx\")", "xx", exercises.StringX("xx"));
            assertEquals("Input: stringX(\"x\")", "x", exercises.StringX("x"));
            assertEquals("Input: stringX(\"\")", "", exercises.StringX(""));
        }

        [TestMethod]
        public void altPairs()
        {
            assertEquals("Input: altPairs(\"kitten\")", "kien", exercises.AltPairs("kitten"));
            assertEquals("Input: altPairs(\"Chocolate\")", "Chole", exercises.AltPairs("Chocolate"));
            assertEquals("Input: altPairs(\"CodingHorror\")", "Congrr", exercises.AltPairs("CodingHorror"));
            assertEquals("Input: altPairs(\"yak\")", "ya", exercises.AltPairs("yak"));
            assertEquals("Input: altPairs(\"ya\")", "ya", exercises.AltPairs("ya"));
            assertEquals("Input: altPairs(\"y\")", "y", exercises.AltPairs("y"));
            assertEquals("Input: altPairs(\"\")", "", exercises.AltPairs(""));
            assertEquals("Input: altPairs(\"ThisThatTheOther\")", "ThThThth", exercises.AltPairs("ThisThatTheOther"));
        }

        [TestMethod]
        public void stringYak()
        {
            assertEquals("Input: stringYak(\"yakpak\")", "pak", exercises.StringYak("yakpak"));
            assertEquals("Input: stringYak(\"pakyak\")", "pak", exercises.StringYak("pakyak"));
            assertEquals("Input: stringYak(\"yak123ya\")", "123ya", exercises.StringYak("yak123ya"));
            assertEquals("Input: stringYak(\"yak\")", "", exercises.StringYak("yak"));
            assertEquals("Input: tringYak(\"yakxxxyak\")", "xxx", exercises.StringYak("yakxxxyak"));
            assertEquals("Input: stringYak(\"HiyakHi\")", "HiHi", exercises.StringYak("HiyakHi"));
            assertEquals("Input: stringYak(\"xxxyakyyyakzzz\")", "xxxyyzzz", exercises.StringYak("xxxyakyyyakzzz"));
        }

        // java syntax
        public void assertEquals(string message, string expected, string actual)
        {
            Assert.AreEqual(expected, actual, message);
        }

        // java syntax
        public void assertEquals(string message, bool expected, bool actual)
        {
            Assert.AreEqual(expected, actual, message);
        }

        // java syntax
        public void assertEquals(string message, int expected, int actual)
        {
            Assert.AreEqual(expected, actual, message);
        }
    }


}
