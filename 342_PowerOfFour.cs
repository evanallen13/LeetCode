using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _342_PowerOfFour
    {
        public static bool IsPowerOfFour(int n)
        {
            if (n == 0) return false;
            if (n == 1) return true;
            return n % 4 == 0 && IsPowerOfFour(n / 4);
        }
    }
}

