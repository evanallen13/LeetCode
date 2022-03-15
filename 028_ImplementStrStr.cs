using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _028_ImplementStrStr
    {
        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Length < needle.Length)
                return -1;
            if (haystack == string.Empty || needle == string.Empty)
                return 0;


            char[] charArray = haystack.ToCharArray();

            if (haystack.Length >= needle.Length)
            {
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (i <= (haystack.Length - needle.Length))
                    {
                        if (charArray[i] == needle[0])
                        {
                            string subStr = haystack.Substring(i, needle.Length);

                            if (subStr == needle)
                            {
                                return i;
                            }
                        }
                    }
                }
            }


            return -1;
        }
    }
}
