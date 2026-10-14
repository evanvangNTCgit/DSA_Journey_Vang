using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    public static class CountMonobitInteger
    {
        public static void Main(string[] args) 
        {
            CountMonobit(1);
        }

        // Given N
        // Count return the count of monobit integers in a range of 0-n
        public static int CountMonobit(int n)
        {
            /**
             * Solution below worked.
             * However seems to be very unoptimized.
             * I suspect that the issue is casting the integer to a string.
             */
            int monobitCount = 0;

            for (int i = 0; i <= n; i++)
            {
                string binary = Convert.ToString(i, 2);

                var hashSet = binary.ToHashSet();
                if (hashSet.Count == 1)
                {
                    monobitCount++;
                }
            }

            return monobitCount;
        }
    }
}
