public class Solution {
    public long MaxRunTime(int n, int[] batteries) {
        long sum = 0;
        foreach (int b in batteries) sum += b;

        long left = 0, right = sum / n;
        long ans = 0;

        while (left <= right) {
            long mid = left + (right - left) / 2;

            if (CanRun(mid, n, batteries)) {
                ans = mid;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return ans;
    }
    private bool CanRun(long time, int n, int[] batteries) {
        long total = 0;

        foreach (int b in batteries) {
            total += Math.Min(b, time);
            if (total >= (long)n * time) return true;
        }

        return total >= (long)n * time;
    }
}