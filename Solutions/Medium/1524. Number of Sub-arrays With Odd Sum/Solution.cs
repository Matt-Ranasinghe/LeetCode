public class Solution {
    public int NumOfSubarrays(int[] arr) {
        const int MOD = (int)1e9 + 7;
        int result = 0;
        int n = arr.Length;
        int[,] prefixSum = new int[n + 1,2];
        for(int i = 0; i < n; i++){
            int parity = arr[i] % 2;
            prefixSum[i + 1,parity] = 1;
            prefixSum[i + 1,0] += prefixSum[i,0 + parity];
            prefixSum[i + 1,1] += prefixSum[i,(1 + parity) % 2];
            result = (result + prefixSum[i + 1,1]) % MOD;
        }
        return result;
    }
}