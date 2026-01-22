class Solution:
    def minimumPairRemoval(self, nums: List[int]) -> int:
        n: int = len(nums)
        result: int = 0
        while(not(self.nonDecreasing(nums))):
            result += 1
            minSum, pos = (5000000, -1)
            for i in range(0, n - 1):
                if(minSum > nums[i] + nums[i + 1]):
                    minSum = nums[i] + nums[i + 1]
                    pos = i
            n -= 1
            nums.pop(pos + 1)
            nums[pos] = minSum
        return result
    
    def nonDecreasing(self, nums: List[int]) -> bool:
        n: int = len(nums)
        for i in range(1, n):
            if(nums[i - 1] > nums[i]):
                return False
        return True