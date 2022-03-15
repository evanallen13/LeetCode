using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _035_SearchInsertPosition
    {
        public static int searchInsert(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }

                else
                {
                    right = mid - 1;
                }


                Console.WriteLine($"Left:{left} Mid:{mid} Right{right}");
            }

            return nums[mid] < target ? mid + 1 : mid;
        }

    }
}
