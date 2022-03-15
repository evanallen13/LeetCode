using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class CompareTwoBinaryTrees
    {
        /*
*  Given two binary trees, determine wheater
*  they have the same inorder traversal 
* 
*        Tree 1                  Tree 2
* 
*           5                       3
*          /  \                   /  \
*        3     7                 1    6
*       /      /                    /   \
*      1      6                    5     7
*/
        public static bool compareTwoBinaryTrees()
        {
            TreeNode p = new TreeNode(5);
            p.left = new TreeNode(3);
            p.left.left = new TreeNode(1);

            TreeNode q = new TreeNode(3);
            q.left = new TreeNode(1);
            q.right = new TreeNode(6);
            q.right.left = new TreeNode(5);
            q.right.right = new TreeNode(7);

            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            List<int> list1 = new List<int>();
            List<int> list2 = list1;

            inorder(p, ref list1);
            inorder(q, ref list2);

            return list1 == list2;
        }

        private static void inorder(TreeNode root, ref List<int> list)
        {
            if (root == null) return;
            inorder(root.left, ref list);
            list.Add(root.val);
            inorder(root.right, ref list);
        }

        private class TreeNode
        {
            public int val
            { get; set; }

            public TreeNode left
            { get; set; }

            public TreeNode right
            { get; set; }

            public TreeNode(int val)
            {
                this.val = val;
            }
        }
    }
}
