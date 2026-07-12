public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        int n = arr.Length;
        PriorityQueue<(int val, int pos), int> pq = new PriorityQueue<(int val, int pos), int>();
        for(int i = 0; i < n; i++){
            pq.Enqueue((arr[i], i), arr[i]);
        }
        int current = 0, prev = Int32.MinValue;
        while(pq.Count > 0){
            (int val, int pos) dequeued = pq.Dequeue();
            if(prev < dequeued.val) 
            {
                current++;
                prev = dequeued.val;
            }
            arr[dequeued.pos] = current;
        }
        return arr;
    }
}