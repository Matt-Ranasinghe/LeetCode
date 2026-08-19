public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        Array.Sort(reservedSeats, (a, b) => {
            int comp = a[0].CompareTo(b[0]);
            if(comp == 0) return a[1].CompareTo(b[1]);
            return comp;
        });
        int reservedPointer = 0;
        int result = 0;
        for(int i = 1; i <= n; i++){
            if(reservedPointer == reservedSeats.Length) 
            {
                result += 2 * (n - i + 1);
                break;
            }
            if(reservedSeats[reservedPointer][0] > i) 
            {
                result += 2;
                continue;
            }
            bool[] combinations = new bool[3];
            while(reservedPointer < reservedSeats.Length && reservedSeats[reservedPointer][0] == i){
                if(reservedSeats[reservedPointer][1] >= 2 && reservedSeats[reservedPointer][1] <= 5){
                    combinations[0] = true;
                }
                if(reservedSeats[reservedPointer][1] >= 4 && reservedSeats[reservedPointer][1] <= 7){
                    combinations[1] = true;
                }
                if(reservedSeats[reservedPointer][1] >= 6 && reservedSeats[reservedPointer][1] <= 9){
                    combinations[2] = true;
                }
                reservedPointer++;
            }
            if(!combinations[0] && !combinations[2]) result += 2;
            else if(!combinations[0] || !combinations[1] || !combinations[2]) result += 1;
        }
        return result;
    }
}