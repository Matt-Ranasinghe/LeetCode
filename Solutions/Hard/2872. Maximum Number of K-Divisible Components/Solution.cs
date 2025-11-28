public class Solution {
    
    private int result = 0;
    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k) {
        Dictionary<int, List<int>> connections = new Dictionary<int, List<int>>();
        for(int i = 0; i < n; i++){
            connections[i] = new List<int>();
        }
        foreach(int[] edge in edges){
            connections[edge[0]].Add(edge[1]);
            connections[edge[1]].Add(edge[0]);
        }
        DFS(connections, values, k, 0, -1);
        return result;
    }

    private long DFS (Dictionary<int, List<int>> connections, int[] values, int k, int node, int parent){
        long nodeConnection = values[node];
        foreach(int child in connections[node]){
            if(child == parent) continue;
            nodeConnection += DFS(connections, values, k, child, node);
        }
        if(nodeConnection % k == 0){
            result++;
            return 0;
        }
        else{
            return nodeConnection;
        }
    }
}