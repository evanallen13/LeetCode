using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LengthOfLastWord
    {
        public static int lengthOfLastWord(string s)
        {
            s = s.Trim();
            string[] words = s.Split(" ");
            string lastWord = words[words.Length - 1];

            return lastWord.Length;
        }
    }
}
