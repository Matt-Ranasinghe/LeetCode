public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int left = 0, right = n - 1;
        while(left <= right){
            int mid = (right - left) / 2 + left;
            if(nums[mid] == target) return mid;
            if(nums[mid] < nums[right]){
                if(target < nums[mid] || target > nums[right]) right = mid - 1;
                else left = mid + 1;
            }
            else{
                if((target < nums[mid] && target < nums[left]) || (target > nums[mid] && target > nums[left])) left = mid + 1;
                else right = mid - 1;
            }
        }
        return -1;
    }
}