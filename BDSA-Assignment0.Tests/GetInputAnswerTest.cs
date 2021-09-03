using System;
using Xunit;

namespace BDSA_Assignment0.Tests
{
    public class GetInputAnswerTest
    {
        [Fact]
        public void StringEntered() {
            var result = Program.GetInputAnswer("ThisIsNotANumber");
            Assert.Contains("Please enter an integer", result); //, $"Should react to a string being entered"
        }

        [Fact]
        public void TooEarlyYear() {
            var result = Program.GetInputAnswer("1253");
            Assert.Contains("Year must be at least 1582", result); //,$"Should react to input being below 1582"
        }

        [Theory]
        [InlineData("1600")]
        [InlineData("2004")]
        public void LeapYearEntered(string value) {
            var result = Program.GetInputAnswer(value);
            Assert.Equal("yay", result); //, $"Should return 'yay' to leap year {value}"
        }

        [Theory]
        [InlineData("1601")]
        [InlineData("2300")]
        public void NonLeapYearEntered(string value) {
            var result = Program.GetInputAnswer(value);
            Assert.Equal("nay", result); //, $"Should return 'nay' to non-leap year {value}"
        }
    }
}
