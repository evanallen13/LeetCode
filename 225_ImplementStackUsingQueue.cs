using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _225_ImplementStackUsingQueue
    {
        List<int> listStack = new List<int>();
        int size { get; set; }


        public _225_ImplementStackUsingQueue()
        {
            this.listStack = new List<int>();
            this.size = 0;
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            listStack.Add(x);
            size++;
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            int result =   listStack[listStack.Count - 1];
            listStack.Remove(result);
            size--;
            return result;
        }

        /** Get the top element. */
        public int Top()
        {
            int result = listStack[listStack.Count - 1];
            return result;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            if (listStack.Count == 0)
                return true;
            return false;
        }
    }
}
