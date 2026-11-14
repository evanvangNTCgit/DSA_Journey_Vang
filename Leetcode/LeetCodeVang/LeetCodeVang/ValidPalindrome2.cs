namespace LeetCodeVang
{
    public static class ValidPalindrome2
    {
        public static void Main(string[] args)
        {
            var test = ValidPalindrome("abbadc");
            Console.WriteLine("hi");
        }

        /*
         * Given a string s,
         * Return true if s can be a palindrome
         * after deleting at most ONE character from it.
         * 
         * Constraints:
         * S is made up of only lowercase English letters
         */

        static bool charDeleted = false;
        public static bool ValidPalindrome(string s)
        {
            int right = s.Length - 1;
            for (int left = 0; left < right; left++, right--)
            {
                if (s[left] != s[right] && !charDeleted)
                {
                    charDeleted = true;
                    // Use recursion and check valid palindrom in two substrings.
                    // One with left char gone, one with right char gone.
                    string leftCharGone = s.Substring(left + 1, right - left);
                    string rightCharGone = s.Substring(left, right - (left));

                    if (ValidPalindrome(leftCharGone) || ValidPalindrome(rightCharGone))
                        return true;
                    else
                        return false;
                }
                else if (s[left] != s[right] && charDeleted)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
