namespace LeetCodeVang
{
    /*
     * Prefix tree (or trie) is a tree data structure
     * used to efficiently store and retrieve keys in a set of strings.
     */
    public class PrefixTree
    {
        private TrieNode root;

        public PrefixTree()
        {
            root = new TrieNode();
        }

        /// <summary>
        /// Inserts the word into the prefix trie.
        /// </summary>
        /// <param name="word">Word to insert.</param>
        public void Insert(string word)
        {
            TrieNode start = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (i == word.Length - 1 && start.Children.ContainsKey(word[i]))
                {
                    start.Children[word[i]].IsEndOfWord = true;
                }
                else if (i == word.Length - 1 && !start.Children.ContainsKey(word[i]))
                {
                    start.Children.Add(word[i], new TrieNode());
                    start.Children[word[i]].IsEndOfWord = true;
                }
                else if (start.Children.ContainsKey(word[i]))
                {
                    start = start.Children[word[i]];
                }
                else
                {
                    start.Children.Add(word[i], new TrieNode());
                    start = start.Children[word[i]];
                }
            }
        }

        /// <summary>
        /// Checks if word is in the trie.
        /// </summary>
        /// <param name="word">Word to check in tree.</param>
        /// <returns>If word is in trie.</returns>
        public bool Search(string word)
        {
            TrieNode start = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (start.Children.ContainsKey(word[i]))
                {
                    // First check if at the end of word.
                    // And is also recognized as end of word in node.
                    if (i == word.Length - 1 && !start.Children[word[i]].IsEndOfWord)
                        return false;


                    start = start.Children[word[i]];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if a previously inserted word is in the prefix trie.
        /// </summary>
        /// <param name="prefix">Prefix to look for.</param>
        /// <returns>If a word starts with prefix.</returns>
        public bool StartsWith(string prefix)
        {
            TrieNode start = root;

            for (int i = 0; i < prefix.Length; i++)
            {
                if (start.Children.ContainsKey(prefix[i]))
                {
                    start = start.Children[prefix[i]];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class TrieNode
    {
        // Stores the characters that can follow this node.
        public Dictionary<char, TrieNode> Children { get; set; }

        // Identifies whether this node completes an inserted word.
        public bool IsEndOfWord { get; set; }

        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            IsEndOfWord = false;
        }
    }
}
