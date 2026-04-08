public class Solution {
    public int XorAfterQueries(int[] nums, int[][] queries) {
        int result = 0, MOD = (int) 1e9 + 7;
        foreach(int[] query in queries){
            for(int i = query[0]; i <= query[1]; i += query[2]){
                nums[i] = (int) (((long) nums[i] * query[3]) % MOD);
            }
        }
        foreach(int num in nums){
            result ^= num;
        }
        return result;
    }
}