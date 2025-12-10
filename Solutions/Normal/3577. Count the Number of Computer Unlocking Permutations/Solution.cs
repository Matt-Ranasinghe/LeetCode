public class Solution {
    const int MOD = (int)1e9 + 7;
    public int CountPermutations(int[] complexity) {
        int firstComplexity = complexity[0], n = complexity.Length;
        for(int i = 1; i < n; i++){
            if(complexity[i] <= firstComplexity){
                return 0;
            }
        }
        return Factorial(n - 1, 1);
    }

    private int Factorial(int n, long result){
        if(n == 0) return (int)result;
        return Factorial(n - 1, (result * n) % MOD);
    }
}