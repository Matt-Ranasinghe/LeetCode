public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length, add = n - 1;
        while(digits[add] == 9){
            digits[add] = 0;
            add--;
            if(add == -1){
                int[] ld = new int[n + 1];
                ld[0] = 1;
                return ld;
            }
        }
        digits[add]++;
        return digits;
    }
}