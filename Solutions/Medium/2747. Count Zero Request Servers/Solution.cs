public class Solution {
    public int[] CountServers(int n, int[][] logs, int x, int[] queries) {
        List<int[]>[] serverRequests = new List<int[]>[n + 1];
        for(int i = 0; i <= n; i++) serverRequests[i] = new List<int[]>();
        Array.Sort(logs, (x, y) => {
            int comp = x[1].CompareTo(y[1]);
            if(comp != 0) return comp;
            else return x[0].CompareTo(y[0]);
        });
        foreach(int[] log in logs){
            int serverIdx = log[0];
            if(serverRequests[serverIdx].Count < 1) serverRequests[serverIdx].Add(new int[]{log[1], log[1] + x});
            else{
                int m = serverRequests[serverIdx].Count;
                if(serverRequests[serverIdx][m - 1][1] >= log[1]) serverRequests[serverIdx][m - 1][1] = log[1] + x;
                else serverRequests[serverIdx].Add(new int[]{log[1], log[1] + x});
            }
        }
        int r = logs.Length;
        int lastServerRequest = logs[r - 1][1];
        int s = lastServerRequest + x + 2;
        int[] prefixSum = new int[s];
        foreach(List<int[]> server in serverRequests){
            foreach(int[] request in server){
                prefixSum[request[0]] += 1;
                prefixSum[request[1] + 1] -= 1;
            }
        }
        for(int i = 1; i < s; i++){
            prefixSum[i] += prefixSum[i - 1];
        }

        int q = queries.Length;
        int[] result = new int[q];
        for(int i = 0; i < q; i++){
            if(queries[i] >= s) result[i] = n;
            else result[i] = n - prefixSum[queries[i]];
        }
        return result;
    }
}