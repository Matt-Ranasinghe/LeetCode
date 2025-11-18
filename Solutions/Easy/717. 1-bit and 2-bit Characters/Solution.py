class Solution:
    def isOneBitCharacter(self, bits: List[int]) -> bool:
        if(bits[-1] == 1):
            return False
        n = len(bits)
        i = 0
        while(i < n):
            if(i == n - 1):
                return True
            if(bits[i] == 1):
                i += 1
            i += 1
        return False