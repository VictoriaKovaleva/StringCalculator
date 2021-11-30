using System;
using Xunit;

namespace StringCalculatorKata.Test
{
    public class StringCalculatorShould
    {
        [Fact]
        public void Return0WhenInputStringIsEmpty()
        {
            string actual = StringCalculator.Sum("");
            
            Assert.Null(actual);
        }
    }
}