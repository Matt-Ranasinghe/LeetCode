public class Solution {
    public long CountMajoritySubarrays(int[] nums, int target) {
        int n = nums.Length;
        int[] pre = new int[n * 2 + 1];
        pre[n] = 1;
        int count = n;
        long ans = 0, presum = 0;
        for (int i = 0; i < n; i++) {
            if (nums[i] == target) {
                presum += pre[count];
                count++;
                pre[count]++;
            } else {
                count--;
                presum -= pre[count];
                pre[count]++;
            }
            ans += presum;
        }
        return ans;
    }
}