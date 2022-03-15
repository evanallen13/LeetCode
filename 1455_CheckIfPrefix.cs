using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _1455_CheckIfPrefix
    {
        public static int IsPrefixOfWord(string sentence, string searchWord)
        {
            if (sentence.Length == 0) return -1;
            string[] strs = sentence.Split(' ');

            for(int i = 0; i < strs.Length; i++)
            {
                if (strs[i].StartsWith(searchWord))
                    return i;
            }

            return -1;
        }
    }
}
