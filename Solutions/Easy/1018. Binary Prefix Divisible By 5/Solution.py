class Solution:
    def prefixesDivBy5(self, nums: List[int]) -> List[bool]:
        result: List[int] = []
        rem: int = 0
        for num in nums:
            rem <<= 1
            rem += num
            rem %= 5
            result.append((rem == 0))
        return result