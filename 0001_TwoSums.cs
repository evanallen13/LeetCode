using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _001_TwoSums 
    {
        public static int[] twoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int j = 0; j < nums.Length; j++)
            {
                int num = nums[j];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != j)
                    {
                        if (num + nums[i] == target)
                        {
                            result[0] = j;
                            result[1] = i;
                            return result;
                        }
                    }

                }
            }

            return result;
        }
    }
}
