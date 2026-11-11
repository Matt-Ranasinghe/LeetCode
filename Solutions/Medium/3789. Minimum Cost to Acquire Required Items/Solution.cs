public class Solution {
    public long MinimumCost(int cost1, int cost2, int costBoth, int need1, int need2) {
        long smaller = Math.Min(need1, need2);
        long larger = Math.Max(need1, need2);
        if(cost1 >= costBoth && cost2 >= costBoth) return larger * costBoth;
        long costCombined = cost1 + cost2;
        long result = 0;
        if(costCombined > costBoth) result += smaller * costBoth;
        else result += smaller * costCombined;
        if(need1 > need2) result += (need1 - need2) * (long)Math.Min(cost1, costBoth);
        else result += (need2 - need1) * (long)Math.Min(cost2, costBoth);
        return result;
    }
}