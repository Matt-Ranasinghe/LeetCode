public class Solution {
    public bool CanAliceWin(int n) {
        int subtract = 10;
        bool result = false;
        while(n - subtract >= 0){
            n -= subtract--;
            result = !result;
        }
        return result;
    }
}