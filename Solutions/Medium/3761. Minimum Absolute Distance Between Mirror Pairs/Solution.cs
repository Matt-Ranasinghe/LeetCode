public class Solution {
    public int MinMirrorPairDistance(int[] nums) {
        int minimumDist = Int32.MaxValue;
        int n = nums.Length;
        Dictionary<int, int> lastSeen = new Dictionary<int, int>();
        for (int i = 0; i < n; i++) {
            int num = nums[i];
            if (lastSeen.ContainsKey(num)) {
                minimumDist = Math.Min(i - lastSeen[num], minimumDist);
                if (minimumDist == 1) return 1; 
            }
            int current = RemoveTrailingZeroes(nums[i]);
            lastSeen[Reverse(current)] = i;
        }

        return minimumDist == Int32.MaxValue ? -1 : minimumDist;
    }

    private int RemoveTrailingZeroes(int num){
        while(num % 10 == 0){
            num /= 10;
        }
        return num;
    } 

    private int Reverse(int num) {
        if (num == 0) return 0;
        int result = 0;
        while (num > 0) {
            result = (result * 10) + (num % 10);
            num /= 10;
        }
        return result;
    }
}