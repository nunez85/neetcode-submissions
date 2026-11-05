public class Solution {
    public string LongestCommonPrefix(string[] strs) {
      // find the shortest string
      // begin by comparing its first character
      // if it is not found as a substring in any string then just return 
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