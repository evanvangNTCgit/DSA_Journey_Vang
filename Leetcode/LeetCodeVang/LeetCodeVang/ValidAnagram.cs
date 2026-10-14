namespace LeetCodeVang
{
    public static class ValidAnagram
    {
        public static void Main(string[] args)
        {
            var test = IsAnagram("jar", "jam");
            Console.WriteLine(test);
        }

        // Given two strings s and t
        // Return true if they are anagrams, otherwise false.
        // Anagrams meaning, both strings contain the same characters the same amount of times
        // bat and tab ==> true, bat and cat ==> false

        // I think my initial thoughts are to use a dictionary.
        // The dictionary shall store the character and amount of times it appears in one of the strings.

        /*
         * The time complexity for this is O(N+M) 
         * Since this algorithm will entirely depend on the length of strings passed in between S and T
         */
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(s[i]))
                {
                    keyValuePairs.Add(s[i], 1);
                }
                // Does already have the character.
                else
                {
                    keyValuePairs[s[i]] = keyValuePairs[s[i]] + 1;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!keyValuePairs.TryGetValue(t[i], out int value))
                {
                    return false;
                }
                // Was seen in string s as well.
                else
                {
                    /*
                     * If seen in dictionary and value more than 1 decrement from it.
                     * And seen with just 1 remove from dictionary entirely.
                     */
                    if(value == 1)
                    {
                        keyValuePairs.Remove(t[i]);
                    } 
                    else
                    {
                        keyValuePairs[t[i]] = keyValuePairs[t[i]] - 1;
                    }
                }
            }

            return keyValuePairs.Keys.Count == 0;
        }
    }
}
