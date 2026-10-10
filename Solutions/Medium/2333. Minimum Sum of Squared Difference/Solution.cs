public class Solution {
    public long MinSumSquareDiff(int[] nums1, int[] nums2, int k1, int k2) {
        int n = nums1.Length;
        long totalK = (long)k1 + k2;
        int[] diffs = new int[n];
        long totalDiff = 0;
        int maxDiff = 0;

        for (int i = 0; i < n; i++) {
            diffs[i] = Math.Abs(nums1[i] - nums2[i]);
            totalDiff += diffs[i];
            if (diffs[i] > maxDiff) maxDiff = diffs[i];
        }
        if (totalK >= totalDiff) return 0;
        int[] count = new int[maxDiff + 1];
        foreach (int d in diffs) {
            count[d]++;
        }
        for (int d = maxDiff; d > 0 && totalK > 0; d--) {
            if (count[d] == 0) continue;
            long take = Math.Min(totalK, (long)count[d]);
            count[d] -= (int)take;
            count[d - 1] += (int)take;
            totalK -= take;
        }
        long ans = 0;
        for (int d = 1; d <= maxDiff; d++) {
            if (count[d] > 0) {
                ans += (long)count[d] * d * d;
            }
        }
        return ans;
    }
}