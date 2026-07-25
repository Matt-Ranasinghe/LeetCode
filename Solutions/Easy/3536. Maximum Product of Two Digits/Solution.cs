public class Solution {
    public int MaxProduct(int n) {
        int largest = 0, second = 0;
        while(n > 0){
            int digit = n % 10;
            if(digit > largest){
                second = largest;
                largest = digit;
            }
            else if(digit > second){
                second = digit;
            }
            n /= 10;
        }
        return second * largest;
    }
}