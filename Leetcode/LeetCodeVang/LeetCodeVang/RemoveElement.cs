namespace LeetCodeVang
{
    public static class RemoveElement
    {
        public static void Main(string[] args)
        {

        }

        // Given an integer array and an integer value.
        // Remove all occurences of the value in nums IN-PLACE.
        // Order of elements may be changed. 
        // Then return the number of elements not equal to provided value.

        // Also need to sort the ones that do not equal value to the top.
        // Val=2 [3,2,2,3,4] ==> [3,3,4,_,_]
        // Nice did it in one shot!
        public static int RemoveElementSolution(int[] nums, int val)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            return index;
        }
    }
}
