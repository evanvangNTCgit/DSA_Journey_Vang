namespace LeetCodeVang
{
    public static class FindIndexOfFirstOccurenceInString
    {
        public static void Main(string[] args)
        {
            var test = StrStr("sadbutsad", "sad");
            Console.WriteLine(test);
        }

        // Given two strings (needle, haystack)
        // Return first occurence of needle in haystack.
        // Or -1 if needle is not in the haystack.

        // haystack and needle both only lowercase characters
        // No need to account for capitalization.
        public static int StrStr(string haystack, string needle)
        {
            // Well this is an easy start...
            // return haystack.IndexOf(needle);

            // base cases.
            if (string.IsNullOrEmpty(needle)) return 0;
            if (needle.Length > haystack.Length) return -1;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] != needle[0]) continue;

                int j = 1;
                while (j < needle.Length && haystack[i + j] == needle[j]) j++;

                if (j == needle.Length) return i;
            }
            return -1;
        }
    }
}
