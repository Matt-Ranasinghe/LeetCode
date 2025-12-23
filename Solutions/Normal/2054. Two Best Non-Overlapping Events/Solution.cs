public class Solution {
    public int MaxTwoEvents(int[][] events) {
        Array.Sort(events, (x, y) => x[0].CompareTo(y[0]));
        int result = 0, max = 0, n = events.Length;
        PriorityQueue<(int end, int score), int> pq = new PriorityQueue<(int end, int score), int>();
        foreach(int[] ev in events){
            pq.Enqueue((ev[1], ev[2]), ev[1]);
            while(pq.Count > 0 && pq.Peek().end < ev[0]){
                max = Math.Max(pq.Dequeue().score, max);
            }
            result = Math.Max(result, max + ev[2]);
        }
        return result;
    }
}