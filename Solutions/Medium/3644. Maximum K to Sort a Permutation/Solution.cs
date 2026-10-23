public class Solution {
    public int SortPermutation(int[] nums) {
        int n = nums.Length;
        int result = Int32.MaxValue;
        for(int i = 0; i < n; i++){
            if(nums[i] != i) result &= nums[i];
        }
        return result == Int32.MaxValue ? 0 : result;
    }
}