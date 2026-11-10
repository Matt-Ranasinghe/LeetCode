public class Solution {
    public int ClimbStairs(int n, int[] costs) {
        int[] stepDP = new int[n + 1];
        Array.Fill(stepDP, Int32.MaxValue);
        stepDP[0] = 0;
        for(int i = 1; i <= n; i++){
            for(int j = Math.Max(i - 3, 0); j < i; j++){
                stepDP[i] = Math.Min((int)Math.Pow(i - j, 2) + stepDP[j] + costs[i - 1], stepDP[i]);
            }
        }
        return stepDP[n];
    }
}