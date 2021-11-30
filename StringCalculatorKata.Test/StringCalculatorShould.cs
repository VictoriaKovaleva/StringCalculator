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
    }
}