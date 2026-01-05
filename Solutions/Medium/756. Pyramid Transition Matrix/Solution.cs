public class Solution {
    public bool PyramidTransition(string bottom, IList<string> allowed) {
        HashSet<string> seen = new HashSet<string>();
        Dictionary<string, List<char>> pyrTop = new Dictionary<string, List<char>>();
        foreach(string allowedTriangle in allowed){
            string baseTri = allowedTriangle[0..2];
            if(!pyrTop.ContainsKey(baseTri)) pyrTop[baseTri] = new List<char>();
            pyrTop[baseTri].Add(allowedTriangle[2]);
        }
        return TestTriangles(pyrTop, seen, "", bottom, 0);
    }

    private bool TestTriangles(Dictionary<string, List<char>> pyrTop, HashSet<string> seen, string nextPyr, string curPyr, int pointer){
        if(pointer == curPyr.Length - 1){
            if(nextPyr.Length == 1) return true;
            if(seen.Contains(nextPyr)) return false;
            seen.Add(nextPyr);
            curPyr = nextPyr;
            nextPyr = "";
            pointer = 0; 
        }
        string baseTri = curPyr[pointer..(pointer+2)];
        if(!pyrTop.ContainsKey(baseTri)) return false;
        foreach(char top in pyrTop[baseTri]){
            bool valid = TestTriangles(pyrTop, seen, nextPyr + top, curPyr, pointer + 1);
            if(valid) return true;
        }
        return false;
    }
}