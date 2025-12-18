public class Solution {
    public long MaxProfit(int[] prices, int[] strategy, int k) {
        int n = prices.Length;
        long result = 0;
        long baseProfit = 0, modifiedProfit = 0; 
        int half = k/2;
        for(int i = 0; i < n; i++){
            baseProfit += prices[i] * strategy[i];
        }
        modifiedProfit = baseProfit;
        for(int i = 0; i < k; i++){
            if(i < half){
                modifiedProfit -= strategy[i] * prices[i];
            }
            else{
                modifiedProfit += (1 - strategy[i]) * prices[i];
            }
        }
        result = Math.Max(baseProfit, modifiedProfit);
        for(int i = 0; i < n - k; i++){
            modifiedProfit += strategy[i] * prices[i];
            modifiedProfit -= prices[i + half];
            modifiedProfit += (1 - strategy[i + k]) * prices[i + k];
            result = Math.Max(modifiedProfit, result);
        }
        return result;
    }
}