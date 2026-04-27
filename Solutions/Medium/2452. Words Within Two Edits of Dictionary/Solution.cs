public class Solution {
    private bool ValidS(string s, string[] dict)
    {
        foreach(string t in dict)
        {
            int diff = 0, len = t.Length;
            for(int i = 0; i < len; i++)
            {
                if(s[i] != t[i])
                {
                    if(++diff > 2)
                        break;
                }
            }
            if(diff <= 2)
                return true;
        }
        return false;
    }
    public IList<string> TwoEditWords(string[] queries, string[] dictionary) {
        List<string> res = new();
        foreach(string s in queries)
        {
            if(ValidS(s, dictionary))
                res.Add(s);
        }
        return res;
    }
}