class Solution:
    def countOdds(self, low: int, high: int) -> int:
        return floor((high - low) / 2) + 1 if low % 2 == 1 else ceil((high-low) / 2)