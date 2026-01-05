class Solution:
    def maxOperations(self, s: str) -> int:
        one_seen: bool = False
        ones: int = 0
        result: int = 0
        for c in s:
            if(c == '1'):
                one_seen = True
                ones += 1
            elif(one_seen):
                result += ones
                one_seen = False
        return result