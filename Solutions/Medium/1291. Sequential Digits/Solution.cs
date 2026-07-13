public class Solution {
    private static readonly List<int> sequentialDigits = new List<int>();

    public IList<int> SequentialDigits(int low, int high) {
        if(sequentialDigits.Count == 0) buildSequences();
        IList<int> result = new List<int>();
        int pos = 0;
        while(pos < sequentialDigits.Count && sequentialDigits[pos] <= high ){
            if(sequentialDigits[pos] >= low) result.Add(sequentialDigits[pos]);
            pos++;
        }
        return result;
    }

    private static void buildSequences(){
        int current = 0;
        for(int i = 1; i < 10; i++){
            current = i;
            for(int j = i; j < 10; j++){
                sequentialDigits.Add(current);
                current = current * 10 + j + 1;
            }
        }
        sequentialDigits.Sort();
    }
}