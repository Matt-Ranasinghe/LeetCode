using System;
using System.Collections.Generic;
using System.Linq;

namespace _516._Longist_Palindromic_Subsequence
{
    class Solution
    {
        public int LongestPalindromeSubseq(string s) {
            int n = s.Length;
            int[,] dp = new int[n,n];
            for(int i = 0; i < n; i++){
                for(int j = 0; j < n; j++){
                    dp[i,j] = -1;
                }
            }
            return LongestSequence(0, n - 1, s, dp);
        }
        private int LongestSequence(int left, int right, string s, int[,] dp){
            if(left > right) return 0;
            if(left == right) return 1;
            if(dp[left,right] != -1){
                return dp[left, right];
            }
            else if(s[left] == s[right]){
                dp[left,right] = LongestSequence(left + 1, right - 1, s, dp) + 2;
                return dp[left, right];
            }
            else{
                dp[left, right] = Math.Max(LongestSequence(left, right - 1, s, dp), LongestSequence(left + 1, right, s, dp));
                return dp[left, right];
            }
        }
    }
}
