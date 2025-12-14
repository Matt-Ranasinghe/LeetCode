public class Solution {
    public int NumberOfWays(string corridor) {
        int chairNum = 0;
        List<(int Start, int End)> gaps = new List<(int Start, int End)>();
        int n = corridor.Length;
        const int MOD = (int) 1e9 + 7;
        int start = -1;
        for(int i = 0; i < n; i++){
            if(corridor[i] == 'S'){
                chairNum++;
                if(chairNum % 2 == 1){
                    start = i;
                }
                else{
                    gaps.Add((start, i));
                    start = -1;
                }
            }
        }
        if(start != -1 || gaps.Count() == 0) return 0;
        long result = 1;
        for(int i = 0; i < gaps.Count() - 1; i++){
            result = (result * (gaps[i + 1].Start - gaps[i].End)) % MOD;
        }
        return (int) result;
    }
}