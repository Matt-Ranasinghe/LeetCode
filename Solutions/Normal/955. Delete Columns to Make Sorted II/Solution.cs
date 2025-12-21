public class Solution {
    public int MinDeletionSize(string[] strs) {
        List<List<string>> breakDownSeq = new List<List<string>>(), nextSeq = new List<List<string>>();
        breakDownSeq.Add(strs.ToList());
        int result = 0, n = strs[0].Length;
        for(int i = 0; i < n; i++){
            bool fail = false;
            foreach(List<string> seq in breakDownSeq){
                nextSeq.Add(new List<string>());
                nextSeq[nextSeq.Count - 1].Add(seq[0]);
                for(int j = 1; j < seq.Count; j++){
                    if(seq[j][i] < seq[j - 1][i]){
                        result++;
                        fail = true;
                        break;
                    }
                    else if(seq[j][i] > seq[j - 1][i]){
                        nextSeq.Add(new List<string>());
                    }
                    nextSeq[nextSeq.Count - 1].Add(seq[j]);
                }
                if(fail) break;
            }
            if(!fail){
                breakDownSeq = nextSeq;
                nextSeq = new List<List<string>>();
            }
            else{
                nextSeq.Clear();
            }
            if(breakDownSeq.Count == strs.Length) return result;
        }
        return result;
    }
}