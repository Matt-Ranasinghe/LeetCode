public class Solution {
    public int MaxDistinctElements(int[] nums, int k) {
        Array.Sort(nums);
        int result = 1;
        int nextBest = nums[0] - k + 1;
        for(int i = 1; i < nums.Length; i++){
            if(nextBest <= nums[i] - k){
                nextBest = nums[i] - k + 1;
                result++;
            }
            else if(nextBest <= nums[i] + k){
                nextBest++;
                result++;
            }
        }
        return result;
    }
}