using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _002_AddTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resultHead = new ListNode(0);
            ListNode resultIterator = resultHead;

            ListNode p1 = l1;
            ListNode p2 = l2;

            bool carry = false;

            while (p1 != null || p2 != null)
            {
                int sum = 0;

                if (p1 == null)
                {
                    sum += p2.val;
                    p2 = p2.next;
                }
                else if (p2 == null)
                {
                    sum += p1.val;
                    p1 = p1.next;
                }
                else
                {
                    sum += p1.val + p2.val;
                    p1 = p1.next;
                    p2 = p2.next;
                }

                if (carry)
                    sum++;

                if (sum >= 10)
                {
                    sum %= 10;
                    carry = true;
                }
                else
                {
                    carry = false;
                }

                ListNode newNode = new ListNode(sum);
                resultIterator.next = newNode;
                resultIterator = resultIterator.next;
            }
            if (carry)
            {
                resultIterator.next = new ListNode(1);
            }

            return resultHead.next;
        }
    }
}
