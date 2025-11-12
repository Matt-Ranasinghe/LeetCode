public class Solution {
    public int MinOperations(int[] nums) {
        int n = nums.Length;
        int minimumLength = Int32.MaxValue;
        int ones = 0;
        foreach(int num in nums){
            if(num == 1) ones++;
        }
        if(ones != 0) return n - ones;
        for(int i = 0; i < n - 1; i++){
            int currentGCD = nums[i];
            for(int j = i + 1; j < n; j++){
                currentGCD = GCD(currentGCD, nums[j]);
                if(currentGCD == 1) minimumLength = j - i;
                if(j - i >= minimumLength) break;
            }
            if(minimumLength == Int32.MaxValue) return -1;
        }
        return minimumLength + n - 1;
    }

    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }
}
