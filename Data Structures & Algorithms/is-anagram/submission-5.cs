public class Solution {
    public bool IsAnagram(string s, string t) {
        // Keep track of all the letters and their count
        Dictionary<char, int> ds = GetDictLetterCounter(s);
        Dictionary<char, int> dt = GetDictLetterCounter(t);

        return DictContainsValues(ds, dt) && DictContainsValues(dt, ds);
    }

    public Dictionary<char, int> GetDictLetterCounter(string word) {
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

    public bool DictContainsValues(Dictionary<char, int> t, Dictionary<char, int> s) {
        foreach (var (key, value) in t) {
            if (s.TryGetValue(key, out var currentValue))
            {
                if (value != currentValue) {
                    return false;
                }
            } else {
                return false;
            }
        }
        return true;
    }
}
