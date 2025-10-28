class Solution:
    def countValidSelections(self, nums: List[int]) -> int:
        n = len(nums)
        sum: List[int] = [nums[0]]
        for i in range(1, n):
            sum.append(nums[i] + sum[- 1])
        half = sum[-1] // 2
        even = sum[-1] % 2 == 0
        result = 0
        for i in range(n):
            if(even):
                if(sum[i] == half and nums[i] == 0):
                    result += 2
            else:
                if((sum[i] == half or sum[i] - 1 == half) and nums[i] == 0):
                    result += 1
        return result
        