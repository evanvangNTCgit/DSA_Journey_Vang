namespace LeetCodeVang
{
    public static class RansomNote
    {
        public static void Main(string[] args)
        {

        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> charFreq = new Dictionary<char, int>();

            for (int i = 0; i < magazine.Length; i++)
            {
                if (charFreq.ContainsKey(magazine[i]))
                {
                    charFreq[magazine[i]]++;
                }
                else
                {
                    charFreq.Add(magazine[i], 1);
                }
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (charFreq.ContainsKey(ransomNote[i]))
                {
                    charFreq[ransomNote[i]]--;
                    if (charFreq[ransomNote[i]] == 0)
                        charFreq.Remove(ransomNote[i]);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
