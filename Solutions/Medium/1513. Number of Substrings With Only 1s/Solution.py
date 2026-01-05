class Solution:
    def numSub(self, s: str) -> int:
        run: int = 0
        result: int = 0
        MOD: int = 1000000007
        for c in s:
            if(c == '1'):
                run += 1
                result = (result + run) % MOD
            else:
                run = 0
        return result