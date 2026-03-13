public class Solution {
    public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes) {
        int n = workerTimes.Length;
        PriorityQueue<(long time, long tot, int worker), long> pq = new PriorityQueue<(long time, long pos, int worker), long>();
        for(int i = 0; i < n; i++){
            pq.Enqueue((workerTimes[i], 0, i), workerTimes[i]);
        }
        long result = 0;
        while(mountainHeight > 0){
            (long time, long tot, int worker) pair = pq.Dequeue();
            result = pair.time + pair.tot;
            long newTime = pair.time + workerTimes[pair.worker];
            pq.Enqueue((newTime, result, pair.worker), result + newTime);
            mountainHeight--;
        }
        return result;
    }
}