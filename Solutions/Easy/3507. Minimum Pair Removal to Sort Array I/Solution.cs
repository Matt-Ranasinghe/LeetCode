public class Solution {
    public int MinimumPairRemoval(int[] nums) {
        int n = nums.Length, res = 0;
        if(n == 1) return 0;
        List<int> numsList = new List<int>(nums);
        while(!IsNonDecreasing(numsList))
        {
            int minimumSum = Int32.MaxValue, pos = -1;
            for(int i = 0; i < numsList.Count - 1; i++)
            {
                if(minimumSum > numsList[i] + numsList[i+1])
                {
                    pos = i;
                    minimumSum = numsList[i] + numsList[i + 1];
                }
            }
            numsList[pos] = minimumSum;
            numsList.RemoveAt(pos + 1);
            res++;
        }
        return res;
    }

    private bool IsNonDecreasing(List<int> numsList)
    {
        for(int i = 0; i < numsList.Count - 1; i++)
        {
            if(numsList[i] > numsList[i + 1]) return false;
        }
        return true;
    }
}