using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _0069_Sqrt
    {
        public static int MySqrt(int x)
        {
            int l = 0;
            int r = x > 46340 ? 46340 : x;
            int m = 0;

            while (l <= r)
            {
                int midIndex = (l + r) / 2;
                m = (midIndex * midIndex);
                if (m == x)
                    return midIndex;

                if (m > x)
                    r = midIndex - 1;
                else if (m < x)
                    l= midIndex + 1;
            }

            return r;
        }
    }
}
