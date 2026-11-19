public class Solution {
    public int MinimizeSum(int[] nums) {
        if(nums.Length < 4) return 0;
        int min1 = Int32.MaxValue, min2 = Int32.MaxValue, max1 = Int32.MinValue, max2 = Int32.MinValue;
        int min3 = Int32.MaxValue, max3 = Int32.MinValue;
        foreach(int num in nums){
            if(min1 > num){
                min3 = min2;
                min2 = min1;
                min1 = num;
            }
            else if(min2 > num){
                min3 = min2;
                min2 = num;
            }
            else if(min3 > num){
                min3 = num;
            }
            if(max1 < num){
                max3 = max2;
                max2 = max1;
                max1 = num;
            }
            else if(max2 < num){
                max3 = max2;
                max2 = num;
            }
            else if(max3 < num){
                max3 = num;
            }
        }
        return Math.Min(max3 - min1, Math.Min(max2 - min2, max1 - min3));
    }
}