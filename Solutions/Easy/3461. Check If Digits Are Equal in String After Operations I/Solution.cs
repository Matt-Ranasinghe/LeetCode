public class Solution {
    public int CountValidSelections(int[] nums) {
        int n = nums.Length;
        int[] prefixSum = new int[n];
        prefixSum[0] = nums[0];
        for(int i = 1; i < n; i++){
            prefixSum[i] += prefixSum[i - 1] + nums[i];
        }
        bool even = prefixSum[n - 1] % 2 == 0;
        int half = 0, result = 0;
        half = prefixSum[n - 1] / 2;
        for(int i = 0; i < n; i++){
            if(even){
                if(prefixSum[i] == half && nums[i] == 0) result += 2;
            }
            else{
                if((prefixSum[i] == half || prefixSum[i] - 1 == half) && nums[i] == 0) result += 1;
            }
        }
        return result;
    }
}