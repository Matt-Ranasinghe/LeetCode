class Solution:
    def kLengthApart(self, nums: List[int], k: int) -> bool:
        pointer: int = -k - 1
        for i in range(len(nums)):
            if(nums[i] == 1):
                if(pointer + k >= i):
                    return False
                pointer = i
        return True
