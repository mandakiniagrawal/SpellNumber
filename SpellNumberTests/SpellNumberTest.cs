using System;
using Xunit;
using SpellNumberExercise;

namespace SpellNumberTests
{
    public class SpellNumberTest
    {
        private SpellNumber spellNumber;
        public SpellNumberTest()
        {
            spellNumber = new SpellNumber();
        }
        [Fact]
        public void Test0True()
        {
            var result = spellNumber.FinalNumberToWord(0);
            Assert.Equal("Zero", result);
        }

        [Fact]
        public void Test0False()
        {
            var result = spellNumber.FinalNumberToWord(0);
            Assert.NotEqual("zero", result);
        }

        [Fact]
        public void TestUnsupported1()
        {
            var result = spellNumber.FinalNumberToWord(-1);
            Assert.Equal("Not supported", result);
        }

        [Fact]
        public void TestUnsupported2()
        {
            var result = spellNumber.FinalNumberToWord(-19999);
            Assert.Equal("Not supported", result);
        }

        [Fact]
        public void Test1True()
        {
            var result = spellNumber.FinalNumberToWord(1);
            Assert.Equal("One", result);
        }

        [Fact]
        public void Test100True()
        {
            var result = spellNumber.FinalNumberToWord(100);
            Assert.Equal("One Hundred", result);
        }

        [Fact]
        public void Test56True()
        {
            var result = spellNumber.FinalNumberToWord(56);
            Assert.Equal("Fifty Six", result);
        }

        [Fact]
        public void Test1456True()
        {
            var result = spellNumber.FinalNumberToWord(1456);
            Assert.Equal("One Thousand Four Hundred Fifty Six", result);
        }

        [Fact]
        public void Test2560True()
        {
            var result = spellNumber.FinalNumberToWord(2560);
            Assert.Equal("Two Thousand Five Hundred Sixty", result);
        }

        [Fact]
        public void Test23560True()
        {
            var result = spellNumber.FinalNumberToWord(23560);
            Assert.Equal("Twenty Three Thousand Five Hundred Sixty", result);
        }

        [Fact]
        public void Test10000True()
        {
            var result = spellNumber.FinalNumberToWord(10000);
            Assert.Equal("Ten Thousand", result);
        }

        [Fact]
        public void Test345333True()
        {
            var result = spellNumber.FinalNumberToWord(345333);
            Assert.Equal("Three Lakhs Fourty Five Thousand Three Hundred Thirty Three", result);
        }
    }
}
