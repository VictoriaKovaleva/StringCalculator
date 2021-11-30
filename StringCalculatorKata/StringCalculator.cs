using System;

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
            foreach (var number in numbersArray)
                sum += int.Parse(number);
            return sum;
        }
    }
}