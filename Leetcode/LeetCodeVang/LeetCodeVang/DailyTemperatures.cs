using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    public static class DailyTemperatures
    {
        public static void Main(string[] args)
        {
            var test = DailyTemperaturesSol([73, 74, 75, 71, 69, 72, 76, 73]);

            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            Console.ReadLine();
        }

        /*
         * Given an array of integers temperatues that represents the daily temps
         * 
         * Return an array answer such that answer[i] is the number of days
         * you have to wait after ith day to get a warmer temp.
         * 
         * If there is not future day where this is possible 
         * answer[i] == 0 instead.
         * 
         * Examples:
         * [73,74,75,71,69,72,76,73]
         * [1,1,4,2,1,1,0,0]
         * 
         * [30,60,90]
         * [1,1,0]
         * 
         * Constraints:
         * 1 <= temperatures.length <= 10^5
         * 30 <= temperatures[i] <= 100
         */
        public static int[] DailyTemperaturesSol(int[] temperatues)
        {
            int[] results = new int[temperatues.Length];
            Stack<int> stack = new Stack<int>();

            // Go through all temps.
            for(int i = 0; i < temperatues.Length; i++)
            {
                /*
                 * So the stack will make sure we keep checking the temp at the left of the array (first-last)
                 * Also check if at that index (stack.peek) is less than current iteration
                 * If so update the results array.
                 */
                while(stack.Count > 0 && temperatues[stack.Peek()] < temperatues[i])
                {
                    int daysWaiting = i - stack.Peek();

                    results[stack.Pop()] = daysWaiting;
                }
                stack.Push(i);
            }

            return results;
        }
    }
}
