public class Solution {
    public int MaxJumps(int[] arr, int d) {
        int n = arr.Length;
        int[] bestPath = new int[n];
        int result = 0;
        Array.Fill(bestPath, -1);
        for(int i = 0; i < n; i++){
            if(bestPath[i] != -1) continue;
            int jumps = 0;
            for(int j = i - 1; j >= Math.Max(0, i - d); j--){
                if(arr[j] >= arr[i]) break;
                jumps = Math.Max(jumps, bestPath[j] + 1);
            }
            for(int j = i + 1; j <= Math.Min(n - 1, i + d); j++){
                if(arr[j] >= arr[i]) break;
                if(bestPath[j] != -1) jumps = Math.Max(jumps, bestPath[j] + 1);
                else {
                    jumps = Math.Max(jumps, depthFirstJumps(arr, j, d, bestPath) + 1);
                }
            }
            bestPath[i] = jumps;
            result = Math.Max(jumps + 1, result);
        }
        return result;
    }

    private int depthFirstJumps(int[] arr, int current, int d, int[] bestPath){
        int n = arr.Length;
        if(bestPath[current] != -1) return bestPath[current];
        int jumps = 0;
        for(int j = current - 1; j >= Math.Max(0, current - d); j--){
            if(arr[j] >= arr[current]) break;
            if(bestPath[j] != -1) jumps = Math.Max(jumps, bestPath[j] + 1);
            else {
                jumps = Math.Max(jumps, depthFirstJumps(arr, j, d, bestPath) + 1);
            }
        }
        for(int j = current + 1; j <= Math.Min(n - 1, current + d); j++){
            if(arr[j] >= arr[current]) break;
            if(bestPath[j] != -1) jumps = Math.Max(jumps, bestPath[j] + 1);
            else {
                jumps = Math.Max(jumps, depthFirstJumps(arr, j, d, bestPath) + 1);
            }
        }
        bestPath[current] = jumps;
        return jumps;
    }
}