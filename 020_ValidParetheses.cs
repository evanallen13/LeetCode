using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _020_ValidParetheses
    {
        public static bool IsValid(string s)
        {
             Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (stack.Count > 0 && c == ')' && stack.Peek() == '(')
                    stack.Pop();
                else if (stack.Count > 0 && c == '}' && stack.Peek() == '{')
                    stack.Pop();
                else if (stack.Count > 0 && c == ']' && stack.Peek() == '[')
                    stack.Pop();
                else
                    stack.Push(c);
            }
            return stack.Count == 0;
        }

    }
}
