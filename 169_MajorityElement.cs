using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _169_MajorityElement
    {
        public static int MajorityElement(int[] nums)
        {
            int maxNum = 0;
            int maxAmount = 0;
            List<int> numsCounted = new List<int>();

            foreach (int num in nums)
            {
                if (numsCounted.IndexOf(num) != -1) continue;
                int internalMax = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == num)
                        internalMax += 1;
                }

                if (internalMax > maxAmount)
                {
                    maxNum = num;
                    maxAmount = internalMax;
                }

                numsCounted.Add(num);
            }

            return maxNum;
        }
    }
}
