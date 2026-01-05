public class Solution {
    public int MaxSumDivThree(int[] nums)
    {
        int[] dp = new int[]{0, int.MinValue, int.MinValue};

        foreach (var n in nums)
        {
            int[] next = (int[])dp.Clone();
            foreach (int r in new int[]{0,1,2})
            {
                int nr = (r + n) % 3;
                next[nr] = Math.Max(next[nr], dp[r] + n);
            }
            dp = next;
        }

        return dp[0];
    }
}