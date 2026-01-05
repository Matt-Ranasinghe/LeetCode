public class Solution {
    public long MaxMatrixSum(int[][] matrix) {
        int smallestNum = Int32.MaxValue;
        bool oddNeg = false;
        long result = 0;
        foreach(int[] row in matrix){
            foreach(int num in row){
                if(num < 0) {
                    oddNeg = !oddNeg;
                }
                smallestNum = Math.Min(smallestNum, Math.Abs(num));
                result += Math.Abs(num);
            }
        }
        return oddNeg ? result - 2 * smallestNum : result;
    }
}