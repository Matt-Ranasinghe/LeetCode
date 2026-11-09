public class Solution {
    public IList<int> BusiestServers(int k, int[] arrival, int[] load) {
        int n = arrival.Length;
        PriorityQueue<(int server, int end), int> loadedServers = new PriorityQueue<(int server, int end), int>();
        int[] jobsAssigned = new int[k];
        SortedSet<int> availableServers = new SortedSet<int>();
        int time = 0;
        for(int i = 0; i < k; i++) availableServers.Add(i);
        for(int i = 0; i < n; i++){
            time = arrival[i];
            while(loadedServers.Count > 0 && loadedServers.Peek().end <= time){
                int freedServer = loadedServers.Dequeue().server;
                if(freedServer < i % k) freedServer += ((i / k) + 1) * k;
                else freedServer += (i / k) * k;
                availableServers.Add(freedServer);
            }
            if(availableServers.Count < 1) continue;
            
            int end = time + load[i];
            if(availableServers.Contains(i)){
                int server = i % k;
                loadedServers.Enqueue((i % k, end), end);
                availableServers.Remove(i);
                jobsAssigned[server]++;
            }
            else {
                int nextAvailable = availableServers.Min();
                loadedServers.Enqueue((nextAvailable % k, end), end);
                availableServers.Remove(nextAvailable);
                jobsAssigned[nextAvailable % k]++;
            }
        }
        int max = jobsAssigned.Max();
        List<int> result = new List<int>();
        for(int i = 0; i < k; i++){
            if(jobsAssigned[i] == max) result.Add(i);
        }
        return result;
    }
}