public class Solution {
    public int MajorityElement(int[] nums) {
        int res = 0, count = 0;

        foreach (int num in nums) {
            if (count == 0) {
                res = num;
            }

            count += (num == res) ? 1: -1;
        }

        return res;
    }
}