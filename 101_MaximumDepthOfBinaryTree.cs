using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _101_MaximumDepthOfBinaryTree
    {
        public int MaxDepth()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);

            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            int result = 0;

            return result;
        }
    }
}
