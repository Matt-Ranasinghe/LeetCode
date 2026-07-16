public class Solution {
    public long GcdSum(int[] nums) {
        int n = nums.Length;
        int[] max = new int[n];
        int prefixNum = 0;
        for(int i = 0; i < n; i++){
            prefixNum = Math.Max(prefixNum, nums[i]);
            max[i] = prefixNum;
        }

        int[] gcds = new int[n];
        for(int i = 0; i < n; i++){
            gcds[i] = GCD(nums[i], max[i]);
        }
        Array.Sort(gcds);
        long result = 0;
        for(int i = 0; i < n/2; i++){
            result += GCD(gcds[i], gcds[n - i - 1]);
        }
        return result;
    }

    private int GCD(int a, int b){
        while(a != 0){
            int temp = a;
            a = b % a;
            b = temp;
        }
        return b;
    }
}