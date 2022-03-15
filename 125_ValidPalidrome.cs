using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _125_ValidPalidrome
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();

            int head = 0;
            int tail = s.Length - 1;

            while (head < tail)
            {
                char headElem = s[head];
                char tailElem = s[tail];

                if (!isLetter(headElem))
                {
                    head++;
                }
                else if (!isLetter(tailElem))
                {
                    tail--;
                }
                else
                {
                    if (headElem != tailElem)
                    {
                        return false;
                    }

                    tail--;
                    head++;
                }
            }

            return true;
        }

        private static bool isLetter(char c)
        {
            if ((c >= 'A' && c <= 'Z') ||
                (c >= 'a' && c <= 'z') ||
                (c >= '0' && c <= '9'))
                return true;
            else
                return false;

        }
    }
}
