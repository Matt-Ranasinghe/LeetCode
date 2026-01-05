public class Solution {
    public int[][] RangeAddQueries(int n, int[][] queries) {
        int[][] matrixResult = new int[n][];
        for(int i = 0; i < n; i++){
            matrixResult[i] = new int[n];
        }
        foreach(int[] query in queries){
            for(int i = query[0]; i <= query[2]; i++){
                matrixResult[i][query[1]]++;
                if(query[3] < n - 1) matrixResult[i][query[3] + 1]--;
            }
        }
        foreach(int[] row in matrixResult){
            for(int i = 1; i < n; i++){
                row[i] += row[i - 1];
            }
        }
        return matrixResult;
    }
}