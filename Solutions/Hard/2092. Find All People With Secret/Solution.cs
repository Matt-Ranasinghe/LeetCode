public class Solution {
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson) {
        bool[] knowsSecret = new bool[n];
        HashSet<int> knows = new HashSet<int>();
        Array.Sort(meetings, (x, y) => x[2].CompareTo(y[2]));
        knowsSecret[0] = true;
        knows.Add(0);
        knowsSecret[firstPerson] = true;
        knows.Add(firstPerson);
        int prev = 0, m = meetings.Length;
        Queue<int> queue = new Queue<int>();
        int i = 0;
        HashSet<int> seen = new HashSet<int>();
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        while(i < m){
            prev = meetings[i][2];
            while(i < m && prev == meetings[i][2]){
                int p1 = meetings[i][0], p2 = meetings[i][1];
                if(!dict.ContainsKey(p1)) dict[p1] = new List<int>();
                if(!dict.ContainsKey(p2)) dict[p2] = new List<int>();
                dict[p1].Add(p2);
                dict[p2].Add(p1);
                if(knowsSecret[p1]) queue.Enqueue(p1);
                if(knowsSecret[p2]) queue.Enqueue(p2);
                i++;
            }
            while(queue.Count > 0){
                int person = queue.Dequeue();
                if(seen.Contains(person)) continue;
                seen.Add(person);
                foreach(int metPerson in dict[person]){
                    queue.Enqueue(metPerson);
                    knows.Add(metPerson);
                    knowsSecret[metPerson] = true;
                }
            }
            seen.Clear();
            dict.Clear();
        }
        return knows.ToList();
    }
}