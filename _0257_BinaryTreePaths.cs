using System;
using System.Collections.Generic;
using LeetCode.DataStuctures;

namespace LeetCode.Questions
{
    class _0257_BinaryTreePaths
    {
        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> result = new List<string>();
            if(root == null) return result;

            string curr_path = root.val.ToString();
            // Deep first search
            if(root.left == null && root.right == null) 
                result.Add(curr_path);
            
            if(root.left != null)
                dfs(root.left, curr_path, ref result);

            if(root.right != null)
                dfs(root.right, curr_path, ref result);

            return result;
        }

        public static void dfs(TreeNode node, string curr_path,ref List<string> result){

            curr_path += $"->{node.val}";

            if(node.left == null && node.right == null){
                result.Add(curr_path);
                return;
            }

             if(node.left != null)
                dfs(node.left, curr_path, ref result);

            if(node.right != null)
                dfs(node.right, curr_path, ref result);

        }
    }
}
