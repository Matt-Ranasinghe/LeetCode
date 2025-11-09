class Solution:
    def minimumOneBitOperations(self, n: int) -> int:
        
        def mostSigBit(n: int) -> int:
            msb = 1
            while(msb <= n):
                msb <<= 1
            return msb >> 1
        
        def flipBits(msb: int) -> int:
            return (msb << 1) - 1

        res: int = 0
        while(n > 0):
            msb: int = mostSigBit(n)
            res ^= flipBits(msb)
            n ^= msb


        return res