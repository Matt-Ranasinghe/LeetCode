public class Solution {
    public int MinOperations(int[] nums) {
        if(nums.Length <= 1) return 0;
        int decreasingCount = 0, increasingCount = 0;
        int lastIncrease = -1, lastDecrease = -1;
        int n = nums.Length;
        for(int i = 0; i < n; i++){
            if(nums[i] > nums[(i + 1) % n]) {
                decreasingCount++;
                lastDecrease = (i + 1) % n;
            }
            else if(nums[i] < nums[(i + 1)%n]) {
                increasingCount++;
                lastIncrease = i;
            }
        }
        if(decreasingCount > 1 && increasingCount > 1) return -1;
        if(decreasingCount > 1){
            return Math.Min(n - lastIncrease - 1, lastIncrease + 1) + 1;
        }
        return Math.Min(lastDecrease, n - lastDecrease + 2);
    }
}