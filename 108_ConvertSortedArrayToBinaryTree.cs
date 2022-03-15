using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _108_ConvertSortedArrayToBinaryTree
    {

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            TreeNode result = constructTreeFromArray(nums, 0, nums.Length - 1);

            return result;
        }

        public static TreeNode constructTreeFromArray(int[] nums, int left, int right)
        {
            if (left > right) return null;
            int mid = left + (right - left) / 2;

            TreeNode node = new TreeNode(nums[mid]);
            node.left = constructTreeFromArray(nums, left, mid - 1);
            node.right = constructTreeFromArray(nums, mid + 1, right);

            return node;
        }
    }
}
