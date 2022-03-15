using System;
using LeetCode.DataStuctures;

namespace LeetCode
{
    class _0965_UnivaluedBinaryTree
    {
        public bool IsUnivalTree(TreeNode root)
        {
            bool result = true;
            Check(root, ref result);

            return result;
        }
        public static void Check(TreeNode root, ref bool result)
        {
            int val = root.val;

            if (root.right != null)
            {
                if (root.right.val != val)
                {
                    result = false;
                    return;
                }
                Check(root.right, ref result);
            }

            if (root.left != null)
            {
                if (root.left.val != val)
                {
                    result = false;
                    return;
                }
                Check(root.left, ref result);
            }
        }
    }
}