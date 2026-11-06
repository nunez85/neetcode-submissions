public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 0) {
            return new List<List<string>> { new List<string> { strs[0]}};
        }
        Dictionary<string, List<string>> anagramsDict = new();

        foreach (string str in strs) {
            string sortedStr = SortString(str);
            List<string> anagrams;
            if (!anagramsDict.TryGetValue(sortedStr, out anagrams)) {
                anagrams = new List<string>();
            }
            anagrams.Add(str);
            anagramsDict[sortedStr] = anagrams;
        }

        return anagramsDict.Values.ToList();
    }

    public string SortString(string str) {
        if (string.IsNullOrEmpty(str) || str.Length == 1) {
            return str;
        }

        Span<char> charSpan = str.Length <= 128
            ? stackalloc char[str.Length]
            : new char[str.Length];

        str.AsSpan().CopyTo(charSpan);

        charSpan.Sort();
        return new String(charSpan);
    }
}
