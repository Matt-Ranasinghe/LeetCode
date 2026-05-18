public class Solution {
    public int MinJumps(int[] arr) {
        int n = arr.Length;
        if(n == 1) return 0;
        Dictionary<int, List<int>> positionMap = new Dictionary<int, List<int>>();
        for(int i = 0; i < n; i++){
            int num = arr[i];
            if(!positionMap.ContainsKey(num)) positionMap[num] = new List<int>();
            positionMap[num].Add(i);
        }
        int[] visited = new int[n];
        Array.Fill(visited, -1);
        visited[0] = 0;
        Queue<int> posQueue = new Queue<int>();
        posQueue.Enqueue(0);
        while(posQueue.Count > 0){
            int posDeq = posQueue.Dequeue();
            int arrVal = arr[posDeq];
            int steps = visited[posDeq];
            if(positionMap.ContainsKey(arrVal)){
                foreach(int position in positionMap[arrVal]){
                    if(visited[position] != -1) continue;
                    if(position == n - 1) return steps + 1;
                    posQueue.Enqueue(position);
                    visited[position] = steps + 1;
                }
                positionMap.Remove(arrVal);
            }
            int posSub = posDeq - 1;
            int posAdd = posDeq + 1;
            if(posSub >= 0 && visited[posSub] == -1){
                visited[posSub] = steps + 1;
                posQueue.Enqueue(posSub);
            }
            if(posAdd < n && visited[posAdd] == -1){
                if(posAdd == n - 1) return steps + 1;
                visited[posAdd] = steps + 1;
                posQueue.Enqueue(posAdd);
            }
        }
        return -1;
    }
}