using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _155_MinStack
    {
        LinkedList head = null;
        int MIN { get; set; }
        /** initialize your data structure here. */
        public _155_MinStack()
        {

        }

        public void Push(int x)
        {
            if (head == null) MIN = x;
            LinkedList newNode = new LinkedList(x);
            newNode.next = head;

            if(x <= MIN)
                MIN = x;

            head = newNode;
        }

        public void Pop()
        {
            if (head == null) return;
            int val = head.val;
            this.head = head.next;
        }

        public int Top()
        {
            if (head == null) return -1;
            int result = head.val;
            return result;
        }

        public int GetMin()
        {
            if (head == null) return -1;
            int min = head.val;
            LinkedList dummy = head;
            while (true)
            {
                if (dummy == null) break;
                if (dummy.val <= min) min = dummy.val;
                dummy = dummy.next;
            }

            return min;
        }

        private class LinkedList
        {
            public int val;
            public LinkedList next;
            public LinkedList(int val = 0, ListNode next = null)
            {
                this.val = val;
                next = null;
            }
        }
    }
}
