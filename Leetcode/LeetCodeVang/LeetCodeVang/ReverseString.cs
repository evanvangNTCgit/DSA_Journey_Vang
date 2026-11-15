namespace LeetCodeVang
{
    public static class ReverseString
    {
        public static void Main(string[] args)
        {

        }

        /*
         * Given an array of char's representing string s.
         * 
         * Write a function that reverses a string.
         * 
         * Modify the input array in-place with O(1) memory.
         * 
         * input: [n,e,e,t]
         * output: [t,e,e,n]
         */
        public static void ReverseStringSol(char[] s)
        {
            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                var temp = s[l];
                s[l] = s[r];
                s[r] = temp;
                l++;
                r--;
            }
        }
    }
}
