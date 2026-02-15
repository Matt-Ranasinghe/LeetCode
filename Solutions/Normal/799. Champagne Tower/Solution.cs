public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        if(query_row == 0) return Math.Min(1.0, poured);
        double[] prevLayer = new double[1];
        double[] nextLayer;
        prevLayer[0] = poured;
        for(int i = 0; i < query_row; i++){
            nextLayer = new double[i + 2];
            for(int j = 0; j < i + 1; j++){
                double overflow = (prevLayer[j] - 1) / 2.0;
                if(overflow > 0){
                    nextLayer[j] += overflow;
                    nextLayer[j + 1] += overflow;
                }
            }
            prevLayer = nextLayer;
        }
        return Math.Min(1.0, prevLayer[query_glass]);
    }
}