public class Solution {
    public bool SumGame(string num) {
        int n = num.Length;
        int LHSwilds = 0;
        int LHStotal = 0;
        for(int i = 0; i < n/2; i++){
            if(num[i] == '?') LHSwilds++;
            else LHStotal += (num[i] - '0');
        }
        for(int i = n/2; i < n; i++){
            if(num[i] == '?') LHSwilds--;
            else LHStotal -= (num[i] - '0');
        }
        if(LHStotal == 0 && LHSwilds == 0) return false;
        bool positive = LHStotal > 0;
        bool wilds = LHSwilds > 0;
        if((positive && wilds) || (!positive && !wilds) || Math.Abs(LHSwilds) % 2 == 1) return true;
        if((LHSwilds / 2) * 9 + LHStotal == 0) return false;
        return true;
    }
}