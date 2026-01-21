class Solution:
    def minBitwiseArray(self, nums: List[int]) -> List[int]:
        n: int = len(nums)
        result: List[int] = []
        for i in range(0, n):
            exp: int = 1
            res: int = -1
            while((exp & nums[i]) != 0):
                res = nums[i] - exp
                exp <<= 1
            result.append(res)
        return result