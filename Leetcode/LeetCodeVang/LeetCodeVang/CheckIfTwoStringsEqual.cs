using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace LeetCodeVang
{
    public static class CheckIfTwoStringsEqual
    {
        public static void Main(string[] args)
        {
            string[] word1 = { "a"};
            string[] word2 = { "a", "b" };
            var test = ArrayStringsAreEqual(word1, word2);
            Console.WriteLine(test);
        }

        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            // Pointers for where you are at in the array
            int word1Pointer = 0;
            int word2Pointer = 0;

            // Two pointers for the two strings as you iterate.
            int left = 0;
            int right = 0;

            while(word1Pointer < word1.Length)
            {
                left = 0;
                string leftWord = word1[word1Pointer];

                string rightWord = word2[word2Pointer];

                for (int i = 0; i < leftWord.Length; i++)
                {
                    bool rightNeedsToIncrement = right >= rightWord.Length;
                    if (rightNeedsToIncrement)
                    {
                        // Check if it CAN increment.
                        bool canIncrement = word2Pointer + 1 < word2.Length;
                        if (canIncrement)
                        {
                            word2Pointer++;
                            right = 0;
                            rightWord = word2[word2Pointer];
                        }
                        else
                        {
                            return false;
                        }
                    }

                    if (leftWord[left] != rightWord[right])
                    {
                        return false;
                    }
                    else
                    {
                        left++;
                        right++;
                    }
                }

                // Increment word1pointer for next loop.
                word1Pointer++;
            }

            // If at the end of the last word in word1
            // last word in word2 still had chars to iterate through
            // That means word2 had more chars.
            if (right < word2[word2Pointer].Length || word2Pointer < word2.Length - 1)
                return false;

            return true;
        }
    }
}
