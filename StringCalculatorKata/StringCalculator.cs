using System;

namespace StringCalculatorKata
{
    public static class StringCalculator
    {
        public static int Sum(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
                return 0;

            var numbersArray = numbers.Split(",");
            if (numbersArray.Length > 1)
            {
                var sum = 0;
                foreach (var number in numbersArray) 
                    sum += int.Parse(number);
                return sum;
            }

            return Int32.Parse(numbersArray[0]);
        }
    }
}