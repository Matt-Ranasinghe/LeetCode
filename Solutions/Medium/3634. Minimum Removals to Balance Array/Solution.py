class Solution:
    def minRemoval(self, nums: List[int], k: int) -> int:
        n: int = len(nums)
        nums.sort()
        result = float('inf')
        right: int = 0
        for i in range(0, n):
            while(right < n and nums[i] * k >= nums[right]):
                right += 1
            result = min(n - (right - i), result)
        return result