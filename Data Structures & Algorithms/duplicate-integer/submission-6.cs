public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> unique = new ();

        foreach (int n in nums) {
            unique.Add(n);
        }

        return unique.Count() != nums.Length;
        
    }
}