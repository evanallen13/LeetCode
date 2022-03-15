using LeetCode.DataStuctures;

namespace LeetCode.Questions
{
    class _108_ConvertToTree
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return Convert(nums, 0, nums.Length - 1);
        }

        public static TreeNode Convert(int[] nums, int l, int r)
        {
            if (l > r) return null;

            int m = l + (r - l) / 2;
            int val = nums[m];

            TreeNode node = new TreeNode(val);


            // Left
            node.left = Convert(nums, l, m - 1);
            // Right 
            node.right = Convert(nums, m + 1, r);

            return node;
        }

    }
}


