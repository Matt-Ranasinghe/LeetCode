class Solution:
    def smallestNumber(self, n: int) -> int:
        result: int = 1
        while result < n:
            result *= 2
            result += 1
        return result