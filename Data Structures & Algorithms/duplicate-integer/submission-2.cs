//using System.Collections.Generic;

public class Solution {
    public bool hasDuplicate(int[] nums) 
    {

        HashSet<int> numsFilter = new HashSet<int>(nums);
        if(nums.Length == numsFilter.Count)
            return false;
        else 
            return true;

        
    }
}