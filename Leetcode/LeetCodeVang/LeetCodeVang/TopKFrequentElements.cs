namespace LeetCodeVang
{

    /*
     * Hello future self, and anybody checking this github.
     * 
     * This is a solution I am super proud of it took me two nights to solve this question.
     * The only hints I took was that it could be done with a multidimensional array. To maintain an O(n) runtime.
     * As well as using a bucket sort, though I do not see much sorting going on haha, just storing it at frequency columns along with the numbers.
     */
    public static class TopKFrequentElements
    {
        public static void Main(string[] args)
        {
            var test = TopKFrequent([1, 1, 1, 2, 2, 3], 2);
            Console.WriteLine(test);
        }

        // Given an integer array and an integer
        // Return the (k) most frequent elements within the array.

        /*
         * Stumped me a bit too, k mean top specified most frequent numbers
         * So it returned the top two numbers in the array.
         */
        // Nums = [1,2,2,3,3,3], k = 2
        // Output = [2,3]
        public static int[] TopKFrequent(int[] nums, int k)
        {
            // int[,] frequencyArray = new int[nums.Length + 1, (nums[nums.Length - 1] + 1)];

            // An array of lists of integers
            List<int>[] frequencyArray = new List<int>[nums.Length + 1];
            int[] topMostArray = new int[k];

            // Key: Represents the number in the nums array. All unique keys so no accidental counting.
            // Value: Represends occurance in the nums array.
            Dictionary<int, int> occuranceDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                /*
                 * The occurance dictionary will help determine where to put number at.
                 * Within the frequency array.
                 * Will store number at the index determined by the frequency.
                 */
                if (occuranceDict.TryGetValue(nums[i], out int value))
                {
                    value = value + 1;
                    occuranceDict[nums[i]] = value;

                    // frequencyArray[value, nums[i]] = nums[i];
                }
                else
                {
                    occuranceDict.Add(nums[i], 1);

                    // frequencyArray[1, nums[i]] = nums[i];
                }
            }

            foreach (KeyValuePair<int,int> kvp in occuranceDict)
            {
                if (frequencyArray[kvp.Value] == null)
                    frequencyArray[kvp.Value] = new List<int> { kvp.Key };
                else
                    frequencyArray[kvp.Value].Add(kvp.Key);
            }

            /*
             * Now to loop through the frequency array.
             * We go backwards (most to least frequency)
             * Then decrement from amount to add
             */
            // This is so the last for loop know what index to add at in topmost array
            // So we do not overwrite previous values.
            int indexToAddAt = 0;
            int amountToAdd = k; // To decrement as we add to the topmost array.
            for (int i = (nums.Length); i >= 0; i--)
            {
                if (amountToAdd <= 0)
                    break;
                if (frequencyArray[i] == null || frequencyArray[i].Count < 1)
                    continue;

                if (frequencyArray[i].Count == k && amountToAdd == k)
                    return frequencyArray[i].ToArray();
                else
                {
                    for(int j = 0; j < frequencyArray[i].Count; j++)
                    {
                        if (amountToAdd <= 0)
                            return topMostArray;

                        topMostArray[indexToAddAt] = frequencyArray[i][j];
                        indexToAddAt++;
                        amountToAdd--;
                    }
                }
            }

            return topMostArray;
        }
    }
}
