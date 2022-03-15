using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _66_PlusOne
    {
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            digits[n - 1] = digits[n - 1] + 1;

            for (int i = n - 1; i >= 0; i--)
            {
                int current = digits[i];

                if (i == 0)
                {
                    for (int j = 1; j < n; j++)
                    {
                        digits[j] = 0;
                    }
                }
                else if (current > 9)
                {
                    int next = digits[i - 1];
                    digits[i] = 0;
                    digits[i - 1] = next + 1;
                }
                else
                {
                    break;
                }
            }

            int first = digits[0];
            if (first >= 10)
            {
                int[] newArr = new int[n + 1];
                newArr[0] = 1;
                return newArr;
            }
            else
            {
                return digits;
            }
        }
    }
}
