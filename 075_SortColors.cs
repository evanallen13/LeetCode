using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _075_SortColors
    {
        public static void SortColors(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1) return;

            while (true)
            {
                bool isSorted = true;
                for (int i = 1; i < nums.Length; i++)
                {
                    int num = nums[i];
                    int prev = nums[i - 1];
                    if (num < prev)
                    {
                        nums[i - 1] = num;
                        nums[i] = prev;
                        isSorted = false;
                    }
                }

                if (isSorted)
                    break;
            }
        }
    }
}
