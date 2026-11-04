public class Solution {
    public bool IsAnagram(string s, string t) {
        // Keep track of all the letters and their count
        Dictionary<char, int> ds = GetLetterCounter(s);
        Dictionary<char, int> dt = GetLetterCounter(t);

        foreach ((char letter, int count) in ds) {
            if (dt.TryGetValue(letter, out int currentCount))
            {
                if (count != currentCount) {
                    return false;
                }
            } else {
                return false;
            }
        }

        foreach ((char letter, int count) in dt) {
            if (ds.TryGetValue(letter, out int currentCount))
            {
                if (count != currentCount) {
                    return false;
                }
            } else {
                return false;
            }
        }

        return true;
    }

    public Dictionary<char, int> GetLetterCounter(string word) {
        Dictionary<char, int> letterCounter = new();
        foreach (char letter in word) {
            if (letterCounter.TryGetValue(letter, out int currentCount)) {
                letterCounter[letter] = currentCount + 1;
            } else {
                letterCounter[letter] = 1;
            }
        }

        return letterCounter;
    }
}
