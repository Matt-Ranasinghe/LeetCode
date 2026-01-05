public class Solution {
    public int BestClosingTime(string customers) {
        int numOfCustomers = 0;
        foreach(char c in customers)
        {
            if(c == 'Y') numOfCustomers++;
        }
        int minPenalty = numOfCustomers;
        int penalty = numOfCustomers;
        int res = 0;
        for(int i = 0; i < customers.Length; i++)
        {
            penalty += 'Y' == customers[i] ? -1 : 1;
            if (penalty < minPenalty)
            {
                minPenalty = penalty;
                res = i + 1;
            }
        }
        return res;
    }
}