public class Solution {
    public int StoneGameVIII(int[] stones) {
        int n = stones.Length;
        int[] prefixSum = new int[n];
        prefixSum[0] = stones[0];
        for (int i = 1; i < n; i++) {
            prefixSum[i] = prefixSum[i - 1] + stones[i];
        }

        int[] best = new int[n];
        best[n - 1] = prefixSum[n - 1];
        for (int i = n - 2; i >= 1; i--) {
            best[i] = Math.Max(best[i + 1], prefixSum[i] - best[i + 1]);
            Console.WriteLine(best[i]);
        }
        return best[1];
    }
}