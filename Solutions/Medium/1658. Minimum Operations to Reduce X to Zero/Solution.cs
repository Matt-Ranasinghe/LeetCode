public class Solution {
    public int MinOperations(int[] nums, int x) {
        int n = nums.Length;
        int left = 0, right = n - 1;
        int total = 0, result = Int32.MaxValue;
        while(left < n && total + nums[left] <= x){
            total += nums[left];
            left++;
        }
        if(total == x) {
            result = left;
            if(left == n) return n;
        }
        else if(left == n) return -1;
        while(total + nums[right] <= x || left > 0){
            while(total + nums[right] > x && left > 0){
                left--;
                total -= nums[left];
            }
            total += nums[right];
            if(total == x) result = Math.Min(result, n - right + left);
            right--;
        }
        return result == Int32.MaxValue ? -1 : result;
    }
}