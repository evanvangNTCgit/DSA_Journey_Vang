namespace LeetCodeVang
{
    public static class InsertIntoABinarySearchTree
    {
        /*
         * Given the root of a BST
         * And a value val to insert into the tree
         * 
         * Return the root of the BST after insertion.
         * It is GUARANTEED that th new value does not exist in the root tree alr.
         * 
         * Super proud of this solution even though it is bottom 5 percent in run time.
         * This problem looked harder and I solved it with no hints.
         */
        public static TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root is null)
                return new TreeNode(val);
            TreeNode pointer = root;
            while (true)
            {
                if (pointer.val < val)
                {
                    if (pointer.right is null)
                    {
                        pointer.right = new TreeNode(val);
                        return root;
                    }

                    pointer = pointer.right;
                }
                if (pointer.val > val)
                {
                    if (pointer.left is null)
                    {
                        pointer.left = new TreeNode(val);
                        return root;
                    }
                    pointer = pointer.left;
                }
            }
        }
    }
}
