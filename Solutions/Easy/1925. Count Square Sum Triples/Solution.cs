public class Solution {
    public int CountTriples(int n) {
        int result = 0;
        for(int i = 5; i <= n; i++){
            for(int j = 4; j < i; j++){
                for(int k = 3; k < j; k++){
                    if(k*k + j*j == i*i){
                        result += 2;
                    }
                }
            }
        }
        return result;
    }
}