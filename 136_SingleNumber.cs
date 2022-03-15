using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _136_SingleNumber
    {
        public static int SingleNumber(int[] nums)
        {

            List<int> arrSingle = new List<int>();
            List<int> arrDouble = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // If in double
                if (arrDouble.IndexOf(nums[i]) != -1)
                {
                    continue;
                    // If in single
                }
                else if (arrSingle.IndexOf(nums[i]) != -1)
                {
                    arrDouble.Add(nums[i]);
                    arrSingle.Remove(nums[i]);
                }
                else
                {
                    arrSingle.Add(nums[i]);
                }
            }

            return arrSingle[0];
        }
    }
}
