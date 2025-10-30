class Solution:
    def minNumberOperations(self, target: List[int]) -> int:
        numOfPasses: int = 0
        prev: int = 0
        for num in target:
            if(prev < num):
                numOfPasses += (num - prev)
            prev = num
        return numOfPasses