public class Solution {
    public int AssignEdgeWeights(int[][] edges) {
        int MOD = (int)1e9 + 7;
        Dictionary<int, List<int>> dictEdges = new Dictionary<int, List<int>>();
        foreach(int[] edge in edges){
            if(!dictEdges.ContainsKey(edge[0])) dictEdges[edge[0]] = new List<int>();
            if(!dictEdges.ContainsKey(edge[1])) dictEdges[edge[1]] = new List<int>();
            dictEdges[edge[0]].Add(edge[1]);
            dictEdges[edge[1]].Add(edge[0]);
        }
        HashSet<int> visited = new HashSet<int>();
        visited.Add(1);
        Queue<(int node, int depth)> queue = new Queue<(int node, int depth)>();
        queue.Enqueue((1, 0));
        int maxDepth = 1;
        while(queue.Count > 0){
            (int node, int depth) nodeData = queue.Dequeue();
            maxDepth = nodeData.depth;
            foreach(int neighbour in dictEdges[nodeData.node]){
                if(!visited.Contains(neighbour)){
                    visited.Add(neighbour);
                    queue.Enqueue((neighbour, nodeData.depth + 1));
                }
            }
        }
        long result = 1;
        for(int i = 1; i < maxDepth; i++){
            result = (result * 2) % MOD;
        }
        return (int) result;
    }
}