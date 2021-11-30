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

        [Fact]
        public void Return1WhenStringIs1()
        {
            int actual = StringCalculator.Sum("1");
            
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Return2WhenStringIs2()
        {
            int actual = StringCalculator.Sum("2");
            
            Assert.Equal(2, actual);
        }
    }
}