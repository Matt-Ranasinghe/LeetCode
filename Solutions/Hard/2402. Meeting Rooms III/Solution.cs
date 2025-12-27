public class Solution {
    public int MostBooked(int n, int[][] meetings) {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));
        PriorityQueue<int, int> availableRooms = new PriorityQueue<int, int>();
        for (int i = 0; i < n; i++) {
            availableRooms.Enqueue(i, i);
        }
        PriorityQueue<(long endTime, int room), (long, int)> busyRooms = new PriorityQueue<(long, int), (long, int)>();
        int[] count = new int[n];
        foreach (var meeting in meetings) {
            long start = meeting[0];
            long end = meeting[1];
            long duration = end - start;
            while (busyRooms.Count > 0 && busyRooms.Peek().endTime <= start) {
                (long endTime, int room) finished = busyRooms.Dequeue();
                availableRooms.Enqueue(finished.room, finished.room);
            }

            if (availableRooms.Count > 0) {
                int room = availableRooms.Dequeue();
                busyRooms.Enqueue((end, room), (end, room));
                count[room]++;
            } else {
                (long endTime, int room) earliest = busyRooms.Dequeue();
                long newEnd = earliest.endTime + duration;
                busyRooms.Enqueue((newEnd, earliest.room), (newEnd, earliest.room));
                count[earliest.room]++;
            }
        }
        int result = 0;
        for (int i = 1; i < n; i++) {
            if (count[i] > count[result]) {
                result = i;
            }
        }
        return result;
    }
}