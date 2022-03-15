using System;

namespace LeetCode
{
    public class MyLinkedList
    {
        /** Initialize your data structure here. */
        public Node node;
        public MyLinkedList()
        {
            this.node = null;
        }

        public class Node
        {
            public int val;
            public Node next;
            public Node(int val)
            {
                this.val = val;
                this.next = null;
            }
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            int i = 0;
            Node dummy = node;
            while (dummy != null)
            {
                if (i == index) return dummy.val;
                i++;
                dummy = dummy.next;
            }

            return -1;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node newNode = new Node(val);
            newNode.next = node;
            node = newNode;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if(this.node == null) return;

            Node n = this.node;
            while(n.next != null){
                n = n.next;
            }

            n.next = new Node(val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if(this.node == null) return;

            int i = 0;
            Node n = this.node;
            Node last = n;
            while(n != null){
                if(i == val - 1){

                }
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            int i = 0;
            Node curr = node;
            Node prev = node;

            while (curr != null)
            {
                if (i == index){

                }
                i++;
                prev = curr;
                curr = curr.next;
            }
        }


    }

}