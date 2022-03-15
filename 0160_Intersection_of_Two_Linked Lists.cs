using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _0160_Intersection_of_Two_Linked_Lists
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {

            HashSet <ListNode> hash = new HashSet<ListNode>();

            while (headA != null)
            {
                hash.Add(headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                if (hash.Contains(headB))
                    return headB;
                headB = headB.next;
            }

            return new ListNode();
        }
    }
}
