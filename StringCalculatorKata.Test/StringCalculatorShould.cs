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
        [InlineData("4, 6", 10)]
        [InlineData("10, 5", 15)]
        [InlineData("23, 15", 38)]
        public void ReturnSumOfNumbersWhenStringHasTwoNumbers(string numbers, int expected)
        {
            int actual = StringCalculator.Sum(numbers);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("10,18,7", 35)]
        [InlineData("10,20,40,5", 75)]
        [InlineData("100,2,305,15", 422)]
        public void ReturnSumOfAnyAmountOfNumbersOfString(string numbers, int expected)
        {
            int actual = StringCalculator.Sum(numbers);
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Return6WhenStringHas1And2And3AndNewLine()
        {
            int actual = StringCalculator.Sum("1\n2,3");
            
            Assert.Equal(6, actual);
        }
        
    }|
}