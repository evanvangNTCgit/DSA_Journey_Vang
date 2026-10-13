namespace LeetCodeVang
{
    public static class PalindromeNumber
    {
        public static void Main(string[] args)
        {
            IsPalindrome(1001);
        }

        // Given an integer (x)
        // Return true if X is a palindrome
        // Palindrom meaning it reads the same reversed
        // 121 ==> 121
        // Constraint: -231 <= x <= 231 - 1
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            // To brute force a solution I will cast the integer to a string
            // Reverse through this string cast it back to an integer and check if its still x (palindrome).
            //StringBuilder sb = new StringBuilder(x.ToString());
            //StringBuilder palindromeBuilder = new StringBuilder();
            //for (int i = sb.Length - 1; i >= 0; i--)
            //{
            //    palindromeBuilder.Append(sb[i]);
            //}

            //if (int.TryParse(palindromeBuilder.ToString(), out int palindrome))
            //{
            //    return palindrome == x;
            //}
            //else
            //{
            //    return false;
            //}


            // Instead what I can do is continually divide a number by 10
            // Get the digit left over and add it on.
            // Then check if it equals the integer passed into the parameter.
            int invertedNumber = 0;
            int realNumber = x;

            if (x < 0)
            {
                return false;
            }

            while (x != 0)
            {
                int digit = x % 10;
                invertedNumber = (invertedNumber * 10) + digit;
                x = x / 10;
            }

            if (realNumber == invertedNumber)
            {
                return true;
            }

            return false;
        }
    }
}
