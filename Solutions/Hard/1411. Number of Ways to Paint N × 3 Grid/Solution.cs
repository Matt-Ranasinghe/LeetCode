public class Solution {
    private const int MOD = (int) 1e9 + 7;

    public int NumOfWays(int n) {
        long same = 6;
        long diff = 6;

        for (int i = 1; i < n; i++) {
            long newSame = (same * 3 + diff * 2) % MOD;
            long newDiff = (same * 2 + diff * 2) % MOD;
            same = newSame;
            diff = newDiff;
        }

        return (int)((same + diff) % MOD);
    }
}