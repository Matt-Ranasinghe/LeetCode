public class Solution {
    public int[] FindXSum(int[] nums, int k, int x) {
        int n = nums.Length;
        int[] result = new int[n - k + 1];

        for (int i = 0; i <= n - k; i++) {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            for (int j = i; j < i + k; j++) {
                if (!freq.ContainsKey(nums[j])) freq[nums[j]] = 0;
                freq[nums[j]]++;
            }

            List<(int num, int count)> list = new List<(int, int)>();
            foreach (var kvp in freq) {
                list.Add((kvp.Key, kvp.Value));
            }

            list.Sort((a, b) => {
                if (b.count == a.count) return b.num.CompareTo(a.num);
                return b.count.CompareTo(a.count);
            });

            HashSet<int> keep = new HashSet<int>();
            for (int j = 0; j < Math.Min(x, list.Count); j++) {
                keep.Add(list[j].num);
            }

            int sum = 0;
            for (int j = i; j < i + k; j++) {
                if (keep.Contains(nums[j])) {
                    sum += nums[j];
                }
            }

            result[i] = sum;
        }

        return result;
    }
}