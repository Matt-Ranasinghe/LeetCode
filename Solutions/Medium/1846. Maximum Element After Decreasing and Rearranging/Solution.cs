public class Solution {
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr) {
        Array.Sort(arr);
        int result = 0;
        foreach(int num in arr){
            if(result < num) result++;
        }
        return result;
    }
}