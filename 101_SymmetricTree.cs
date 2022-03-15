using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _101_SymmetricTree
    {
        public static bool IsSymmetric(TreeNode root)
        {
            bool result = true;
            check(root.left, root.right, ref result);

            return result;
        }

        public static void check(TreeNode left, TreeNode right, ref bool result)
        {
            if (left == null && right == null) return;
            if (left == null)
            {
                result = false;
                return;
            }
            if (right == null)
            {
                result = false;
                return;
            }

            if (left.val == right.val)
            {
                check(left.right, right.left, ref result);
                check(left.left, right.right, ref result);
            }
            else
            {
                result = false;
                return;
            }

        }

    }
}
