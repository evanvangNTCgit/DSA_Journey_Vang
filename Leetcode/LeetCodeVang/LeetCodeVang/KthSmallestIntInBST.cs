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
            PriorityQueue<int, int> pQ = new PriorityQueue<int, int>();

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while(q.Count > 0) 
            {
                TreeNode node = q.Dequeue();

                pQ.Enqueue(node.val, node.val);

                if(node.left is not null)
                    q.Enqueue(node.left);
                if (node.right is not null)
                    q.Enqueue(node.right);
            }

            // Now to get the Kth smallest value.
            for(int i = 1;  i <= k; i++)
            {
                if(i == k)
                {
                    return pQ.Dequeue();
                }
                pQ.Dequeue();
            }

            return -1;
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
