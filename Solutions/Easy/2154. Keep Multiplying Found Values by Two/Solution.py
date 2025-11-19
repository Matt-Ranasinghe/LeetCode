class Solution:
    def findFinalValue(self, nums: List[int], original: int) -> int:
        seen = set()
        for num in nums:
            if(num > original):
                seen.add(num)
            elif(num == original):
                original *= 2
                while(original in seen):
                    original *= 2
        return original