public class Solution {
    public int MinimumPairRemoval(int[] nums) {
        int n = nums.Length;
        if (n < 2) return 0;
        long[] newNums = nums.Select(item => (long)item).ToArray();
        int end = -1;
        int[] nextActive = new int[n];
        int[] prevActive = new int[n];
        long[] snapshot = new long[n];
        bool[] active = new bool[n];
        int violationCount = 0;
        PriorityQueue<(long val, int index), (long val, int index)> pq = new PriorityQueue<(long val, int index), (long val, int index)>(
            Comparer<(long val, int index)>.Create((x, y) => {
                int res = x.val.CompareTo(y.val);
                return res != 0 ? res : x.index.CompareTo(y.index);
            })
        );
        int IsViolation(int left, int right) {
            if (left == end || right == end) return 0;
            return newNums[left] > newNums[right] ? 1 : 0;
        }
        for (int i = 0; i < n; i++) {
            active[i] = true;
            nextActive[i] = (i < n - 1) ? i + 1 : end;
            prevActive[i] = (i > 0) ? i - 1 : end;
        }
        for (int i = 0; i < n; i++) {
            if (nextActive[i] != end) {
                violationCount += IsViolation(i, nextActive[i]);
                snapshot[i] = newNums[i] + newNums[nextActive[i]];
                pq.Enqueue((snapshot[i], i), (snapshot[i], i));
            }
        }
        int result = 0;
        while (violationCount > 0 && pq.Count > 0) {
            long currentMergeVal = 0;
            int index = -1;
            while (pq.Count > 0) {
                (long val, int index) top = pq.Dequeue();
                if (active[top.index] && nextActive[top.index] != end && top.val == snapshot[top.index]) {
                    currentMergeVal = top.val;
                    index = top.index;
                    break;
                }
            }
            if (index == -1) break;
            int nextIdx = nextActive[index];
            int pIdx = prevActive[index];
            int afterNext = nextActive[nextIdx];
            violationCount -= IsViolation(pIdx, index);
            violationCount -= IsViolation(index, nextIdx);
            violationCount -= IsViolation(nextIdx, afterNext);
            newNums[index] = currentMergeVal;
            active[nextIdx] = false;
            nextActive[index] = afterNext;
            if (afterNext != end) {
                prevActive[afterNext] = index;
            }
            violationCount += IsViolation(pIdx, index);
            violationCount += IsViolation(index, afterNext);
            if (nextActive[index] != end) {
                snapshot[index] = newNums[index] + newNums[nextActive[index]];
                pq.Enqueue((snapshot[index], index), (snapshot[index], index));
            }
            if (pIdx != end) {
                snapshot[pIdx] = newNums[pIdx] + newNums[index];
                pq.Enqueue((snapshot[pIdx], pIdx), (snapshot[pIdx], pIdx));
            }
            result++;
        }
        return result;
    }
}