public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        int appleSum = apple.Sum();
        Array.Sort(capacity, (x, y) => y.CompareTo(x));
        int result = 0, count = 0;
        while(appleSum > 0) {
            appleSum -= capacity[count++];
            result++;
        }
        return result;
    }
}