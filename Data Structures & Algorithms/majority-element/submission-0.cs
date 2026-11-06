public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        int middle = nums.Length / 2;
        return nums[middle];
    }
}