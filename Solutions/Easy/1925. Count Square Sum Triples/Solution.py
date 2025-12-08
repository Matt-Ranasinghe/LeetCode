class Solution:
    def countTriples(self, n: int) -> int:
        result: int = 0
        for i in range(5, n + 1):
            for j in range(4, i):
                for k in range(3, j):
                    result += 2 if k**2 + j**2 == i**2 else 0
        return result