public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> counter = new();
        int res = 0, maxCount = 0;

        foreach(int n in nums) {
            if (!(counter.ContainsKey(n))) {
                counter[n] = 0;
            }
            counter[n]++;

            if (counter[n] > maxCount) {
                maxCount = counter[n];
                res = n;
            }
        }

        return res;
    }
}