public class Solution {
    public int MaxSideLength(int[][] mat, int threshold) {
        int result = 0;
        int n = mat.Length, m = mat[0].Length;
        if(n == 0 || m == 0) return 0;
        int shortSide = Math.Min(n, m);
        int[,] prefixSum = new int[n,m];
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(j > 0){
                    prefixSum[i,j] = mat[i][j] + prefixSum[i,j - 1];
                }
                else{
                    prefixSum[i,j] = mat[i][j];
                }
            }
        }
        for(int i = 1; i <= shortSide; i++){
            bool foundSquare = false;
            for(int j = 0; j <= n - i; j++){
                for(int k = 0; k <= m - i; k++){
                    foundSquare = FindSquare(prefixSum, j, k, i, threshold);
                    if(foundSquare) break;
                }
                if(foundSquare) break;
            }
            if(!foundSquare){
                result = i - 1;
                break;
            }
            else if(shortSide == i) return i;
        }
        return result;
    }

    private bool FindSquare(int[,] prefixSum, int x, int y, int size, int threshold){
        int sum = 0;
        for(int i = x; i < x + size; i++){
            if(y == 0) sum += (prefixSum[i,y + size - 1]);
            else sum += (prefixSum[i,y + size - 1] - prefixSum[i,y - 1]);
        }
        Console.WriteLine(sum);
        return sum <= threshold;
    } 
}