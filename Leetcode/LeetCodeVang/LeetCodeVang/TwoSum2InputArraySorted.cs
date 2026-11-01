namespace LeetCodeVang
{
    public static class TwoSum2InputArraySorted
    {
        public static void Main(string[] args)
        {

        }

        /*
         * Given a 1-Indexed array of numbers already sorted in non-decreasing order
         * Find two numbers taht add up to a specific target number.
         * 
         * Return the indicies of the two numbers index1 & index2 as an integer array
         * [index1, index2]
         * CANNOT USE THE SAME ELEMENT TWICE
         * CONSTANT SPACE
         * 
         * Examples:
         * [2,7,11,5] target = 9
         * [1,2] (2,7 equal 9, also remember ONE indexed)
         * 
         * [2,3,4] target = 6
         * [1,3] (2,4 equal 6, also ONE indexed)
         * 
         * ALL TESTS HAVE ONE SOLUTION
         */
        public static int[] TwoSum(int[] numbers, int target)
        {
            // [1,2,3,7] target = 5

            int l = 0;
            int r = numbers.Length - 1;

            while (l < r)
            {
                int leftRightSum = numbers[l] + numbers[r];

                if(leftRightSum < target)
                {
                    l++;
                }
                else if (leftRightSum > target)
                {
                    r--;
                }
                else if (leftRightSum == target)
                {
                    return [l + 1, r + 1];
                }
            }

            return [-1, -1];
        }
    }
}
