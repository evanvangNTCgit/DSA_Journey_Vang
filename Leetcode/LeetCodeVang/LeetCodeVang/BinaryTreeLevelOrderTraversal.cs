namespace LeetCodeVang
{
    public static class BinaryTreeLevelOrderTraversal
    {
        public static void Main(string[] args)
        {
            TreeNode root5 = new TreeNode(5);
            TreeNode root4 = new TreeNode(4);
            TreeNode root2 = new TreeNode(2, root4, root5);

            TreeNode root6 = new TreeNode(6);
            TreeNode root7 = new TreeNode(7);
            TreeNode root3 = new TreeNode(3, root6, root7);

            TreeNode root = new TreeNode(1, root2, root3);

            var test = LevelOrder(root);
            Console.ReadLine();
        }

        /*
         * GIven a binary tree root, return the level order traversal
         * of it as a nested list,
         * Eash sublist containts the values of nodes at a particular level.
         * From left to right.
         * 
         * [1,2,3,4,5,6,7]
         * output: [[1],[2,3],[4,5,6,7]]
         * 
         * Constraints:
         * 0 <= The number of nodes in the tree <= 2000
         */
        public static List<List<int>> LevelOrder(TreeNode root)
        {
            if (root is null)
                return new List<List<int>>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            List<List<int>> Levels = new List<List<int>>();

            while (queue.Count > 0)
            {
                // Only go through the current level so..
                int levelCount = queue.Count;

                // Values at this level...
                List<int> subLevel = new List<int>();

                while (levelCount > 0)
                {
                    TreeNode node = queue.Dequeue();

                    subLevel.Add(node.val);

                    if (node.left is not null)
                        queue.Enqueue(node.left);
                    if (node.right is not null)
                        queue.Enqueue(node.right);

                    levelCount--;
                }
                Levels.Add(subLevel);
            }

            return Levels;

            // This solution worked... I want a better memory percentage.
            //// Setting up the queue of nodes to loop through.
            //Queue<TreeNode> queue = new Queue<TreeNode>();
            //queue.Enqueue(root);

            //// List to return:
            //List<List<int>> Levels = new List<List<int>>();

            //while (queue.Count > 0)
            //{
            //    Queue<TreeNode> whatToAddAfter = new Queue<TreeNode>();
            //    List<int> subLevel = new List<int>();

            //    while (queue.Count > 0)
            //    {
            //        TreeNode node = queue.Dequeue();

            //        subLevel.Add(node.val);

            //        if (node.left is not null)
            //            whatToAddAfter.Enqueue(node.left);
            //        if (node.right is not null)
            //            whatToAddAfter.Enqueue(node.right);
            //    }

            //    Levels.Add(subLevel);
            //    queue = whatToAddAfter;
            //}
            //return Levels;
        }

        // Class definition for problem.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
