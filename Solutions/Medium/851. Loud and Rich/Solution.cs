public class Solution {
    public int[] LoudAndRich(int[][] richer, int[] quiet) {
        int n = quiet.Length;
        List<int>[] richTable = new List<int>[n];
        PriorityQueue<(int per, int quiet), int> pq = new PriorityQueue<(int per, int quiet), int>();
        for(int i = 0; i < n; i++) {
            richTable[i] = new List<int>();
            pq.Enqueue((i, quiet[i]), quiet[i]);
        }
        foreach(int[] richness in richer){
            richTable[richness[0]].Add(richness[1]);
        }
        int[] result = new int[n];
        Array.Fill(result, -1);
        while(pq.Count > 0){
            (int per, int quiet) dequeued = pq.Dequeue();
            int person = dequeued.per;
            int quietness = dequeued.quiet;
            if(result[person] == -1) result[person] = person;
            foreach(int other in richTable[person]){
                if(result[other] != -1) continue;
                result[other] = result[person];
                pq.Enqueue((other, quietness), quietness);
            }
        }
        return result;
    }
}