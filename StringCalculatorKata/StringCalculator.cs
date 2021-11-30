using System;

namespace StringCalculatorKata
{
    public static class StringCalculator
    {
        public static int Sum(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
                return 0;
            if (numbers.Length > 2)
                return Int32.Parse(numbers.Substring(2));
            return (Convert.ToInt32(numbers));
        }
    }
}