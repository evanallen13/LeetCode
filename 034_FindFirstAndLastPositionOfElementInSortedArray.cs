using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _034_FindFirstAndLastPositionOfElementInSortedArray
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { -1, -1 };

            int first = -1;
            int last = -1;

            int l = 0;
            int r = nums.Length - 1;

            do
            {
                if(first != -1 && last != -1) break;
                int left = nums[l];
                int right = nums[r];

                if (left == target && first == -1)
                    first = l;

                if (right == target && last == -1)
                    last = r;

                l++;
                r--;
            }while (r != 0);

            Console.WriteLine($"{first} {last}");
            return new int[] { first, last };
        }

        public static int[] SearchRange_First(int[] nums, int target)
        {
            int first = -1;
            int last = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    if (first != -1)
                        last = i;
                    else
                    {
                        first = i;
                        last = i;
                    }
                }
            }

            return new int[] { first, last };
        }
    }
}
