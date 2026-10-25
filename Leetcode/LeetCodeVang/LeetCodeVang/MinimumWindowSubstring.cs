namespace LeetCodeVang
{
    public static class MinimumWindowSubstring
    {
        public static void Main(string[] args)
        {
            var test = MinWindow("a", "a");

            Console.WriteLine($"{test} Finished!");
            Console.ReadLine();
        }

        /*
         * Given two strings S & T
         * Return the shortest substring of S 
         * Such that every character in T, including duplicates is present in the string
         * If such a substring does not exist return an empty string
         * 
         * S = OUZODYXAZV T = XYZ
         * Output: YXAZ
         * YXAZ is the shortest sub-string to include XYZ
         * 
         * S = X, T = xy
         * Output: ""
         * No x or y in the string.
         * 
         * constraints 
         * 1 <= s.length <= 100,000
         * 1 <= t.length <= 100,000
         */
        public static string MinWindow(string s, string t)
        {
            if (t.Length > s.Length)
                return "";

            Dictionary<char, int> CharSeenDict = new Dictionary<char, int>();
            Dictionary<char, int> charsRequired = new Dictionary<char, int>();

            // populate the dict. of req. characters
            // These are the characters required and their frequencies
            for (int i = 0; i < t.Length; i++)
            {
                if (charsRequired.ContainsKey(t[i]))
                    charsRequired[t[i]]++;
                else
                    charsRequired.Add(t[i], 1);
            }

            // This is an integer storing the amount of characters satisifed 
            // When we meet the required character and frequency, increment satisfied.
            // Should match the key count in charRequired dictionary
            // meaning the substring met the requirement of having each char in T.
            int satisfied = 0;
            int left = 0;
            string SmallestSbStr = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (charsRequired.ContainsKey(s[i]))
                {
                    // We start left on the first character seen that is required in T.
                    if (CharSeenDict.Count == 0)
                        left = i;
                    char rightC = s[i];

                    bool HaveSeenThisRequiredChar = CharSeenDict.ContainsKey(rightC);
                    if (!HaveSeenThisRequiredChar)
                    {
                        CharSeenDict.Add(rightC, 1);
                    }
                    else
                    {
                        CharSeenDict[rightC]++;
                    }

                    /*
                     * So for EX. We found the 2 T's in S that was required in T.
                     */
                    bool MeetFrequencyRequirementForRequiredChar = CharSeenDict[rightC] == charsRequired[rightC];
                    if (MeetFrequencyRequirementForRequiredChar)
                    {
                        satisfied++;
                    }

                    // Checking if we exceed the frequency requirement for a character
                    // Or the character on the left is not in T.
                    bool CanIncrementLeft = !charsRequired.ContainsKey(s[left]) || CharSeenDict[s[left]] > charsRequired[s[left]];
                    while (CanIncrementLeft)
                    {
                        // So we do have more than enough of a required char from T.
                        bool ExceedCharFrequency = charsRequired.ContainsKey(s[left]) && CharSeenDict[s[left]] > charsRequired[s[left]];
                        if (ExceedCharFrequency)
                        {
                            CharSeenDict[s[left]]--;
                        }

                        left++;

                        // Is s at left index required for a new substring?
                        // It is if we do not exceed the required frequency for that character.
                        bool NotExceedRequiredCharFrequency = charsRequired.ContainsKey(s[left]) && CharSeenDict[s[left]] <= charsRequired[s[left]];
                        if (NotExceedRequiredCharFrequency)
                        {
                            // Now left starts at the required char for the next substring.
                            break;
                        }
                    }

                    if (satisfied == charsRequired.Count)
                    {
                        string subStr = s.Substring(left, (i + 1) - left);
                        SmallestSbStr = subStr.Length < SmallestSbStr.Length || SmallestSbStr == "" ? subStr : SmallestSbStr;
                    }
                }
            }
            return SmallestSbStr;
        }

        // From reading a leetcode solution
        //public static string MinWindow(string s, string t)
        //{
        //    if (s.Length < t.Length)
        //        return "";

        //    Dictionary<char, int> dict = new Dictionary<char, int>();
        //    for (int i = 0; i < t.Length; i++)
        //    {
        //        if (dict.ContainsKey(t[i]))
        //            dict[t[i]]++;
        //        else
        //            dict.Add(t[i], 1);
        //    }

        //    int r = 0;
        //    int l = 0;
        //    int count = 0;
        //    int res = int.MaxValue;
        //    int minl = 0;
        //    int minr = -1;

        //    while(r < s.Length)
        //    {
        //        char charR = s[r];

        //        if (dict.ContainsKey(charR))
        //        {
        //            dict[charR]--;
        //            if (dict[charR] == 0)
        //            {
        //                count++;
        //            }
        //        }

        //        while(count == dict.Count)
        //        {
        //            if(res > (r - l + 1))
        //            {
        //                res = (r - l + 1);
        //                minl = l;
        //                minr = r;
        //            }

        //            char val = s[l];
        //            if (dict.ContainsKey(val))
        //            {
        //                if (dict[val] == 0)
        //                {
        //                    count--;
        //                }
        //                dict[val]++;
        //            }
        //            l++;
        //        }

        //        r++;
        //    }

        //    return minr == -1 ? "" : s.Substring(minl, (minr + 1) - minl);
        //}
    }
}
