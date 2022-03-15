using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _709_ToLowerCase
    {
        public static string toLowerCase(string str)
        {
            char[] charArr = str.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (!Char.IsLower(charArr[i]))
                    charArr[i] = Char.ToLower(charArr[i]);
            }

            return new string(charArr);
        }
    }
}
