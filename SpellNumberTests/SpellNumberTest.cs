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
            var result = spellNumber.NumberToWord(0);
            Assert.Equal("Zero", result);
        }

        [Fact]
        public void Test0False()
        {
            var result = spellNumber.NumberToWord(0);
            Assert.NotEqual("zero", result);
        }

        [Fact]
        public void TestUnsupported1()
        {
            var result = spellNumber.NumberToWord(-1);
            Assert.Equal("Not supported", result);
        }

        [Fact]
        public void TestUnsupported2()
        {
            var result = spellNumber.NumberToWord(-19999);
            Assert.Equal("Not supported", result);
        }

        [Fact]
        public void Test1True()
        {
            var result = spellNumber.NumberToWord(1);
            Assert.Equal("One", result);
        }

        [Fact]
        public void Test100True()
        {
            var result = spellNumber.NumberToWord(100);
            Assert.Equal("One Hundred", result);
        }

        [Fact]
        public void Test56True()
        {
            var result = spellNumber.NumberToWord(56);
            Assert.Equal("Fifty Six", result);
        }
    }
}
