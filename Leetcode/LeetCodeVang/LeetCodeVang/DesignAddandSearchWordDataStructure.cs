namespace LeetCodeVang
{

    public static class WordDictTesting
    {
        public static void Main(string[] args)
        {
            WordDictionary wordDictionary = new WordDictionary();
            wordDictionary.AddWord("two");
            wordDictionary.AddWord("one");
            wordDictionary.AddWord("three");
            wordDictionary.Search("..");
            //wordDictionary.AddWord("day");
            //wordDictionary.AddWord("bay");
            //wordDictionary.AddWord("may");
            //wordDictionary.Search("say"); // return false
            //wordDictionary.Search("day"); // return true
            //wordDictionary.Search(".ay"); // return true
            //wordDictionary.Search("b.."); // return true

            Console.WriteLine("HI");
        }
    }

    /*
     * Design a data structure that supports adding new words and searching for existing words
     * 
     */
    public class WordDictionary
    {
        private readonly TrieNode root;

        public WordDictionary()
        {
            this.root = new TrieNode();
        }

        /// <summary>
        /// Adds word to the data structure
        /// </summary>
        /// <param name="word">Word to add to data structure.</param>
        public void AddWord(string word)
        {
            TrieNode node = this.root;

            for (int i = 0; i < word.Length; i++)
            {
                if (node.Children.ContainsKey(word[i]))
                {
                    node = node.Children[word[i]];
                    if (i == word.Length - 1)
                        node.IsEndOfWord = true;
                }
                else
                {
                    node.Children.Add(word[i], new TrieNode());
                    node = node.Children[word[i]];
                    if (i == word.Length - 1)
                        node.IsEndOfWord = true;
                }
            }
        }

        /// <summary>
        /// Returns true if there is any string in the data structure that matches passed in word
        /// Dots (.) passed into the word can represent any letter 
        /// so if Day is is in this data structure for example ".ay" returns true.
        /// </summary>
        /// <param name="word">Word to look for in data structure.</param>
        /// <returns>If word exists in data structure.</returns>
        public bool Search(string word)
        {
            // Must do a BFS since we need to check any words that match passsed in parameter
            // Considering a . could be passed in.
            Queue<TrieNode> nodes = new Queue<TrieNode>();
            nodes.Enqueue(this.root);

            int indToFind = 0;
            while (nodes.Count > 0 && indToFind < word.Length)
            {
                // Set a current level of nodes we are iterating
                // So we do not accidentally check nodes down a deeper level.
                int currLevel = nodes.Count;

                // If we are at a dot just continue to the next letter.
                // And enqueue everything at this current level.
                if (word[indToFind] == '.')
                {
                    while (currLevel > 0)
                    {
                        TrieNode node = nodes.Dequeue();

                        foreach (var item in node.Children)
                        {
                            nodes.Enqueue(item.Value);
                        }
                        currLevel--;
                    }

                    indToFind++;
                    continue;
                }

                while (currLevel > 0)
                {
                    TrieNode node = nodes.Dequeue();

                    if (node.Children.ContainsKey(word[indToFind]))
                    {
                        nodes.Enqueue(node.Children[word[indToFind]]);
                    }

                    currLevel--;
                }

                indToFind++;
            }

            // After populating nodes see if any are at the end of the word
            // If so that is true;
            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();

                if (node.IsEndOfWord)
                    return true;
            }

            return false;
        }
    }

    //public class TrieNode
    //{
    //    // Stores the characters that can follow this node.
    //    public Dictionary<char, TrieNode> Children { get; set; }

    //    // Identifies whether this node completes an inserted word.
    //    public bool IsEndOfWord { get; set; }

    //    public TrieNode()
    //    {
    //        Children = new Dictionary<char, TrieNode>();
    //        IsEndOfWord = false;
    //    }
    //}
}
