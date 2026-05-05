public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        for(int i = 0; i < nums.Length;i++) 
        {
            for(int j = i; j < nums.Length - 1;j++)
            {
                if(nums[i] + nums[j+1] == target)
                {
                    return new int[] {i, j+1};
                }
                    
            }
        
        };
        return [-1,-1];
       
    }
}
