using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _172_FactorialTrailingZero
    {
        public static int TrailingZeroes(int n)
        {
            if (n == 0) return n;
            int count = 0;

            while (n > 0)
            {
                count += n / 5;
                n /= 5;
            }

            return count;
        }
    }
}
