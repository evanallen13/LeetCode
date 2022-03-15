using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _167_TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int r = numbers.Length - 1;
            int l = 0;
            while (l < r)
            {
                if (numbers[r] + numbers[l] == target)
                    return new int[] { l + 1, r + 1 };

                if (numbers[r] + numbers[l] > target)
                    r--;
                else
                    l++;
            }

            return new int[] {0,0};
        }
    }
}
