using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    public static class Diameter_of_Binary_Tree
    {
        public static void Main(string[] args)
        {
        }

        public static int DiameterOfBinaryTree(TreeNode root)
        {
            int res = 0;
            DFS(root, ref res);
            return res;
        }

        // Helper DFS function
        public static int DFS(TreeNode root, ref int res)
        {
            if (root == null)
            {
                return 0;
            }
            int left = DFS(root.left, ref res);
            int right = DFS(root.right, ref res);
            res = Math.Max(res, left + right);
            return 1 + Math.Max(left, right);
        }

        // Class Definition:
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
