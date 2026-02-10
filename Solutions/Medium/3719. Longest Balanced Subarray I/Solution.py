class Solution:
    def longestBalanced(self, nums: List[int]) -> int:
        result: int = 0
        n: int = len(nums)
        for i in range(0, n):
            seenDict: dict[int:int] = {}
            even: int = 0
            odd: int = 0
            for j in range(i, n):
                if(nums[j] in seenDict):
                    seenDict[nums[j]] += 1
                else:
                    if(nums[j] % 2 == 0):
                        even += 1
                    else:
                        odd += 1
                    seenDict[nums[j]] = 1
                if (odd == even):
                    result = max(result, j - i + 1)
        return result        