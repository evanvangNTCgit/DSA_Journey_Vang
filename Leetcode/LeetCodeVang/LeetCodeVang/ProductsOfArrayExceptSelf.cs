namespace LeetCodeVang
{
    public static class ProductsOfArrayExceptSelf
    {
        public static void Main(string[] args)
        {
            var test = ProductExceptSelf([1, 2, 4, 6]);

            Console.WriteLine(test);
        }

        /*
         * Given an array of integers,
         * return an array where ouput[i] is the product of all elmenets of nums EXCEPT nums[i]
         * 
         * Input: nums = [1,2,4,6]
         * Ouput: [48,24,12,8]
         * 
         * Essentially for every number in nums you multiply it by every number in the array
         * BESIDES IT SELF
         * 1 * 2 = 2, 2 * 4 = 8, 8 * 6 = 48, hence 48 is first in the output array.
         * 
         * Contraints:
         * 2 <= nums.length <= 100,000
         * -30 <= nums[i] <= 30
         * ALL PRODUCTS A GUARANTEED TO FIT IN 32-BIT INTEGER.
         */
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] productsToReturn = new int[n];

            productsToReturn[0] = 1;
            for (int i = 1; i < n; i++)
            {
                productsToReturn[i] = productsToReturn[i - 1] * nums[i - 1];
            }

            int rightProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                productsToReturn[i] *= rightProduct;
                rightProduct *= nums[i];
            }

            return productsToReturn;
        }

        /*
         * Pre-fix sums analysis
         * 
         * Prefix-sum, a pattern commonly used in algorithms to solve problems invovling subarrays, sums, and ranges.
         * Allows you to preprocess an array then quickly calculate the sum of elements in any subarray 
         * Or find specific patterns such as balanced subarrays.
         * Useful in problems where you calculate sums repeatedly over different ranges of an array.
         * 
         * Can be used with hashmaps as well.
         * This allows for faster lookups.
         * Hashmap can store the first occurance of each prefix sum
         * Helping determin whether a subarray wiht a particula sum exists quickly.
         * 
         * 
         */
    }
}
