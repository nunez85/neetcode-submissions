public class Solution {
    private static Random random = new();

    public int MajorityElement(int[] nums) {
        int candidate, count;
        int length = nums.Length;

        while (true) {
            candidate = nums[random.Next(length)];
            count = nums.Count(x => x == candidate);

            if (count > length / 2) {
                return candidate;
            }
        }

        return -1;
    }
}