class Solution:
    def minCost(self, colours: str, neededTime: List[int]) -> int:
        n = len(colours)
        prev = "-"
        lastNum = 0
        result = 0
        for i in range(n):
            if (prev != colours[i]):
                prev = colours[i]
                lastNum = neededTime[i]
            elif (lastNum >= neededTime[i]):
                result += neededTime[i]
            else:
                result += lastNum
                lastNum = neededTime[i]
        return result
