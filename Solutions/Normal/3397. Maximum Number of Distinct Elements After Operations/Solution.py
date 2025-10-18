class Solution:
    def maxDistinctElements(self, nums: List[int], k: int) -> int:
        nums.sort()
        result: int = 1
        next_best: int = nums[0] - k + 1
        for i in range(1, len(nums)):
            if(next_best < nums[i] - k):
                next_best = nums[i] - k + 1
                result += 1
            elif(next_best <= nums[i] + k):
                next_best += 1
                result += 1
        return result
