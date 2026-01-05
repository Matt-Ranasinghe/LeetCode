class Solution:
    def specialTriplets(self, nums: List[int]) -> int:
        result: int = 0
        left_handside: dict[int, int] = {}
        right_handside: dict[int, int] = {}
        MOD: int = 1000000007
        for num in nums:
            if (num in right_handside):
                right_handside[num] += 1
            else:
                right_handside[num] = 1
        for num in nums:
            right_handside[num] -= 1
            double_num: int = num * 2
            if (double_num in left_handside):
                result = (result + right_handside[double_num] * left_handside[double_num]) % MOD
            if (num in left_handside):
                left_handside[num] += 1
            else:
                left_handside[num] = 1
        return result