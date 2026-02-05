class Solution:
    def constructTransformedArray(self, nums: List[int]) -> List[int]:
        result: List[int] = []
        n: int = len(nums)
        for i in range(0, n):
            move: int = i + nums[i]
            result.append(nums[move % n])
        return result