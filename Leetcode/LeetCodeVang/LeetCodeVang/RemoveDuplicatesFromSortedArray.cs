namespace LeetCodeVang
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static void Main(string[] args)
        {
            var testing = RemoveDuplicates([1,1,2]);
            Console.WriteLine(testing);
        }

        // Given an array of nums. Sorted in a NON-DECREASING ORDER. 
        // Remove dupplicates in-place so that each element only appears once.
        // Relative order of elements remains the same.
        // In-place meaning I operate directly on the same array. No extra space. NO COPY OF THE ARRAY.
        // And return the number of unique elements.
        public static int RemoveDuplicates(int[] nums)
        {
            // Brute force solution
            // Try to now do two loops...
            //Dictionary<int, bool> keyValuePairs = new Dictionary<int, bool>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!keyValuePairs.ContainsKey(nums[i]))
            //        keyValuePairs.Add(nums[i], true);
            //}

            //int index = 0;
            //foreach (var item in keyValuePairs)
            //{
            //    nums[index] = item.Key;
            //    index++;
            //}

            // [1,1,1,2]

            // Nice made it all done in one for loop.
            int uniqueCount = 1;
            int index = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    continue;
                }
                else
                {
                    nums[index] = nums[i + 1];
                    index++;
                    uniqueCount++;
                }
            }

            return uniqueCount;
        }
    }
}
