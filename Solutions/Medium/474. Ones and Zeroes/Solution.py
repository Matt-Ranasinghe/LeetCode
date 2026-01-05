class Solution:
    def findMaxForm(self, strs: List[str], m: int, n: int) -> int:
        dp: List[List[int]] = [[-1 for _ in range(n + 1)] for _ in range(m + 1)]
        dp[0][0] = 0
        result: int = 0
        for string in strs:
            zeroes: int = 0
            ones: int = 0
            for c in string:
                if(c == '1'):
                    ones += 1
                else:
                    zeroes += 1
            for i in range(m, zeroes - 1, -1):
                for j in range(n, ones - 1, -1):
                    if(dp[i - zeroes][j - ones] != -1):
                        dp[i][j] = max(dp[i][j], dp[i - zeroes][j - ones] + 1)
                        result = max(dp[i][j], result)
        return result