namespace LeetCodeVang
{
    public static class ValidParentheses
    {
        public static void Main(string[] args)
        {
            var test = IsValid("[]");
            Console.WriteLine(test);
            Console.ReadLine();
        }

        /*
         * Given a string S consisting of the following characters:
         * () {} []
         * Inpus string S is valid IF AND ONLY IF
         * Every open bracket gets closed by the same type of close bracket
         * Open brackets are closed in the correct order
         * Every close bracket has a corresponding open bracket of the same type.
         * 
         * []
         * true
         * 
         * ([{}])
         * true
         * 
         * [(])
         * False
         * 
         * Constraints:
         * 1 <= s.length <= 1000
         */
        public static bool IsValid(string s)
        {
            // base case.
            if (s.Length <= 1)
                return false;

            Dictionary<char, char> parenthesisPairs = new Dictionary<char, char>()
            { {')', '('},
               { '}', '{' },
                {']', '[' },
            };

            // Stack of the brackets seen.
            Stack<char> parensSeen = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                // So its a closing bracket...
                if (parenthesisPairs.ContainsKey(s[i]))
                {
                    if(parensSeen.TryPeek(out char top))
                    {

                        if(parenthesisPairs[s[i]] == top)
                        {
                            parensSeen.Pop();
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        // So there is not opening bracket at all...
                        return false;
                    }
                }
                else
                {
                    parensSeen.Push(s[i]);
                }
            }
            if (parensSeen.Count > 0)
                return false;
            else
                return true;

            //HashSet<char> openParens = new HashSet<char>() { '(', '{', '[' };
            //HashSet<char> closeParens = new HashSet<char>() { ')', '}', ']' };

            //// Stack to push seen paren characters into 
            //// Stack, LIFO
            //Stack<char> parensSeen = new Stack<char>();

            ///*
            // * So if every open parenthesis character should be closed by its closing counter 
            // * that means we can return false anytime a closed paren does not have its open in order behind it.
            // */
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (closeParens.Contains(s[i]) && parensSeen.TryPeek(out char paren))
            //    {
            //        if (s[i] == ')')
            //        {
            //            if(paren == '(')
            //            {
            //                parensSeen.Pop();
            //            }
            //            else
            //            {
            //                return false;
            //            }
            //        }
            //        else if (s[i] == '}')
            //        {
            //            if (paren == '{')
            //            {
            //                parensSeen.Pop();
            //            }
            //            else
            //            {
            //                return false;
            //            }
            //        }
            //        else if (s[i] == ']')
            //        {
            //            if (paren == '[')
            //            {
            //                parensSeen.Pop();
            //            }
            //            else
            //            {
            //                return false;
            //            }
            //        }
            //    }
            //    else if (closeParens.Contains(s[i]) && !parensSeen.TryPeek(out char top))
            //    {
            //        // Since there is no opening bracket for the closed bracket.
            //        return false;
            //    }
            //    else
            //    {
            //        parensSeen.Push(s[i]);
            //    }
            //}

            //// Parens seen should be cleared out as we pop things off so if its not return false..
            //if (parensSeen.Count == 0)
            //    return true;
            //else
            //    return false;
        }
    }
}
