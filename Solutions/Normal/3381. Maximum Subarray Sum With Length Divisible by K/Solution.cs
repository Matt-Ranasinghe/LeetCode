public class Solution {
    public long MaxSubarraySum(int[] nums, int k)
    {
        int n = nums.Length;
        long ans = -1;
        long currSum = 0;
        long[] maxSum = new long[n+1];

        for(int i=n-1;i>=0;i--)
        {
            currSum += nums[i];
            currSum -= i+k < n ? nums[i+k] : 0;
            if(i+k > n)
            {
                maxSum[i] = 0;
                continue;
            }
            maxSum[i] = Math.Max(currSum,currSum + maxSum[i+k]);
            if(i+k == n) ans = maxSum[i];
            else ans = Math.Max(ans,maxSum[i]);
        }

        return ans;
    }
}