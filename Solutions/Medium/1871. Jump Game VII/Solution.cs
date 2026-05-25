public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {
        int n = s.Length;
        if(s[n - 1] == '1') return false;
        bool[] visited = new bool[n];
        visited[0] = true;
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(0);
        int right = 0;
        while(queue.Count > 0){
            int position = queue.Dequeue();
            for(int i = Math.Max(position + minJump, right); i <= Math.Min(n - 1, position + maxJump); i++){
                if(s[i] == '0' && !visited[i]){
                    if(i == n - 1) return true;
                    queue.Enqueue(i);
                    visited[i] = true;
                }
            }
            right = Math.Min(n - 1, position + maxJump);
        }
        return false;
    }
}