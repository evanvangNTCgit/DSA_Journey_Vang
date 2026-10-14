namespace LeetCodeVang
{
    public static class RearrangeStringToAvoidCharPair
    {
        public static void Main(string[] args)
        {
            var test = RearrangeString("aabc", 'a', 'c');
            Console.WriteLine(test);
        }

        // Given string s and two lower case English letters (x, y)
        // Rearrange the characters of S to construct a new string T such that:
        // T is a PERMUTATION of s, (rearrangement of all the characters of a string.)
        // Every occurance of y appears before every occurance of x in t.

        // Contraints
        // 1 <= s.length <= 100
        // s is ALL LOWERCASE
        // x and y LOWERCASE
        // x != y

        // S = aabc x = a y = c, ==> T = cbaa
        // S = dcab x = d y = b, ==> T = cabd

        // My first throught is that x seems to just be arranged into the back of the string.
        // Thus we can just in one for-loop every time I see x set it to the end (if same char alr there just go back)
        // Then you would replace the current index (in the iteration) with the char it replaced.
        public static string RearrangeString(string s, char x, char y)
        {
            // base case(s)
            if (s.Length <= 0)
                return s;

            string t = string.Empty; // ""

            // We can use an integer to store the amount of X to add after for loop finishes.
            int amountOfXToAdd = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != x)
                {
                    t += s[i];
                }
                else
                {
                    amountOfXToAdd++;
                }
            }
            for (int i = 0; i < amountOfXToAdd; i++)
            {
                t += x;
            }

            return t;
        }
    }
}
