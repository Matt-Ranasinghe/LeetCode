public class Solution {
    public bool CanReach(int[] arr, int start) {
        if(arr[start] == 0) return true;
        int n = arr.Length;
        bool[] visited = new bool[n];
        visited[start] = true;
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        while(queue.Count > 0){
            int value = queue.Dequeue();
            int lb = value - arr[value];
            int ub = value + arr[value];
            if(lb >= 0 && !visited[lb]){
                if(arr[lb] == 0) return true;
                visited[lb] = true;
                queue.Enqueue(lb);
            }
            if(ub < n && !visited[ub]){
                if(arr[ub] == 0) return true;
                visited[ub] = true;
                queue.Enqueue(ub);
            }
        }
        return false;
    }
}