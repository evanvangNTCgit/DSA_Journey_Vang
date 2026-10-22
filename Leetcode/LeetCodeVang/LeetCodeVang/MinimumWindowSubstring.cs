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

            Dictionary<char, int> charsDict = new Dictionary<char, int>();
            Dictionary<char, int> charsReq = new Dictionary<char, int>();

            // populate the dict. of req. characters
            for (int i = 0; i < t.Length; i++)
            {
                if (charsReq.ContainsKey(t[i]))
                    charsReq[t[i]]++;
                else
                    charsReq.Add(t[i], 1);
            }

            int left = 0;
            int satisfied = 0;
            string currSmallestSbStr = "";
            // ADOBECODEBANC
            // ABC
            for (int i = 0; i < s.Length; i++)
            {
                if (charsReq.ContainsKey(s[i]))
                {
                    if (charsDict.Count == 0)
                        left = i;
                    char rightC = s[i];
                    if (!charsDict.ContainsKey(rightC))
                    {
                        charsDict.Add(rightC, 1);
                    }
                    else
                    {
                        charsDict[rightC]++;
                    }
                    if (charsDict[rightC] == charsReq[rightC])
                    {
                        satisfied++;
                    }

                    // ADOBECODEBANC
                    // ABC
                    while (!charsReq.ContainsKey(s[left]) || charsDict[s[left]] > charsReq[s[left]])
                    {
                        if (charsReq.ContainsKey(s[left]) && charsDict[s[left]] > charsReq[s[left]])
                        {
                            charsDict[s[left]]--;
                        }

                        left++;

                        if (charsReq.ContainsKey(s[left]) && charsDict[s[left]] <= charsReq[s[left]])
                        {
                            break;
                        }
                    }

                    if (satisfied == charsReq.Count)
                    {
                        string subStr = s.Substring(left, (i + 1) - left);
                        currSmallestSbStr = subStr.Length < currSmallestSbStr.Length || currSmallestSbStr == "" ? subStr : currSmallestSbStr;
                    }
                }
            }
            return currSmallestSbStr;
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
