using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    public static class BinarySearch
    {
        public static void Main(string[] args)
        {
            var test = Search([-1, 0, 2, 4, 6, 8], 8);
            Console.WriteLine(test);
            Console.ReadLine();
        }

        /*
         * Given an array of distinct integers, sorted in ascending order
         * And a target
         * Implment a function that returns index of target, or -1.
         */

        // [-1,0,2,4,6,8]
        public static int Search(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
        }
    }
}
