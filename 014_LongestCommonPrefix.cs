using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _014_LongestCommonPrefix
    {
        public static string longestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || strs.Length == 1)
            {
                return string.Empty;
            }

            string result = String.Empty;

            string str1 = strs[0];

            for (int i = 0; i <= str1.Length; i++)
            {
                string str1Pefix = str1.Substring(0, i);
                Boolean isPrefix = true;
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length > i)
                    {
                        string currentPrefix = strs[j].Substring(0, i);
                        if (str1Pefix != currentPrefix)
                        {
                            isPrefix = false;
                            break;
                        }
                    }
                    else
                    {
                        isPrefix = false;
                        break;
                    }
                }

                if (isPrefix)
                {
                    result = str1Pefix;
                }
                else
                {
                    break;
                }
            }

            return result;

        }
    }
}
