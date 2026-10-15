namespace LeetCodeVang
{
    public static class GroupAnagrams
    {
        public static void Main(string[] args)
        {
            var test = GroupAnagramsSolution(["act", "pots", "tops", "cat", "stop", "hat"]);
            Console.WriteLine(test);
        }

        // Given an array of strings, gorup all anagrams together into sub lists.
        // Can return the list in any order.
        // Anagram, string that contains the exact same characters in another string. regardless of order.

        // STRS = ["tab","bat","tops","cat"]
        // Output: [["bat, tab"], ["tops"], ["cat"]]

        // My first thought is to use a for loop
        // Add it to a hash set that stores the string (sorted by character)
        // Then a list of int values for where it is in the index of strs.
        public static List<List<string>> GroupAnagramsSolution(string[] strs)
        {
            List<List<string>> anagramsGroup = new List<List<string>>();
            Dictionary<string, List<int>> dictOfStrings = new Dictionary<string, List<int>>();

            for (int i = 0; i < strs.Length; i++)
            {
                string stringOrdered = new string(strs[i].Order().ToArray());
                if (dictOfStrings.TryGetValue(stringOrdered, out List<int> value))
                {
                    value.Add(i);
                }
                else
                {
                    dictOfStrings.Add(stringOrdered, new List<int> { i });
                }
            }

            foreach (KeyValuePair<string, List<int>> item in dictOfStrings)
            {
                List<string> anagramsGrouped = new List<string>();

                foreach (var item1 in item.Value)
                {
                    anagramsGrouped.Add(strs[item1]);
                }

                anagramsGroup.Add(anagramsGrouped);
            }

            return anagramsGroup;
        }

        public static IList<IList<string>> GroupAnagramsSol(string[] strs)
        {
            IList<IList<string>> anagramsGroup = new List<IList<string>>();
            Dictionary<string, List<int>> dictOfStrings = new Dictionary<string, List<int>>();

            for (int i = 0; i < strs.Length; i++)
            {
                string stringOrdered = new string(strs[i].Order().ToArray());
                if (dictOfStrings.TryGetValue(stringOrdered, out List<int> value))
                {
                    value.Add(i);
                }
                else
                {
                    dictOfStrings.Add(stringOrdered, new List<int> { i });
                }
            }

            foreach (KeyValuePair<string, List<int>> item in dictOfStrings)
            {
                List<string> anagramsGrouped = new List<string>();

                foreach (var item1 in item.Value)
                {
                    anagramsGrouped.Add(strs[item1]);
                }

                anagramsGroup.Add(anagramsGrouped);
            }

            return anagramsGroup;
        }
    }
}
