using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _007_ReverseInteger
    {
        public static int Reverse(int x)
        {
            Boolean isNegative = x < 0;
            x = Math.Abs(x);

            char[] numbers = x.ToString().ToCharArray();
            string result = string.Empty;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                result += numbers[i];
            }
            return isNegative ? int.Parse(result) * -1 : int.Parse(result);
        }
    }
}
