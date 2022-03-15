using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _013_RomanToInt
    {
        public static int romanToInt(string s)
        {
            char[] charArr = s.ToUpper().ToCharArray();
            int result = 0;

            for (int i = 0; i < charArr.Length; i++)
            {
                char char1 = charArr[i];
                char char2 = i + 1 < charArr.Length ? charArr[i + 1] : Char.MinValue;

                string[] acceptedSpecial = { "IX", "XX", "XL", "XC", "CD", "CM", "IV" };

                if (Array.IndexOf(acceptedSpecial, $"{char1}{char2}") > -1)
                {
                    result += convertNumeral($"{char1}{char2}");
                    i = i + 1;
                }
                else
                {
                    result += convertNumeral(char1.ToString());
                }
            }

            return result;
        }

        public static int convertNumeral(string numeral)
        {
            switch (numeral)
            {
                case "I":
                    return 1;
                case "V":
                    return 5;
                case "X":
                    return 10;
                case "L":
                    return 50;
                case "C":
                    return 100;
                case "D":
                    return 500;
                case "M":
                    return 1000;

                //// Special Cases
                case "IV":
                    return 4;
                case "IX":
                    return 9;
                case "XX":
                    return 20;
                case "XL":
                    return 40;
                case "XC":
                    return 90;
                case "CD":
                    return 400;
                case "CM":
                    return 900;
                default:
                    return 0;
            }
        }
    }
}
