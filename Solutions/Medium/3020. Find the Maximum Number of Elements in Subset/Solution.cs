public class Solution {
    public int MaximumLength(int[] nums) {
        var freq = new Dictionary<long, int>();
        foreach (int num in nums) {
            freq.TryGetValue(num, out int c);
            freq[num] = c + 1;
        }
        freq.TryGetValue(1, out int onefreq);
        int ans = (onefreq & 1) == 1 ? onefreq : onefreq - 1;
        freq.Remove(1);
        foreach (long num in freq.Keys) {
            int res = 0;
            long x = num;
            while (freq.TryGetValue(x, out int c) && c > 1) {
                res += 2;
                x *= x;
            }
            ans = Math.Max(ans, res + (freq.ContainsKey(x) ? 1 : -1));
        }

        return ans;
    }
}