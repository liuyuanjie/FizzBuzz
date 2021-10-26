using System;

namespace FizzBuzz
{
    public static class FizzBuzzGame
    {
        private const int FizzNumber = 3;
        private const int BuzzNumber = 5;
        private const int WhizzNumber = 7;

        public static string Report(int order)
        {
            if (order.ToString().Contains(FizzNumber.ToString())) return "Fizz";

            var result = string.Empty;
            if (IsFizz(order)) result += "Fizz";
            if (IsBuzz(order)) result += "Buzz";
            if (IsWhizz(order)) result += "Whizz";

            return string.IsNullOrEmpty(result) ? order.ToString() : result;
        }

        private static bool IsWhizz(int order)
        {
            return order % WhizzNumber == 0;
        }

        private static bool IsBuzz(int order)
        {
            return order % BuzzNumber == 0;
        }

        private static bool IsFizz(int order)
        {
            return order % FizzNumber == 0;
        }
    }
}