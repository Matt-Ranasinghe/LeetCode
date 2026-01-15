public class Solution {
    public int MaximizeSquareHoleArea(int n, int m, int[] hBars, int[] vBars) {
        Array.Sort(hBars);
        Array.Sort(vBars);
        int maxHeight = 0, maxWidth = 0;
        int prev = -1, current = 1;
        foreach(int bar in hBars){
            if(prev == bar - 1){
                current++;
            }
            else{
                maxHeight = Math.Max(maxHeight, current);
                current = 2;
            }
            prev = bar;
        }
        maxHeight = Math.Max(maxHeight, current);
        current = 1;
        prev = -1;
        foreach(int bar in vBars){
            if(prev == bar - 1){
                current++;
            }
            else{
                maxWidth = Math.Max(maxWidth, current);
                current = 2;
            }
            prev = bar;
        }
        maxWidth = Math.Max(maxWidth, current);
        return SquareNum(Math.Min(maxWidth, maxHeight));
    }
    private int SquareNum(int x) => x * x;
}