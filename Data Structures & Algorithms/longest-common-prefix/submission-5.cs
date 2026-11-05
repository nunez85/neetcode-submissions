public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) {
            return "";
        } 
        
        if (strs.Length == 1) {
            return strs[0];
        }

        
        string foundPrefix = "";
        Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));

        string longestPossiblePrefix = strs[0];

        for (int i = 1; i <= longestPossiblePrefix.Length; i++) { 
            string substring = longestPossiblePrefix.Substring(0, i);

            foreach (string str in strs) {
                if (!str.Contains(substring)) {
                    return foundPrefix;
                }
            }
            foundPrefix = substring;
        }
        return foundPrefix;
    }
}