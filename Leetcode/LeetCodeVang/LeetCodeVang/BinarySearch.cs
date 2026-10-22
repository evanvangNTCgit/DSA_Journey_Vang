using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    public static class BinarySearch
    {
        public static void Main(string[] args)
        {
            var test = Search([-1, 0, 2, 4, 6, 8], 4);
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

            while(min <= max)
            {
                int mid = (min + max) / 2;
                if (nums[mid] < target)
                {
                    min = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    max = mid - 1;
                }
                else if (nums[mid] == target)
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}

/** Practice:
 * 
 * public static int BinarySearch(int[] nums, int target){
 * 
 * int min = 0
 * int max = nums.Length - 1;
 * 
 * while (min <= max){
 * int mid = (min + max) / 2 
 * if(nums[mid] > target){
 * 
 * l = mid - 1
 * 
 * }
 * else if (nums[mid] < target){
 * 
 * r = mid + 1
 * 
 * }
 * else {
 * return mid
 * }
 * }
 * 
 * }
 *  
 */