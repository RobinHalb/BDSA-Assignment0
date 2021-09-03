using System;
using Xunit;

namespace BDSA_Assignment0.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4)]
        [InlineData(12)]
        public void DivisibleByFour(int value)
        {
            Program program = new Program();
            var result = program.IsLeapYear(value);
            Assert.True(result,$"{value} should be accepted as divisible by four");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(33)]
        public void NotDivisibleByFour(int value) {
            Program program = new Program();
            var result = program.IsLeapYear(value);
            Assert.False(result,$"{value} should be denied as not divisible by four");
        }

        [Theory]
        [InlineData(200)]
        [InlineData(500)]
        public void DivisibleByHundred(int value) {
            Program program = new Program();
            var result = program.IsLeapYear(value);
            Assert.False(result,$"{value} should be denied as divisible by a hundred");
        }

        [Theory]
        [InlineData(400)]
        [InlineData(2000)]
        public void DivisibleByFourHundred(int value)
        {
            Program program = new Program();
            var result = program.IsLeapYear(value);
            Assert.True(result,$"{value} should be accepted as divisible by four hundred");
        }
    }
}
