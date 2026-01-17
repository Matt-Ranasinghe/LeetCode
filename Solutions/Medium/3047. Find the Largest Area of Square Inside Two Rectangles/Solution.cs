public class Solution {
    public long LargestSquareArea(int[][] bottomLeft, int[][] topRight) {
        int n = bottomLeft.Length;
        long result = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < i; j++){
                result = Math.Max(result, MaxSideLength(bottomLeft[i], bottomLeft[j], topRight[i], topRight[j]));
            }
        }
        return result * result;
    }

    private int MaxSideLength(int[] BL1, int[] BL2, int[] TR1, int[] TR2){
        int BX = Math.Max(BL1[0], BL2[0]);
        int BY = Math.Max(BL1[1], BL2[1]);
        int TX = Math.Min(TR1[0], TR2[0]);
        int TY = Math.Min(TR1[1], TR2[1]);
        return Math.Min((TX - BX), (TY - BY));
    }
}