using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCodeVang
{
    public static class TwoSum
    {
        public static void Main(string[] args)
        {
            var answer = TwoSumSolution([2,7,66,67], 9);

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
        }

        // Given an array of int's and a target
        // Return the indecies of two numbers that add up to the target.
        // Assume each input has ONE SOLUTION.
        // Do not use the same element twice.
        // Can return answer in any order.

        /**
         * Constraints:
         * 2 <= nums.length <= 104
         * -109 <= nums[i] <= 109
         * -109 <= target <= 10
         */
        public static int[] TwoSumSolution(int[] nums, int target)
        {
            // Start with a brute force.
            // A nested for loop.
            // We have the outer start.
            // Than the inner can loop through the rest to see if it adds up to the target.
            //for (int i = 0; i < nums.Length; i++) 
            //{
            //    for (int j = i + 1; j < nums.Length; j++) 
            //    {
            //        if ((nums[i] + nums[j]) == target)
            //        {
            //            return [i, j];
            //        }
            //    }
            //}

            //return [6, 7];

            // Now instead what we can do is loop through once.
            // perhaps instead we can use a hash map to store numbers iterated over
            // THEN as we iterate we subract the target from 'i' that would be the number needed to add up to the target
            // Check if there is a key for that. And return that.
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) 
            {
                int numberToCheckInDict = target - nums[i];
                if (keyValuePairs.ContainsKey(numberToCheckInDict))
                    return [keyValuePairs[numberToCheckInDict], i];

                if (!keyValuePairs.ContainsKey(nums[i]))
                keyValuePairs.Add(nums[i], i);
            }

            return [6, 7];
        }
    }
}
