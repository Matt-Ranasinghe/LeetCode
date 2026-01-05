class Solution:
    def longestPalindromeSubseq(self, s: str) -> int:
        n: int = len(s)
        dp: list[list[int]] = [[-1 for _ in range(0, n)] for _ in range(0, n)]
        return self.longestSequence(0, n - 1, s, dp)
        
    def longestSequence(self, left: int, right: int, s: str, dp: list[list[int]]) -> int:
        if left > right:
            return 0
        if left == right:
            return 1
        if dp[left][right] != -1:
            return dp[left][right]
        if s[left] == s[right]:
            dp[left][right] = self.longestSequence(left + 1, right - 1, s, dp) + 2
            return dp[left][right]
        dp[left][right] = max(self.longestSequence(left + 1, right, s, dp),
                              self.longestSequence(left, right - 1, s, dp))
        return dp[left][right]