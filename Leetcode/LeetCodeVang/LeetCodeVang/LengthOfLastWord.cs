using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    public static class LengthOfLastWord
    {
        public static void Main(string[] args) {
            var test = LengthOfLastWordSolution("Today is a nice day");
            Console.WriteLine(test);
        }

        // Given a string s, that consists of words and spaces
        // Return the length of the last word in the string.

        // Constraints:
        // 1 <= s.length <= 10^4
        // s only is english letters and spaces
        // Atleast ONE word in s.

        // Hello World
        // Output: 5, since world is 5 letters long.
        public static int LengthOfLastWordSolution(string s)
        {
            // base case(s)
            if (s.Length == 1)
                return 1;

            // Lets iterate through the string reversed.
            // And store an integer value of highest length of word.
            int length = 0;
            for(int i = s.Length - 1; i>=0; i--)
            {
                if (s[i] == ' ' && length == 0)
                    continue;
                else if (s[i] != ' ')
                    length++;
                else if (s[i] == ' ')
                    break;
            }
            return length;
        }
    }
}
