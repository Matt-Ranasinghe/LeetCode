public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        int result = arr1.Length;
        foreach(int num1 in arr1){
            foreach(int num2 in arr2){
                if((int)Math.Abs(num1 - num2) <= d){
                    result--;
                    break;
                }
            }
        }
        return result;
    }
}