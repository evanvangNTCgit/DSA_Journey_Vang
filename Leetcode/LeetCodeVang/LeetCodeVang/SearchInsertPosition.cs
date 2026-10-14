namespace LeetCodeVang
{
    public static class SearchInsertPosition
    {
        public static void Main(string[] args)
        {
            var test = SearchInsert([1,3,5,6], 0);
            Console.WriteLine(test);
        }

        // Given a sorted array of distinct integers. With a target value.
        // Return the index if the target is found.
        // If not return index of where it would be if inserted at correct order.
        public static int SearchInsert(int[] nums, int target)
        {
            // Base case(s)
            if (nums.Length <= 0)
                return 0;
            if (nums[0] > target)
                return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    // Target here return index.
                    return i;
                }
                else if ((i + 1) == nums.Length)
                {
                    // if at the end of array and still not found...
                    // Return the index of if it were appended.
                    return i + 1;
                }
                else if (nums[i + 1] > target)
                {
                    // Target not here but if it was it would be here.
                    return i + 1;
                }
            }

            return -1;
        }
        /*
         * Very nice I got it on almost the first shot
         * I for got to return i + 1 on the last else if.
         * As well as account for if the first number in the array is bigger than the target.
         */
    }
}
