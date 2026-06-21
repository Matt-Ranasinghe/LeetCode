public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        Array.Sort(costs);
        int result = 0;
        for( ; result < costs.Length; result++){
            if(costs[result] <= coins) coins -= costs[result];
            else break;
        }
        return result;
    }
}