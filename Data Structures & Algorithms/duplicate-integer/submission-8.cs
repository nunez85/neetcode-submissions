
public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        int i = 0;
        int j = 1;
        while (j < nums.Length)
        {
            if (nums[i] == nums[j]) {
                return true;
            }
            i++;
            j++;
        }

        return false;

    }
}
