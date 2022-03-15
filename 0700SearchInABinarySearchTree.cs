using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _0700SearchInABinarySearchTree
    {
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || root.val == val) return root;

            TreeNode result = null;
            search(root.left, val, ref result);
            search(root.right, val, ref result);

            return result;
        }

        public static void search(TreeNode root, int val, ref TreeNode result)
        {
            if (root == null) return;
            if (root.val == val)
            {
                result = root;
                return;
            }
            search(root.left, val, ref result);
            search(root.right, val, ref result);
        }
    }
}
