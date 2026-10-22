namespace LeetCodeVang
{
    public static class LongestRepeatingCharReplacement
    {
        public static void Main(string[] args)
        {
            var test = CharacterReplacement("ABAA", 0);
            Console.WriteLine(test);
            Console.ReadLine();
        }

        /*
         * Given a string S consisting of ONLY UPPERCASE ENGLISH LETTERS
         * Along with an integer K
         * 
         * You are allowed to choose up to K integers and replace them with any uppercase english letter
         * After performing replacements return the lenght of longest substring with only one distinct character.
         * 
         * Input: s = "XYYX" k = 2
         * output 4, since you can replace both Y's for X.
         */
        public static int CharacterReplacement(string s, int k)
        {
            // base case(s)
            if (s.Length == 1)
                return s.Length;

            int ws = 0;

            // Dictionary of the unique characters seen.
            Dictionary<char, int> charsDict = new Dictionary<char, int>();
            int currLongest = 0;
            int maxFrequency = 0;
            int uniqueFrequency = 0;

            // ABBACDA k=1
            for (int i = 0; i < s.Length; i++)
            {
                // Idea
                /*
                 * Use a while loop for resetting window start
                 * The dictionary should instead hold the char and the frequency in the window
                 * 
                 * When resizing (no more chars can replace), remove from the frequency in the array, if its 0 remove from dict
                 * After removing form dict. Then you can start the window at a new index.
                 */
                if (charsDict.ContainsKey(s[i]))
                {
                    charsDict[s[i]]++;
                    maxFrequency = charsDict[s[i]] > maxFrequency ? charsDict[s[i]] : maxFrequency;
                }
                else
                {
                    charsDict.Add(s[i], 1);
                    maxFrequency = charsDict[s[i]] > maxFrequency ? charsDict[s[i]] : maxFrequency;
                }
                uniqueFrequency = ((i + 1) - ws) - maxFrequency;

                // Now we may have to move sliding window...
                while (uniqueFrequency > k)
                {
                    if (charsDict[s[ws]] - 1 == 0)
                        charsDict.Remove(s[ws]);
                    else
                        charsDict[s[ws]]--;
                    ws++;

                    uniqueFrequency = ((i + 1) - ws) - maxFrequency;
                }

                currLongest = (i + 1) - ws > currLongest ? (i + 1) - ws : currLongest;

            }

            return currLongest;
        }
    }
}
