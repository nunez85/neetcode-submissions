
public class Solution {
    public bool hasDuplicate(int[] nums) {
      // I have a array and I want to know if it has a duplicate
      // Is the array already sort it? 
      // If it is, then I could just go through it once with a pointer behind the other one so I could simply check if they are equal, if so, return true
      // How to sort with dotnet? 

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
