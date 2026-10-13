namespace LeetCodeVang
{
    public static class ContainsDuplicate
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world from contains duplicate class!");
        }

        /*
         * Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.
         */
        // Sample input [1,2,3,4,4]

        // Constraints
        // the array length is <= 0 and <= 10 ^ 5
        // and the numbers within the array are -10^9 <= and <= 10^9
        public static bool hasDuplicate(int[] nums)
        {
            // Brute force method iterate through the array once.
            // Then use a nested array to loop through it again.
            // This causes a O(log n) complexity due to the nested for loops.
            //for (int i = 0; i < nums.Length; i++) 
            //{
            //    for(int j = i+1;  j < nums.Length; j++) 
            //    {
            //        if (nums[i] == nums[j])
            //            return true;
            //    }
            //}

            //return false;

            // However we can also use a dictionary (hashmap) to store item within the array as we index through.
            // Then we can refer to this dictionary WHILE WE ITERATE the same array to see if a value is there
            // If a value is there, then thats a duplicate!

            Dictionary<int, bool> duplicatesDictionary = new Dictionary<int, bool>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (duplicatesDictionary.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    duplicatesDictionary.Add(nums[i], true);
                }
            }

            return false;
        }
    }
}
