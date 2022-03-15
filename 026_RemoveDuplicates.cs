using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _026_RemoveDuplicates
    {
        public static int removeDuplicates(int[] nums)
        {
            if (nums == null || nums.Length < 1) return 0;
            int result = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    result++;
                }
            }
            return result + 1;
        }
    }
}
