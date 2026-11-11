using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    public static class BinaryTreeInorderTraversal
    {
        public static void Main(string[] args)
        {

        }

        public static List<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();

            void inorder(TreeNode node)
            {
                if (node is null) return;
                inorder(node.left);
                list.Add(node.val);
                inorder(node.right);
            }
            inorder(root);

            return list;
        }



        // Class definition:
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
