public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        Array.Sort(happiness, (x, y) => y.CompareTo(x));
        long result = 0;
        for(int i = 0; i < k; i++){
            if(happiness[i] - i <= 0) return result;
            result += happiness[i] - i;
        }
        return result;
    }
}