public class Solution {

    public class TrieNode {
        public Dictionary<char, TrieNode> Children { get; } = [];
        public bool IsEndOfWord { get; set; }
    }

    public class Trie {
        private readonly TrieNode _root = new();

        public void Insert(ReadOnlySpan<char> word) {
            TrieNode current = _root;
            foreach (char ch in word) {
                TrieNode next;
                if (!current.Children.TryGetValue(ch, out next)) {
                    next = new TrieNode();
                    current.Children[ch] = next;
                }

                current = next;
            }
        }

        public int Lcp(string word, int prefixLen) {
            TrieNode current = _root;
            int maxLength = Math.Min(word.Length, prefixLen);

            for (int i = 0; i < maxLength; i++) {
                TrieNode next;
                if (!current.Children.TryGetValue(word[i], out next)) {
                    return i;
                }
                current = next;
            }

            return maxLength;
        }
    }

    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";
        if (strs.Length == 1) return strs[0];

        string minStr = strs.MinBy(w => w.Length);

        Trie trie = new();
        trie.Insert(minStr);

        int prefixLen = minStr.Length;
        for (int i = 0; i < strs.Length; i++) {
            prefixLen = trie.Lcp(strs[i], prefixLen);
        }

        return minStr.Substring(0, prefixLen);
    }
}