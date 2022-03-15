using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _104_MaximumDepthOfABinaryTree
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            int result = Math.Min(MaxDepth(root.left), MaxDepth(root.right)) + 1;
            return result;

            //return root == null ? 0 : Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }

    }
}
