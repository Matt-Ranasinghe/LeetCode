public class Solution {
    public string MaxSumOfSquares(int num, int sum) {
        if(sum > 9 * num) return "";
        StringBuilder res = new StringBuilder();
        while(sum > 0){
            if(sum >= 9) res.Append('9');
            else res.Append((char)(sum + '0'));
            num--;
            sum -= 9;
        }
        for(int i = 0; i < num; i++) res.Append('0');
        return res.ToString();
    }
}