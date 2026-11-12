namespace LeetCodeVang
{
    public static class RomanToInteger
    {
        public static void Main(string[] args)
        {
            var test = RomanToInt("MCMXCIV");
        }
        // Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        //Symbol Value
        //I             1
        //V             5
        //X             10
        //L             50
        //C             100
        //D             500
        //M             1000

        // There are six instances where subtraction is used:

        // I can be placed before V(5) and X(10) to make 4 and 9. 
        // X can be placed before L(50) and C(100) to make 40 and 90. 
        // C can be placed before D(500) and M(1000) to make 400 and 900.

        // MCMXCIV = 1994
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>();
            romanValues.Add('I', 1);
            romanValues.Add('V', 5);
            romanValues.Add('X', 10);
            romanValues.Add('L', 50);
            romanValues.Add('C', 100);
            romanValues.Add('D', 500);
            romanValues.Add('M', 1000);

            int val = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                // Check for any instances of subraction behind a roman numeral.
                if (i - 1 >= 0)
                {
                    if ((s[i] == 'V' || s[i] == 'X') && (s[i - 1] == 'I'))
                    {
                        val += romanValues[s[i]] - 1;
                        i--;
                    }
                    else if ((s[i] == 'L' || s[i] == 'C') && (s[i - 1] == 'X'))
                    {
                        val += romanValues[s[i]] - 10;
                        i--;
                    }
                    else if ((s[i] == 'D' || s[i] == 'M') && (s[i - 1] == 'C'))
                    {
                        val += romanValues[s[i]] - 100;
                        i--;
                    }
                    else
                    {
                        val += romanValues[s[i]];
                    }

                    continue;
                }
                else
                {
                    val += romanValues[s[i]];
                }
            }

            return val;
        }
    }
}
