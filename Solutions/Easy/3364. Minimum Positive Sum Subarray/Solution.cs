public class Solution {
    public int MinimumSumSubarray(IList<int> nums, int l, int r) {
        int result = Int32.MaxValue;
        int n = nums.Count;
        for(int i = 0; i <= n - l; i++){
            int current = 0;
            for(int j = i; j < Math.Min(i + r, n); j++){
                current += nums[j];
                Console.WriteLine(current);
                if(j - i >= l - 1 && current > 0) result = Math.Min(current, result);
            }
        }
        return result == Int32.MaxValue ? -1 : result;
    }
}