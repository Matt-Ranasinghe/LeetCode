public class Solution {
    public int MinSubarray(int[] nums, int p) {
        long total = 0;
        foreach (int x in nums) total += x;

        long need = total % p;
        if (need == 0) return 0;

        Dictionary<long, int> map = new Dictionary<long, int>();
        map[0] = -1;

        long prefix = 0;
        int res = nums.Length;

        for (int i = 0; i < nums.Length; i++) {
            prefix = (prefix + nums[i]) % p;

            long target = (prefix - need + p) % p;

            if (map.ContainsKey(target)) {
                res = Math.Min(res, i - map[target]);
            }
            map[prefix] = i;
        }

        return res == nums.Length ? -1 : res;
    }
}