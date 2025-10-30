public class Solution {
    public int MinNumberOperations(int[] target) {
        int numberOfPasses = 0;
        int prev = 0;
        foreach(int num in target){
            if(num > prev) numberOfPasses += (num - prev);
            prev = num;
        }
        return numberOfPasses;
    }
}