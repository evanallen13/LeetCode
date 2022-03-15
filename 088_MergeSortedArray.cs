using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _088_MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int nums1Index = m - 1;
            int nums2Index = n - 1;

            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (nums2Index < 0)
                {
                    break;
                }
                if (nums1Index >= 0 && // num1 Index still going 
                    nums1[nums1Index] > nums2[nums2Index]) // num1 > num2
                {
                    nums1[i] = nums1[nums1Index];
                    nums1Index--;
                }
                else
                {
                    nums1[i] = nums2[nums2Index];
                    nums2Index--;
                }
            }
        }
    }
}
