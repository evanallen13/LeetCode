using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _110_BalanceBinaryTree
    {
        public static bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            int leftMax = 0;
            int rightMax = 0;

            CheckMaxHeight(root.right, ref rightMax);
            CheckMaxHeight(root.left, ref leftMax);

            // if(Math.Abs(leftMax - rightMax) <= 1)
            return Math.Abs(leftMax - rightMax) <= 1;
        }



        private static void CheckMaxHeight(TreeNode root, ref int max)
        {
            if (root == null) return;

            if (root.right != null && root.left != null)
            {
                max++;
            }
            CheckMaxHeight(root.right, ref max);
            CheckMaxHeight(root.left, ref max);
        }
    }
}
