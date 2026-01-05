public class Solution {
    public int SpecialTriplets(int[] nums) {
        const int MOD = (int)1e9 + 7;
        long result = 0;
        Dictionary<int, int> rightHandSide = new Dictionary<int, int>(), leftHandSide = new Dictionary<int, int>();
        foreach(int num in nums){
            if (!rightHandSide.ContainsKey(num)){
                rightHandSide[num] = 1;
            }
            else rightHandSide[num]++;
        }
        foreach(int num in nums){
            rightHandSide[num]--;
            int double_num = num * 2;
            if (leftHandSide.ContainsKey(double_num)){
                result = (result + ((long)leftHandSide[double_num] * rightHandSide[double_num])% MOD) % MOD;
            }
            if (!leftHandSide.ContainsKey(num)){
                leftHandSide[num] = 1;
            }
            else{
                leftHandSide[num]++;
            }
        }
        return (int) result;
    }
}