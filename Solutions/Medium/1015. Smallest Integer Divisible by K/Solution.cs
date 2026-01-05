public class Solution {
    public int SmallestRepunitDivByK(int k) {
        if(k % 2 == 0 || k % 5 == 0){
            return -1;
        }
        int counter = 1 , reminder = 1%k ;
        while(reminder != 0){
            reminder = (reminder * 10 + 1) % k ;
            counter++;
        } 
        return counter;
    }
}