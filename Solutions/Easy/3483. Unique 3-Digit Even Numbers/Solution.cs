public class Solution {
    public int TotalNumbers(int[] digits) {
        int n = digits.Length;
        bool[] seen = new bool[1000];
        int result = 0;
        for(int i = 0; i < n; i++){
            if((digits[i] & 1) == 1) continue;
            for(int j = 0; j < n; j++){
                if(digits[j] == 0 || j == i) continue;
                for(int k = 0; k < n; k++){
                    if(k == i || j == k) continue;
                    int num = (digits[j] * 100) + (digits[k] * 10) + digits[i];
                    if(!seen[num]){
                        result++;
                        seen[num] = true;
                    }
                }
            }
        }
        return result;
    }
}