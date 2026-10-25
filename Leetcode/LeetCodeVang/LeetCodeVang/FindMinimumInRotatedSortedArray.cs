namespace LeetCodeVang
{
    public static class FindMinimumInRotatedSortedArray
    {
        public static void Main(string[] args)
        {
            var test = FindMin([4, 5, 6, 7]);
            Console.WriteLine(test);
        }

        /*
         * Given an array of length nums that was originally sorted in ascending order
         * But has now been rotated between 1 and N times.
         * Return the minimum element in the sorted array.
         * 
         * Constraints:
         * 1 <= nums.length <= 1000
         * -1000 <= nums[i] <= 1000
         * 
         * nums = [3,4,5,6,1,2] <- was roteated 4 times
         * output: 1.
         */
        public static int FindMin(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            // Get how much it was rotated by.
            int rotated = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 < nums.Length && nums[i] > nums[i + 1])
                {
                    rotated = i + 1;
                    break;
                }
            }

            // Well if rotating means the last however many start on the left
            // We can start the search on the left
            return nums[rotated];
        }
    }
}
