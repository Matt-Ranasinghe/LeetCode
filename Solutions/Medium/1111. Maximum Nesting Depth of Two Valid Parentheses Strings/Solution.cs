public class Solution {
    public int[] MaxDepthAfterSplit(string seq) {
        int n = seq.Length;
        int[] result = new int[n];
        int a = 0, b = 0;
        for(int i = 0; i < n; i++){
            if(seq[i] == '('){
                if(a == b) {
                    result[i] = 0;
                    a++;
                }
                else {
                    result[i] = 1;
                    b++;
                }
            }
            else{
                if(a == b){
                    result[i] = 1;
                    b--;
                }
                else{
                    result[i] = 0;
                    a--;
                }
            }
        }
        return result;
    }
}