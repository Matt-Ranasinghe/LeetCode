public class Solution {
    public int[] SortByBits(int[] arr) {
        PriorityQueue<int, (int, int)> pq = new PriorityQueue<int, (int, int)>();
        foreach(int num in arr){
            int bitCount = CountBits(num);
            pq.Enqueue(num, (bitCount, num));
        }
        int n = arr.Length;
        for(int i = 0; i < n; i++){
            arr[i] = pq.Dequeue();
        }
        return arr;
    }

    private int CountBits(int num){
        int result = 0;
        while(num > 0){
            result += (num & 1);
            num >>= 1;
        }
        return result;
    }
}