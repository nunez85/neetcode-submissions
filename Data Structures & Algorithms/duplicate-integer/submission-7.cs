public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> unique = new();

        foreach (int n in nums) {
            if (unique.Contains(n)) {
                return true;
            }
            unique.Add(n);
        }

        return false;
    }
}