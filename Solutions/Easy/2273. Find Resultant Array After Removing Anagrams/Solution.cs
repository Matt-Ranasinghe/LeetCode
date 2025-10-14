using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        if(words.Length == 1) return words.ToList();
        List<string> res = new List<string>();
        res.Add(words[0]);
        char[] arr = words[0].ToCharArray();
        Array.Sort(arr);
        string prev = new string(arr);
        for(int i = 1; i < words.Length; i++){
            arr = words[i].ToCharArray();
            Array.Sort(arr);
            string sorted = new string(arr);
            if(prev != sorted){
                prev = sorted;
                res.Add(words[i]);
            }
        }
        return res;
    }
}
