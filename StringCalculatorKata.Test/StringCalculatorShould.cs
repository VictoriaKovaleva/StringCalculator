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

        [Fact]
        public void Return1WhenStringIs0And1()
        {
            int actual = StringCalculator.Sum("0,1");
            
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Return2WhenStringIs1And1()
        {
            int actual = StringCalculator.Sum("1,1");
            
            Assert.Equal(2, actual);

        }
    }
}