public class Solution {
    public int CountCollisions(string directions) {
        Stack<char> directionStack = new Stack<char>();
        int result = 0;
        foreach(char c in directions){
            if(directionStack.Count == 0){
                if(c == 'L') continue;
                else{
                    directionStack.Push(c);
                }
            }
            else{
                if(c == 'L'){
                    result++;
                    directionStack.Push('S');
                }
                else
                {
                    directionStack.Push(c);
                }
            }
        }
        bool seenStationary = false;
        while(directionStack.Count > 0){
            char car = directionStack.Pop();
            if(seenStationary){
                if(car == 'R') result += 1;
            }
            else{
                if(car == 'S') seenStationary = true;
            }
        }
        return result;
    }
}