﻿using NUnit.Framework;

namespace KataRomanNumerals
{
    class ArabicNumeralTests
    {
        [TestCase("I",    1)]
        [TestCase("II",   2)]
        [TestCase("III",  3)]
        public void Should_return_an_arabic_numeral_when_the_imput_roman_numeral_in_arabic_is_inferior_IV(string romanNumber, int expected)
        {
            int actual = new ArabicNumeral().ToArabic(romanNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("IV",   4)]
        [TestCase("VI",   6)]
        [TestCase("VII",  7)]
        [TestCase("VIII", 8)]
        [TestCase("IX",   9)]
        [TestCase("X",    10)]
        [TestCase("XI",   11)]
        [TestCase("XXI",  21)]
        [TestCase("XXXV", 35)]
        [TestCase("DII",  502)]    
        public void Should_return_an_arabic_numeral_when_the_imput_roman_numeral_in_arabic_is_inferior_MIII(string romanNumber, int expected)
        {
            int actual = new ArabicNumeral().ToArabic(romanNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("MIII",   1003)]
        [TestCase("MCMXC",  1990)]
        [TestCase("MCMIII", 1903)]
        public void Should_return_an_arabic_numeral_when_the_imput_roman_numeral_in_arabic_is_equal_or_greater_than_MIII(string romanNumber, int expected)
        {
            int actual = new ArabicNumeral().ToArabic(romanNumber);
            Assert.AreEqual(expected, actual);
        }

    }
}
