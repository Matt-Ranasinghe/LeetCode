public class Solution {
    private class EventObj {
        public string Type;
        public int Time;
        public string Data;

        public EventObj(string type, int time, string data) {
            Type = type;
            Time = time;
            Data = data;
        }
    }
    public int[] CountMentions(int numberOfUsers, IList<IList<string>> events) {
        int[] mentions = new int[numberOfUsers];
        int[] offlineUntil = new int[numberOfUsers];
        List<EventObj> evs = new List<EventObj>();
        foreach (var e in events) {
            string type = e[0];
            int time = int.Parse(e[1]);
            string data = e[2];
            evs.Add(new EventObj(type, time, data));
        }
        evs.Sort((a, b) => {
            if (a.Time != b.Time)
                return a.Time.CompareTo(b.Time);
            if (a.Type == b.Type)
                return 0;
            return a.Type == "OFFLINE" ? -1 : 1;
        });
        foreach (var ev in evs) {
            int t = ev.Time;
            for (int u = 0; u < numberOfUsers; u++) {
                if (offlineUntil[u] > 0 && offlineUntil[u] <= t)
                    offlineUntil[u] = 0;
            }
            if (ev.Type == "OFFLINE") {
                int uid = int.Parse(ev.Data);
                offlineUntil[uid] = t + 60;
            }
            else {
                string mentionString = ev.Data;
                if (mentionString == "ALL") {
                    for (int u = 0; u < numberOfUsers; u++)
                        mentions[u]++;
                }
                else if (mentionString == "HERE") {
                    for (int u = 0; u < numberOfUsers; u++) {
                        if (offlineUntil[u] == 0)
                            mentions[u]++;
                    }
                }
                else {
                    string[] tokens = mentionString.Split(' ');
                    foreach (string token in tokens) {
                        if (token.StartsWith("id")) {
                            int id = int.Parse(token.Substring(2));
                            mentions[id]++;
                        }
                    }
                }
            }
        }
        return mentions;
    }
}