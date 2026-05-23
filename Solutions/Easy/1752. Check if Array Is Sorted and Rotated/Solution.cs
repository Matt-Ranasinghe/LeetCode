public class Solution {
    public bool Check(int[] nums) {
        bool drop = false;
        for(int i = 0; i < nums.Length; i++)
        {
            if(i == nums.Length - 1)
            {
                if(!(nums[0] >= nums[i]) && drop) return false;
                else if(!(nums[0] >= nums[i])) drop = true;
            }
            else
            {
                if(!(nums[i + 1] >= nums[i]) && drop) return false;
                else if(!(nums[i + 1] >= nums[i])) drop = true;
            }
        }
        return true;
    }
}