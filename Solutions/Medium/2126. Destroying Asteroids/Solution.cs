public class Solution {
    public bool AsteroidsDestroyed(int mass, int[] asteroids) {
        Array.Sort(asteroids);
        long longMass = mass;
        foreach(int asteroid in asteroids){
            if(longMass >= asteroid) longMass += asteroid;
            else return false;
        }
        return true;
    }
}