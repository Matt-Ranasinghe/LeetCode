public class Solution {
    public double AngleClock(int hour, int minutes) {
        double hourPos = 30 * hour + (double) minutes / 2;
        double minutePos = 6 * minutes;
        double smaller = Math.Min(hourPos, minutePos), larger = Math.Max(hourPos, minutePos);
        double angleOne = larger - smaller;
        double angleTwo = 360 - larger + smaller;
        return Math.Min(angleOne, angleTwo);
    }
}