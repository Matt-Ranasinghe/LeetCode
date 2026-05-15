public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int left = 0, right = n - 1;
        if(nums[left] < nums[right]) return nums[0];
        while(left < right){
            int mid = (right - left) / 2 + left;
            if(nums[mid] < nums[right]){
                right = mid;
            }
            else left = mid + 1;
        }
        return nums[left];
    }
}