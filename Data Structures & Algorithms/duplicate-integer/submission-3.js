class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        let uniq = new Set(nums);
        return uniq.size !== nums.length;
    }
}
