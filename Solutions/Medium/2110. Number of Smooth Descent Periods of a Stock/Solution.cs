public class Solution {
    public long GetDescentPeriods(int[] prices) {
        int start = -1, startDist = -1;
        int n = prices.Length;
        long result = 0;
        for(int i = 0; i < n; i++){
            if(prices[i] != start - (i - startDist)){
                result += 1;
                startDist = i;
                start = prices[i];
            }
            else{
                result += i - startDist + 1;
            }
        }
        return result;
    }
}