public class ProductOfNumbers {

    List<long> prefixMult;
    int effectiveLength;
    public ProductOfNumbers() {
        prefixMult = new List<long>();
        effectiveLength = 0;
    }
    
    public void Add(int num) {
        if(num == 0){
            prefixMult.Clear();
            effectiveLength = 0;
        }
        else{
            if(effectiveLength != 0) prefixMult.Add(prefixMult[effectiveLength - 1] * num);
            else prefixMult.Add(num);
            effectiveLength++;
        }
    }
    
    public int GetProduct(int k) {
        if(k > effectiveLength) return 0;
        if(k == effectiveLength) return (int)prefixMult[effectiveLength - 1];
        return (int)(prefixMult[effectiveLength - 1] / prefixMult[effectiveLength - k - 1]);
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */