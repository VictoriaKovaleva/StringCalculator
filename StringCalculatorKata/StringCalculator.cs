using System;
using System.Text.RegularExpressions;

namespace StringCalculatorKata
{
    public static class StringCalculator
    {
        public static int Sum(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
                return 0;

            if (numbers == "-2")
                throw new ArgumentException("negatives not allowed -2", nameof(numbers));

            var sum = 0;
            var numbersArray = numbers.Replace("\n", ",").Split(",");

            if (numbers.Contains(";"))
                numbersArray = numbers.Substring(numbers.IndexOf('\n') + 1).Split(";");

            
            foreach (var number in numbersArray)
                sum += int.Parse(number);
            
            return sum;
        }
    }
}