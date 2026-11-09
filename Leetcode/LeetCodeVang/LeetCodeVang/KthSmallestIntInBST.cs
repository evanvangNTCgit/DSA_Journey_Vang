using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    public static class KthSmallestIntInBST
    {
        public static void Main(string[] args)
        {
        }

        /*
         * Given the root of a binary search tree,
         * And an integer
         * Return the Kth smallest value (1-indexed)
         * 
         * root = [4,3,5,2,null], k = 4
         * output: 5
         * 
         * root = [2,1,3], k = 1
         * output: 1
         */
        public static int KthSmallest(TreeNode root, int k)
        {
            // DFS solution:
            // A BST is inorder traversion so (left -> node -> right) so its narually sorted.
            // So we can traverse the tree inorder, count nodes as we visit them.
            // And stop as soon as we visit Kth smallest node.
            int[] tmp = new int[2];
            tmp[0] = k;
            DFS(root, tmp);
            return tmp[1];
        }

        // DFS helper function
        private static void DFS(TreeNode node, int[] tmp)
        {
            if (node is null) return;

            DFS(node.left, tmp);
            if (tmp[0] == 0) return;

            tmp[0]--;
            if (tmp[0] == 0)
            {
                tmp[1] = node.val;
                return;
            }

            DFS(node.right, tmp);
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
