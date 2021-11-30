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
                var firstNumber = int.Parse(numbersArray[0]);
                var secondNumber = int.Parse(numbersArray[1]);

                return firstNumber + secondNumber;
            }

            return Int32.Parse(numbersArray[0]);
        }
    }
}