public class Solution {
    public int[] GcdValues(int[] nums, long[] queries) {
        int m = nums.Max();
        long[] frequency = new long[m + 1];
        foreach (int num in nums) {
            frequency[num]++;
        }
        for (int i = 1; i <= m; i++) {
            for (int j = i * 2; j <= m; j += i) {
                frequency[i] += frequency[j];
            }
        }
        for (int i = 1; i <= m; i++) {
            frequency[i] = frequency[i] * (frequency[i] - 1) / 2;
        }
        for (int i = m; i >= 1; i--) {
            for (int j = i * 2; j <= m; j += i) {
                frequency[i] -= frequency[j];
            }
        }
        for (int i = 1; i <= m; i++) {
            frequency[i] += frequency[i - 1];
        }
        int[] result = new int[queries.Length];
        for (int k = 0; k < queries.Length; k++) {
            long q = queries[k] + 1;
            int left = 1, right = m;
            while (left < right) {
                int mid = (left + right) / 2;
                if (frequency[mid] >= q) {
                    right = mid;
                } else {
                    left = mid + 1;
                }
            }
            result[k] = left;
        }
        return result;
    }
}