public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int letterPos = -1;
        for(int i = 0; i < letters.Length; i++)
        {
            letterPos = letters[i] > target ? (letterPos == -1 ? i : (letters[letterPos] > letters[i] ? i : letterPos))  : letterPos;
        }
        return letterPos == -1 ? letters[0] : letters[letterPos];
    }
}