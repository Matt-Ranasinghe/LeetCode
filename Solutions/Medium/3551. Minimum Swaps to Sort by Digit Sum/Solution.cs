public class Solution {
    public int MinSwaps(int[] nums) {
        int n = nums.Length;
        (int digitSum, int num, int index)[] digitSumTriples = new (int digitSum, int num, int index)[n];
        for(int i = 0; i < n; i++){
            digitSumTriples[i] = (CalculateDigitSum(nums[i]), nums[i], i);
        }
        Array.Sort(digitSumTriples);
        bool[] visited = new bool[n];
        int cycles = 0;
        for(int i = 0; i < n; i++){
            if(visited[i]) continue;
            cycles += 1;
            visited[i] = true;
            int currentIndex = i;
            while(!visited[digitSumTriples[currentIndex].index]){
                currentIndex = digitSumTriples[currentIndex].index;
                visited[currentIndex] = true;
            }
        }
        return n - cycles;
    }

    private int CalculateDigitSum(int num){
        int sum = 0;
        while(num > 0){
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}