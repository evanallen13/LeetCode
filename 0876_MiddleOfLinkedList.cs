using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _876_MiddleOfLinkedList
    {
        public static void MiddleNode(/* ListNode head */)
        {
            // if (head == null) return head;

            ListNode head = new ListNode(1);
            head.next = new ListNode(4);
            head.next.next = new ListNode(12);
            head.next.next.next = new ListNode(6);
            head.next.next.next.next = new ListNode(10);

            List<int> list = new List<int>();
            ListNode dummy = head;
            int middleIndex = 0;

            while (true)
            {
                if (head == null) break;
                list.Add(head.val);
                head = head.next;
            }

            middleIndex = list.Count / 2;

            for (int i = 0; i < list.Count; i++)
            {
                if (middleIndex == i) break;

                dummy = dummy.next;

            }

            //return head;
        }
        private class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
