using System.Text;

namespace LeetCodeVang
{
    public static class ValidPalindrome
    {
        public static void Main(string[] args)
        {
            var test = IsPalindrome("0P");
            Console.WriteLine(test);
        }

        /*
         * Given the string s
         * Return true if it is a palindrome, otherwise false
         * Palindrome meaning string reads the same forwards and backwards.
         * 
         * Constraints:
         * 1 <= s.length <= 1000
         * s only made up of printable ASCII characters.
         * 
         * Was it a car or a cat I saw? = true
         */
        public static bool IsPalindrome(string s)
        {
            StringBuilder sb= new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (IsASCIILetterOrNum(s[i]))
                {
                    sb.Append(s[i]);
                }
            }

            s = sb.ToString().ToUpper();

            // Two pointers
            int left = 0;
            int right = sb.Length - 1;

            while (left < right)
            {
                while (s[left] == ' ')
                {
                    if ((left + 1) <= (s.Length - 1))
                        left++;
                }
                while (s[right] == ' ')
                {
                    if ((right - 1) >= 0)
                        right--;
                }

                if (s[left] != s[right])
                {
                    return false;
                }

                if ((left + 1) <= (s.Length - 1))
                    left++;
                if ((right - 1) >= 0)
                    right--;
            }
            return true;
        }

        private static bool IsASCIILetterOrNum(char c)
        {
            if ('A' <= c && c <= 'Z')
                return true;

            if ('a' <= c && c <= 'z')
                return true;

            // Numberic letters aswell
            if (int.TryParse(c.ToString(), out int result))
                return true;

            return false;
        }

        /*
         * Notes on two pointer algorithm approach.
         * Whats a pointer?
         * Object that stores the memory address of another object.
         * Or pointer references another object.
         * 
         * Example
         * pointer = 0;
         * arr[pointer] ==> [10,30,50,70] (points at 10)
         * 
         * pointer = 3. (points at 70)
         * 
         * So two pointers involves the usage of TWO pointers instead of one.
         * These multiple pointers can keep track of multiple indices of our input.
         * So we can look at two values at the same time.
         */
    }
}
