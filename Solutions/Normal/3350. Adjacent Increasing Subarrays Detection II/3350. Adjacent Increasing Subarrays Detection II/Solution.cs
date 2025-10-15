public class Solution {
    public int MaxIncreasingSubarrays(IList<int> nums) {
        int max = 0, n = nums.Count;
        int[] startPoint = new int[n];
        int prev = Int32.MaxValue;
        int length = 0;
        for(int i = 0; i < n; i++){
            if(nums[i] > prev){
                length++;
            }
            else{
                length = 1;
            }
            if(length % 2 == 0){
                int half = length / 2;
                max = Math.Max(max, half);
            }
            if(i - length >= 0 && length <= startPoint[i - length]){
                max = Math.Max(max, length);
            }
            startPoint[i] = length;
            prev = nums[i];
        }
        return max;
    }
}