using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace LeetCodeVang
{
    public static class BestTimeToBuyAndSellStock
    {
        public static void Main(string[] args)
        {
            var test = MaxProfit([1,2,0]);
            Console.WriteLine(test);
            Console.ReadLine();
        }

        /*
         * Given an array of prices where prices[i] is the price of 'neetcoin' On the i'th day 
         * Choose a single day to buy one neet coin and a different day IN THE FUTURE to sell it
         * Return maximum profit achievable
         * Choice of no profit is possible which would be 0
         * 
         * Contraints:
         * 1 <= prices.length <= 100
         * 0 <= prices[i] <= 100
         * 
         * Input: prices = [10,8,7,5,2]
         * output 0, there is no profitable day
         * 
         * prices = [10,1,5,6,7,1]
         * output 6, buy on [1] or 1 and sell on [4] or 7
         */
        public static int MaxProfit(int[] prices)
        {
            //// base case(s)
            //if (prices.Length == 1)
            //    return 0;

            //// First we start at first index.
            //// Then keep slowly going up.

            //// Once we find a number lowest than currently start of slide window slide it to their.

            //int maxProfit = 0;

            //int windowStart = 0;
            //int windowEnd = 1;
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    if (prices[windowStart] > prices[i])
            //    {
            //        windowStart = i;
            //        windowEnd = windowStart + 1;
            //    } else
            //    {
            //        int profit = prices[windowEnd] - prices[windowStart];
            //        maxProfit = profit > maxProfit ? profit : maxProfit;

            //        if(windowEnd + 1 < prices.Length)
            //        windowEnd++;
            //    }
            //}

            //return maxProfit;

            // The improved version I saw on leet code:
            // base case(s)
            if (prices.Length == 1)
                return 0;

            int minPrice = int.MaxValue;

            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }

                if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;
        }

        /*
         * Sliding window learning.
         * Sliding window is a technique used to solve problems that involve subarray, substring, or window.
         * 
         * Instead of repeatedly iterating over the same elements,
         * use a sliding window that maintains a range (or window)
         * This window moves step by step through the data, updating results incrementally
         * 
         * Idea is to use results of the previous window to do computations for the next window.
         */
    }
}
