using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class _501_FineModeInBinarySearchTree
    {
        public static int[] FindMode(TreeNode root)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> result = new List<int>();
            returnMode(root, ref dict);

            if (dict.Count == 0) return new int[] { };
            int max = dict.Values.Max();
            return dict.Where(x => x.Value == max).Select(x => x.Key).ToArray();
        }


        private static void returnMode(TreeNode root, ref Dictionary<int, int> dict)
        {
            if (root == null) return;
            int val = root.val;
            try
            {
                dict.Add(val, 1);
            }
            catch (ArgumentException)
            {
                dict[val] = dict[val] + 1;
            }


            returnMode(root.left, ref dict);
            returnMode(root.right, ref dict);
        }
    }
}
