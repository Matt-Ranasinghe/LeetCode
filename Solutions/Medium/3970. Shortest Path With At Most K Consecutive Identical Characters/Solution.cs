public class Solution {
    public int ShortestPath(int n, int[][] edges, string labels, int k) {
        if(n == 1) return 0;
        List<(int end, int width)>[] nodes = new List<(int end, int width)>[n];
        for(int i = 0; i < n; i++){
            nodes[i] = new List<(int end, int width)>();
        }
        foreach(int[] edge in edges){
            nodes[edge[0]].Add((edge[1], edge[2]));
        }
        if(nodes[0].Count < 1) return -1;
        PriorityQueue<(int node, char c, int charCount, int weight), int> pq = new PriorityQueue<(int node, char c, int charCount, int weight), int>();
        pq.Enqueue((0, labels[0], 1, 0), 0);
        bool[,] seen = new bool[n,k + 1];
        while(pq.Count > 0){
            (int node, char c, int charCount, int weight) nodeData = pq.Dequeue();
            if(seen[nodeData.node, nodeData.charCount]) continue;
            if(nodeData.node == n - 1) return nodeData.weight;
            seen[nodeData.node, nodeData.charCount] = true;
            foreach((int end, int weight) connection in nodes[nodeData.node]){
                int endNode = connection.end;
                int newWeight =  nodeData.weight + connection.weight;
                if(labels[endNode] != nodeData.c) {
                    pq.Enqueue((endNode, labels[endNode], 1, newWeight), newWeight);
                }
                else if(k >= nodeData.charCount + 1){
                    pq.Enqueue((endNode, labels[endNode], nodeData.charCount + 1, newWeight), newWeight);
                }
            }
        }
        return -1;
    }
}