public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length * 2];
        int numsIndex = 0;
        int modulo = nums.Length;
        for (int i = 0; i < ans.Length; i++) {
            numsIndex = i % modulo;
            ans[i] = nums[numsIndex];
        }
        return ans;
    }
}