public class Solution {
    public int MinCost(int n, int[][] edges) {
        Dictionary<int, List<(int node, int cost)>> dictEdges = new Dictionary<int, List<(int node, int cost)>>();
        for(int i = 0; i < n; i++){
            dictEdges[i] = new List<(int node, int cost)>();
        }
        foreach(int[] edge in edges){
            dictEdges[edge[0]].Add((edge[1], edge[2]));
            dictEdges[edge[1]].Add((edge[0], edge[2] * 2));
        }
        PriorityQueue<(int node, int cost), int> pq = new PriorityQueue<(int node, int cost), int>();
        HashSet<int> seen = new HashSet<int>();
        pq.Enqueue((0, 0), 0);
        while(pq.Count > 0){
            (int node, int cost) dequeuedNode = pq.Dequeue();
            if(seen.Contains(dequeuedNode.node)) continue;
            seen.Add(dequeuedNode.node);
            if(dequeuedNode.node == n - 1) return dequeuedNode.cost;
            foreach((int node, int cost) connected in dictEdges[dequeuedNode.node]){
                int cost = dequeuedNode.cost + connected.cost;
                pq.Enqueue((connected.node, cost), cost);
            }
        }
        return -1;
    }
}