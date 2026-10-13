namespace LeetCodeVang
{
    public static class LongestSubStringNoRepeatingChar
    {
        public static void Main(string[] args)
        {
            var test = LengthOfLongestSubstring("1R1T7");
            Console.WriteLine(test);
        }

        // Given string S
        // Find the longest substring without duplicating characters.
        // s = bbbbbbb answer = b
        // s = abcbca answer = abc
        public static int LengthOfLongestSubstring(string s)
        {

            // It thought this was a good solution in one loop.
            // Turns out there is a lot better.
            // base cases
            //if (s.Length == 1 || s.Length == 0)
            //    return s.Length;

            //int length = 0;
            //int left = 0;

            //// To store characters seen.
            //List<char> chars = new();

            //for (int r = left; r < s.Length; r++)
            //{
            //    if (chars.Contains(s[r]))
            //    {
            //        left++;
            //        r = left;
            //        chars.Clear();
            //        chars.Add(s[r]);
            //    }
            //    else
            //    {
            //        chars.Add(s[r]);
            //    }

            //    if (chars.Count() > length)
            //    {
            //        length = chars.Count();
            //    }
            //}
            //return length;

            // base cases
            if (s.Length == 1 || s.Length == 0)
                return s.Length;

            // 1R1T7
            HashSet<char> charactersSeen = new();

            int topLength = 0;

            int left = 0;
            for (int i = 0; i < s.Length; i++) 
            {
                if (!charactersSeen.Contains(s[i]))
                {
                    charactersSeen.Add(s[i]);
                } else
                {
                    left++;
                    i = (left - 1);
                    charactersSeen.Clear();
                }

                if(charactersSeen.Count() > topLength)
                    topLength = charactersSeen.Count();
            }

            return topLength;
        }
    }
}
