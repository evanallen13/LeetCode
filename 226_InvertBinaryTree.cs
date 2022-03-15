
using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _226_InvertBinaryTree
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;
            TreeNode right = root.right;
            TreeNode left = root.left;

            root.left = right;
            root.right = left;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }


    }
}
