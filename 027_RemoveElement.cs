using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _027_RemoveElement
    {
        public static int removeElement(int[] nums, int val)
        {
            List<int> numsList = new List<int>();

            foreach (int num in nums)
            {
                if (num != val)
                    numsList.Add(num);
            }

            for (int i = 0; i < numsList.Count; i++)
            {
                nums[i] = numsList[i];
            }

            return numsList.Count;
        }
    }
}
