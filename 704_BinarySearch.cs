using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _704_BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            int l = 0;
            int r = nums.Length - 1;

            while (l <= r)
            {
                // Middle Index
                int m = l + (r - l) / 2;
                // Middle Num --EQUALS-- Target
                if (nums[m] == target) return m;
                // Middle Num --LESS THAN-- Target
                if (nums[m] < target) l = m + 1;
                // Middle Num --GREATER THAN-- Target
                if (nums[m] > target) r = m - 1;
            }
            return -1;
        }
    }
}
