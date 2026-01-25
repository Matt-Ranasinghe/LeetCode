class Solution:
    def minimumDifference(self, nums: List[int], k: int) -> int:
        if(k == 1):
            return 0
        nums.sort()
        result = float('inf')
        for i in range(0, len(nums) - (k - 1)):
            result = min(result, nums[i + k - 1] - nums[i])
        return result