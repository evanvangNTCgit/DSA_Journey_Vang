namespace LeetCodeVang
{
    public static class PermutationInString
    {
        public static void Main(string[] args)
        {
            CheckInclusion("adc", "dcda");
         }

        /*
         * Given two strings s1 and s2
         * Reutnr true if s2 contains a permutation of s1
         * False otherisw
         * 
         * Input s1 = 'abc', s2 = 'lecabee'
         * True
         * Notice how cab is a permutation of abc
         * 
         * Input s1 = 'abc', s2 = 'lecaabee'
         * False
         */
        public static bool CheckInclusion(string s1, string s2)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (charFrequency.ContainsKey(s1[i]))
                    charFrequency[s1[i]]++;
                else
                    charFrequency.Add(s1[i], 1);
            }

            // Once we see a char that s1 has we can start the window there.
            // As we mvoe up s2, check if it is within s1...
            int windowStart = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                // Add 1 to i to account for length starting at 1.
                if (((i + 1) - windowStart) == s1.Length)
                {
                    // Check if this is a permutation.
                    Dictionary<char, int> permuation = new Dictionary<char, int>();
                    for (int j = 0; j < s1.Length; j++)
                    {
                        if (permuation.ContainsKey(s2[(windowStart + j)]))
                            permuation[s2[(windowStart + j)]]++;
                        else
                            permuation.Add(s2[(windowStart + j)], 1);
                    }

                    if (charFrequency.OrderBy(kvp => kvp.Key).SequenceEqual(permuation.OrderBy(per => per.Key)))
                        return true;
                }

                // Must increment window.
                if (!s1.Contains(s2[i]))
                {
                    if (i + 1 < s2.Length)
                        windowStart = i + 1;
                }
                if (((i + 1) - windowStart) == s1.Length)
                {
                    windowStart++;
                }
            }
            return false;
        }
    }
}
