class Solution:
    def totalMoney(self, n: int) -> int:
        mod = n % 7
        div = n // 7
        result = 28 * div + 7 * (div * (div - 1)) / 2
        result += mod * (div + 1) + (mod * (mod - 1)) / 2
        return int(result)