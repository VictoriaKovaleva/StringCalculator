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

            var numbersArray = numbers.Replace("\n", ",").Split(",");

            var sum = 0;

            if (numbers.Contains("//"))
            {
                var index = numbers.IndexOf('1');
                string[] nextLineArray = numbers.Substring(index).Split(";");
                foreach (var number in nextLineArray)
                    sum += int.Parse(number);
            }

            if (!numbers.Contains("//"))
            foreach (var number in numbersArray)
                sum += int.Parse(number);
            
            return sum;
        }
    }
}