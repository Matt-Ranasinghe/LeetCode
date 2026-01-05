class Solution:
    MOD: int = 1000000007
    def countPermutations(self, complexity: List[int]) -> int:
        first_complexity: int = complexity[0]
        n: int = len(complexity)
        for i in range(1, n):
            if (first_complexity >= complexity[i]):
                return 0
        return self.modFact(n - 1, 1)

    def modFact(self, n: int, result: int) -> int:
        if (n == 0):
            return result
        return self.modFact(n - 1, (result * n) % self.MOD)