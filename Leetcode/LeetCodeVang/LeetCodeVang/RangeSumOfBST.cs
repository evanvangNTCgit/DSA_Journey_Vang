namespace LeetCodeVang
{
    public static class RangeSumOfBST
    {
        public static void Main(string[] args)
        {
        }
        /*
         * You are given the root node of a binary search tree and two integers low and high, 
         * return the sum of values of all nodes with a value in the inclusive range [low, high].
         */
        public static int RangeSumBST(TreeNode root, int low, int high)
        {
            int sum = 0;
            void traverseRoute(TreeNode node)
            {
                if (node is null) return;
                else if (node.val >= low && node.val <= high) sum += node.val;
                if (node.val > low)
                    traverseRoute(node.left);

                if (node.val < high)
                    traverseRoute(node.right);
            }
            traverseRoute(root);
            return sum;
        }

        // Class definition.
        //public class TreeNode
        //{
        //    public int val;
        //    public TreeNode left;
        //    public TreeNode right;
        //    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        //    {
        //        this.val = val;
        //        this.left = left;
        //        this.right = right;
        //    }
        //}
    }
}
