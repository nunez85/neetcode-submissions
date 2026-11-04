public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length * 2];

        int numsIndex;
        for (int i = 0; i < ans.Length; i++) {
            numsIndex = i % nums.Length;
            ans[i] = nums[numsIndex];
        }
        return ans;
    }
}