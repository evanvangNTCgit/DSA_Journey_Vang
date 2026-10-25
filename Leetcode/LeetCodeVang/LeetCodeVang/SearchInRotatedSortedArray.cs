namespace LeetCodeVang
{
    public static class SearchInRotatedSortedArray
    {
        public static void Main(string[] args)
        {
            var test = Search([5,1,3], 3);

            Console.WriteLine(test);
        }

        /*
         * Given an array of length N, which was originally soted in ascending order
         * But has now been rotated between 1 to n times.
         * Return the index of the provided target integer.
         * 
         * [3,4,5,6,1,2] was rotated 4 tiems
         * [1,2,3,4,5,6] was rotated 6 or 0 times
         * 
         * Constraints:
         * 1 <= nums.length <= 1000
         * -1000 <= nums[i] <= 1000
         * -1000 <= target <= 1000
         * All values in nums are unique.
         */
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int pivot = (left + right) / 2;

                if (nums[pivot] == target)
                {
                    return pivot;
                }
                // Checking the left half of the binary search if it has the target.
                else if (nums[left] <= nums[pivot])
                {
                    /*
                     * Is the target on left or less? 
                     * And the target is less than our pivot. 
                     * That means we clear out this right side.
                     */
                    if (nums[left] <= target && target < nums[pivot])
                    {
                        right = pivot - 1;
                    }
                    // Otherwise, that means its not on the left side of our binary search.
                    else
                    {
                        left = pivot + 1;
                    }
                }
                // Checking the right side
                else
                {
                    /*
                     * Is the target more than our pivot?
                     * Is it also less than whats on the right?
                     * That means this left side can be cleared out.
                     */
                    if (nums[pivot] < target && target <= nums[right])
                    {
                        left = pivot + 1;
                    }
                    // Other wise this means the target is actually on the left side still.
                    else
                    {
                        right = pivot - 1;
                    }
                }
            }
            return -1;
        }
    }
}
