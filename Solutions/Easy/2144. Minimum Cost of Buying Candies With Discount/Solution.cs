public class Solution {
    public int MinimumCost(int[] cost) {
        Array.Sort(cost, (a, b) => b.CompareTo(a));
        int result = 0, n = cost.Length;
        for(int i = 0; i < n; i += 3){
            if(i + 1 < n) result += cost[i] + cost[i + 1];
            else result += cost[i];
        }
        return result;
    }
}