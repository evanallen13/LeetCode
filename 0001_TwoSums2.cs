using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _001_TwoSums2
    {
        public static int[] twoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int need = target - num;
                // Check if needed number "need" is in dict
                bool checkIfNeed = dict.ContainsValue(need);

                if (checkIfNeed)
                {
                    foreach (KeyValuePair<int, int> kvp in dict)
                    {
                       if(kvp.Value == need)
                        return new int[]{kvp.Key, i};
                    }
                }

                dict.Add(i, num);
            }
             return new int[2];
        }
    }
}
