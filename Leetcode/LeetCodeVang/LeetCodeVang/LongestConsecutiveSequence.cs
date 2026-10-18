namespace LeetCodeVang
{
    public static class LongestConsecutiveSequence
    {
        public static void Main(string[] args)
        {
            // Should be 7
            var test = LongestConsecutive([2, 20, 4, 10, 3, 4, 5]);
            Console.WriteLine(test);
        }

        /*
         * Given an array of integers,
         * Return the length of the longest consecutive sequence of elements that can be formed
         * Consec. Seq. meaning a seq. of elements in which each element-
         * is exactly 1 greater than the previous element
         * The elements do not have to be consecutive in the original array.
         * 
         * MUST BE O(N) TIME COMPLEXITY
         * 
         * Nums = [2,20,4,10,3,4,5]
         * Output: 4
         * So notice the longest sequence is 2,3,4,5
         * 
         * Constraints: 
         * 0 <= nums.length <= 100,000
         * -10^9 <= nums[i] <= 10^9
         */
        public static int LongestConsecutive(int[] nums)
        {
            // Base case(s)
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;

            // To maintain O(1) look up when counting up sequence(s)
            var hashSet = nums.ToHashSet();
            var hashsetToCount = nums.ToHashSet();

            // To filter out numbers we do not need to sort with check if each number already had a number behind it.
            for(int i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i] - 1))
                {
                    hashsetToCount.Remove(nums[i]);
                }
            }

            int currSeq = 1;
            int topSeq = 1;
            foreach (int number in hashsetToCount)
            {
                int numberToFind = number + 1;
                while (hashSet.Contains(numberToFind))
                {
                    currSeq++;
                    numberToFind++;
                }
                topSeq = currSeq > topSeq ? currSeq : topSeq;

                // Now reset the seq.
                currSeq = 1;
            }

            return topSeq;
        }
    }
}
