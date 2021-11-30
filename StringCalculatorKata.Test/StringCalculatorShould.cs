using System;
using Xunit;

namespace StringCalculatorKata.Test
{
    public class StringCalculatorShould
    {
        [Fact]
        public void Return0WhenStringIsEmpty()
        {
            int actual = StringCalculator.Sum("");
            
            Assert.Equal(0, actual);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        public void ReturnNumberWhenStringIsOneNumber(string number, int expected)
        {
            int actual = StringCalculator.Sum(number);
            
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData("0,1", 1)]
        [InlineData("1, 1", 2)]
        public void ReturnSumOfNumbersWhenStringHasTwoNumbers(string numbers, int expected)
        {
            int actual = StringCalculator.Sum(numbers);
            
            Assert.Equal(expected, actual);
        }
    }
}