public class Solution {
    public long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost) {
        int n = original.Length;
        long[][] costTable = new long[26][];
        for(int i = 0; i < 26; i++){
            long[] arr = new long[26];
            Array.Fill(arr, -1);
            arr[i] = 0;
            costTable[i] = arr;
        }
        for(int i = 0; i < n; i++){
            int ori = original[i] - 'a';
            int cha = changed[i] - 'a';
            if(costTable[ori][cha] == -1 || costTable[ori][cha] > cost[i]) costTable[ori][cha] = cost[i];
        }
        for (int k = 0; k < 26; k++) {
            for (int i = 0; i < 26; i++) {
                for (int j = 0; j < 26; j++)  {
                    if (costTable[i][k] > -1 && costTable[k][j] > -1) {
                        if(costTable[i][j] == -1) costTable[i][j] = costTable[i][k] + costTable[k][j];
                        else costTable[i][j] = Math.Min(costTable[i][j], costTable[i][k] + costTable[k][j]);
                    }
                }
            }
        }
        long result = 0;
        int m = source.Length;
        for(int i = 0; i < m; i++){
            long transformationCost = costTable[source[i] - 'a'][target[i] - 'a'];
            if(transformationCost == -1) return -1;
            else result += transformationCost;
        }
        return result;
    }
}