public class Solution {
    public int MinScore(int n, int[][] roads) {
        List<(int dest, int weight)>[] connections = new List<(int dist, int weight)>[n + 1];
        for(int i = 0; i <= n; i++) connections[i] = new List<(int dist, int weight)>();
        foreach(int[] road in roads){
            connections[road[0]].Add((road[1], road[2]));
            connections[road[1]].Add((road[0], road[2]));
        }
        int result = Int32.MaxValue;
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        bool[] visited = new bool[n + 1];
        visited[1] = true;
        while(queue.Count > 0){
            int node = queue.Dequeue();
            foreach((int dest, int weight) edge in connections[node]){
                result = Math.Min(edge.weight, result);
                if(visited[edge.dest]) continue;
                visited[edge.dest] = true;
                queue.Enqueue(edge.dest);
            }
        }
        return result;
    }
}