
public class Solution {
    public bool hasDuplicate(int[] nums) {
        var uniq = new HashSet<int>(nums);
        return nums.Length != uniq.Count;
    }
}
